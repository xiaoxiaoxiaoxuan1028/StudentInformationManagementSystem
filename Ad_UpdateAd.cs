using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace database_exp7
{
    public partial class Ad_UpdateAd : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        Ad_UserManage pform;
        static string aid;
        public Ad_UpdateAd(Ad_UserManage parent,string id)
        {
            InitializeComponent();
            pform = parent;
            aid = id;
            this.info_ad.DataSource = Query("select aid,aname,asex from admins").Tables["admins"];
        }

        public static DataSet Query(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);    //创建数据库链接
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);          //创建DataSet和SQL Server之间的桥接器，用于对数据库进行操作
            DataSet ds = new DataSet();                                 //创建一个数据集
            try
            {
                con.Open();                 //打开连接
                sda.Fill(ds, "admins");
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


        private void btn_update_Click(object sender, EventArgs e)
        {
            int cur_row = info_ad.CurrentRow.Index;  //获取当前选中行
            string aid_2 = info_ad.Rows[cur_row].Cells[0].Value.ToString().Trim(); //获取该行第0列
            string aname = info_ad.Rows[cur_row].Cells[1].Value.ToString().Trim(); //获取该行第1列
            string asex = info_ad.Rows[cur_row].Cells[2].Value.ToString().Trim(); //获取该行第2列
            Ad_UpdateAd2 childrenForm = new Ad_UpdateAd2(this,aid_2,aname,asex);
            childrenForm.Owner = this;
            this.Hide();
            childrenForm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int a = info_ad.CurrentRow.Index;  //获取当前选中行
            string aid_1 = info_ad.Rows[a].Cells[0].Value.ToString().Trim(); //获取该行第0列
            string sql = "delete from admins where aid = '" + aid_1 + "'";

            if (Ad_UserManage.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("删除成功!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.info_ad.DataSource = Query("select aid,aname,asex from admins").Tables["admins"];
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void Ad_UpdateAd_Load(object sender, EventArgs e)
        {

        }
    }
}
