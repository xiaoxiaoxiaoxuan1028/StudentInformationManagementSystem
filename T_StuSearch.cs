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

namespace database_exp7
{
    public partial class T_StuSearch : Form
    {
        public LoginIn_Teacher pform;

        //从app.config配置文件读取key=connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public T_StuSearch(LoginIn_Teacher parent)
        {
            InitializeComponent();
            pform = parent;

        }

        private void btn_sidsearch_Click(object sender, EventArgs e)
        {
            string sid = tbox_sid.Text.Trim();
            if (sid == "")
            {
                this.info_data.DataSource = Query("select sid,sname,ssex,sage,sgrade,sdept,syear from students").Tables["students"];
            }
            else
            {
                this.info_data.DataSource = Query("select sid,sname,ssex,sage,sgrade,sdept,syear from students where sid = '" + sid + "'").Tables["students"];
            }
            label_num.Text = this.info_data.RowCount.ToString();
        }

        private void btn_cidsearch_Click(object sender, EventArgs e)
        {
            string cid = tbox_cid.Text.Trim();
            if (cid == "")
            {
                this.info_data.DataSource = Query("select sid,sname,ssex,sage,sgrade,sdept,syear from students").Tables["students"];
            }
            else
            {
                this.info_data.DataSource = Query("select students.sid,sname,ssex,sage,sgrade,sdept,syear from students,choices where students.sid=choices.sid and cid = '" + cid + "'").Tables["students"];
            }
            label_num.Text = this.info_data.RowCount.ToString();
        }

        public static DataSet Query(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);    //创建数据库链接
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);          //创建DataSet和SQL Server之间的桥接器，用于对数据库进行操作
            DataSet ds = new DataSet();                                 //创建一个数据集
            try
            {
                con.Open();                 //打开连接
                sda.Fill(ds, "students");
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

        private void T_StuSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
