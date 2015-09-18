namespace CW_Study_Tool_3_for_PC
{
    partial class FrmNewGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewGroup));
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.tbNewGroup = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.FocusCuesEnabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.Location = new System.Drawing.Point(320, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbNewGroup
            // 
            this.tbNewGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewGroup.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbNewGroup.Border.Class = "TextBoxBorder";
            this.tbNewGroup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNewGroup.DisabledBackColor = System.Drawing.Color.White;
            this.tbNewGroup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbNewGroup.ForeColor = System.Drawing.Color.Black;
            this.tbNewGroup.Location = new System.Drawing.Point(13, 13);
            this.tbNewGroup.Name = "tbNewGroup";
            this.tbNewGroup.PreventEnterBeep = true;
            this.tbNewGroup.Size = new System.Drawing.Size(428, 34);
            this.tbNewGroup.TabIndex = 1;
            this.tbNewGroup.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbNewGroup.WatermarkText = "Your group name";
            // 
            // FrmNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 107);
            this.Controls.Add(this.tbNewGroup);
            this.Controls.Add(this.btnAdd);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(471, 154);
            this.MinimumSize = new System.Drawing.Size(471, 154);
            this.Name = "FrmNewGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Group";
            this.Load += new System.EventHandler(this.FrmNewGroup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNewGroup;
    }
}