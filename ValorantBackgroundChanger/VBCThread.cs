using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ValorantBackgroundChanger
{
    public class VBCThread
    {
        private readonly string valorantSrcFilePath;
        private readonly string replacementVideoSrcFilePath;

        public VBCThread()
        {
            var appDataFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ValorantBackGroundChanger");
            valorantSrcFilePath = Path.Combine(appDataFolderPath, "ValorantSrcFolder.txt");
            replacementVideoSrcFilePath = Path.Combine(appDataFolderPath, "ReplacementVideoSrc.txt");
        }

        public void Start()
        {
            while (true)
            {
                if (Process.GetProcessesByName("VALORANT-Win64-Shipping").Length > 0)
                {
                    ReplaceBackground();
                }
                Thread.Sleep(1000);
            }
        }

        private string GetFilePath(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return null;
        }

        private void ReplaceBackground()
        {
            string valoPath = GetFilePath(valorantSrcFilePath);
            string videoPath = GetFilePath(replacementVideoSrcFilePath);

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
    }
}