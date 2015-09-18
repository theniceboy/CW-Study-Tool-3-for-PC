namespace CW_Study_Tool_3_for_PC
{
    partial class FrmNewWord
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
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.tbTranslation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbWord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.FocusCuesEnabled = false;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClear.Location = new System.Drawing.Point(12, 468);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 44);
            this.btnClear.Symbol = "";
            this.btnClear.SymbolSize = 12F;
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.FocusCuesEnabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.Location = new System.Drawing.Point(731, 468);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 44);
            this.btnAdd.Symbol = "";
            this.btnAdd.SymbolSize = 12F;
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.tbTranslation.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbTranslation.ForeColor = System.Drawing.Color.Black;
            this.tbTranslation.Location = new System.Drawing.Point(12, 96);
            this.tbTranslation.MaxLength = 2147483647;
            this.tbTranslation.Multiline = true;
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.PreventEnterBeep = true;
            this.tbTranslation.Size = new System.Drawing.Size(869, 366);
            this.tbTranslation.TabIndex = 8;
            this.tbTranslation.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbTranslation.WatermarkText = "The most powerful programming language in the world";
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
            this.tbWord.Font = new System.Drawing.Font("Segoe UI", 32F);
            this.tbWord.ForeColor = System.Drawing.Color.Black;
            this.tbWord.Location = new System.Drawing.Point(12, 12);
            this.tbWord.Name = "tbWord";
            this.tbWord.PreventEnterBeep = true;
            this.tbWord.Size = new System.Drawing.Size(869, 78);
            this.tbWord.TabIndex = 7;
            this.tbWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWord.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbWord.WatermarkText = "C-Sharp";
            // 
            // FrmNewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 524);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.tbWord);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmNewWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Word";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNewWord_FormClosed);
            this.Load += new System.EventHandler(this.FrmNewWord_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTranslation;
        private DevComponents.DotNetBar.Controls.TextBoxX tbWord;
    }
}