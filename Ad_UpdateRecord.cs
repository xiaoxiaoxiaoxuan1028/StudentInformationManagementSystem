using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_exp7
{
    public partial class Ad_UpdateRecord : Form
    {
        public Ad_ChooseManage pform;
        static string oldsid;
        static string oldcid;
        public Ad_UpdateRecord(Ad_ChooseManage parent,string sid,string cid,string cterm,string csore,string istrue)
        {
            InitializeComponent();
            pform = parent;
            tbox_sid.Text = sid;
            tbox_cid.Text = cid;
            cbox_term.Text = cterm;
            tbox_score.Text = csore;
            cbox_repeat.Text = istrue;
            oldsid = sid;
            oldcid = cid;

            string sql1 = "select distinct cterm from choices";
            if (Ad_ChooseManage.ExecuteSql(sql1) != 0)
            {
                this.cbox_term.DataSource = Ad_ChooseManage.Query(sql1).Tables["choices"];
                cbox_term.DisplayMember = "cterm";
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string newsid = tbox_sid.Text.Trim();
            string newcid = tbox_cid.Text.Trim();
            string cterm = cbox_term.Text;
            string cscore = tbox_score.Text.Trim();
            string istrue = cbox_repeat.Text;
            string sql = "update choices set sid = '" + newsid + "',cid='" + newcid + "',cterm=" + int.Parse(cterm) + ",cscore=" + int.Parse(cscore) + ",istrue='" + istrue + "' where sid = '" + oldsid + "' and cid = '" + oldcid + "'";
            if (Ad_ChooseManage.ExecuteSql(sql) != 0)
                MessageBox.Show("修改成功！");
            this.pform.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void Ad_UpdateRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
