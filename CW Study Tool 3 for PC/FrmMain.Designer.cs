namespace CW_Study_Tool_3_for_PC
{
    partial class FrmMain
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
            this.btnLearnWords = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnManageWords = new DevComponents.DotNetBar.ButtonX();
            this.btnLogout = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnLearnWords
            // 
            this.btnLearnWords.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLearnWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLearnWords.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLearnWords.Enabled = false;
            this.btnLearnWords.FocusCuesEnabled = false;
            this.btnLearnWords.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLearnWords.Location = new System.Drawing.Point(12, 12);
            this.btnLearnWords.Name = "btnLearnWords";
            this.btnLearnWords.Size = new System.Drawing.Size(307, 62);
            this.btnLearnWords.TabIndex = 0;
            this.btnLearnWords.Text = "Learn Words";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // btnManageWords
            // 
            this.btnManageWords.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnManageWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageWords.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnManageWords.Enabled = false;
            this.btnManageWords.FocusCuesEnabled = false;
            this.btnManageWords.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnManageWords.Location = new System.Drawing.Point(12, 84);
            this.btnManageWords.Name = "btnManageWords";
            this.btnManageWords.Size = new System.Drawing.Size(307, 72);
            this.btnManageWords.TabIndex = 1;
            this.btnManageWords.Text = "Manage Words";
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogout.Enabled = false;
            this.btnLogout.FocusCuesEnabled = false;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.Location = new System.Drawing.Point(12, 166);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(307, 41);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextColor = System.Drawing.Color.Red;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 220);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageWords);
            this.Controls.Add(this.btnLearnWords);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(349, 267);
            this.MinimumSize = new System.Drawing.Size(349, 267);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW Study Tool 3 for PC";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX btnLearnWords;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        public DevComponents.DotNetBar.ButtonX btnManageWords;
        public DevComponents.DotNetBar.ButtonX btnLogout;
    }
}