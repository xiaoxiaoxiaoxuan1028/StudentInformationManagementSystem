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
    public partial class Stu_Search : Form
    {
        public LoginIn_Stu pform;
        static string sid;
        static int sum_point;
        static double sum_gpa = 0;
        static double gpa;
        static int sum_course;

        //从app.config配置文件读取key=connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public Stu_Search(LoginIn_Stu parent,string id)
        {
            InitializeComponent();
            pform = parent;
            sid = id;
            string sql = "select distinct cid from choices where sid = '" + sid + "'";


            if (Ad_ChooseManage.ExecuteSql(sql) != 0)
            {
                this.cbox_cid.DataSource = Ad_ChooseManage.Query(sql).Tables["choices"];
                cbox_cid.DisplayMember = "cid";
            }

            string sql1 = "select distinct cterm from choices where sid = '" + sid + "'";


            if (Ad_ChooseManage.ExecuteSql(sql1) != 0)
            {
                this.cbox_term.DataSource = Ad_ChooseManage.Query(sql1).Tables["choices"];
                cbox_term.DisplayMember = "cterm";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public double GPAtest(int score)
        {
            double gpa_0;
            if (score >= 90)
                gpa_0 = 4.0;
            else if (score >= 85)
                gpa_0 = 3.7;
            else if (score >= 81)
                gpa_0 = 3.3;
            else if (score >= 78)
                gpa_0 = 3.0;
            else if (score >= 75)
                gpa_0 = 2.7;
            else if (score >= 72)
                gpa_0 = 2.3;
            else if (score >= 68)
                gpa_0 = 2.0;
            else if (score >= 64)
                gpa_0 = 1.7;
            else if (score >= 60)
                gpa_0 = 1.0;
            else
                gpa_0 = 0;
            return gpa_0;
        }

        private void btn_termsearch_Click(object sender, EventArgs e)
        {
            label_credit.Text = "";
            label_gpa.Text = "";
            label_fail.Text = "";
            sum_gpa = 0;
            string cterm = this.cbox_term.Text;
            if (cterm == "")
            {
                this.course_data.DataSource = Query("select * from choices where sid = '" + sid + "'").Tables["choices"];
            }
            else
            {
                this.course_data.DataSource = Query("select * from choices where sid = '" + sid + "' and cterm = " + int.Parse(cterm)).Tables["choices"];
            }
            int temp_count = this.course_data.RowCount - 1;
            if(temp_count == 0)
            {
                label_gpa.Text = "0.0000";
            }
            for (int i = 0; i < this.course_data.RowCount - 1; i++)
            {
                if (this.course_data.Rows[i].Cells[3].Value.ToString() == "")
                {
                    temp_count--;
                }
                else
                {
                    sum_gpa = sum_gpa + GPAtest(int.Parse(this.course_data.Rows[i].Cells[3].Value.ToString().Trim()));
                }
                gpa = (sum_gpa / (double)temp_count);
                label_gpa.Text = gpa.ToString("0.0000");
            }
            statistics_1(cterm,"");
            statistics_2(cterm,"");
        }

        private void btn_cidsearch_Click(object sender, EventArgs e)
        {
            sum_gpa = 0;
            string cid = cbox_cid.Text;
            if (cid == "")
            {
                this.course_data.DataSource = Query("select * from choices where sid = '" + sid + "'").Tables["choices"];
            }
            else
            {
                this.course_data.DataSource = Query("select * from choices where sid = '" + sid + "' and cid = '" + cid + "'").Tables["choices"];
            }
            int temp_count = this.course_data.RowCount - 1;
            for (int i = 0; i < this.course_data.RowCount - 1; i++)
            {
                if (this.course_data.Rows[i].Cells[3].Value.ToString() == "")
                {
                    temp_count--;
                }
                else
                {
                    sum_gpa = sum_gpa + GPAtest(int.Parse(this.course_data.Rows[i].Cells[3].Value.ToString().Trim()));
                }
                gpa = (sum_gpa / (double)temp_count);
                label_gpa.Text = gpa.ToString("0.0000");
            }
            statistics_1("",cid);
            statistics_2("",cid);

        }

        //算学分
        void statistics_1(string cterm,string cid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            if(cterm == "" && cid == "")
                cmd.CommandText = "select sum(cpoint) s1 from choices,courses where sid = '" + sid + "'and courses.cid=choices.cid and cscore>=60 group by sid";
            else if(cterm.Length != 0 && cid == "")
                cmd.CommandText = "select sum(cpoint) s1 from choices,courses where sid = '" + sid + "' and choices.cterm = " + int.Parse(cterm) + "and cscore>=60 and courses.cid=choices.cid group by sid";
            else if(cterm == "" && cid.Length != 0)
                cmd.CommandText = "select sum(cpoint) s1 from choices,courses where sid = '" + sid + "' and choices.cid = '" + cid + "'and cscore>=60 and courses.cid=choices.cid group by sid";
            //DataSet ds = new DataSet();//创建一个数据缓存
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sum_point = reader.GetInt32(reader.GetOrdinal("s1"));
                    label_credit.Text = sum_point.ToString();
                }
                else
                {
                    label_credit.Text = "0";
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

        //算不合格门数
        void statistics_2(string cterm,string cid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            if (cterm == "" && cid == "")
                cmd.CommandText = "select count(*) c1 from choices where sid = '" + sid + "' and cscore < 60 group by sid";
            else if(cterm.Length != 0 && cid == "")
                cmd.CommandText = "select count(*) c1 from choices where sid = '" + sid + "' and cterm = " + int.Parse(cterm) + " and cscore < 60 group by sid";
            else if(cterm == "" && cid.Length != 0)
                cmd.CommandText = "select count(*) c1 from choices where sid = '" + sid + "' and cid = '" + cid + "' and cscore < 60 group by sid";
            //DataSet ds = new DataSet();//创建一个数据缓存
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sum_course = reader.GetInt32(reader.GetOrdinal("c1"));
                    if (sum_course.ToString() == null)
                        sum_course = 0;
                    label_fail.Text = sum_course.ToString();
                }
                else
                {
                    label_fail.Text = "0";
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



        public static DataSet Query(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);    //创建数据库链接
            
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);          //创建DataSet和SQL Server之间的桥接器，用于对数据库进行操作
            DataSet ds = new DataSet();                                 //创建一个数据集
            try
            {
                con.Open();                 //打开连接
                sda.Fill(ds, "choices");
                return ds;
            }
            
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);     //抛出异常
                return ds;
            }
            finally
            {
                sda.Dispose();      //sda处理，以便空间回收
                con.Close();        //连接关闭
            }
        }


        private void btn_return_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void Stu_Search_Load(object sender, EventArgs e)
        {

        }

      

    }
}
