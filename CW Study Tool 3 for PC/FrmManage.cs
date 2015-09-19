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
    public partial class FrmManage : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmManage()
        {
            InitializeComponent();
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

        public async void  load_groups()
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
        public async void load_words()
        {
            if (internet_available() == 1)
            {
                MessageBoxEx.Show("Internet not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            this.lvWords.BeginUpdate();
            this.lvWords.Items.Clear();
            var query = ParseObject.GetQuery("words").WhereEqualTo("username", Gib.username).WhereEqualTo("group", Gib.cur_group);
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
            ToastNotification.Show(this, "Group \"" + Gib.cur_group + "\" loaded", null, 1000);
            pnWords.Enabled = true;
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
                pnWords.Enabled = false;
                Gib.cur_group = lvGroups.SelectedItems[0].Text;
                load_words();
            }
        }

        private void lvWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWords.SelectedItems.Count > 0)
            {
                string tword = lvWords.SelectedItems[0].Text, ttranslation = lvWords.SelectedItems[0].ToolTipText;
                if (tword != Gib.cur_word && Gib.cur_changed)
                {
                    if (
                        MessageBoxEx.Show(this,
                            "Your word \"" + Gib.cur_word +
                            "\" has been changed. Do you want to update those changes to cloud?", "Dialog",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, true) ==
                        DialogResult.Yes)
                    {
                        btnUpdate_Click(sender, e);
                    }
                }
                pnEdit.Enabled = true;
                Gib.cur_word = tbWord.Text = tword;
                tbTranslation.Text = ttranslation;
                Gib.cur_changed = false;
                lbEdit.Text = "Editing: " + Gib.cur_word;
            }
        }

        private void tbWord_TextChanged(object sender, EventArgs e)
        {
            Gib.cur_changed = true;
        }

        private void tbTranslation_TextChanged(object sender, EventArgs e)
        {
            Gib.cur_changed = true;
        }

        private void btnNewGroup_Click(object sender, EventArgs e)
        {
            FrmNewGroup frm = new FrmNewGroup();
            frm.ShowDialog(this);
        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            FrmNewWord frm = new FrmNewWord();
            frm.ShowDialog(this);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (var obj in wordlist)
            {
                if (obj["word"].ToString() == Gib.cur_word)
                {
                    obj["word"] = tbWord.Text.Trim();
                    obj["translation"] = tbTranslation.Text;
                    await obj.SaveAsync();
                    ToastNotification.Close(this);
                    ToastNotification.Show(this, "Word \"" + Gib.cur_word + "\" updated", null, 1000);
                    load_words();
                    Gib.cur_changed = false;
                    break;
                }
            }
        }

        private async void btnBatch_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; //过滤文件类型
            fd.ShowReadOnly = true; //设定文件是否只读
            if (fd.ShowDialog() == DialogResult.OK)
            {
                ToastNotification.Show(this, "Importing...", null, 5000);
                string[] strlist = File.ReadAllLines(fd.FileName);
                int js = 0;
                foreach (string str in strlist)
                {
                    string s = str.Trim();
                    if (s != "")
                    {
                        ParseObject word = new ParseObject("words");
                        word["word"] = s;
                        word["translation"] = "";
                        word["username"] = Gib.username;
                        word["group"] = Gib.cur_group;
                        await word.SaveAsync();
                        ++js;
                    }
                }
                if (js > 0)
                {
                    load_words();
                    ToastNotification.Close(this);
                    ToastNotification.Show(this, "Successfully imported " + js + " words", null, 5000);
                }
                else
                {
                    ToastNotification.Close(this);
                    ToastNotification.Show(this, "No words imported", null, 5000, eToastGlowColor.Red);
                }
            }
        }
    }
}