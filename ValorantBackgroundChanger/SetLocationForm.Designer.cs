namespace ValorantBackgroundChanger
{
    partial class SetLocationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.srcTf = new System.Windows.Forms.TextBox();
            this.folderBrowserBtn = new System.Windows.Forms.Button();
            this.setLocationbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the folder where your Valorant is installed. (Example: C:\\\\Riot Gam" +
    "es\\\\Valorant)";
            // 
            // srcTf
            // 
            this.srcTf.Location = new System.Drawing.Point(12, 43);
            this.srcTf.Name = "srcTf";
            this.srcTf.Size = new System.Drawing.Size(230, 20);
            this.srcTf.TabIndex = 1;
            this.srcTf.Text = "C:\\Riot Games\\VALORANT";
            // 
            // folderBrowserBtn
            // 
            this.folderBrowserBtn.Location = new System.Drawing.Point(248, 43);
            this.folderBrowserBtn.Name = "folderBrowserBtn";
            this.folderBrowserBtn.Size = new System.Drawing.Size(24, 20);
            this.folderBrowserBtn.TabIndex = 2;
            this.folderBrowserBtn.Text = "...";
            this.folderBrowserBtn.UseVisualStyleBackColor = true;
            this.folderBrowserBtn.Click += new System.EventHandler(this.folderBrowserBtn_Click);
            // 
            // setLocationbtn
            // 
            this.setLocationbtn.Location = new System.Drawing.Point(12, 69);
            this.setLocationbtn.Name = "setLocationbtn";
            this.setLocationbtn.Size = new System.Drawing.Size(75, 23);
            this.setLocationbtn.TabIndex = 3;
            this.setLocationbtn.Text = "Set Location";
            this.setLocationbtn.UseVisualStyleBackColor = true;
            this.setLocationbtn.Click += new System.EventHandler(this.setLocationbtn_Click);
            // 
            // SetLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 96);
            this.Controls.Add(this.setLocationbtn);
            this.Controls.Add(this.folderBrowserBtn);
            this.Controls.Add(this.srcTf);
            this.Controls.Add(this.label1);
            this.Name = "SetLocationForm";
            this.Text = "Set Valorant Location";
            this.Load += new System.EventHandler(this.SetLocationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox srcTf;
        private System.Windows.Forms.Button folderBrowserBtn;
        private System.Windows.Forms.Button setLocationbtn;
    }
}