namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("查看餐点");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("商家好店");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("在线订餐");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("商品信息", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("我的订单");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("我的资料");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("个人信息", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("修改密码");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("退出系统");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("系统管理", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeView1.Location = new System.Drawing.Point(17, 16);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "节点1";
            treeNode11.Text = "查看餐点";
            treeNode12.Name = "节点2";
            treeNode12.Text = "商家好店";
            treeNode13.Name = "节点3";
            treeNode13.Text = "在线订餐";
            treeNode14.Name = "节点0";
            treeNode14.Text = "商品信息";
            treeNode15.Name = "节点5";
            treeNode15.Text = "我的订单";
            treeNode16.Name = "节点6";
            treeNode16.Text = "我的资料";
            treeNode17.Name = "节点4";
            treeNode17.Text = "个人信息";
            treeNode18.Name = "节点8";
            treeNode18.Text = "修改密码";
            treeNode19.Name = "节点9";
            treeNode19.Text = "退出系统";
            treeNode20.Name = "节点7";
            treeNode20.Text = "系统管理";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode17,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(228, 586);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(266, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 586);
            this.panel1.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎订餐";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
    }
}