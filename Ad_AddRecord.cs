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
    public partial class Ad_AddRecord : Form
    {
        public Ad_ChooseManage pform;
        public Ad_AddRecord(Ad_ChooseManage parent)
        {
            InitializeComponent();
            pform = parent;

            string sql1 = "select distinct cterm from choices";
            if (Ad_ChooseManage.ExecuteSql(sql1) != 0)
            {
                this.cbox_term.DataSource = Ad_ChooseManage.Query(sql1).Tables["choices"];
                cbox_term.DisplayMember = "cterm";
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string sid = tbox_sid.Text.Trim();
            string cid = tbox_cid.Text.Trim();
            string cterm = cbox_term.Text;
            string cscore = tbox_score.Text.Trim();
            string istrue = cbox_repeat.Text;
            string sql = "insert into choices(sid,cid,cterm,cscore,istrue) values('" + sid + "','" + cid + "'," + int.Parse(cterm) + "," + int.Parse(cscore) + ",'" + istrue + "')";
            if (Ad_ChooseManage.ExecuteSql(sql) != 0)//向源数据库传递并执行SQL语句
                MessageBox.Show("选课信息添加成功！");
            this.pform.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void Ad_AddRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
