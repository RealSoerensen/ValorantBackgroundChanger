using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ValorantBackgroundChanger
{
    public partial class Main : Form
    {
        private readonly Settings settings;
        private Thread t;

        public Main(Settings settings)
        {
            this.settings = settings;
            InitializeComponent();
            Icon = Properties.Resources.VBC;
            SetupVideoPlayer();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            CheckValoPath();
            CheckVideoPath();
            DisplayCurrentVideo();
            t = new Thread(StartVBCThread)
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

        private void RestoreVideo()
        {
            string valoPath = settings.ValoSrcPath;
            bool isBackgroundRestored = false;
            if (string.IsNullOrEmpty(valoPath))
            {
                return;
            }

            string[] files = Directory.GetFiles(valoPath);
            string backupFile = null;
            string videoFile = null;
            foreach (string file in files)
            {
                if (file.EndsWith(".bak"))
                {
                    backupFile = file;
                }

                else if (file.Contains("HomepageEp") && file.EndsWith(".mp4"))
                {
                    videoFile = file;
                }
            }

            if (backupFile != null && videoFile != null)
            {
                File.Delete(videoFile);
                File.Move(backupFile, videoFile);
                isBackgroundRestored = true;
                settings.ReplacementVideoSrcPath = null;
                settings.SaveSettings();
            }

            MessageBox.Show(isBackgroundRestored ? "Background restored!" : "Background is already restored!");
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
            if (newVideoPath.Length == 0) return;
            settings.ReplacementVideoSrcPath = newVideoPath;
            settings.SaveSettings();
            MessageBox.Show("Saved!");
            newVideoPathTf.Text = settings.ReplacementVideoSrcPath;
            DisplayCurrentVideo();
        }

        private void StartVBCThread()
        {
            new VBCThread().Start();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingForm(settings).Show();
            Hide();
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("VALORANT-Win64-Shipping").Length > 0 || Process.GetProcessesByName("RiotClientService").Length > 0)
            {
                MessageBox.Show("Please close any Riot services before restoring");
                return;
            }
            if (settings.ReplacementVideoSrcPath == null)
            {
                MessageBox.Show("No background to restore.");
                return;
            }
            
            RestoreVideo();
            CheckVideoPath();
            DisplayCurrentVideo();
        }

        private void Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!settings.CloseMinimizes)
            {
                t.Abort();
                return;
            }
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Minimized:
                    notifyIcon.Visible = true;
                    ShowInTaskbar = false;
                    break;
                case FormWindowState.Normal:
                    notifyIcon.Visible = false;
                    ShowInTaskbar = true;
                    break;
                case FormWindowState.Maximized:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Abort();
            Application.Exit();
        }
    }
}
