namespace ValorantBackgroundChanger
{
    partial class SettingForm
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
            this.toggleStartUp = new System.Windows.Forms.CheckBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.toggleStartMinimized = new System.Windows.Forms.CheckBox();
            this.toggleCloseMinimizes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // toggleStartUp
            // 
            this.toggleStartUp.AutoSize = true;
            this.toggleStartUp.Location = new System.Drawing.Point(12, 12);
            this.toggleStartUp.Name = "toggleStartUp";
            this.toggleStartUp.Size = new System.Drawing.Size(117, 17);
            this.toggleStartUp.TabIndex = 0;
            this.toggleStartUp.Text = "Start with Windows";
            this.toggleStartUp.UseVisualStyleBackColor = true;
            this.toggleStartUp.CheckedChanged += new System.EventHandler(this.toggleStartUp_CheckedChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 81);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // toggleStartMinimized
            // 
            this.toggleStartMinimized.AutoSize = true;
            this.toggleStartMinimized.Location = new System.Drawing.Point(12, 35);
            this.toggleStartMinimized.Name = "toggleStartMinimized";
            this.toggleStartMinimized.Size = new System.Drawing.Size(96, 17);
            this.toggleStartMinimized.TabIndex = 2;
            this.toggleStartMinimized.Text = "Start minimized";
            this.toggleStartMinimized.UseVisualStyleBackColor = true;
            this.toggleStartMinimized.CheckedChanged += new System.EventHandler(this.toggleStartMinimized_CheckedChanged);
            // 
            // toggleCloseMinimizes
            // 
            this.toggleCloseMinimizes.AutoSize = true;
            this.toggleCloseMinimizes.Location = new System.Drawing.Point(12, 58);
            this.toggleCloseMinimizes.Name = "toggleCloseMinimizes";
            this.toggleCloseMinimizes.Size = new System.Drawing.Size(86, 17);
            this.toggleCloseMinimizes.TabIndex = 3;
            this.toggleCloseMinimizes.Text = "(X) minimizes";
            this.toggleCloseMinimizes.UseVisualStyleBackColor = true;
            this.toggleCloseMinimizes.CheckedChanged += new System.EventHandler(this.toggleCloseMinimizes_CheckedChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 108);
            this.Controls.Add(this.toggleCloseMinimizes);
            this.Controls.Add(this.toggleStartMinimized);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.toggleStartUp);
            this.Name = "SettingForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox toggleStartUp;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.CheckBox toggleStartMinimized;
        private System.Windows.Forms.CheckBox toggleCloseMinimizes;
    }
}