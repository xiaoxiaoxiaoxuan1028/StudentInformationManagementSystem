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
    public partial class Ad_UpdateCourse : Form
    {
        public Ad_CourseManage pform;
        string oldcid;

        public Ad_UpdateCourse(Ad_CourseManage parent,string cid,string cname,string cterm,string cpoint,string ctime,string cquality)
        {
            InitializeComponent();
            pform = parent;
            tbox_cid.Text = cid;
            tbox_cname.Text = cname;
            tbox_credit.Text = cpoint;
            cbox_term.Text = cterm;
            tbox_hour.Text = ctime;
            cbox_feature.Text = cquality;
            oldcid = cid.Trim();
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
            string newcid = tbox_cid.Text.Trim();
            string cname = tbox_cname.Text.Trim();
            string cterm = cbox_term.Text;
            string cpoint = tbox_credit.Text.Trim();
            string ctime = tbox_hour.Text.Trim();
            string cquality = cbox_feature.Text;
            string sql = "update courses set cid = '" + newcid + "',cname='" + cname + "',cterm=" + int.Parse(cterm) + ",cpoint=" + int.Parse(cpoint) + ",ctime =" + int.Parse(ctime) + ",cquality ='" + cquality + "' where cid = '" + oldcid + "'";
            if (Ad_CourseManage.ExecuteSql(sql) != 0)
                MessageBox.Show("修改成功！");
            this.pform.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void Ad_UpdateCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
