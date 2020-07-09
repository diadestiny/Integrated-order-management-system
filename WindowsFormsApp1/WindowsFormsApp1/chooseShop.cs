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
    public partial class chooseShop : Form
    {
        public chooseShop()
        {
            InitializeComponent();
        }
        private void chooseForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = loginForm.getName();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string kehuid = textBox1.Text;
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();

            if(textBoxAddR.Text==""||textBox1.Text==""||textBoxid.Text=="")
            {
                MessageBox.Show("信息不完整，点餐失败");
            }
            else
            {
                string sql = "insert into 订单(送达地址, 下单时间, 客户账号, 商品编号) values('" + textBoxAddR.Text + "', (select CONVERT(varchar(30), getdate(), 120)),'" + textBox1.Text + "'," + textBoxid.Text + ")";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandText = sql;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("点餐成功");

                }

               
            }
            if (listBox1.Items.Count > 0)
            {//清空所有项
                listBox1.Items.Clear();
            }
            string sql2 = "select 订单编号,商品名称,下单时间 from 订单,商品 where 订单.商品编号=商品.商品编号 and 客户账号='" + textBox1.Text + "'";
            SqlDataAdapter adp2 = new SqlDataAdapter(sql2, conn);
            DataSet ds2 = new DataSet();
            adp2.Fill(ds2);
            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                listBox1.Items.Add(row[0].ToString() + " " + row[1].ToString() + " " + row[2].ToString());
                listBox1.Items.Add("");
            }

            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.DataSource = null;
            }

            string sql = "select 商品编号 as 餐点编号,商品名称 as 餐点名称, 上架时间, 价格, 发布商家 from 商品, 商家 where 商家.商家账号 = 商品.发布商家 and 商家.店铺地址 like '%" + comboBox1.SelectedItem.ToString() + "%'";
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mos_click(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxcName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            string sql = "delete from 订单 where 订单编号 = " + (listBox1.SelectedItem.ToString()).Split(' ')[0] ;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandText = sql;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("删除成功！");
                if (listBox1.Items.Count > 0)
                {//清空所有项
                    listBox1.Items.Clear();
                }
                string sql2 = "select 订单编号,商品名称,下单时间 from 订单,商品 where 订单.商品编号=商品.商品编号 and 客户账号='" + textBox1.Text + "'";
                SqlDataAdapter adp2 = new SqlDataAdapter(sql2, conn);
                DataSet ds2 = new DataSet();
                adp2.Fill(ds2);
                foreach (DataRow row in ds2.Tables[0].Rows)
                {
                    listBox1.Items.Add(row[0].ToString()+" "+row[1].ToString()+" " +row[2].ToString());
                    listBox1.Items.Add("");
                }

            }
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}
