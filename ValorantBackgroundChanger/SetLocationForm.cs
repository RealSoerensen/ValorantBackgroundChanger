using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ValorantBackgroundChanger
{
    public partial class SetLocationForm : Form
    {
        private static readonly string root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"ValorantBackGroundChanger\");
        private readonly string textFile = root + "ValorantSrcFolder.txt";
        
        public SetLocationForm()
        {
            InitializeComponent();
        }

        private void folderBrowserBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            srcTf.Text = folderBrowser.SelectedPath;
        }

        private void setLocationbtn_Click(object sender, EventArgs e)
        { 
            // Open the stream and write to it.
            using (FileStream fs = File.OpenWrite(textFile))
            {
                string finalText = srcTf.Text + @"\\live\\ShooterGame\\Content\\Movies\\Menu";
                Byte[] info = new UTF8Encoding(true).GetBytes(finalText);

                // Add some information to the file.
                fs.Write(info, 0, info.Length);

            }
            Hide();
        }
    }
}
