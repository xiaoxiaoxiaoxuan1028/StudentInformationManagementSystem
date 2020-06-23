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
    public partial class LoginIn_Teacher : Form
    {
        static string id;
        static string tname;
        static string tsex;
        static string tdept;
        static string title;
        static int tsalary;
        static string temail;
        static string ttel;
        static string ltime;
        static string time;

        //从app.config配置文件读取key=connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public LoginIn_Teacher()
        {
            InitializeComponent();
        }

        public LoginIn_Teacher(string tid,string ttime)
        {
            InitializeComponent();
            id = tid;
            time = ttime;
            label_tid.Text = id;
            Initialize_1();
            Initialize_2();
        }

        void Initialize_1()
        {

            SqlConnection con = new SqlConnection(connectionString);//创建一个数据库连接
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from teachers where tid= '" + id + "'";
            //SqlDataAdapter sda = new SqlDataAdapter(sql, con);//创建DataSet和SQL Server之间的桥接器，用于对数据库进行操作
            //DataSet ds = new DataSet();//创建一个数据集（数据缓存）
            try
            {
                con.Open();//打开连接
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tname = reader.GetString(reader.GetOrdinal("tname"));
                    tsex = reader.GetString(reader.GetOrdinal("tsex"));
                    tdept = reader.GetString(reader.GetOrdinal("tdept"));
                    title = reader.GetString(reader.GetOrdinal("title"));
                    tsalary = reader.GetInt32(reader.GetOrdinal("tsalary"));
                    temail = reader.GetString(reader.GetOrdinal("temail"));
                    ttel = reader.GetString(reader.GetOrdinal("ttel"));
                    ltime = reader.GetString(reader.GetOrdinal("ttime"));
                    label_tname.Text = tname;
                    label_sex.Text = tsex;
                    label_dep.Text = tdept;
                    label_title.Text = title;
                    label_salary.Text = tsalary.ToString();
                    label_email.Text = temail;
                    label_tel.Text = ttel;
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
            string sql_cmd = "update teachers set ttime = '" + time + "' where tid = '" + id + "'";
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

        private void btn_score_search_Click(object sender, EventArgs e)
        {
            T_ScoreSearch childrenForm = new T_ScoreSearch(this,id);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_scoreinput_Click(object sender, EventArgs e)
        {
            T_ScoreInput childrenForm = new T_ScoreInput(this,id);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_info_search_Click(object sender, EventArgs e)
        {
            T_StuSearch childrenForm = new T_StuSearch(this);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginIn_Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
