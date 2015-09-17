using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CW_Study_Tool_3_for_PC
{
    public partial class FrmLoading : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            lbMessage.Text = Gib.progressStr;
        }
    }
}