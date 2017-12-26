using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Sticker
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            // Check every registry key Sticker has possibly written to and decide which autorun setting is active.
            // Working around Wow6432Node as below, the rest should be self-explantory
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            if (key != null && key.GetValue("Sticker") != null) globalAutorunRadioButton.Checked = true;
            else
            {
                key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run");
                if (key != null && key.GetValue("Sticker") != null) globalAutorunRadioButton.Checked = true;
                else
                {
                    key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
                    if (key != null && key.GetValue("Sticker") != null) userAutorunRadioButton.Checked = true;
                    else
                    {
                        key = Registry.CurrentUser.OpenSubKey("Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run");
                        if (key != null && key.GetValue("Sticker") != null) userAutorunRadioButton.Checked = true;
                        else disableAutorunRadioButton.Checked = true;
                    }
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        { 
            try
            {
                // I don't have any fucking idea why .net writes to SOFTWARE and deletes from SOFTWARE\Wow6432Node in the same process
                // Hell of a workaround.
                RegistryKey globalStartup = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                RegistryKey globalStartup64 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                RegistryKey userStartup = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                RegistryKey userStartup64 = Registry.CurrentUser.OpenSubKey("Software\\WoW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                string command = "\"" + typeof(MainForm).Assembly.Location + "\"";

                // Just delete all registry keys except the selected one
                if (globalAutorunRadioButton.Checked)
                {

                    if (userStartup != null) userStartup.DeleteValue("Sticker", false);
                    if (userStartup64 != null) userStartup64.DeleteValue("Sticker", false);
                    if (globalStartup != null) globalStartup.SetValue("Sticker", command);
                }
                else if (userAutorunRadioButton.Checked)
                {
                    if (globalStartup != null) globalStartup.DeleteValue("Sticker", false);
                    if (globalStartup64 != null) globalStartup64.DeleteValue("Sticker", false);
                    if (userStartup != null) userStartup.SetValue("Sticker", command);
                }
                else
                {
                    if (globalStartup != null) globalStartup.DeleteValue("Sticker", false);
                    if (globalStartup64 != null) globalStartup64.DeleteValue("Sticker", false);
                    if (userStartup != null) userStartup.DeleteValue("Sticker", false);
                    if (userStartup64 != null) userStartup64.DeleteValue("Sticker", false);
                }
                Close();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You are not authroized to perform this action", "Sticker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
