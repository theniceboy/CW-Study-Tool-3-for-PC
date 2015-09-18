using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Parse;

namespace CW_Study_Tool_3_for_PC
{
    public partial class FrmNewWord : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmNewWord()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            string tword = tbWord.Text.Trim();
            if (tword != "")
            {
                var query =
                    ParseObject.GetQuery("words")
                        .WhereEqualTo("username", Gib.username)
                        .WhereEqualTo("group", Gib.cur_group)
                        .WhereEqualTo("word", tword);
                IEnumerable<ParseObject> wordlist = await query.FindAsync();
                if (wordlist.Count() == 0)
                {
                    ParseObject word = new ParseObject("words");
                    word["word"] = tword;
                    word["translation"] = tbTranslation.Text;
                    word["username"] = Gib.username;
                    word["group"] = Gib.cur_group;
                    await word.SaveAsync();
                    ToastNotification.Close(this);
                    ToastNotification.Show(this, "New word added", null, 1000);
                    btnClear_Click(sender, e);
                }
                else
                {
                    ToastNotification.Close(this);
                    ToastNotification.Show(this, "The word \"" + tword + "\" already exists", null, 2000,
                        eToastGlowColor.Red);
                }
            }
            else
            {
                ToastNotification.Close(this);
                ToastNotification.Show(this, "New word cannot be empty", null, 1000, eToastGlowColor.Red);
            }
            this.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbWord.Text = tbTranslation.Text = "";
        }

        private void FrmNewWord_Load(object sender, EventArgs e)
        {

        }

        private void FrmNewWord_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmManage frm = (FrmManage) this.Owner;
            frm.load_words();
        }
    }
}