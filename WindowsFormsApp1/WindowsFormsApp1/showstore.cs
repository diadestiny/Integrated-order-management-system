using System;

using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class showstore : Form
    {
        public showstore()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            string sql="";
            if (comboBox1.Text == "全部")
            {
                 sql = "select 商家账号,店铺名称,店铺地址,联系电话,出售餐点数量 from 商家,(select count(*) as 出售餐点数量 ,发布商家 from 商品 group by 发布商家) as shopdetail where 商家账号 = shopdetail.发布商家 ";
            }
            else {
                string term = comboBox1.SelectedItem.ToString();
                sql = "select 商家账号,店铺名称,店铺地址,联系电话,出售餐点数量 from 商家,(select count(*) as 出售餐点数量 ,发布商家 from 商品 group by 发布商家) as shopdetail where 商家账号 = shopdetail.发布商家 and 店铺地址 like '%" + term + "%'";
            }
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();


        }
    }
}
