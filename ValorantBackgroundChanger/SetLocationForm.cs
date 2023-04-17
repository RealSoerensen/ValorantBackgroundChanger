﻿using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ValorantBackgroundChanger
{
    public partial class SetLocationForm : Form
    {
        private Settings settings = new Settings();

        public SetLocationForm(Settings settings)
        {
            settings.ReadSettings();
            InitializeComponent();
        }

        private void folderBrowserBtn_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    srcTf.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void setLocationbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string finalText = Path.Combine(srcTf.Text, "live", "ShooterGame", "Content", "Movies", "Menu");
                settings.ValoSrcPath = finalText;
                using (StreamWriter w = new StreamWriter("settings.json"))
                {
                    w.Write(JsonConvert.SerializeObject(settings));
                }
                Hide();
                new Main(settings).Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SetLocationForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This program is not affiliated with Riot Games or VALORANT. VALORANT is a registered trademark of Riot Games, Inc. VALORANT © Riot Games, Inc. All rights reserved." +
                "\nYou could be banned using this program as it changes the game files which is against TOS",
                "Disclaimer", MessageBoxButtons.OK);
        }
    }
}
