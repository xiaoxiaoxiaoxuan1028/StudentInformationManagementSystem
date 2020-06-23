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
    public partial class Ad_UpdateStudent : Form
    {
        public Ad_StuManage pform;
        static string oldsid;
        public Ad_UpdateStudent(Ad_StuManage parent,string sid,string sname,string ssex,string sgrade,string sdept,string syear,string sage)
        {
            InitializeComponent();
            pform = parent;
            tbox_sid.Text = sid;
            tbox_sname.Text = sname;
            cbox_sex.Text = ssex;
            cbox_grade.Text = sgrade;
            tbox_major.Text = sdept;
            cbox_year.Text = syear;
            tbox_sage.Text = sage;
            oldsid = sid;

            string sql1 = "select distinct sgrade from students";
            if (Ad_StuManage.ExecuteSql(sql1) != 0)
            {
                this.cbox_grade.DataSource = Ad_StuManage.Query(sql1).Tables["students"];
                cbox_grade.DisplayMember = "sgrade";
            }

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string newsid = tbox_sid.Text.Trim();
            string sname = tbox_sname.Text.Trim();
            string ssex = cbox_sex.Text;
            string sgrade = cbox_grade.Text;
            string sdept = tbox_major.Text.Trim();
            string syear = cbox_year.Text;
            string sage = tbox_sage.Text.Trim();
            string sql = "update students set sid = '" + newsid + "',sname='" + sname + "',ssex='" + ssex + "',sgrade='" + sgrade + "',sdept='" + sdept + "',syear='" + syear + "',sage=" + int.Parse(sage) + " where sid = '" + oldsid + "'";
            if (Ad_StuManage.ExecuteSql(sql) != 0)
                MessageBox.Show("修改成功！");

            this.pform.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void Ad_UpdateStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
