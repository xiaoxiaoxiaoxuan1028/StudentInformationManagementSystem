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
    public partial class Ad_TeacherManage : Form
    {
        public LoginIn_Ad pform;
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public Ad_TeacherManage(LoginIn_Ad parent)
        {
            InitializeComponent();
            pform = parent;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void tbox_tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Ad_AddTeacher childrenForm = new Ad_AddTeacher(this);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int cur_row = t_data.CurrentRow.Index;  //获取当前选中行
            string tid = t_data.Rows[cur_row].Cells[0].Value.ToString().Trim(); //获取该行第0列
            string tname = t_data.Rows[cur_row].Cells[1].Value.ToString().Trim(); //获取该行第1列
            string tsex = t_data.Rows[cur_row].Cells[2].Value.ToString().Trim(); //获取该行第2列
            string tdept = t_data.Rows[cur_row].Cells[3].Value.ToString().Trim(); //获取该行第3列
            string title = t_data.Rows[cur_row].Cells[4].Value.ToString().Trim(); //获取该行第4列
            string tsalary = t_data.Rows[cur_row].Cells[5].Value.ToString().Trim(); //获取该行第5列
            string temail = t_data.Rows[cur_row].Cells[6].Value.ToString().Trim(); //获取该行第6列
            string ttel = t_data.Rows[cur_row].Cells[7].Value.ToString().Trim(); //获取该行第7列
            Ad_UpdateTeacher childrenForm = new Ad_UpdateTeacher(this,tid,tname,tsex,tdept,title,tsalary,temail,ttel);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int a = t_data.CurrentRow.Index;  //获取当前选中行
            string tid = t_data.Rows[a].Cells[0].Value.ToString().Trim(); //获取该行第0列
            string sql = "delete from teachers where tid = '" + tid + "'";

            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("删除成功!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string tid = tbox_tid.Text.Trim();
            if (tid == "")
                this.t_data.DataSource = Query("select tid,tname,tsex,tdept,title,tsalary,temail,ttel from teachers ").Tables["teachers"];
            else
                this.t_data.DataSource = Query("select tid,tname,tsex,tdept,title,tsalary,temail,ttel from teachers where tid = '" + tid + "'").Tables["teachers"];

        }

        public static DataSet Query(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);    //创建数据库链接
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);          //创建DataSet和SQL Server之间的桥接器，用于对数据库进行操作
            DataSet ds = new DataSet();                                 //创建一个数据集
            try
            {
                con.Open();                 //打开连接
                sda.Fill(ds, "teachers");
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
        //增删改
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

        private void Ad_TeacherManage_Load(object sender, EventArgs e)
        {

        }
    }
}
