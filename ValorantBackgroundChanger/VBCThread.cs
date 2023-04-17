using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ValorantBackgroundChanger
{
    public class VBCThread
    {
        private readonly Settings settings = new Settings();
        private string valoPath;
        private string videoPath;

        public VBCThread()
        {
            setSettings();
        }

        private void setSettings()
        {
            settings.ReadSettings();
            valoPath = settings.ValoSrcPath;
            videoPath = settings.ReplacementVideoSrcPath;
        }

        public void Start()
        {
            bool isBackgroundChanged = false;
            while (!isBackgroundChanged)
            {
                setSettings();
                ReplaceBackground();
                if (Process.GetProcessesByName("VALORANT-Win64-Shipping").Length > 0)
                {
                    isBackgroundChanged = checkIfBackgroundChanged();
                }
                Thread.Sleep(1000);
            }
        }

        private void ReplaceBackground()
        {
            if (string.IsNullOrEmpty(valoPath) || string.IsNullOrEmpty(videoPath))
            {
                return;
            }

            try
            {
                string[] files = Directory.GetFiles(valoPath);
                foreach (string file in files)
                {
                    if (file.Contains("HomepageEp"))
                    {
                        File.Copy(videoPath, file, true);
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Thread.Sleep(100);
                ReplaceBackground();
            }
        }

        private bool checkIfBackgroundChanged()
        {
            if (string.IsNullOrEmpty(valoPath) || string.IsNullOrEmpty(videoPath))
            {
                return false;
            }
            FileInfo videoFileInfo = new FileInfo(videoPath);
            int videoFileSize = (int)videoFileInfo.Length;
            int valoVideoFileSize = 0;
            try
            {
                string[] files = Directory.GetFiles(valoPath);
                foreach (string file in files)
                {
                    if (file.Contains("HomepageEp"))
                    {
                        FileInfo valoVideoFileInfo = new FileInfo(file);
                        valoVideoFileSize = (int)valoVideoFileInfo.Length;
                    }
                }
            }
            catch (Exception)
            {
                Thread.Sleep(100);
                checkIfBackgroundChanged();
            }
            return (videoFileSize == valoVideoFileSize);
        }
    }
}