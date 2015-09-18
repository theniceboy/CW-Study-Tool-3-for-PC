using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Parse;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace CW_Study_Tool_3_for_PC
{
    public partial class FrmMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
            ParseClient.Initialize(S.ps1, S.ps2);
        }
        
        private string uname, pword;
        private int get_type = -1;

        #region Internet Connect Class
        /*
         * Not available: 1
         * Available: 2
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

        void get_user_info()
        {
            Gib.username = File.ReadAllText(Gib.hostpaths + "username");
            Gib.password = File.ReadAllText(Gib.hostpaths + "password");
        }

        /*
            Internet not available: -1
            Login successed: 0
            Username not exists: 1
            Password incorrect: 2
        */

        async void login_check(string username, string password)
        {
            if (internet_available() == 1)
            {
                get_type = -1;
            }
            var query = ParseObject.GetQuery("users").WhereEqualTo("username", username);
            IEnumerable<ParseObject> result = await query.FindAsync();
            if (result.Count() == 0)
            {
                get_type = 1;
                tried_login();
                return;
            }
            ParseObject obj = result.First();
            uname = username;
            pword = obj.Get<string>("password");
            if (pword != password)
            {
                get_type = 2;
            }
            get_type = 0;
            tried_login();
        }

        void tried_login()
        {
            if (get_type == -1)
            {
                MessageBoxEx.Show("Internet not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if (get_type == 1)
            {
                MessageBoxEx.Show("Username not exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FrmLogin frm = new FrmLogin();
                frm.ShowDialog(this);
            }
            else if (get_type == 1)
            {
                MessageBoxEx.Show("Password incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FrmLogin frm = new FrmLogin();
                frm.ShowDialog(this);
            }
            else
            {
                Gib.username = uname;
                Gib.password = pword;
            }
        }

        private void btnManageWords_Click(object sender, EventArgs e)
        {
            FrmManage frm = new FrmManage();
            frm.ShowDialog(this);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:\\ProgramData\\CW Soft"))
                Directory.CreateDirectory("C:\\ProgramData\\CW Soft");
            if (!Directory.Exists(Gib.hostpath))
                Directory.CreateDirectory(Gib.hostpath);
            if (!File.Exists(Gib.hostpaths + "username"))
            {
                FrmLogin frm = new FrmLogin();
                frm.ShowDialog(this);
            }
            else
            {
                get_user_info();
                login_check(Gib.username, Gib.password);
                btnLearnWords.Enabled = btnManageWords.Enabled = btnLogout.Enabled = true;
            }
        }
    }
}
