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
    public partial class Ad_UpdateTeacher : Form
    {
        public Ad_TeacherManage pform;
        static string oldtid;
        public Ad_UpdateTeacher(Ad_TeacherManage parent,string tid,string tname,string tsex,string tdept,string title,string tsalary,string temail,string ttel)
        {
            InitializeComponent();
            pform = parent;
            tbox_tid.Text = tid;
            tbox_tname.Text = tname;
            cbox_sex.Text = tsex;
            tbox_dep.Text = tdept;
            tbox_title.Text = title;
            tbox_email.Text = temail;
            tbox_tel.Text = ttel;
            tbox_salary.Text = tsalary;
            oldtid = tid;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string newtid = tbox_tid.Text.Trim();
            string tname = tbox_tname.Text.Trim();
            string tsex = cbox_sex.Text;
            string tdept = tbox_dep.Text.Trim();
            string title = tbox_title.Text.Trim();
            string tsalary = tbox_salary.Text.Trim();
            string temail = tbox_email.Text.Trim();
            string ttel = tbox_email.Text.Trim();
            string sql = "update teachers set tid='" + newtid + "',tname='" + tname + "',tsex='" + tsex + "',tdept='" + tdept + "',title='" + title + "',tsalary=" + int.Parse(tsalary) + ",temail='" + temail + "',ttel='" + ttel + "' where tid = '" + oldtid + "'";
            if (Ad_TeacherManage.ExecuteSql(sql) != 0)
                MessageBox.Show("修改成功！");
            this.pform.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void Ad_UpdateTeacher_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
