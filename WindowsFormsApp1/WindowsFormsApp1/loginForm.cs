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
    public partial class loginForm : System.Windows.Forms.Form
    {
        public static string connectionString = "Data Source=.;Initial Catalog=shop;Integrated Security=True";
        public static string name;
        public static string role;

        public loginForm()
        {
            InitializeComponent();
        }
        
 
        private void loginForm_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            name = textBoxname.Text.Trim();
            role = this.comboBoxrole.SelectedItem.ToString();
            if (name == "" || textBoxpasswd.Text.Trim() == "" || role == "")
            {
                MessageBox.Show("请将信息输入完整！");
            }
            else
            {
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                if (role == "客户")
                {
                    string sql = "select 客户账号,登录密码 from 客户 where 客户账号='" + name +
                     "' and 登录密码='" + textBoxpasswd.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();
                        Form2 mainframe = new Form2();
                        mainframe.BringToFront();
                        mainframe.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("用户名或者密码错误！");
                    }
                }
                else if (role == "商家")
                {
                    string sql1 = "select 商家账号,登录密码 from 商家 where 商家账号='" + name +
                     "' and 登录密码='" + textBoxpasswd.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //this.Close();
                        conn.Close();
                        Form1 mainframe = new Form1();
                        mainframe.BringToFront();
                        mainframe.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或者密码错误！");
                    }
                }

            }
        }
        public static String getName()
        {
            return name;
        }
        public static String getRole()
        {
            return role;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxrole_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            registerKehu registerKehu = new registerKehu();
            registerKehu.BringToFront();
            registerKehu.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            registerShop registerShop = new registerShop();
            registerShop.BringToFront();
            registerShop.Show();
            this.Hide();
        }
    }
}
