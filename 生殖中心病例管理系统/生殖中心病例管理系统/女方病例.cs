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
    public partial class 女方病例 : Form
    {
        public 女方病例()
        {
            InitializeComponent();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            hepatitis_textBox.Height = 50;
            if (hepatitis_textBox .Text =="无")//实现点击切换有无
            {
                hepatitis_textBox.Text = "有";
            }
            else
            {
                hepatitis_textBox.Text = "无";
            }
           

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            tubercular_textbox.Text = "有";
        }

        private void 女方病例_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 196, 231, 239);//设置当前窗体背景颜色
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
