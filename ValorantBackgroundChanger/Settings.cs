using System.IO;
using Newtonsoft.Json;

namespace ValorantBackgroundChanger
{
    public class Settings
    {
        private string valoSrcPath;
        private string replacementVideoSrcPath;
        private bool startWithWindows;

        public Settings()
        {
            valoSrcPath = "";
            replacementVideoSrcPath = "";
            startWithWindows = false;
        }

        public string ValoSrcPath { get => valoSrcPath; set => valoSrcPath = value; }
        public string ReplacementVideoSrcPath { get => replacementVideoSrcPath; set => replacementVideoSrcPath = value; }
        public bool StartWithWindows { get => startWithWindows; set => startWithWindows = value; }

        public void ReadSettings()
        {
            using (StreamReader r = new StreamReader("settings.json"))
            {
                var json = r.ReadToEnd();
                var settings = JsonConvert.DeserializeObject<Settings>(json);
                this.valoSrcPath = settings.ValoSrcPath;
                this.replacementVideoSrcPath = settings.ReplacementVideoSrcPath;
                this.startWithWindows = settings.StartWithWindows;
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