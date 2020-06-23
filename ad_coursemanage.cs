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
    public partial class Ad_CourseManage : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public LoginIn_Ad pform;
        public Ad_CourseManage(LoginIn_Ad parent)
        {
            InitializeComponent();
            pform = parent;
            string sql = "select distinct cterm from courses";

            if (Ad_CourseManage.ExecuteSql(sql) != 0)
            {
                this.cbox_term.DataSource = Ad_CourseManage.Query(sql).Tables["courses"];
                cbox_term.DisplayMember = "cterm";
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Ad_AddCourse childrenForm = new Ad_AddCourse(this);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int cur_row = course_data.CurrentRow.Index;  //获取当前选中行
            string cid = course_data.Rows[cur_row].Cells[0].Value.ToString().Trim(); //获取该行第0列
            string cname = course_data.Rows[cur_row].Cells[1].Value.ToString().Trim(); //获取该行第1列
            string cterm = course_data.Rows[cur_row].Cells[2].Value.ToString().Trim(); //获取该行第2列
            string cpoint = course_data.Rows[cur_row].Cells[3].Value.ToString().Trim(); //获取该行第3列
            string ctime = course_data.Rows[cur_row].Cells[4].Value.ToString().Trim(); //获取该行第4列
            string cquality = course_data.Rows[cur_row].Cells[5].Value.ToString().Trim(); //获取该行第5列
            Ad_UpdateCourse childrenForm = new Ad_UpdateCourse(this,cid,cname,cterm,cpoint,ctime,cquality);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int a = course_data.CurrentRow.Index;  //获取当前选中行
            string cid = course_data.Rows[a].Cells[0].Value.ToString().Trim(); //获取该行第0列
            string sql = "delete from courses where cid = '" + cid + "'";

            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("删除成功!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string term = cbox_term.Text;
            if (cbox_term.SelectedIndex == -1 && cbox_term.Text == "")
                this.course_data.DataSource = Query("select * from courses").Tables["courses"];
            else
                this.course_data.DataSource = Query("select * from courses where cterm = " + int.Parse(term)).Tables["courses"];
        }

        public static DataSet Query(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);    //创建数据库链接
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);          //创建DataSet和SQL Server之间的桥接器，用于对数据库进行操作
            DataSet ds = new DataSet();                                 //创建一个数据集
            try
            {
                con.Open();                 //打开连接
                sda.Fill(ds, "courses");
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

        private void Ad_CourseManage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
