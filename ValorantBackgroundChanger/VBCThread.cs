using System;
using System.Diagnostics;
using System.IO;
using System.Security;
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
            try
            {
                settings.ReadSettings();
                valoPath = settings.ValoSrcPath;
                videoPath = settings.ReplacementVideoSrcPath;
            }
            catch
            {
                Thread.Sleep(100);
                setSettings();
            }

        }

        public void Start()
        {
            while (true)
            {
                setSettings();
                bool isBackgroundChanged = checkIfBackgroundChanged();
                if (!isBackgroundChanged)
                {
                    ReplaceBackground();
                }
                Thread.Sleep(5000);
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
                bool isOriginalSaved = isBackedUp();
                foreach (string file in files)
                {
                    if (file.Contains("HomepageEp") && !file.EndsWith(".bak"))
                    {
                        if (!isOriginalSaved)
                        {
                            string backup = file + ".bak";
                            File.Copy(file, backup, true);
                        }
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

        private bool isBackedUp()
        {
            string[] files = Directory.GetFiles(valoPath);
            foreach (string file in files)
            {
                if (file.EndsWith(".bak"))
                {
                    return true;
                }
            }
            return false;
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