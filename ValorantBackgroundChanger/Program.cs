﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ValorantBackgroundChanger
{
    internal static class Program
    {
        private static Settings settings = new Settings();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] 
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CheckIfSettingsExist();
            settings.ReadSettings();
            if (!CheckValoPath())
            {
                Application.Run(new SetLocationForm(settings));
            }
            else
            {
                Application.Run(new Main(settings));
            }
        }

        static void CheckIfSettingsExist()
        {
            if (File.Exists("settings.json")) return;
            using (StreamWriter w = new StreamWriter("settings.json"))
            {
                w.Write(JsonConvert.SerializeObject(settings));
            }
        }

        static bool CheckValoPath()
        {
            return (settings.ValoSrcPath.Length > 0);
        }
    }
}
