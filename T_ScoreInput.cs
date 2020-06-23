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
    public partial class T_ScoreInput : Form
    {
        public LoginIn_Teacher pform;
        static string tid;

        //从app.config配置文件读取key=connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public T_ScoreInput(LoginIn_Teacher parent,string id)
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

        private void btn_next_Click(object sender, EventArgs e)
        {
            string cid = cbox_cid.Text;
            string sid = tbox_sid.Text.Trim();
            string score = tbox_score.Text.Trim();

            string sql = "update choices set cscore = " + int.Parse(score) + " from choices,costea where choices.cid = costea.cid and tid = '" + tid + "' and sid = '" + sid + "' and choices.cid = '" + cid + "'";
            if (ExecuteSql(sql) != 0)
            {
                MessageBox.Show("录入成功！");
                tbox_score.Text = "";
                tbox_sid.Text = "";
                if (check_fix.Checked == false)
                {
                    cbox_cid.Text = "";
                }
            }
            else
            {
                MessageBox.Show("录入失败：该生没有选修这门课！");
                tbox_score.Text = "";
                tbox_sid.Text = "";
                if (check_fix.Checked == false)
                {
                    cbox_cid.Text = "";
                }
            }

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void T_ScoreInput_Load(object sender, EventArgs e)
        {

        }
    }
}
