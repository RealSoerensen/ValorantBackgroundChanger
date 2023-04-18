using System;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using File = System.IO.File;

namespace ValorantBackgroundChanger
{
    public partial class SettingForm : Form
    {
        private readonly Settings settings;
        private WshShell wshShell = new WshShell();
        private IWshShortcut shortcut;
        private static string startUpFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

        public SettingForm(Settings settings)
        {
            this.settings = settings;
            InitializeComponent();
            Icon = Properties.Resources.VBC;
            toggleStartUp.Checked = settings.StartWithWindows;
            toggleStartMinimized.Checked = settings.StartMinimized;
            toggleCloseMinimizes.Checked = settings.CloseMinimizes;

        }

        private void toggleStartUp_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleStartUp.Checked)
            {
                // Create the shortcut
                shortcut =
                    (IWshShortcut) wshShell.CreateShortcut(
                        startUpFolderPath + "\\" + Application.ProductName + ".lnk"
                        );

                shortcut.TargetPath = Application.ExecutablePath;
                shortcut.WorkingDirectory = Application.StartupPath;
                shortcut.Description = "Launch My Application";
                shortcut.IconLocation = Application.StartupPath + @"\resource\VBC.ico";
                shortcut.Save();
                settings.StartWithWindows = true;
            }
            else
            {
                if (File.Exists(startUpFolderPath + "\\" + Application.ProductName + ".lnk"))
                    File.Delete(startUpFolderPath + "\\" + Application.ProductName + ".lnk");
                settings.StartWithWindows = false;
            }
            settings.SaveSettings();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new Main(settings).Show();
            Hide();
        }

        private void toggleStartMinimized_CheckedChanged(object sender, EventArgs e)
        {
            settings.StartMinimized = toggleStartMinimized.Checked;
            settings.SaveSettings();
        }

        private void toggleCloseMinimizes_CheckedChanged(object sender, EventArgs e)
        {
            settings.CloseMinimizes = toggleCloseMinimizes.Checked;
            settings.SaveSettings();
        }
    }
}
