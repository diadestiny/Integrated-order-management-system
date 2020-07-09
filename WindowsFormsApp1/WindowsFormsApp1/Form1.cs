using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (this.treeView1.SelectedNode.Text)
            {

                case "周边商品":
                    searchgoods f3 = new searchgoods();
                    f3.TopLevel = false;
                    f3.FormBorderStyle = FormBorderStyle.None;
                    f3.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f3);
                    f3.Show();
                    break;
                case "我的商品":
                    myshop f2 = new myshop();
                    f2.TopLevel = false;
                    f2.FormBorderStyle = FormBorderStyle.None;
                    f2.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f2);
                    f2.Show();
                    break;
                case "我的接单":
                    myjiedan f4 = new myjiedan();
                    f4.TopLevel = false;
                    f4.FormBorderStyle = FormBorderStyle.None;
                    f4.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f4);
                    f4.Show();
                    break;
                case "发布商品":
                    createShop f6 = new createShop();
                    f6.TopLevel = false;
                    f6.FormBorderStyle = FormBorderStyle.None;
                    f6.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f6);
                    f6.Show();
                    break;
                case "商家资料":
                    shopProfile f5 = new shopProfile();
                    f5.TopLevel = false;
                    f5.FormBorderStyle = FormBorderStyle.None;
                    f5.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f5);
                    f5.Show();
                    break;
                case "退出系统":
                    Application.Exit();
                    break;

                case "修改密码":
                    modifymimaForm f14 = new modifymimaForm();
                    f14.TopLevel = false;
                    f14.FormBorderStyle = FormBorderStyle.None;
                    f14.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f14);
                    f14.Show();
                    break;
            }
        }
    }
}
