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
    public partial class zhuchuangti : Form
    {
        public zhuchuangti()
        {
            InitializeComponent();
        }

        private void zhuchuangti_Load(object sender, EventArgs e)
        {
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage3.BorderStyle = BorderStyle.Fixed3D;
            tabPage4.BorderStyle = BorderStyle.Fixed3D;
            tabPage5.BorderStyle = BorderStyle.Fixed3D;
            tabPage6.BorderStyle = BorderStyle.Fixed3D;
            tabPage7.BorderStyle = BorderStyle.Fixed3D;
            while (true)
            {
                toolStripLabel3.Text = DateTime.Now.ToString();
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
          
        }

       

      
    }
}
