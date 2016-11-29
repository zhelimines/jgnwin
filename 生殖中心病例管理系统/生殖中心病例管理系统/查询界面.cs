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
    public partial class 查询界面 : Form
    {
        public 查询界面()
        {
            InitializeComponent();
        }

   

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Height = 254;
        }

        private void jian_Click(object sender, EventArgs e)
        {
            this.Height = 254;
            jia.Visible = true;
            jian.Visible = false;
        }

        private void jia_Click(object sender, EventArgs e)
        {
            this.Height = 370;
            jia.Visible = false;
            jian.Visible = true;
         
        }
    }
}
