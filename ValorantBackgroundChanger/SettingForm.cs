using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorantBackgroundChanger
{
    public partial class SettingForm : Form
    {
        private Settings settings = new Settings();
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public SettingForm(Settings settings)
        {
            this.settings = settings;
            // The value doesn't exist, the application is not set to run at startup
            settings.StartWithWindows = (rkApp.GetValue("ValorantBackgroundChanger") != null);
            InitializeComponent();
            toggleStartUp.Checked = settings.StartWithWindows;

        }

        private void toggleStartUp_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleStartUp.Checked)
            {
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("ValorantBackgroundChanger", Application.ExecutablePath);
                settings.StartWithWindows = true;
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("ValorantBackgroundChanger", false);
                settings.StartWithWindows = false;
            }
            settings.SaveSettings();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new Main(settings).Show();
            Hide();
        }
    }
}
