namespace Sticker
{
    partial class SettingsForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.startUpGroupBox = new System.Windows.Forms.GroupBox();
            this.userAutorunRadioButton = new System.Windows.Forms.RadioButton();
            this.globalAutorunRadioButton = new System.Windows.Forms.RadioButton();
            this.disableAutorunRadioButton = new System.Windows.Forms.RadioButton();
            this.startUpGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(197, 117);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(116, 117);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // startUpGroupBox
            // 
            this.startUpGroupBox.Controls.Add(this.userAutorunRadioButton);
            this.startUpGroupBox.Controls.Add(this.globalAutorunRadioButton);
            this.startUpGroupBox.Controls.Add(this.disableAutorunRadioButton);
            this.startUpGroupBox.Location = new System.Drawing.Point(12, 12);
            this.startUpGroupBox.Name = "startUpGroupBox";
            this.startUpGroupBox.Size = new System.Drawing.Size(260, 97);
            this.startUpGroupBox.TabIndex = 2;
            this.startUpGroupBox.TabStop = false;
            this.startUpGroupBox.Text = "Startup";
            // 
            // userAutorunRadioButton
            // 
            this.userAutorunRadioButton.AutoSize = true;
            this.userAutorunRadioButton.Location = new System.Drawing.Point(11, 40);
            this.userAutorunRadioButton.Name = "userAutorunRadioButton";
            this.userAutorunRadioButton.Size = new System.Drawing.Size(178, 17);
            this.userAutorunRadioButton.TabIndex = 2;
            this.userAutorunRadioButton.TabStop = true;
            this.userAutorunRadioButton.Text = "Start automatically when I log on";
            this.userAutorunRadioButton.UseVisualStyleBackColor = true;
            // 
            // globalAutorunRadioButton
            // 
            this.globalAutorunRadioButton.AutoSize = true;
            this.globalAutorunRadioButton.Location = new System.Drawing.Point(11, 19);
            this.globalAutorunRadioButton.Name = "globalAutorunRadioButton";
            this.globalAutorunRadioButton.Size = new System.Drawing.Size(220, 17);
            this.globalAutorunRadioButton.TabIndex = 1;
            this.globalAutorunRadioButton.TabStop = true;
            this.globalAutorunRadioButton.Text = "Start automatically when any user logs on";
            this.globalAutorunRadioButton.UseVisualStyleBackColor = true;
            // 
            // disableAutorunRadioButton
            // 
            this.disableAutorunRadioButton.AutoSize = true;
            this.disableAutorunRadioButton.Location = new System.Drawing.Point(11, 61);
            this.disableAutorunRadioButton.Name = "disableAutorunRadioButton";
            this.disableAutorunRadioButton.Size = new System.Drawing.Size(149, 17);
            this.disableAutorunRadioButton.TabIndex = 0;
            this.disableAutorunRadioButton.TabStop = true;
            this.disableAutorunRadioButton.Text = "Do not start with Windows";
            this.disableAutorunRadioButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 152);
            this.Controls.Add(this.startUpGroupBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Sticker.Images.icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sticker - Settings";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.startUpGroupBox.ResumeLayout(false);
            this.startUpGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox startUpGroupBox;
        private System.Windows.Forms.RadioButton userAutorunRadioButton;
        private System.Windows.Forms.RadioButton globalAutorunRadioButton;
        private System.Windows.Forms.RadioButton disableAutorunRadioButton;
    }
}