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
    public partial class LoginIn_Ad : Form
    {
        static string connectionString = ConfigurationManager.AppSettings["connectionString"];
        static string id;
        static string name;
        static string ltime;
        static string time;
        public LoginIn_Ad()
        {
            InitializeComponent();
        }

        public LoginIn_Ad(string aid,string atime)
        {
            InitializeComponent();
            id = aid;
            time = atime;
            //  this.adminlist.DataSource = QueryRole("execute sp_AdminLogin").Tables["role"];
            Initialize_1();
            Initialize_2();
        }


        void Initialize_1()
        {
            SqlConnection con = new SqlConnection(connectionString);//创建一个数据库连接
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from admins where aid= '" + id + "'";
            // SqlDataAdapter sda = new SqlDataAdapter(sql_cmd, con);//创建DataSet和SQL Server之间的桥接器，用于对数据库进行操作
            DataSet ds = new DataSet();//创建一个数据集（数据缓存）
            try
            {
                con.Open();//打开连接
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    name = reader.GetString(reader.GetOrdinal("aname"));
                    ltime = reader.GetString(reader.GetOrdinal("atime"));
                    label_aname.Text = name;
                    label_lastlogin.Text = ltime;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);//抛出异常
            }
            finally
            {
                cmd.Dispose();//sda处理，以便空间回收
                con.Close();//连接关闭
            }
        }

        void Initialize_2()
        {
            SqlConnection con = new SqlConnection(connectionString);    //创建一个数据库连接
            string sql_cmd = "update admins set atime = '" + time + "' where aid = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql_cmd, con);                      //创建SqlCommand用于对数据库进行操作
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        private void btn_changepwd_Click(object sender, EventArgs e)
        {
            ChangePwd1 childrenForm = new ChangePwd1(id);
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void ad_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            Ad_CourseManage childrenForm = new Ad_CourseManage(this);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            Ad_TeacherManage childrenForm = new Ad_TeacherManage(this);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_stu_Click(object sender, EventArgs e)
        {
            Ad_StuManage childrenForm = new Ad_StuManage(this);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            Ad_ChooseManage childrenForm = new Ad_ChooseManage(this);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            Ad_UserManage childrenForm = new Ad_UserManage(this,id);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void LoginIn_Ad_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
