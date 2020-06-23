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
    public partial class LoginIn_Stu : Form
    {
        static string id;
        static string sname;
        static string ssex;
        static int sage;
        static string sgrade;
        static string sdept;
        static string syear;
        static string ltime;
        static string time;

        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public LoginIn_Stu()
        {
            InitializeComponent();
        }

        public LoginIn_Stu(string sid,string stime)
        {
            InitializeComponent();
            id = sid;
            time = stime;
            label_sid.Text = id;
            Initialize_1();
            Initialize_2();
        }

        void Initialize_1()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from students where sid = '" + id + "'";
            //DataSet ds = new DataSet();//创建一个数据缓存
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sname = reader.GetString(reader.GetOrdinal("sname"));
                    ssex = reader.GetString(reader.GetOrdinal("ssex"));
                    sage = reader.GetInt32(reader.GetOrdinal("sage"));
                    sgrade = reader.GetString(reader.GetOrdinal("sgrade"));
                    sdept = reader.GetString(reader.GetOrdinal("sdept"));
                    syear = reader.GetString(reader.GetOrdinal("syear"));
                    ltime = reader.GetString(reader.GetOrdinal("stime"));
                    label_sname.Text = sname;
                    label_sex.Text = ssex;
                    label_sage.Text = sage.ToString();
                    label_grade.Text = sgrade;
                    label_major.Text = sdept;
                    label_year.Text = syear;
                    label_lastlogin.Text = ltime;
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
            SqlConnection con = new SqlConnection(connectionString);    //创建一个数据库连接
            string sql_cmd = "update students set stime = '" + time + "' where sid = '" + id + "'";//更新登陆时间
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



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            Stu_Search childrenForm = new Stu_Search(this,id);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_changepwd_Click(object sender, EventArgs e)
        {
            ChangePwd1 childrenForm = new ChangePwd1(id);
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginIn_Stu_Load(object sender, EventArgs e)
        {

        }
    }
}
