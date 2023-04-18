using System;
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
                ReplaceBackground();
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
    }
}