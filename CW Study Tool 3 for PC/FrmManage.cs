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

        private string cur_group, cur_word = "", cur_translation = "";
        private bool cur_changed = false;

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

        async void  load_groups()
        {
            if (internet_available() == 1)
            {
                MessageBoxEx.Show("Internet not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            this.lvGroups.BeginUpdate();
            this.lvGroups.Items.Clear();
            var query = ParseObject.GetQuery("groups").WhereEqualTo("username", Gib.username);
            IEnumerable<ParseObject> result = await query.FindAsync();
            foreach (var obj in result)
            {
                ListViewItem item = new ListViewItem();
                item.Text = obj["name"].ToString();
                this.lvGroups.Items.Add(item);
            }
            this.lvGroups.EndUpdate();
            ToastNotification.Close(this);
            ToastNotification.Show(this, "Finish loading your groups", null, 2000);
        }

        private IEnumerable<ParseObject> wordlist;
        async void load_words()
        {
            if (internet_available() == 1)
            {
                MessageBoxEx.Show("Internet not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            this.lvWords.BeginUpdate();
            this.lvWords.Items.Clear();
            var query = ParseObject.GetQuery("words").WhereEqualTo("username", Gib.username).WhereEqualTo("group", cur_group);
            wordlist = await query.FindAsync();
            foreach (var obj in wordlist)
            {
                ListViewItem item = new ListViewItem();
                item.Text = obj["word"].ToString();
                item.ToolTipText = obj["translation"].ToString();
                this.lvWords.Items.Add(item);
            }
            this.lvWords.EndUpdate();
            ToastNotification.Close(this);
            ToastNotification.Show(this, "Group \"" + cur_group + "\" loaded", null, 1000);
        }

        private void FrmManage_Load(object sender, EventArgs e)
        {
            pnWords.BackColor = pnEdit.BackColor = Color.White;
            load_groups();
        }

        private void lvGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGroups.SelectedItems.Count > 0)
            {
                pnWords.Enabled = true;
                cur_group = lvGroups.SelectedItems[0].Text;
                load_words();
            }
        }

        private void lvWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWords.SelectedItems.Count > 0)
            {
                string tword = lvWords.SelectedItems[0].Text, ttranslation = lvWords.SelectedItems[0].ToolTipText;
                if (tword != cur_word && cur_changed)
                {
                    if (
                        MessageBoxEx.Show(this,
                            "Your word \"" + cur_word +
                            "\" has been changed. Do you want to update those changes to cloud?", "Dialog",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, true) ==
                        DialogResult.Yes)
                    {
                        btnUpdate_Click(sender, e);
                    }
                }
                pnEdit.Enabled = true;
                cur_word = tbWord.Text = tword;
                cur_translation = tbTranslation.Text = ttranslation;
                cur_changed = false;
                lbEdit.Text = "Editing: " + cur_word;
            }
        }

        private void tbWord_TextChanged(object sender, EventArgs e)
        {
            cur_changed = true;
        }

        private void tbTranslation_TextChanged(object sender, EventArgs e)
        {
            cur_changed = true;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (var obj in wordlist)
            {
                if (obj["word"].ToString() == cur_word)
                {
                    obj["word"] = tbWord.Text.Trim();
                    obj["translation"] = tbTranslation.Text;
                    await obj.SaveAsync();
                    ToastNotification.Close(this);
                    ToastNotification.Show(this, "Word \"" + cur_word + "\" updated", null, 1000);
                    load_words();
                    break;
                }
            }
        }
    }
}