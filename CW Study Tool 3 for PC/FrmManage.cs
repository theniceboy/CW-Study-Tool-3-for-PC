using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Parse;

namespace CW_Study_Tool_3_for_PC
{
    public partial class FrmManage : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmManage()
        {
            InitializeComponent();
        }

        #region Internet Connect Class
        /*
         * Not available£º1
         * Available£º2
        */
        public const int INTERNET_CONNECTION_MODEM = 1;
        public const int INTERNET_CONNECTION_LAN = 2;
        [DllImport("winInet.dll")]
        public static extern bool InternetGetConnectedState(ref int dwFlag, int dwReserved);

        int internet_available()
        {
            System.Int32 dwFlag = new int();
            if (!InternetGetConnectedState(ref dwFlag, 0))
                return 1;
            else
                return 2;
        }
        #endregion

        async void get_groups()
        {
            if (internet_available() == 1)
            {
                MessageBoxEx.Show("Internet not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            lvGroups.
            var query = ParseObject.GetQuery("groups").WhereEqualTo("username", Gib.username);
            IEnumerable<ParseObject> result = await query.FindAsync();
            foreach (var obj in result)
            {
                MessageBox.Show(obj["name"].ToString());
            }
        }

        private void FrmManage_Load(object sender, EventArgs e)
        {
            get_groups();
        }
    }
}