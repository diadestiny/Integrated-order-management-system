using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (this.treeView1.SelectedNode.Text)
            {
                case "查看餐点":
                    searchgoods f1 = new searchgoods();
                    f1.TopLevel = false;
                    f1.FormBorderStyle = FormBorderStyle.None;
                    f1.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f1);
                    f1.Show();
                    break;
                case "商家好店":
                    showstore f2 = new showstore();
                    f2.TopLevel = false;
                    f2.FormBorderStyle = FormBorderStyle.None;
                    f2.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f2);
                    f2.Show();
                    break;
                case "在线订餐":
                    chooseShop f3 = new chooseShop();
                    f3.TopLevel = false;
                    f3.FormBorderStyle = FormBorderStyle.None;
                    f3.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f3);
                    f3.Show();
                    break;
                case "我的订单":
                    mydingdan f4 = new mydingdan();
                    f4.TopLevel = false;
                    f4.FormBorderStyle = FormBorderStyle.None;
                    f4.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f4);
                    f4.Show();
                    break;
                case "我的资料":
                    myProfile f5 = new myProfile();
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
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
