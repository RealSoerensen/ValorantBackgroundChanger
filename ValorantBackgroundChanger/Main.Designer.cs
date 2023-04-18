using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.newVideoPathTf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileExplorerBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.currentVideoWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentVideoWMP)).BeginInit();
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
            this.saveBtn.Location = new System.Drawing.Point(203, 248);
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
            this.settingsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(290, 24);
            this.mainMenu.TabIndex = 11;
            this.mainMenu.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(12, 248);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(93, 23);
            this.restoreBtn.TabIndex = 12;
            this.restoreBtn.Text = "Restore original";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Valorant Background Changer";
            ContextMenu contextMenu1 = new ContextMenu();
            contextMenu1.MenuItems.Add("Restore original", new EventHandler(restoreBtn_Click));
            contextMenu1.MenuItems.Add("Settings", new EventHandler(settingsToolStripMenuItem_Click));
            contextMenu1.MenuItems.Add("Exit", new EventHandler(exitToolStripMenuItem_Click));
            this.notifyIcon.ContextMenu = contextMenu1;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 281);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fileExplorerBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentVideoWMP);
            this.Controls.Add(this.newVideoPathTf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Valorant Background Changer";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Main_Closing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentVideoWMP)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

