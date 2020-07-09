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
    public partial class myshop : Form
    {
        public myshop()
        {
            InitializeComponent();

            string sql = "select 商品.商品编号,商品名称,上架时间,价格 from 商品 where 发布商家 = '"+loginForm.getName()+"'";
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            sql = " select 商品名称,count(*)销售量 from 订单,商品 where 商品.发布商家='"+loginForm.getName()+"'and 订单.商品编号 = 商品.商品编号 group by 商品.商品名称";
            adp1 = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            adp1.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string sql = "update 商品 set 商品名称 = '" + textName.Text + "',上架时间= '" + textTime.Text + "',价格= " + textPrice.Text + ",商品简介= '" + richTextBox.Text + " 'where 商品编号 = '" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("修改信息成功！");

            sql = "select 商品.商品编号,商品名称,上架时间,价格 from 商品 where 发布商家 = '" + loginForm.getName() + "'";
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

        private void mos_click(object sender, DataGridViewCellMouseEventArgs e)
        {
            textName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textTime.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textPrice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            //textBox1.Text.Trim()  textBox2.Text.Trim()
            string sql = "select 商品简介 from 商品 where 商品编号 = '" + id + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                richTextBox.Text = dr[0].ToString();
            }
            dr.Close();
            conn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            string sql = "delete from 商品 where 商品编号 = " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("删除商品成功！");

            sql = "select 商品.商品编号,商品名称,上架时间,价格 from 商品 where 发布商家 = '" + loginForm.getName() + "'";
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }


    }
}
