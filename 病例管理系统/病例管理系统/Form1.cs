using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 病例管理系统
{
    public partial class denglu : Form
    {
        public denglu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           this.BackColor = Color.FromArgb(255, 146, 168, 209);
           button1 .BackColor =Color .FromArgb (255,146,168,209);
           button2.BackColor = Color.FromArgb(255, 146, 168, 209);
        }
        //登录
        private void button1_Click(object sender, EventArgs e)
        {
            if (yanzheng())
            {               
                zhuchuangti a = new zhuchuangti();
                this.Hide();
                a.Show();                  //显示主界面
               
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("密码不能为空");
            }
            else
            {
                MessageBox.Show("密码输入错误");
            }
        }
        //退出
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认关闭", "提示信息", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //待更改 登录时的密码验证
        private bool yanzheng()
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    } 
}
