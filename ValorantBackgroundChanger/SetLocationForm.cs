using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ValorantBackgroundChanger
{
    public partial class SetLocationForm : Form
    {
        private readonly string valorantSrcFilePath;

        public SetLocationForm()
        {
            var appDataFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ValorantBackGroundChanger");
            valorantSrcFilePath = Path.Combine(appDataFolderPath, "ValorantSrcFolder.txt");
            InitializeComponent();
        }

        private void folderBrowserBtn_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    srcTf.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void setLocationbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string finalText = Path.Combine(srcTf.Text, "live", "ShooterGame", "Content", "Movies", "Menu");
                File.WriteAllText(valorantSrcFilePath, finalText);
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
