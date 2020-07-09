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
    public partial class createShop : Form
    {
        public createShop()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string price = textBoxPirce.Text;
            string info = richTextBox.Text;
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;


            string sql = "insert into 商品 (商品名称,上架时间,价格,发布商家,商品简介) values('"+name+"',(select CONVERT(varchar(30),getdate(),120)),"+price+",'"+loginForm.getName()+"','"+info+"')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("发布餐点成功！");

            conn.Close();
        }

        private void kaisheForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
