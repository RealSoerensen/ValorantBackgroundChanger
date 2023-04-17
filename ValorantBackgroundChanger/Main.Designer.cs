namespace ValorantBackgroundChanger
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.newVideoPathTf = new System.Windows.Forms.TextBox();
            this.currentVideoWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.fileExplorerBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.sSsettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dISCLAIMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.currentVideoWMP)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MP4 to replace background";
            // 
            // newVideoPathTf
            // 
            this.newVideoPathTf.Location = new System.Drawing.Point(9, 222);
            this.newVideoPathTf.Name = "newVideoPathTf";
            this.newVideoPathTf.Size = new System.Drawing.Size(229, 20);
            this.newVideoPathTf.TabIndex = 6;
            // 
            // currentVideoWMP
            // 
            this.currentVideoWMP.Enabled = true;
            this.currentVideoWMP.Location = new System.Drawing.Point(12, 44);
            this.currentVideoWMP.Name = "currentVideoWMP";
            this.currentVideoWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("currentVideoWMP.OcxState")));
            this.currentVideoWMP.Size = new System.Drawing.Size(254, 143);
            this.currentVideoWMP.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current video replacing background";
            // 
            // fileExplorerBtn
            // 
            this.fileExplorerBtn.Location = new System.Drawing.Point(244, 222);
            this.fileExplorerBtn.Name = "fileExplorerBtn";
            this.fileExplorerBtn.Size = new System.Drawing.Size(30, 23);
            this.fileExplorerBtn.TabIndex = 9;
            this.fileExplorerBtn.Text = "...";
            this.fileExplorerBtn.UseVisualStyleBackColor = true;
            this.fileExplorerBtn.Click += new System.EventHandler(this.fileExplorerBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 249);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save change";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem3});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(290, 24);
            this.mainMenu.TabIndex = 11;
            this.mainMenu.Text = "menuStrip1";
            // 
            // sSsettingsToolStripMenuItem
            // 
            this.sSsettingsToolStripMenuItem.Name = "sSsettingsToolStripMenuItem";
            this.sSsettingsToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // dISCLAIMERToolStripMenuItem
            // 
            this.dISCLAIMERToolStripMenuItem.Name = "dISCLAIMERToolStripMenuItem";
            this.dISCLAIMERToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // settingsToolStripMenuItem2
            // 
            this.settingsToolStripMenuItem2.Name = "settingsToolStripMenuItem2";
            this.settingsToolStripMenuItem2.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem2.Text = "Settings";
            // 
            // settingsToolStripMenuItem3
            // 
            this.settingsToolStripMenuItem3.Name = "settingsToolStripMenuItem3";
            this.settingsToolStripMenuItem3.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem3.Text = "Settings";
            this.settingsToolStripMenuItem3.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 281);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fileExplorerBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentVideoWMP);
            this.Controls.Add(this.newVideoPathTf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenu);
            this.HelpButton = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Main";
            this.Text = "Valorant Background Changer";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentVideoWMP)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newVideoPathTf;
        private AxWMPLib.AxWindowsMediaPlayer currentVideoWMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fileExplorerBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem sSsettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dISCLAIMERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem3;
    }
}

