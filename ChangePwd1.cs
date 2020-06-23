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
    public partial class ChangePwd1 : Form
    {
        static string connectionString = ConfigurationManager.AppSettings["connectionString"];
        static string id;

        public ChangePwd1()
        {
            InitializeComponent();
        }

        public ChangePwd1(string uid)
        {
            InitializeComponent();
            id = uid;
        }

        private void changepwd1_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            string oldpwd = tbox_pwd.Text.Trim();
            SqlConnection con = new SqlConnection(connectionString);//创建一个数据库连接
            string sql = "select * from users where uid=" + id + " and upasswd='" + oldpwd+"'";
            SqlCommand cmd = new SqlCommand(sql, con);//创建一个SqlCommand，用于对数据库进行操作
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //tbox_pwd.Text = reader.ToString();
                if (!reader.Read())
                {
                    MessageBox.Show("密码输入错误，请重试！");
                    tbox_pwd.Text = "";
                }
                else
                {
                    ChangePwd2 childrenForm = new ChangePwd2(this, id);
                    childrenForm.Owner = this;
                    this.Hide();
                    childrenForm.Show();
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
            
            finally
            {
                cmd.Dispose();//cmd处理，以便空间回收
                con.Close();//连接关闭
            }
            
        }


        private void ChangePwd1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_next;
            tbox_pwd.UseSystemPasswordChar = true;
        }

        private void check_fix_CheckedChanged(object sender, EventArgs e)
        {
            tbox_pwd.UseSystemPasswordChar = false;
        }
    }



}
