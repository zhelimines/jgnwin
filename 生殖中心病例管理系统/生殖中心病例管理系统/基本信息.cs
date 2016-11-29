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
    public partial class 基本信息 : Form
    {
        public 基本信息()
        {
            InitializeComponent();
        }

        private void 基本信息_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 196, 231, 239);//设置当前窗体背景颜色
            this.Visible = false;//默认隐藏
        }

        private void date_MouseDown(object sender, MouseEventArgs e)
        {
            date.Text = DateTime.Now.ToString("D");
        }
    }
}
