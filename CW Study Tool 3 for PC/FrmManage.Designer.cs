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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManage));
            this.lvGroups = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.chGroups = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbGroups = new System.Windows.Forms.Label();
            this.btnNewGroup = new DevComponents.DotNetBar.ButtonX();
            this.lvWords = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.chWords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbWords = new System.Windows.Forms.Label();
            this.btnNewWord = new DevComponents.DotNetBar.ButtonX();
            this.tbWord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbTranslation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.pnWords = new System.Windows.Forms.Panel();
            this.pnEdit = new System.Windows.Forms.Panel();
            this.lbEdit = new System.Windows.Forms.Label();
            this.pnWords.SuspendLayout();
            this.pnEdit.SuspendLayout();
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
            this.chGroups});
            this.lvGroups.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvGroups.ForeColor = System.Drawing.Color.Black;
            this.lvGroups.FullRowSelect = true;
            this.lvGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvGroups.Location = new System.Drawing.Point(12, 44);
            this.lvGroups.MultiSelect = false;
            this.lvGroups.Name = "lvGroups";
            this.lvGroups.Size = new System.Drawing.Size(216, 519);
            this.lvGroups.TabIndex = 0;
            this.lvGroups.UseCompatibleStateImageBehavior = false;
            this.lvGroups.View = System.Windows.Forms.View.Details;
            this.lvGroups.SelectedIndexChanged += new System.EventHandler(this.lvGroups_SelectedIndexChanged);
            // 
            // chGroups
            // 
            this.chGroups.Text = "Groups";
            this.chGroups.Width = 210;
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
            this.btnNewGroup.Click += new System.EventHandler(this.btnNewGroup_Click);
            // 
            // lvWords
            // 
            this.lvWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvWords.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lvWords.Border.Class = "ListViewBorder";
            this.lvWords.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chWords});
            this.lvWords.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvWords.ForeColor = System.Drawing.Color.Black;
            this.lvWords.FullRowSelect = true;
            this.lvWords.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvWords.Location = new System.Drawing.Point(3, 35);
            this.lvWords.MultiSelect = false;
            this.lvWords.Name = "lvWords";
            this.lvWords.Size = new System.Drawing.Size(268, 520);
            this.lvWords.TabIndex = 4;
            this.lvWords.UseCompatibleStateImageBehavior = false;
            this.lvWords.View = System.Windows.Forms.View.Details;
            this.lvWords.SelectedIndexChanged += new System.EventHandler(this.lvWords_SelectedIndexChanged);
            // 
            // chWords
            // 
            this.chWords.Text = "Words";
            this.chWords.Width = 265;
            // 
            // lbWords
            // 
            this.lbWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWords.BackColor = System.Drawing.Color.Transparent;
            this.lbWords.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbWords.ForeColor = System.Drawing.Color.Black;
            this.lbWords.Location = new System.Drawing.Point(20, -1);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(248, 29);
            this.lbWords.TabIndex = 5;
            this.lbWords.Text = "Words";
            this.lbWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewWord
            // 
            this.btnNewWord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewWord.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnNewWord.FocusCuesEnabled = false;
            this.btnNewWord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewWord.Location = new System.Drawing.Point(3, 4);
            this.btnNewWord.Name = "btnNewWord";
            this.btnNewWord.Size = new System.Drawing.Size(25, 25);
            this.btnNewWord.Symbol = "";
            this.btnNewWord.SymbolColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewWord.SymbolSize = 10F;
            this.btnNewWord.TabIndex = 6;
            this.btnNewWord.Click += new System.EventHandler(this.btnNewWord_Click);
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
            this.tbWord.Location = new System.Drawing.Point(0, 36);
            this.tbWord.Name = "tbWord";
            this.tbWord.PreventEnterBeep = true;
            this.tbWord.Size = new System.Drawing.Size(525, 34);
            this.tbWord.TabIndex = 7;
            this.tbWord.TextChanged += new System.EventHandler(this.tbWord_TextChanged);
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
            this.tbTranslation.Location = new System.Drawing.Point(0, 76);
            this.tbTranslation.MaxLength = 2147483647;
            this.tbTranslation.Multiline = true;
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.PreventEnterBeep = true;
            this.tbTranslation.Size = new System.Drawing.Size(525, 436);
            this.tbTranslation.TabIndex = 8;
            this.tbTranslation.TextChanged += new System.EventHandler(this.tbTranslation_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.FocusCuesEnabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(0, 518);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(525, 38);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnWords
            // 
            this.pnWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnWords.Controls.Add(this.btnNewWord);
            this.pnWords.Controls.Add(this.lvWords);
            this.pnWords.Controls.Add(this.lbWords);
            this.pnWords.Enabled = false;
            this.pnWords.Location = new System.Drawing.Point(234, 9);
            this.pnWords.Name = "pnWords";
            this.pnWords.Size = new System.Drawing.Size(271, 555);
            this.pnWords.TabIndex = 10;
            // 
            // pnEdit
            // 
            this.pnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnEdit.Controls.Add(this.lbEdit);
            this.pnEdit.Controls.Add(this.tbWord);
            this.pnEdit.Controls.Add(this.btnUpdate);
            this.pnEdit.Controls.Add(this.tbTranslation);
            this.pnEdit.Enabled = false;
            this.pnEdit.Location = new System.Drawing.Point(522, 8);
            this.pnEdit.Name = "pnEdit";
            this.pnEdit.Size = new System.Drawing.Size(525, 556);
            this.pnEdit.TabIndex = 11;
            // 
            // lbEdit
            // 
            this.lbEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEdit.BackColor = System.Drawing.Color.Transparent;
            this.lbEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbEdit.ForeColor = System.Drawing.Color.Black;
            this.lbEdit.Location = new System.Drawing.Point(0, 1);
            this.lbEdit.Name = "lbEdit";
            this.lbEdit.Size = new System.Drawing.Size(525, 29);
            this.lbEdit.TabIndex = 7;
            this.lbEdit.Text = "Editing: ";
            this.lbEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 576);
            this.Controls.Add(this.pnWords);
            this.Controls.Add(this.btnNewGroup);
            this.Controls.Add(this.lbGroups);
            this.Controls.Add(this.lvGroups);
            this.Controls.Add(this.pnEdit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage You Words";
            this.Load += new System.EventHandler(this.FrmManage_Load);
            this.pnWords.ResumeLayout(false);
            this.pnEdit.ResumeLayout(false);
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
        private System.Windows.Forms.ColumnHeader chGroups;
        private System.Windows.Forms.ColumnHeader chWords;
        private System.Windows.Forms.Panel pnWords;
        private System.Windows.Forms.Panel pnEdit;
        private System.Windows.Forms.Label lbEdit;
    }
}