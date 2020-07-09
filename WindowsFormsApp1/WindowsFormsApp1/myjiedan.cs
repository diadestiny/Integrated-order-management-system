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

namespace WindowsFormsApp1
{
    public partial class myjiedan : Form
    {
        public myjiedan()
        {
            InitializeComponent();
        }
        private void showkebiaoForm_Load(object sender, EventArgs e)
        {
            //首先得到用户
            string name = loginForm.getName();
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            string sql = "select 订单编号,商品名称,送达地址,下单时间,客户.客户账号,手机号码 as 客户手机号 from 订单,商品,客户 where 发布商家='" + name + "'and 订单.商品编号=商品.商品编号 and 订单.客户账号=客户.客户账号";
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
