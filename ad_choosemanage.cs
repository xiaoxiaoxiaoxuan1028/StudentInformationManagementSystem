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
    public partial class Ad_ChooseManage : Form
    {
        public LoginIn_Ad pform;
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public Ad_ChooseManage(LoginIn_Ad parent)
        {
            InitializeComponent();
            pform = parent;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Ad_AddRecord childrenForm = new Ad_AddRecord(this);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int cur_row = choose_data.CurrentRow.Index;  //获取当前选中行
            string sid = choose_data.Rows[cur_row].Cells[0].Value.ToString().Trim(); //获取该行第0列
            string cid = choose_data.Rows[cur_row].Cells[1].Value.ToString().Trim(); //获取该行第1列
            string cterm = choose_data.Rows[cur_row].Cells[2].Value.ToString().Trim(); //获取该行第2列
            string csore = choose_data.Rows[cur_row].Cells[3].Value.ToString().Trim(); //获取该行第3列
            string istrue = choose_data.Rows[cur_row].Cells[4].Value.ToString().Trim(); //获取该行第4列
            Ad_UpdateRecord childrenForm = new Ad_UpdateRecord(this,sid,cid,cterm,csore,istrue);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int a = choose_data.CurrentRow.Index;  //获取当前选中行
            string sid = choose_data.Rows[a].Cells[0].Value.ToString().Trim(); //获取该行第0列
            string cid = choose_data.Rows[a].Cells[1].Value.ToString().Trim(); //获取该行第1列
            string sql = "delete from choices where sid = '" + sid + "' and cid = '" + cid + "'";

            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("删除成功!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sid = tbox_sid.Text.Trim();
            string cid = tbox_cid.Text.Trim();
            if (sid == "" && cid.Length != 0)
                this.choose_data.DataSource = Query("select * from choices where cid = '" + cid + "'").Tables["choices"];
            else if(cid == "" && sid.Length != 0)
                this.choose_data.DataSource = Query("select * from choices where sid = '" + sid + "'").Tables["choices"];
            else if(sid=="" && cid.Length==0)
                this.choose_data.DataSource = Query("select * from choices").Tables["choices"];
            else 
                this.choose_data.DataSource = Query("select * from choices where cid = '" + cid + "' and sid = '" + sid + "'").Tables["choices"];
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


        private void Ad_ChooseManage_Load(object sender, EventArgs e)
        {

        }
    }
}
