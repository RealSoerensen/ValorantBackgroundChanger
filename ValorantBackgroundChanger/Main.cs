using System;
using System.Threading;
using System.Windows.Forms;

namespace ValorantBackgroundChanger
{
    public partial class Main : Form
    {
        private readonly Settings settings = new Settings();

        public Main(Settings settings)
        {
            this.settings = settings;
            InitializeComponent();
            SetupVideoPlayer();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            CheckValoPath();
            CheckVideoPath();
            DisplayCurrentVideo();
            Thread t = new Thread(StartVBCThread)
            {
                IsBackground = true
            };
            t.Start();
        }

        private void SetupVideoPlayer()
        {
            currentVideoWMP.uiMode = "none";
            currentVideoWMP.settings.setMode("loop", true);
            currentVideoWMP.settings.volume = 0;
        }

        private void CheckValoPath()
        {
            if (settings.ValoSrcPath.Length > 0) return;
            Hide();
            new SetLocationForm(settings).Show();
        }

        private void CheckVideoPath()
        {
            newVideoPathTf.Text = settings.ReplacementVideoSrcPath;
        }

        private void DisplayCurrentVideo()
        {
            currentVideoWMP.URL = settings.ReplacementVideoSrcPath;
        }

        private void fileExplorerBtn_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "MP4 Files (*.mp4)|*.mp4";
                openFileDialog.Title = "Select a MP4 File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    newVideoPathTf.Text = openFileDialog.FileName;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string newVideoPath = newVideoPathTf.Text;
            if (newVideoPath == null) return;
            settings.ReplacementVideoSrcPath = newVideoPath;
            settings.SaveSettings();
            MessageBox.Show("Saved!");
            DisplayCurrentVideo();
        }

        private void StartVBCThread()
        {
            new VBCThread().Start();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingForm(settings).Show();
        }
    }
}
