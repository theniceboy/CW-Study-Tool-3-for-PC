using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Parse;

namespace CW_Study_Tool_3_for_PC
{
    public partial class FrmLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        private string uname, pword;
        private int get_type = -1;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (get_type != 0)
            {
                Application.Exit();
            }
        }

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
       
        /*
            Internet not available: -1
            Login successed: 0
            Username not exists: 1
            Password incorrect: 2
        */
        private async void login(string username, string password)
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
            if (pword != S.encrypt(password))
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
            }
            else if (get_type == 1)
            {
                MessageBoxEx.Show("Password incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Gib.username = uname;
                Gib.password = pword;
                File.WriteAllText(Gib.hostpaths + "username", Gib.username);
                File.WriteAllText(Gib.hostpaths + "password", Gib.password);
                FrmMain frm = (FrmMain) this.Owner;
                frm.btnLearnWords.Enabled = frm.btnManageWords.Enabled = frm.btnLogout.Enabled = true;
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login(tbUsername.Text, tbPassword.Text);
        }
    }
}