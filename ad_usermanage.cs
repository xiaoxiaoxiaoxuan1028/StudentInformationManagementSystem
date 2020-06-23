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
    public partial class Ad_UserManage : Form
    {
        public LoginIn_Ad pform;
        static int stu_num;
        static int t_num;
        static int a_num;
        static string aid;
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public Ad_UserManage(LoginIn_Ad parent,string id)
        {
            InitializeComponent();
            pform = parent;
            aid = id;
            Initialize_1();
            Initialize_2();
            Initialize_3();
        }

        void Initialize_1()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select count(*) num from students";
            //DataSet ds = new DataSet();//创建一个数据缓存
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    stu_num = reader.GetInt32(reader.GetOrdinal("num"));
                    label_snum.Text = stu_num.ToString();
                }
                else
                {
                    label_snum.Text = "0";
                }
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

        void Initialize_2()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select count(*) num from teachers";
            //DataSet ds = new DataSet();//创建一个数据缓存
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    t_num = reader.GetInt32(reader.GetOrdinal("num"));
                    label_tnum.Text = t_num.ToString();
                }
                else
                {
                    label_tnum.Text = "0";
                }
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

        void Initialize_3()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select count(*) num from admins";
            //DataSet ds = new DataSet();//创建一个数据缓存
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    a_num = reader.GetInt32(reader.GetOrdinal("num"));
                    label_anum.Text = a_num.ToString();
                }
                else
                {
                    label_anum.Text = "0";
                }
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



        private void btn_return_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void btn_addad_Click(object sender, EventArgs e)
        {
            Ad_AddAdmin childrenForm = new Ad_AddAdmin(this);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_pwdreset_Click(object sender, EventArgs e)
        {
            Ad_PwdReset childrenForm = new Ad_PwdReset(this);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_permission_Click(object sender, EventArgs e)
        {
            Ad_UpdateAd childrenForm = new Ad_UpdateAd(this,aid);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        public static int ExecuteSql(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);    //创建一个数据库连接
            SqlCommand cmd = new SqlCommand(sql, con);                      //创建SqlCommand用于对数据库进行操作
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();        //rows接受sql执行后返回的行数
                return rows;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }


        private void Ad_UserManage_Load(object sender, EventArgs e)
        {

        }
    }
}
