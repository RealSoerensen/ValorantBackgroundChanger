using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ValorantBackgroundChanger
{
    public partial class Main : Form
    {
        private readonly string appDataFolderPath;
        private readonly string valorantSrcFilePath;
        private readonly string replacementVideoSrcFilePath;
        private string currentVideoPath;
        private string newVideoPath;

        public Main()
        {
            appDataFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ValorantBackGroundChanger");
            valorantSrcFilePath = Path.Combine(appDataFolderPath, "ValorantSrcFolder.txt");
            replacementVideoSrcFilePath = Path.Combine(appDataFolderPath, "ReplacementVideoSrc.txt");

            InitializeComponent();
            SetupVideoPlayer();
            LoadSettings();
        }

        private void LoadSettings()
        {
            CreateAppDataFolder();
            CreateValoSrcFolderTxt();
            CheckPathFile();
            CreateReplacementVideoSrcTxt();
            CheckVideoPath();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(StartVBCThread);
            t.Start();
        }

        private void SetupVideoPlayer()
        {
            currentVideoWMP.uiMode = "none";
            currentVideoWMP.settings.setMode("loop", true);
            currentVideoWMP.settings.volume = 0;
        }

        private void CreateAppDataFolder()
        {
            if (!Directory.Exists(appDataFolderPath))
            {
                Directory.CreateDirectory(appDataFolderPath);
            }
        }

        private void CreateValoSrcFolderTxt()
        {
            if (!File.Exists(valorantSrcFilePath))
            {
                File.WriteAllText(valorantSrcFilePath, "");
            }
        }

        private void CheckPathFile()
        {
            string valoPath = GetFilePath(valorantSrcFilePath);
            if (valoPath == null)
            {
                using (var setLocForm = new SetLocationForm())
                {
                    if (setLocForm.ShowDialog() == DialogResult.OK)
                    {
                        GetFilePath(valorantSrcFilePath);
                    }
                }
            }
        }

        private void CreateReplacementVideoSrcTxt()
        {
            if (!File.Exists(replacementVideoSrcFilePath))
            {
                File.WriteAllText(replacementVideoSrcFilePath, "");
            }
        }

        private void CheckVideoPath()
        {
            currentVideoPath = GetFilePath(replacementVideoSrcFilePath);
            newVideoPathTf.Text = currentVideoPath;
            DisplayCurrentVideo();
        }

        private string GetFilePath(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return null;
        }

        private void DisplayCurrentVideo()
        {
            currentVideoWMP.URL = currentVideoPath;
        }

        private void fileExplorerBtn_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "MP4 Files (*.mp4)|*.mp4";
                openFileDialog.Title = "Select a MP4 File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    newVideoPath = openFileDialog.FileName;
                    newVideoPathTf.Text = newVideoPath;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (newVideoPath == null) return;
            File.WriteAllText(replacementVideoSrcFilePath, newVideoPath);
            MessageBox.Show("Saved!");
            DisplayCurrentVideo();
        }

        private void StartVBCThread()
        {
            new VBCThread().Start();
        }
    }
}
