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
    public partial class registerKehu : Form
    {
        public registerKehu()
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
            string sex = textBox4.Text;
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
                        string sql = "insert into 客户(客户账号,客户姓名,登录密码,性别,居住地,手机号码) values('"+id+"','" + name + "','" + passwd + "','" + sex + "','" + location + "','" + telnum + "')";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("注册成功！");
                }
                conn.Close();
            }

        }
    }
}
