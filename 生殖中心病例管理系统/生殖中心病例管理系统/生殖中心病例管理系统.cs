//背景主色196, 231, 239   英文字体Georgia   中文微软雅黑

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
    public partial class mainInterface : Form
    {
        

        public mainInterface()
        {
            InitializeComponent();
        }
        //加载
        private void Form2_Load(object sender, EventArgs e)
        {
            
            this.BackColor = Color .FromArgb (255,196,231,239 );//设置当前窗体背景颜色
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;//设置两个split样式，但是未能解决焦点问题
           
            listView_CaseRegistration.GridLines = true;//表格是否显示网格线
            listView_CaseRegistration.FullRowSelect = true;//是否选中整行



            listView_CaseRegistration.View = View.Details;//设置显示方式
            listView_CaseRegistration.Scrollable = true;//是否自动显示滚动条
            listView_CaseRegistration.MultiSelect = false;//是否可以选择多行

            //添加表头（列）
            listView_CaseRegistration.Columns.Add("日期", 160, HorizontalAlignment.Center);
            listView_CaseRegistration.Columns.Add("序号", 100, HorizontalAlignment.Center);
            listView_CaseRegistration.Columns.Add("病历号", 100, HorizontalAlignment.Center);
            listView_CaseRegistration.Columns.Add("姓名", 100, HorizontalAlignment.Center);

            listView_CaseRegistration.Columns.Add("年龄", 160, HorizontalAlignment.Center);
            listView_CaseRegistration.Columns.Add("职业", 100, HorizontalAlignment.Center);
            listView_CaseRegistration.Columns.Add("地址/电话", 100, HorizontalAlignment.Center);
            listView_CaseRegistration.Columns.Add("诊断", 100, HorizontalAlignment.Center);

            listView_CaseRegistration.Columns.Add("周期", 160, HorizontalAlignment.Center);
           
            listView_CaseRegistration.Columns.Add("护士", 100, HorizontalAlignment.Center);
            for (int i = 0; i < 10; i++)
            {
                listView_CaseRegistration.Columns[i].Width = -1;//根据内容设置宽度
            }
           
            //添加表格内容
            for (int i = 0; i < 6; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();

                item.SubItems[0].Text = "日期" + i.ToString();
                item.SubItems.Add(i.ToString());
                item.SubItems.Add((i + 7).ToString());
                item.SubItems.Add((i * i).ToString());
                listView_CaseRegistration.Items.Add(item);
            }
            

        }
        //退出事件
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void 女方病例模板_Paint(object sender, PaintEventArgs e)
        {
            //this.女方病例模板 .HorizontalScroll.Visible = true;
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {
          
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            基本信息 diao = new 基本信息();
            diao.ShowDialog();//显示基本信息窗体
        }

        private void button2_Click(object sender, EventArgs e)
        {
            女方病例 diaoyong = new 女方病例();
            diaoyong.ShowDialog();
        }
      
        
        private void 男方病例_Click(object sender, EventArgs e)
        {
            男方病例form a = new 男方病例form();
            a.ShowDialog(this );
          
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            查询界面 a = new 查询界面();
            a.Show();
        }

      
    }
}
