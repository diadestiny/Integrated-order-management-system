using System;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class registerShop : Form
    {
        public registerShop()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string passwd = textBox2.Text;
            string quepasswd = textBox3.Text;
            string location = textBox5.Text;
            string telnum = textBox6.Text;
            string name = textBox7.Text;
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            if (passwd == "" || quepasswd == "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                if (quepasswd != passwd)
                {
                    MessageBox.Show("两次输入的密码不一致!");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    string sql = "insert into 商家(商家账号,登录密码,店铺名称,店铺地址,联系电话) values('" + id + "','" + passwd + "','" + name +  "','" + location + "','" + telnum + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("注册成功！");
                }
                conn.Close();
            }

        }
    }
}
