using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace database_exp7
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
            radioButton_stu.Checked = true; //默认是学生身份登录
        }

        //从app.config配置文件读取key=connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (login_id.Text.Trim() == "")
                MessageBox.Show("登陆名不能为空");
            else if (login_pwd.Text.Trim() == "")
                MessageBox.Show("密码不能为空");
            else
            {
                string id = login_id.Text.Trim();
                string pwd = login_pwd.Text.Trim();
                string sql;
                SqlConnection con = new SqlConnection(connectionString);//创建一个数据库连接
                if (radioButton_ad.Checked) //管理员
                    sql = "select * from users where uid = " + id + " and upasswd = " + pwd + " and ugroup = 1";
                else if (radioButton_t.Checked) //教师
                    sql = "select * from users where uid = " + id + " and upasswd = " + pwd + " and ugroup = 2";
                //else if (radioButton_stu.Checked) //学生
                else
                    sql = "select * from users where uid = " + id + " and upasswd = " + pwd + " and ugroup = 3";

                SqlCommand cmd = new SqlCommand(sql, con);//创建一个SqlCommand，用于对数据库进行操作  
                try
                {
                    con.Open();//打开连接
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("用户名或密码错误，请重试！");
                        login_id.Text = "";
                        login_pwd.Text = "";
                    }
                    else
                    {  
                        string time = DateTime.Now.ToString();
                        if (radioButton_ad.Checked)
                        {
                            LoginIn_Ad childrenForm = new LoginIn_Ad(id,time);
                            childrenForm.Owner = this;
                            this.Hide();
                            childrenForm.Show();
                        }
                        else if (radioButton_stu.Checked)
                        {
                            LoginIn_Stu childrenForm = new LoginIn_Stu(id,time);
                            childrenForm.Owner = this;
                            this.Hide();
                            childrenForm.Show();
                        }
                        else if (radioButton_t.Checked)
                        {
                            LoginIn_Teacher childrenForm = new LoginIn_Teacher(id,time);
                            childrenForm.Owner = this;
                            this.Hide();
                            childrenForm.Show();
                        }
                    }
                }
                catch (SqlException e1)
                {
                    MessageBox.Show(e1.Message);
                }
                finally
                {
                    cmd.Dispose();//cmd处理
                    con.Close();
                }
            }
        }

        private void radioButton_stu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void form_login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_login;
            login_pwd.UseSystemPasswordChar = true;
            this.skinEngine1.SkinFile = "Wave.ssk";
        }
    }
}
