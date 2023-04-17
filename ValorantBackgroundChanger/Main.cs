using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ValorantBackgroundChanger
{
    public partial class Main : Form
    {
        private static readonly string root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"ValorantBackGroundChanger\");
        private readonly string valorantSrc = root + "ValorantSrcFolder.txt";
        private readonly string videoSrc = root + "ReplacementVideoSrc.txt";
        private string currentVideoPath;
        private string newVideoPath;


        public Main()
        {
            CreateAppDataFolder();
            CreateValoSrcFolderTxt();
            CheckPathFile();
            CreateReplacementVideoSrcTxt();
            InitializeComponent();
            CheckVideoPath();
            DisplayCurrentVideo();
            currentVideoWMP.uiMode = "none";
            currentVideoWMP.settings.setMode("loop", true);
            currentVideoWMP.settings.volume = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(StartVBCThread);
            t.Start();
        }

        private string GetFilePath(string path)
        {
            string filePath = null;
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    filePath = s;
                }
            }
            return filePath;
        }

        private void CreateAppDataFolder()
        {
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
        }

        private void CreateValoSrcFolderTxt()
        {
            if (!File.Exists(valorantSrc))
            {
                using (FileStream fs = File.Create(valorantSrc))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("");
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        private void CheckPathFile()
        {
            string valoPath = GetFilePath(valorantSrc);
            if (valoPath == null)
            {
                SetLocationForm setLocForm = new SetLocationForm();
                setLocForm.ShowDialog();
                if (setLocForm.DialogResult == DialogResult.OK)
                {
                    GetFilePath(valorantSrc);
                }
            }
        }

        private void CreateReplacementVideoSrcTxt()
        {
            if (!File.Exists(videoSrc))
            {
                using (FileStream fs = File.Create(videoSrc))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("");
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        private void CheckVideoPath()
        {
            currentVideoPath = GetFilePath(videoSrc);
            newVideoPathTf.Text = currentVideoPath;
        }

        private void DisplayCurrentVideo()
        {
            currentVideoWMP.URL = currentVideoPath;
        }

        private void fileExplorerBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP4 Files (*.mp4)|*.mp4";
            openFileDialog.Title = "Select a MP4 File";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            newVideoPath = openFileDialog.FileName;
            newVideoPathTf.Text = newVideoPath;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (newVideoPath == null) return;
            using (StreamWriter sw = File.CreateText(videoSrc))
            {
                sw.WriteLine(newVideoPath);
            }
            MessageBox.Show("Saved!");
            DisplayCurrentVideo();
        }

        private void StartVBCThread()
        {
            new VBCThread().Start();
        }
    }
}
