using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ValorantBackgroundChanger
{
    public class VBCThread
    {
        private static readonly string root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"ValorantBackGroundChanger\");
        private readonly string valorantSrc = root + "ValorantSrcFolder.txt";
        private readonly string videoSrc = root + "ReplacementVideoSrc.txt";

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
            string valoPath = null;
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    valoPath = s;
                }
            }
            return valoPath;
        }


        private void ReplaceBackground()
        {
            string valoPath = GetFilePath(valorantSrc);
            string videoPath = GetFilePath(videoSrc);
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