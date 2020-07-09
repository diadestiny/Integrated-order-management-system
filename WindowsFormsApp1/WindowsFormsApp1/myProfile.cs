using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class myProfile : Form
    {

        public myProfile()
        {
            InitializeComponent();
            textBox1.Text = loginForm.getName();

            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            string sql = "select 客户姓名,性别,居住地,手机号码 from 客户 where 客户账号 = '" + textBox1.Text + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textName.Text = dr[0].ToString();
                textSex.Text = dr[1].ToString();
                textADDR.Text = dr[2].ToString();
                textTel.Text = dr[3].ToString();
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
                string sql = "update 客户 set 客户姓名 = '" + textName.Text + "',性别= '" + textSex.Text + "',居住地='" + textADDR.Text + "',手机号码= " + textTel.Text + " where 客户账号 = '" + textBox1.Text + "'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改信息成功！");

                sql = "select 客户姓名,性别,居住地,手机号码 from 客户 where 客户账号 = '" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    textName.Text = dr[0].ToString();
                    textSex.Text = dr[1].ToString();
                    textADDR.Text = dr[2].ToString();
                    textTel.Text = dr[3].ToString();
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
