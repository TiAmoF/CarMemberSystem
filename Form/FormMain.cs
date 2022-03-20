using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarMemberSystem
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            panelsystem.BackgroundImage = Image.FromFile(@"..\..\img\首页展示图(白).jpg");
            //this.WindowState = FormWindowState.Maximized;
        }

        //消费收银
        private void btnXFSY_BtnClick(object sender, EventArgs e)
        {
            panelsystem.Controls.Clear();
            chargeFee chargefee = new chargeFee();
            //嵌入子窗体到父窗体中，把添加学员信息嵌入到主窗体右侧
            chargefee.TopLevel = false; //将子窗体设置成非最高层，非顶级控件
            chargefee.WindowState = FormWindowState.Maximized;//将当前窗口设置成最大化
            chargefee.FormBorderStyle = FormBorderStyle.None;//去掉窗体边框
            chargefee.Parent = this.panelsystem;//指定子窗体显示的容器
            chargefee.Show();
        }

        //会员管理
        private void btnHYGL_BtnClick(object sender, EventArgs e)
        {
            //panelsystem.BackgroundImage = null;
            panelsystem.Controls.Clear();
            MessageBox.Show("1111");
        }

        //商品管理
        private void btnSPGL_BtnClick(object sender, EventArgs e)
        {
            //panelsystem.BackgroundImage = null;
            panelsystem.Controls.Clear();
            MessageBox.Show("1111");
        }

        //员工管理
        private void btnYGTC_BtnClick(object sender, EventArgs e)
        {
            //panelsystem.BackgroundImage = null;
            panelsystem.Controls.Clear();
            MessageBox.Show("1111");
        }

        //店铺分析
        private void btnDPFX_BtnClick(object sender, EventArgs e)
        {
            //panelsystem.BackgroundImage = null;
            panelsystem.Controls.Clear();
            MessageBox.Show("1111");
        }

        //其他
        private void btnQT_BtnClick(object sender, EventArgs e)
        {
            //panelsystem.BackgroundImage = null;
            panelsystem.Controls.Clear();
            MessageBox.Show("1111");
        }
    }
}
