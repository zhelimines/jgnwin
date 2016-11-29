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
    public partial class 男方病例form : Form
    {
        public 男方病例form()
        {
            InitializeComponent();
        }

        private void 男方病例_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            

           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void 男方病例form_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 196, 231, 239);//设置当前窗体背景颜色
        }
    }
}
