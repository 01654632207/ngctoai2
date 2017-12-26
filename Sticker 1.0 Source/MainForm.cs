using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Sticker
{
    public partial class MainForm : Form
    {
        List<StickerForm> notes = new List<StickerForm>();

        // XML "note" tag containing all the data for a note winow
        [XmlType("note")]
        public struct Note
        {
            [XmlText] public string rtf; // content
            [XmlAttribute] public int x, y, width, height, needle; // needle: Needle color, just for fun, 0-2
            [XmlAttribute] public bool top; // has window been always on top
        }

        private XmlSerializer serializer = new XmlSerializer(typeof(Note[]));

        // The data path depends on the existance of a file "local" in the application's directory.
        // If it exists, Sticker writes to the user's application data directory, otherwise, to its own location (portable mode)
        private string appDataPath = 
            File.Exists(Path.GetDirectoryName(typeof(MainForm).Assembly.Location) + "\\local") ?
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Sticker\\":
            Environment.CurrentDirectory + "\\";


        public MainForm()
        {
            InitializeComponent();

            try
            {
                // notes.xml stores our data
                if (!Directory.Exists(appDataPath)) Directory.CreateDirectory(appDataPath);
                FileStream fs = new FileStream(appDataPath + "notes.xml", FileMode.Open);

                // the XML file describes an array of Node objects as declared above.
                Note[] data = (Note[])serializer.Deserialize(fs);
                foreach (Note note in data)
                {
                    // Create a note form from the xml data
                    StickerForm f = new StickerForm(note.rtf, note.needle, new Point(note.x, note.y), new Size(note.width, note.height));
                    f.Leave += new EventHandler(StickerForm_Deactivate);
                    f.FormClosed += new FormClosedEventHandler(StickerForm_FormClosed);
                    f.Show(note.top ? NoteImportance.Important : NoteImportance.Normal);
                    notes.Add(f);
                }
            }
            // If reading fails, we don't care: The desktop starts empty again.
            catch (InvalidOperationException) { }
            catch (XmlException) { }
            catch (FileNotFoundException) { }
            catch (IOException) { }
        }

        private void StickerForm_Deactivate(object sender, EventArgs e)
        {
            // When a note form loses focus, save the current arrangement
            save();
        }

        private void StickerForm_FormClosed(object sender, EventArgs e)
        {
            // Update the XML without the closed (== removed) form.
            notes.Remove((StickerForm)sender);
            save();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            // We don't need the MainForm, it's only necessary for the Tray Icon
            Hide();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new node form at random position
            StickerForm f = new StickerForm();
            f.Show(NoteImportance.Temporary);
            f.Activate();
            notes.Add(f);
        }

        private void save()
        {
            int existing = 0;
            // Skip empty sheets when saving
            foreach (StickerForm form in notes) 
                if (!form.Empty) existing++;
            
            Note[] data = new Note[existing];
            int j = 0;

            foreach (StickerForm f in notes)
            {
                if (!f.Empty)
                {
                    // Build the Note[] structure for the XML file.
                    Note n = new Note();
                    n.rtf = f.Rtf;
                    n.x = f.Location.X;
                    n.y = f.Location.Y;
                    n.width = f.Width;
                    n.height = f.Height;
                    n.top = f.Importance == NoteImportance.Important;
                    n.needle = f.Needle;
                    data[j++] = n;
                }
            }
            try
            {
                // Try to save
                FileStream fs = new FileStream(appDataPath + "notes.xml", FileMode.Create);
                serializer.Serialize(fs, data);
                fs.Close();
            }
            // Same as above, if writing the XML fails, it's the user's problem, not ours.
            catch (FileNotFoundException) { }
            catch (IOException) { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            save();
        }

        private void trayIcon_MouseClick(object sender, EventArgs e)
        {
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            // A left click on the tray icon is equivalent to Right Click - New
            if (e.Button == MouseButtons.Left)
                newMenuItem_Click(sender, e);
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
        
        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }
    }
}
