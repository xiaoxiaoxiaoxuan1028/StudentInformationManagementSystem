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
    public partial class Ad_AddAdmin : Form
    {
        public Ad_UserManage pform;
        public Ad_AddAdmin(Ad_UserManage parent)
        {
            InitializeComponent();
            pform = parent;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string aid = tbox_id.Text.Trim();
            string aname = tbox_name.Text.Trim();
            string asex = "男";
            string pwd = tbox_pwd.Text.Trim();
            string atime = DateTime.Now.ToString();
            string sql = "insert into admins(aid,aname,asex,atime) values('" + aid + "','" + aname + "','" + asex + "','" + atime + "')";
            if(string.Compare(pwd,"123456") != 0)
            {
                string sql1 = "update users set upasswd = '" + pwd + "' where uid = '" + aid + "'";
                if (Ad_UserManage.ExecuteSql(sql) != 0 && Ad_UserManage.ExecuteSql(sql1) != 0)//向源数据库传递并执行SQL语句
                    MessageBox.Show("添加管理员信息成功！");
            }
            else
            {
                if (Ad_UserManage.ExecuteSql(sql) != 0)//向源数据库传递并执行SQL语句
                    MessageBox.Show("添加管理员信息成功！");
            }
            this.pform.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void Ad_AddAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbox_pwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
