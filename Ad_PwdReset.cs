using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace database_exp7
{
    public partial class Ad_PwdReset : Form
    {
        public Ad_UserManage pform;

        public Ad_PwdReset(Ad_UserManage parent)
        {
            InitializeComponent();
            pform = parent;
            radioButton1.Checked = true;
        }

        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        private void button1_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (tbox_id.Text.Trim() == "")
                MessageBox.Show("账号不能为空！");
            else
            {
                string id = tbox_id.Text.Trim();
                string sql;
                if (radioButton1.Checked)
                {
                    sql = "update users set upasswd = '123456' where uid = '" + id + "' and ugroup = 3";
                }
                else
                {
                    sql = "update users set upasswd = '123456' where uid = '" + id + "' and ugroup = 2";
                }
                if(Ad_UserManage.ExecuteSql(sql) != 0)
                {
                    MessageBox.Show("密码已恢复默认值！");
                }
                else
                {
                    MessageBox.Show("账号不存在！");
                }

                this.pform.Show();
                this.Close();
            }
        }

        private void Ad_PwdReset_Load(object sender, EventArgs e)
        {

        }
    }
}
