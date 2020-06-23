using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_exp7
{
    public partial class Ad_UpdateAd2 : Form
    {
        static string oldaid;
        public Ad_UpdateAd pform;
        public Ad_UpdateAd2(Ad_UpdateAd parent,string aid,string aname,string asex)
        {
            InitializeComponent();
            pform = parent;
            tbox_aid.Text = aid;
            tbox_aname.Text = aname;
            cbox_asex.Text = asex;
            oldaid = aid;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string newaid = tbox_aid.Text.Trim();
            string aname = tbox_aname.Text.Trim();
            string asex = cbox_asex.Text;
            string sql = "update admins set aid = '" + newaid + "',aname = '" + aname + "',asex = '" + asex + "' where aid = '" + oldaid + "'";
            if (Ad_UserManage.ExecuteSql(sql) != 0)
                MessageBox.Show("修改成功！");
            this.pform.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.pform.Show();
            this.Close();
        }

        private void Ad_UpdateAd2_Load(object sender, EventArgs e)
        {

        }
    }
}
