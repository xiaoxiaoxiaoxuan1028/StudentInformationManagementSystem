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
    public partial class Ad_AddCourse : Form
    {
        public Ad_CourseManage pform;
        public Ad_AddCourse(Ad_CourseManage parent)
        {
            InitializeComponent();
            pform = parent;
            string sql = "select distinct cquality from courses";

            if (Ad_CourseManage.ExecuteSql(sql) != 0)
            {
                this.cbox_feature.DataSource = Ad_CourseManage.Query(sql).Tables["courses"];
                cbox_feature.DisplayMember = "cquality";
            }

            string sql1 = "select distinct cterm from courses";
            if (Ad_CourseManage.ExecuteSql(sql) != 0)
            {
                this.cbox_term.DataSource = Ad_CourseManage.Query(sql1).Tables["courses"];
                cbox_term.DisplayMember = "cterm";
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string cid = tbox_cid.Text.Trim();
            string cname = tbox_cname.Text.Trim();
            string cpoint = tbox_credit.Text.Trim();
            string cterm = cbox_term.Text;
            string cquality = cbox_feature.Text;
            string ctime = tbox_hour.Text.Trim();
            //SQL添加数据语句字符串
            string sql = "insert into courses(cid,cname,cterm,cpoint,ctime,cquality) values('" + cid + "','" + cname + "'," + int.Parse(cterm) + "," + int.Parse(cpoint) + "," + int.Parse(ctime) + ",'" + cquality + "')";
            if (Ad_CourseManage.ExecuteSql(sql) != 0)//向源数据库传递并执行SQL语句
                MessageBox.Show("添加课程信息成功！");
            this.pform.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void Ad_AddCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
