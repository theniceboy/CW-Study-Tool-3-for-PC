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
    public partial class FrmNewGroup : DevComponents.DotNetBar.Metro.MetroForm
    {
        private FrmManage frm;
        public FrmNewGroup()
        {
            InitializeComponent();
        }

        private void FrmNewGroup_Load(object sender, EventArgs e)
        {
            frm = (FrmManage) this.Owner;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            string tgroup = tbNewGroup.Text.Trim();
            if (tgroup != "")
            {
                var query =
                    ParseObject.GetQuery("groups")
                        .WhereEqualTo("username", Gib.username)
                        .WhereEqualTo("name", tgroup);
                IEnumerable<ParseObject> grouplist = await query.FindAsync();
                if (grouplist.Count() == 0)
                {
                    ParseObject group = new ParseObject("groups");
                    group["name"] = tgroup;
                    group["username"] = Gib.username;
                    await group.SaveAsync();
                    ToastNotification.Close(frm);
                    ToastNotification.Show(frm, "New group added", null, 2000);
                    frm.load_groups();
                    this.Close();
                }
                else
                {
                    ToastNotification.Close(this);
                    ToastNotification.Show(this, "The grou \"" + tgroup + "\" already exists", null, 2000,
                        eToastGlowColor.Red);
                }
            }
            else
            {
                ToastNotification.Close(this);
                ToastNotification.Show(this, "New group name cannot be empty", null, 1000, eToastGlowColor.Red);
            }
            this.Enabled = true;
        }
    }
}