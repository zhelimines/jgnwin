using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace 生殖中心病例管理系统
{
    public partial class 登录界面 : Form
    {
        public 登录界面()
        {
            InitializeComponent();
        }
        //退出登录界面
        private void button1_Click(object sender, EventArgs e)
        {
            //验证退出
            //if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            //{
            //    this.Close();//退出
            //}
            this.Close();
        }

        //验证登录
        private void button2_Click(object sender, EventArgs e)
        {
            //登录条件
            if (textBox1.Text=="admin"&&textBox2.Text=="admin")
            {
                this.Visible = false;//隐藏当前登录窗体
                mainInterface s = new mainInterface();
                s.Visible = true;//显示主界面
            }
            else
            {
                MessageBox.Show("密码出错");
            }
        }
        
        //加载登陆界面
        private void Form1_Load(object sender, EventArgs e)
        {
          
            mainInterface s = new mainInterface();
            s.Visible = false;//初始默认隐藏主界面
           

            this.BackColor = Color.FromArgb(255, 191, 229, 238);

        }
        //帮助
        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
