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
    public partial class T_ScoreSearch : Form
    {
        public LoginIn_Teacher pform;
        static string tid;
        static int num_xuanke;
        static int num_avg;
        static int num_max;
        static int num_min;

        //从app.config配置文件读取key=connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public T_ScoreSearch(LoginIn_Teacher parent,string id)
        {
            InitializeComponent();
            pform = parent;
            tid = id;
            string sql = "select cid from costea where tid = '" + tid + "'";


            if (ExecuteSql(sql) != 0)
            {
                this.cbox_cid.DataSource = Query(sql).Tables["costea"];
                cbox_cid.DisplayMember = "cid";
            }
        }

        private static int ExecuteSql(string sql)
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


        private void btn_sidsearch_Click(object sender, EventArgs e)
        {
            label_avg.Text = "";
            label_min.Text = "";
            label_num.Text = "";
            label_max.Text = "";
            string sid = tbox_sid.Text.Trim();
            if (sid == "")
            {
                this.info_data.DataSource = Ad_ChooseManage.Query("select * from choices where cid in ( select cid from costea where tid = '" + tid + "')").Tables["choices"];
            }
            else
            {
                this.info_data.DataSource = Ad_ChooseManage.Query("select * from choices where sid = '" + sid + "' and cid in ( select cid from costea where tid = '" + tid + "')").Tables["choices"];
            }
        }

        private void btn_cidsearch_Click(object sender, EventArgs e)
        {
            label_avg.Text = "";
            label_min.Text = "";
            label_num.Text = "";
            label_max.Text = "";
            string cid = cbox_cid.Text.Trim();
            if (cid == "")
            {
                this.info_data.DataSource = Ad_ChooseManage.Query("select * from choices where cid in (select cid from costea where tid = '" + tid + "')").Tables["choices"];
            }
            else
            {
                this.info_data.DataSource = Ad_ChooseManage.Query("select * from choices where cid = '" + cid + "' and '" + cid + "' in ( select cid from costea where tid = '" + tid + "')").Tables["choices"];
                if(this.info_data.RowCount == 0)
                {
                    label_avg.Text = "0";
                    label_min.Text = "0";
                    label_num.Text = "0";
                    label_max.Text = "0";
                }
                statistics_1(cid);
            }
        }

        void statistics_1(string cid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select count(*) c1,avg(cscore) c2,max(cscore) c3,min(cscore) c4 from choices where cid = '" + cid + "' and cid in ( select cid from costea where tid = '" + tid + "') group by cid";
            //DataSet ds = new DataSet();//创建一个数据缓存
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    num_xuanke = reader.GetInt32(reader.GetOrdinal("c1"));
                    num_avg = reader.GetInt32(reader.GetOrdinal("c2"));
                    num_max = reader.GetInt32(reader.GetOrdinal("c3"));
                    num_min = reader.GetInt32(reader.GetOrdinal("c4"));
                    label_num.Text = num_xuanke.ToString();
                    label_avg.Text = num_avg.ToString();
                    label_max.Text = num_max.ToString();
                    label_min.Text = num_min.ToString();
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
                sda.Fill(ds, "costea");
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

        private void T_ScoreSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
