namespace Sticker
{
    partial class StickerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickerForm));
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.topBox = new System.Windows.Forms.PictureBox();
            this.needle = new System.Windows.Forms.PictureBox();
            this.resizeBox = new System.Windows.Forms.PictureBox();
            this.topBorder = new System.Windows.Forms.PictureBox();
            this.bottomBorder = new System.Windows.Forms.PictureBox();
            this.rightBorder = new System.Windows.Forms.PictureBox();
            this.leftBorder = new System.Windows.Forms.PictureBox();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.controlTimer = new System.Windows.Forms.Timer(this.components);
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.fontBox = new System.Windows.Forms.PictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.topBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.needle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.AutoWordSelection = true;
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Location = new System.Drawing.Point(10, 56);
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBox.ShortcutsEnabled = false;
            this.textBox.Size = new System.Drawing.Size(202, 145);
            this.textBox.TabIndex = 5;
            this.textBox.Text = "";
            this.textBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.textBox_LinkClicked);
            this.textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            this.textBox.MouseEnter += new System.EventHandler(this.StickerForm_MouseEnter);
            this.textBox.MouseLeave += new System.EventHandler(this.StickerForm_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // topBox
            // 
            this.topBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topBox.Location = new System.Drawing.Point(10, 12);
            this.topBox.Name = "topBox";
            this.topBox.Size = new System.Drawing.Size(18, 16);
            this.topBox.TabIndex = 10;
            this.topBox.TabStop = false;
            this.topBox.Visible = false;
            this.topBox.Click += new System.EventHandler(this.topBox_Click);
            // 
            // needle
            // 
            this.needle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.needle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.needle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.needle.Location = new System.Drawing.Point(89, 9);
            this.needle.Name = "needle";
            this.needle.Size = new System.Drawing.Size(52, 48);
            this.needle.TabIndex = 2;
            this.needle.TabStop = false;
            this.needle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StickerForm_MouseDown);
            this.needle.MouseEnter += new System.EventHandler(this.StickerForm_MouseEnter);
            this.needle.MouseLeave += new System.EventHandler(this.StickerForm_MouseLeave);
            this.needle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StickerForm_MouseMove);
            // 
            // resizeBox
            // 
            this.resizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeBox.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.resizeBox.Image = ((System.Drawing.Image)(resources.GetObject("resizeBox.Image")));
            this.resizeBox.Location = new System.Drawing.Point(198, 188);
            this.resizeBox.Name = "resizeBox";
            this.resizeBox.Size = new System.Drawing.Size(22, 22);
            this.resizeBox.TabIndex = 4;
            this.resizeBox.TabStop = false;
            this.resizeBox.Visible = false;
            this.resizeBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.resizeBox.MouseEnter += new System.EventHandler(this.StickerForm_MouseEnter);
            this.resizeBox.MouseLeave += new System.EventHandler(this.StickerForm_MouseLeave);
            this.resizeBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // topBorder
            // 
            this.topBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topBorder.BackgroundImage")));
            this.topBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topBorder.Location = new System.Drawing.Point(1, 0);
            this.topBorder.Name = "topBorder";
            this.topBorder.Size = new System.Drawing.Size(218, 1);
            this.topBorder.TabIndex = 9;
            this.topBorder.TabStop = false;
            // 
            // bottomBorder
            // 
            this.bottomBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomBorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomBorder.BackgroundImage")));
            this.bottomBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottomBorder.Location = new System.Drawing.Point(1, 209);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(218, 1);
            this.bottomBorder.TabIndex = 8;
            this.bottomBorder.TabStop = false;
            // 
            // rightBorder
            // 
            this.rightBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightBorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightBorder.BackgroundImage")));
            this.rightBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightBorder.Location = new System.Drawing.Point(219, 1);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(1, 207);
            this.rightBorder.TabIndex = 7;
            this.rightBorder.TabStop = false;
            // 
            // leftBorder
            // 
            this.leftBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftBorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftBorder.BackgroundImage")));
            this.leftBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftBorder.Location = new System.Drawing.Point(0, 2);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(1, 207);
            this.leftBorder.TabIndex = 6;
            this.leftBorder.TabStop = false;
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBox.Image = ((System.Drawing.Image)(resources.GetObject("closeBox.Image")));
            this.closeBox.Location = new System.Drawing.Point(192, 12);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(16, 16);
            this.closeBox.TabIndex = 3;
            this.closeBox.TabStop = false;
            this.closeBox.Visible = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            this.closeBox.MouseEnter += new System.EventHandler(this.StickerForm_MouseEnter);
            this.closeBox.MouseLeave += new System.EventHandler(this.StickerForm_MouseLeave);
            // 
            // controlTimer
            // 
            this.controlTimer.Interval = 500;
            this.controlTimer.Tick += new System.EventHandler(this.controlTimer_Tick);
            // 
            // colorBox
            // 
            this.colorBox.Image = global::Sticker.Images.Color;
            this.colorBox.Location = new System.Drawing.Point(58, 12);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(16, 16);
            this.colorBox.TabIndex = 12;
            this.colorBox.TabStop = false;
            this.toolTip2.SetToolTip(this.colorBox, "Change Color");
            this.colorBox.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // fontBox
            // 
            this.fontBox.Image = global::Sticker.Properties.Resources.Font;
            this.fontBox.Location = new System.Drawing.Point(34, 12);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(18, 16);
            this.fontBox.TabIndex = 13;
            this.fontBox.TabStop = false;
            this.toolTip2.SetToolTip(this.fontBox, "Change Font");
            this.fontBox.Click += new System.EventHandler(this.fontBox_Click);
            // 
            // toolTip2
            // 
            this.toolTip2.ShowAlways = true;
            // 
            // StickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(220, 210);
            this.ControlBox = false;
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.topBox);
            this.Controls.Add(this.needle);
            this.Controls.Add(this.resizeBox);
            this.Controls.Add(this.topBorder);
            this.Controls.Add(this.bottomBorder);
            this.Controls.Add(this.rightBorder);
            this.Controls.Add(this.leftBorder);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.closeBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(160, 130);
            this.Name = "StickerForm";
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.StickerForm_Activated);
            this.Deactivate += new System.EventHandler(this.StickerForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StickerForm_FormClosing);
            this.Shown += new System.EventHandler(this.StickerForm_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StickerForm_MouseDown);
            this.MouseEnter += new System.EventHandler(this.StickerForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.StickerForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StickerForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.topBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.needle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox needle;
        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.PictureBox resizeBox;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.PictureBox leftBorder;
        private System.Windows.Forms.PictureBox rightBorder;
        private System.Windows.Forms.PictureBox bottomBorder;
        private System.Windows.Forms.PictureBox topBorder;
        private System.Windows.Forms.PictureBox topBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer controlTimer;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.PictureBox fontBox;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;



    }
}