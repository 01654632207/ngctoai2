using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sticker
{

    /// <summary>
    /// Represents the visibility of a StickerForm.
    /// Normal: Locked to the desktop
    /// Important: Always-on-top
    /// Temporary: Always-on-top until the next focus loss.
    /// </summary>
    public enum NoteImportance { Normal, Important, Temporary }


    public partial class StickerForm : Form
    {
        private int needleIndex;

        public int Needle
        {
            get { return needleIndex; }
        }

        private void init(int nneedle, Point location)
        {
            InitializeComponent();
            toolTip1.SetToolTip(closeBox, "Delete this note");
            needleIndex = nneedle;
            // Resources needle0 to needle2 are our colored needles
            needle.Image = (Image)Images.ResourceManager.GetObject("needle" + needleIndex);
            Location = location;
            StartPosition = FormStartPosition.Manual;
        }


        /// <summary>
        /// Setup a new note form with a random needle at a random position.
        /// </summary>
        public StickerForm()
        {
            Random rnd = new Random();
            // Find a position within the current working area
            Rectangle wa = Screen.PrimaryScreen.WorkingArea;
            init(rnd.Next(3), new Point(rnd.Next(wa.Width - Width), rnd.Next(wa.Height - Height)));
        }

        /// <summary>
        /// Setup a new note form with a given appearance
        /// </summary>
        /// <param name="rtf">The content RTF</param>
        /// <param name="nneedle">Needle ID (0-2)</param>
        /// <param name="location">Location relative to the desktop's upper left corner</param>
        /// <param name="size">Note size in pixels</param>
        public StickerForm(string rtf, int nneedle, Point location, Size size)
        {
            init(nneedle, location);
            textBox.Rtf = rtf;
            Size = size;
        }

        // The textBox is always focused.
        private void StickerForm_Shown(object sender, EventArgs e)
        {
            textBox.Focus();
        }

        // As above.
        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox.Focus();
        }


        private Point startPoint;
        private bool controlsVisible = false;
        private bool kill = false;

        // Saves the MouseMove origin.
        void StickerForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            startPoint = new Point(-MousePosition.X+Location.X, -MousePosition.Y+Location.Y);
        }

        // Moves the form like a normal window
        void StickerForm_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(startPoint.X, startPoint.Y);
                Location = mousePos;
            }
        }

        // Saves the resize origin
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(-e.X + resizeBox.Width, -e.Y + resizeBox.Height);
        }

        // Resizes the form 
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(startPoint.X, startPoint.Y);
                Size = new Size(mousePos.X - Location.X, mousePos.Y - Location.Y);
            }
        }

        // Shows the close-/alwaysOnTop-/whatever- controls when hovering the form
        private void StickerForm_MouseEnter(object sender, EventArgs e)
        {
            if (!controlsVisible)
            {
                closeBox.Show();
                topBox.Show();
                resizeBox.Show();
                fontBox.Show();
                colorBox.Show();
                controlsVisible = true;
                // Always-on-top-forms are transparent, so they are made fully visible
                if (importance == NoteImportance.Important) Opacity = 1.0;
                // In some cases MouseLeave does not work, so start checking if the form is still hovered
                controlTimer.Enabled = true;
            }
        }

        private void StickerForm_MouseLeave(object sender, EventArgs e)
        {
            tryHidingControls();  
        }

        private void tryHidingControls()
        {
            if (!Bounds.Contains(MousePosition))
            {
                closeBox.Hide();
                topBox.Hide();
                resizeBox.Hide();
                fontBox.Hide();
                colorBox.Hide();
                controlsVisible = false;
                // Make always-on-top forms transparent again
                if (importance == NoteImportance.Important) Opacity = 0.8;
                controlTimer.Enabled = false;
            }
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            // this is needed to avoid alt-f4 
            kill = true;
            Close();
        }

        private void textBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            // Handle links like links.
            System.Diagnostics.Process.Start(e.LinkText);
        }


        // Handles hotkeys in the RTF control. Self-explanatory.
        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                e.Handled = true;
                switch (e.KeyCode)
                {
                    case Keys.B: toggleFontStyle(FontStyle.Bold); break;
                    case Keys.I: toggleFontStyle(FontStyle.Italic); break;
                    case Keys.U: toggleFontStyle(FontStyle.Underline); break;
                    case Keys.L: textBox.SelectionAlignment = HorizontalAlignment.Left; break;
                    case Keys.E: textBox.SelectionAlignment = HorizontalAlignment.Center; break;
                    case Keys.R: textBox.SelectionAlignment = HorizontalAlignment.Right; break;
                    case Keys.Z: textBox.Undo(); break;
                    case Keys.Y: textBox.Redo(); break;
                    default: e.Handled = false; break;
                }
            }
        }

        // I don't know the Point in making Bold/Italic/Underlined-properties read-only...
        private void toggleFontStyle(FontStyle style)
        {
            FontStyle boxStyle = textBox.SelectionFont.Style;
            if (boxStyle.HasFlag(style)) boxStyle &= ~style;
            else boxStyle |= style;
            textBox.SelectionFont = new Font(textBox.SelectionFont, boxStyle);
        }

        private void StickerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Only close if the X is clicked manually.
            e.Cancel = !kill;
        }

        private void StickerForm_Activated(object sender, EventArgs e)
        {
        }

        private void StickerForm_Deactivate(object sender, EventArgs e)
        {
            // If the form is temporary on top (as it is on creation), stick it to the desktop if it loses focus
            if (!kill & importance == NoteImportance.Temporary) Importance = NoteImportance.Normal;   
        }

        public string Rtf
        {
            get { return textBox.Rtf; }
            set { textBox.Rtf = value; }
        }
        
        [DllImport("user32.dll", SetLastError = false)]
        private static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        // Get the desktop's explorer window (the one with the icons ;) )
        private static IntPtr desktop = FindWindowEx(GetDesktopWindow(), IntPtr.Zero, "Progman", "Program Manager");

        private NoteImportance importance = NoteImportance.Normal;

        public NoteImportance Importance
        {
            get { return importance; }
            
            set 
            {                
                switch (value)
                {
                    case NoteImportance.Normal: 
                        // Toggle the visibility box
                        topBox.Image = Images.important;
                        toolTip1.SetToolTip(topBox, "Display this note always on top");
                        // Child forms do not support Opacity
                        Opacity = 1.0;
                        TopMost = false;
                        // Stick to the desktop
                        SetParent(this.Handle, desktop);
                        // Make sure our Form does not fall behind the desktop
                        BringToFront();
                        break;

                    case NoteImportance.Important:
                        // Toggle the visibility box
                        topBox.Image = Images.desktop;
                        toolTip1.SetToolTip(topBox, "Stick this note to the desktop");
                        // Free the form (no parent)
                        SetParent(this.Handle, IntPtr.Zero);
                        // Always-on-top forms are transparent while out of focus.
                        if (new Rectangle(Location, Size).Contains(MousePosition)) Opacity = 1.0;
                        else Opacity = 0.85;
                        // Always-on-top, of course
                        TopMost = true;
                        BringToFront();
                        break;

                    case NoteImportance.Temporary:
                        // Same as above.
                        topBox.Image = Images.important;
                        toolTip1.SetToolTip(topBox, "Display this note always on top");
                        // Same as above
                        SetParent(this.Handle, IntPtr.Zero);
                        Opacity = 1.0;
                        TopMost = true;
                        BringToFront();
                        // Activate the form so that the user can start typing without an additional click
                        Activate();
                        break;
                }
                importance = value;
            }
        }
        
        public void Show(NoteImportance im)
        {
            Show();
            Importance = im;
        }

        public bool Empty
        {
            get { return textBox.Text == ""; }
        }

        private void topBox_Click(object sender, EventArgs e)
        {
            // Toggle Importance
            if (importance == NoteImportance.Important) Importance = NoteImportance.Normal;
            else Importance = NoteImportance.Important;
        }

        private void controlTimer_Tick(object sender, EventArgs e)
        {
            tryHidingControls();
        }

        //thay doi font chu
        private void fontBox_Click(object sender, EventArgs e)
        {
            
            toolTip2.SetToolTip(fontBox, "Change fonts");
            FontDialog f = new FontDialog();
            if (f.ShowDialog()==DialogResult.OK)
            {
                textBox.Font = f.Font;
            }
        }

        //thay doi color chu
        private void colorBox_Click(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(colorBox, "Change Color");
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog()==DialogResult.OK)
            {
                textBox.ForeColor = c.Color;
            }
        }

        //gan phim tat cho chuc nang
        private void StickerForm_Keyup(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                e.Handled = true;
                if (e.KeyCode.Equals(Keys.F11))
                {
                    fontBox_Click(null, null);
                }

            }
        }



       

        


    }
}
