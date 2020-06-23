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
    public partial class ChangePwd2 : Form
    {
        public ChangePwd1 parent;
        static string id;
        static string connectionString = ConfigurationManager.AppSettings["connectionString"];
        
        public ChangePwd2()
        {
            InitializeComponent();
        }

        public ChangePwd2(ChangePwd1 pform,string uid)
        {
            InitializeComponent();
            parent = pform;
            id = uid;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            string pwd1 = tbox_newpwd1.Text.Trim();
            string pwd2 = tbox_newpwd2.Text.Trim();
            if (pwd1 == "")
            {
                MessageBox.Show("新密码不能为空！");
                tbox_newpwd2.Text = "";
            }
            else if (pwd2 == "")
            {
                MessageBox.Show("请再次输入密码！");
                tbox_newpwd1.Text = "";
            }
            else if (string.Compare(pwd1, pwd2) != 0)
            {
                MessageBox.Show("两次输入密码不一致！");
                tbox_newpwd1.Text = "";
                tbox_newpwd2.Text = "";
            }
            else
            {
                string sql = "update users set upasswd = '" + pwd1 + "' where uid = '" + id+"'";
                SqlConnection con = new SqlConnection(connectionString);//创建一个数据库连接
                SqlCommand cmd = new SqlCommand(sql, con);//创建一个SqlCommand，用于对数据库进行操作
                try
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();//rows接受sql执行后返回的行数
                    if (rows == 0)
                        MessageBox.Show("修改失败！");
                    else
                        MessageBox.Show("修改成功！");
                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message + "\n修改失败");
                    throw new Exception(err.Message);
                }
                finally
                {
                    cmd.Dispose();//对SqlCommand进行处理，回收
                    con.Close();//连接关闭
                }
                this.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.parent.Close();
        }

        private void ChangePwd2_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_next;
            tbox_newpwd1.UseSystemPasswordChar = true;
            tbox_newpwd2.UseSystemPasswordChar = true;
        }
    }
}
