namespace CW_Study_Tool_3_for_PC
{
    partial class FrmManage
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
            this.lvGroups = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.lbGroups = new System.Windows.Forms.Label();
            this.btnNewGroup = new DevComponents.DotNetBar.ButtonX();
            this.lvWords = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.lbWords = new System.Windows.Forms.Label();
            this.btnNewWord = new DevComponents.DotNetBar.ButtonX();
            this.tbWord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbTranslation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.Words = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Groups = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvGroups
            // 
            this.lvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvGroups.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lvGroups.Border.Class = "ListViewBorder";
            this.lvGroups.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Groups});
            this.lvGroups.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvGroups.ForeColor = System.Drawing.Color.Black;
            this.lvGroups.Location = new System.Drawing.Point(12, 44);
            this.lvGroups.Name = "lvGroups";
            this.lvGroups.Size = new System.Drawing.Size(216, 425);
            this.lvGroups.TabIndex = 0;
            this.lvGroups.UseCompatibleStateImageBehavior = false;
            this.lvGroups.View = System.Windows.Forms.View.Details;
            // 
            // lbGroups
            // 
            this.lbGroups.AutoSize = true;
            this.lbGroups.BackColor = System.Drawing.Color.White;
            this.lbGroups.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbGroups.ForeColor = System.Drawing.Color.Black;
            this.lbGroups.Location = new System.Drawing.Point(91, 12);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(60, 20);
            this.lbGroups.TabIndex = 1;
            this.lbGroups.Text = "Groups";
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnNewGroup.FocusCuesEnabled = false;
            this.btnNewGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGroup.Location = new System.Drawing.Point(12, 13);
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.Size = new System.Drawing.Size(25, 25);
            this.btnNewGroup.Symbol = "";
            this.btnNewGroup.SymbolColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewGroup.SymbolSize = 10F;
            this.btnNewGroup.TabIndex = 3;
            // 
            // lvWords
            // 
            this.lvWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvWords.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lvWords.Border.Class = "ListViewBorder";
            this.lvWords.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Words});
            this.lvWords.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvWords.ForeColor = System.Drawing.Color.Black;
            this.lvWords.Location = new System.Drawing.Point(251, 44);
            this.lvWords.Name = "lvWords";
            this.lvWords.Size = new System.Drawing.Size(252, 425);
            this.lvWords.TabIndex = 4;
            this.lvWords.UseCompatibleStateImageBehavior = false;
            this.lvWords.View = System.Windows.Forms.View.Details;
            // 
            // lbWords
            // 
            this.lbWords.BackColor = System.Drawing.Color.White;
            this.lbWords.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbWords.ForeColor = System.Drawing.Color.Black;
            this.lbWords.Location = new System.Drawing.Point(268, 9);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(224, 29);
            this.lbWords.TabIndex = 5;
            this.lbWords.Text = "Words";
            this.lbWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewWord
            // 
            this.btnNewWord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewWord.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnNewWord.Enabled = false;
            this.btnNewWord.FocusCuesEnabled = false;
            this.btnNewWord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewWord.Location = new System.Drawing.Point(251, 13);
            this.btnNewWord.Name = "btnNewWord";
            this.btnNewWord.Size = new System.Drawing.Size(25, 25);
            this.btnNewWord.Symbol = "";
            this.btnNewWord.SymbolColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewWord.SymbolSize = 10F;
            this.btnNewWord.TabIndex = 6;
            // 
            // tbWord
            // 
            this.tbWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWord.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbWord.Border.Class = "TextBoxBorder";
            this.tbWord.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbWord.DisabledBackColor = System.Drawing.Color.White;
            this.tbWord.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbWord.ForeColor = System.Drawing.Color.Black;
            this.tbWord.Location = new System.Drawing.Point(522, 44);
            this.tbWord.Name = "tbWord";
            this.tbWord.PreventEnterBeep = true;
            this.tbWord.Size = new System.Drawing.Size(354, 34);
            this.tbWord.TabIndex = 7;
            // 
            // tbTranslation
            // 
            this.tbTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTranslation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbTranslation.Border.Class = "TextBoxBorder";
            this.tbTranslation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTranslation.DisabledBackColor = System.Drawing.Color.White;
            this.tbTranslation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbTranslation.ForeColor = System.Drawing.Color.Black;
            this.tbTranslation.Location = new System.Drawing.Point(522, 84);
            this.tbTranslation.MaxLength = 2147483647;
            this.tbTranslation.Multiline = true;
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.PreventEnterBeep = true;
            this.tbTranslation.Size = new System.Drawing.Size(354, 342);
            this.tbTranslation.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Location = new System.Drawing.Point(522, 432);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(354, 38);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            // 
            // Words
            // 
            this.Words.Text = "Words";
            this.Words.Width = 250;
            // 
            // Groups
            // 
            this.Groups.Text = "Groups";
            this.Groups.Width = 210;
            // 
            // FrmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 482);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.btnNewWord);
            this.Controls.Add(this.lbWords);
            this.Controls.Add(this.lvWords);
            this.Controls.Add(this.btnNewGroup);
            this.Controls.Add(this.lbGroups);
            this.Controls.Add(this.lvGroups);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage You Words";
            this.Load += new System.EventHandler(this.FrmManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lvGroups;
        private System.Windows.Forms.Label lbGroups;
        public DevComponents.DotNetBar.ButtonX btnNewGroup;
        private System.Windows.Forms.Label lbWords;
        public DevComponents.DotNetBar.ButtonX btnNewWord;
        private DevComponents.DotNetBar.Controls.ListViewEx lvWords;
        private DevComponents.DotNetBar.Controls.TextBoxX tbWord;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTranslation;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private System.Windows.Forms.ColumnHeader Groups;
        private System.Windows.Forms.ColumnHeader Words;
    }
}