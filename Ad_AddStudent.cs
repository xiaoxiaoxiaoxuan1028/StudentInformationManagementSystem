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
    public partial class Ad_AddStudent : Form
    {
        public Ad_StuManage pform;
        public Ad_AddStudent(Ad_StuManage parent)
        {
            InitializeComponent();
            pform = parent;

            string sql1 = "select distinct sgrade from students";
            if (Ad_StuManage.ExecuteSql(sql1) != 0)
            {
                this.cbox_grade.DataSource = Ad_StuManage.Query(sql1).Tables["students"];
                cbox_grade.DisplayMember = "sgrade";
            }

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string sid = tbox_sid.Text.Trim();
            string sname = tbox_sname.Text.Trim();
            string ssex = cbox_sex.Text;
            string sgrade = cbox_grade.Text;
            string sdept = tbox_major.Text.Trim();
            string syear = cbox_year.Text;
            string sage = tbox_sage.Text.Trim();
            string stime = DateTime.Now.ToString();
            string sql = "insert into students(sid,sname,ssex,sgrade,sdept,syear,sage,stime) values('" + sid + "','" + sname + "','" + ssex + "','" + sgrade + "','" + sdept + "','" + syear + "'," + int.Parse(sage) + ",'" + stime + "')";
            if (Ad_StuManage.ExecuteSql(sql) != 0)//向源数据库传递并执行SQL语句
                MessageBox.Show("添加学生信息成功！");
            this.pform.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void Ad_AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
