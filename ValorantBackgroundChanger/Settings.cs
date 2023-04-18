using System.IO;
using Newtonsoft.Json;

namespace ValorantBackgroundChanger
{
    public class Settings
    {
        public Settings()
        {
            ValoSrcPath = "";
            ReplacementVideoSrcPath = "";
            StartWithWindows = false;
            StartMinimized = false;
            CloseMinimizes = false;
        }

        public string ValoSrcPath { get; set; }

        public string ReplacementVideoSrcPath { get; set; }

        public bool StartWithWindows { get; set; }

        public bool StartMinimized { get; set; }

        public bool CloseMinimizes { get; set; }

        public void ReadSettings()
        {
            using (StreamReader r = new StreamReader("settings.json"))
            {
                var json = r.ReadToEnd();
                var settings = JsonConvert.DeserializeObject<Settings>(json);
                this.ValoSrcPath = settings.ValoSrcPath;
                this.ReplacementVideoSrcPath = settings.ReplacementVideoSrcPath;
                this.StartWithWindows = settings.StartWithWindows;
                this.StartMinimized = settings.StartMinimized;
                this.CloseMinimizes = settings.CloseMinimizes;
            }
        }

        public void SaveSettings()
        {
            using (StreamWriter w = new StreamWriter("settings.json"))
            {
                w.Write(JsonConvert.SerializeObject(this));
            }
        }
    }
}