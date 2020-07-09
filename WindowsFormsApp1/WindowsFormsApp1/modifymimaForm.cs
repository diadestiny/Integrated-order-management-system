using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class modifymimaForm : System.Windows.Forms.Form
    {
        public modifymimaForm()
        {
            InitializeComponent();
        }

        private void modifymimaForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = loginForm.getName();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passwd = textBox2.Text;
            string quepasswd = textBox3.Text;
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
                   
                    if(loginForm.getRole()=="顾客")
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        string sql = "update 客户 set 登录密码 ='" + passwd+"' where 客户账号 = '"+textBox1.Text+"'";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改密码成功！");

                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        string sql = "update 商家 set 登录密码 ='" + passwd+"' where 商家账号 = '"+textBox1.Text+"'";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改密码成功！");

                    }        
                       
                    }
                    conn.Close();
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void modifymimaForm_Load_1(object sender, EventArgs e)
        {

        }
    }
    }

