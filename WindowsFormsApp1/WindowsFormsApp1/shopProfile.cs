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
    public partial class shopProfile : Form
    {
        public shopProfile()
        {
            InitializeComponent();
            textBox1.Text = loginForm.getName();

            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            string sql = "select 店铺名称,店铺地址,联系电话 from 商家 where 商家账号 = '" + textBox1.Text + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textName.Text = dr[0].ToString();
                textADDR.Text = dr[1].ToString();
                textTel.Text = dr[2].ToString();
            }
            dr.Close();
            conn.Close();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string sql = "update 商家 set 店铺名称 = '" + textName.Text + "',店铺地址= '" + textADDR.Text+ "',联系电话= " + textTel.Text + " where 商家账号 = '" + textBox1.Text + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("修改信息成功！");

            sql = "select 店铺名称,店铺地址,联系电话 from 商家 where 商家账号 = '" + textBox1.Text + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textName.Text = dr[0].ToString();
                textADDR.Text = dr[1].ToString();
                textTel.Text = dr[2].ToString();
            }

            dr.Close();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
