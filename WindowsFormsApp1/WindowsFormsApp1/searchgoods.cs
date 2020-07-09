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
    public partial class searchgoods : Form
    {
        public searchgoods()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.DataSource = null;
            }
            if (comboBoxterm.Text == "" && textBoxclass.Text == "")
            {
                MessageBox.Show("请输入查询信息！");
            }
            else if (comboBoxterm.Text != "" && textBoxclass.Text == "")
            {
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                string sql = "select 商品编号 as 餐点编号,商品名称 as 餐点名称,上架时间,价格,发布商家 from 商品,商家 where 商家.商家账号=商品.发布商家 and 商家.店铺地址 like '%" + comboBoxterm.SelectedItem.ToString() + "%'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
            else if (textBoxclass.Text != "" && comboBoxterm.Text == "")
            {

                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                //textBox1.Text.Trim()  textBox2.Text.Trim()
                string sql = "select 商品编号 as 餐点编号,商品名称 as 餐点名称, 上架时间, 价格, 发布商家 from 商品, 商家 where 商家.商家账号 = 商品.发布商家 and 商品.商品名称 like '%" + textBoxclass.Text + "%'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();


            }
            else if (textBoxclass.Text != "" && comboBoxterm.Text != "")
            {

                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                //textBox1.Text.Trim()  textBox2.Text.Trim()
                string sql = "select 商品编号 as 餐点编号,商品名称 as 餐点名称, 上架时间, 价格, 发布商家 from 商品, 商家 where 商家.商家账号 = 商品.发布商家 and 商品.商品名称 like '%" + textBoxclass.Text + "%'and 商家.店铺地址 like '%" + comboBoxterm.SelectedItem.ToString() + "%'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();

            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                //textBox1.Text.Trim()  textBox2.Text.Trim()
                string sql = "select 商品简介 from 商品 where 商品编号 = '" + id+ "'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    richTextBox1.Text = dr[0].ToString();
                }
                dr.Close();
                conn.Close();
            }
        }

        private void searchgoods_Load(object sender, EventArgs e)
        {

        }
    }
}
