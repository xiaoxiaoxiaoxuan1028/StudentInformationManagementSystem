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
    public partial class Ad_AddTeacher : Form
    {
        public Ad_TeacherManage pform;
        public Ad_AddTeacher(Ad_TeacherManage parent)
        {
            InitializeComponent();
            pform = parent;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string tid = tbox_tid.Text.Trim();
            string tname = tbox_tname.Text.Trim();
            string tsex = cbox_sex.Text;
            string tdept = tbox_dep.Text.Trim();
            string title = tbox_title.Text.Trim();
            string tsalary = tbox_salary.Text.Trim();
            string temail = tbox_email.Text.Trim();
            string ttel = tbox_tel.Text.Trim();
            string ttime = DateTime.Now.ToString();
            string sql = "insert into teachers(tid,tname,tsex,tdept,title,tsalary,temail,ttel,ttime) values('" + tid + "','" + tname + "','" + tsex + "','" + tdept + "','" + title + "'," + int.Parse(tsalary) + ",'" + temail + "','" + ttel + "','" + ttime + "')";
            if (Ad_TeacherManage.ExecuteSql(sql) != 0)//向源数据库传递并执行SQL语句
                MessageBox.Show("添加教师信息成功！");
            this.pform.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void Ad_AddTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
