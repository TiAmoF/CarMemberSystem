using System.Drawing;
using System.Windows.Forms;

namespace CarMemberSystem
{
    partial class Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.panelsystem = new System.Windows.Forms.Panel();
            this.panelCD = new System.Windows.Forms.Panel();
            this.btnQT = new HZH_Controls.Controls.UCBtnImg();
            this.btnDPFX = new HZH_Controls.Controls.UCBtnImg();
            this.btnYGTC = new HZH_Controls.Controls.UCBtnImg();
            this.btnSPGL = new HZH_Controls.Controls.UCBtnImg();
            this.btnHYGL = new HZH_Controls.Controls.UCBtnImg();
            this.btnXFSY = new HZH_Controls.Controls.UCBtnImg();
            this.panelCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelsystem
            // 
            this.panelsystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelsystem.AutoScroll = true;
            this.panelsystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.panelsystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelsystem.Location = new System.Drawing.Point(0, 100);
            this.panelsystem.Name = "panelsystem";
            this.panelsystem.Size = new System.Drawing.Size(1182, 554);
            this.panelsystem.TabIndex = 1;
            // 
            // panelCD
            // 
            this.panelCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.panelCD.Controls.Add(this.btnQT);
            this.panelCD.Controls.Add(this.btnDPFX);
            this.panelCD.Controls.Add(this.btnYGTC);
            this.panelCD.Controls.Add(this.btnSPGL);
            this.panelCD.Controls.Add(this.btnHYGL);
            this.panelCD.Controls.Add(this.btnXFSY);
            this.panelCD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCD.Location = new System.Drawing.Point(0, 0);
            this.panelCD.Name = "panelCD";
            this.panelCD.Size = new System.Drawing.Size(1182, 100);
            this.panelCD.TabIndex = 2;
            // 
            // btnQT
            // 
            this.btnQT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnQT.BackColor = System.Drawing.Color.White;
            this.btnQT.BtnBackColor = System.Drawing.Color.White;
            this.btnQT.BtnFont = new System.Drawing.Font("微软雅黑", 17F);
            this.btnQT.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnQT.BtnText = "其他";
            this.btnQT.ConerRadius = 1;
            this.btnQT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQT.EnabledMouseEffect = true;
            this.btnQT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.btnQT.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnQT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnQT.Image = ((System.Drawing.Image)(resources.GetObject("btnQT.Image")));
            this.btnQT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQT.ImageFontIcons = ((object)(resources.GetObject("btnQT.ImageFontIcons")));
            this.btnQT.IsRadius = false;
            this.btnQT.IsShowRect = false;
            this.btnQT.IsShowTips = false;
            this.btnQT.Location = new System.Drawing.Point(901, 0);
            this.btnQT.Margin = new System.Windows.Forms.Padding(0);
            this.btnQT.Name = "btnQT";
            this.btnQT.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(133)))), ((int)(((byte)(166)))));
            this.btnQT.RectWidth = 0;
            this.btnQT.Size = new System.Drawing.Size(155, 100);
            this.btnQT.TabIndex = 5;
            this.btnQT.TabStop = false;
            this.btnQT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQT.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnQT.TipsText = "";
            this.btnQT.BtnClick += new System.EventHandler(this.btnQT_BtnClick);
            // 
            // btnDPFX
            // 
            this.btnDPFX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDPFX.BackColor = System.Drawing.Color.White;
            this.btnDPFX.BtnBackColor = System.Drawing.Color.White;
            this.btnDPFX.BtnFont = new System.Drawing.Font("微软雅黑", 17F);
            this.btnDPFX.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDPFX.BtnText = "店铺分析";
            this.btnDPFX.ConerRadius = 1;
            this.btnDPFX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDPFX.EnabledMouseEffect = true;
            this.btnDPFX.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.btnDPFX.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnDPFX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDPFX.Image = ((System.Drawing.Image)(resources.GetObject("btnDPFX.Image")));
            this.btnDPFX.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDPFX.ImageFontIcons = ((object)(resources.GetObject("btnDPFX.ImageFontIcons")));
            this.btnDPFX.IsRadius = false;
            this.btnDPFX.IsShowRect = false;
            this.btnDPFX.IsShowTips = false;
            this.btnDPFX.Location = new System.Drawing.Point(746, 0);
            this.btnDPFX.Margin = new System.Windows.Forms.Padding(0);
            this.btnDPFX.Name = "btnDPFX";
            this.btnDPFX.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(133)))), ((int)(((byte)(166)))));
            this.btnDPFX.RectWidth = 0;
            this.btnDPFX.Size = new System.Drawing.Size(155, 100);
            this.btnDPFX.TabIndex = 4;
            this.btnDPFX.TabStop = false;
            this.btnDPFX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDPFX.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnDPFX.TipsText = "";
            this.btnDPFX.BtnClick += new System.EventHandler(this.btnDPFX_BtnClick);
            // 
            // btnYGTC
            // 
            this.btnYGTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnYGTC.BackColor = System.Drawing.Color.White;
            this.btnYGTC.BtnBackColor = System.Drawing.Color.White;
            this.btnYGTC.BtnFont = new System.Drawing.Font("微软雅黑", 17F);
            this.btnYGTC.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnYGTC.BtnText = "员工提成";
            this.btnYGTC.ConerRadius = 1;
            this.btnYGTC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYGTC.EnabledMouseEffect = true;
            this.btnYGTC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.btnYGTC.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnYGTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnYGTC.Image = ((System.Drawing.Image)(resources.GetObject("btnYGTC.Image")));
            this.btnYGTC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYGTC.ImageFontIcons = ((object)(resources.GetObject("btnYGTC.ImageFontIcons")));
            this.btnYGTC.IsRadius = false;
            this.btnYGTC.IsShowRect = false;
            this.btnYGTC.IsShowTips = false;
            this.btnYGTC.Location = new System.Drawing.Point(591, 0);
            this.btnYGTC.Margin = new System.Windows.Forms.Padding(0);
            this.btnYGTC.Name = "btnYGTC";
            this.btnYGTC.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(133)))), ((int)(((byte)(166)))));
            this.btnYGTC.RectWidth = 0;
            this.btnYGTC.Size = new System.Drawing.Size(155, 100);
            this.btnYGTC.TabIndex = 3;
            this.btnYGTC.TabStop = false;
            this.btnYGTC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYGTC.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnYGTC.TipsText = "";
            this.btnYGTC.BtnClick += new System.EventHandler(this.btnYGTC_BtnClick);
            // 
            // btnSPGL
            // 
            this.btnSPGL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSPGL.BackColor = System.Drawing.Color.White;
            this.btnSPGL.BtnBackColor = System.Drawing.Color.White;
            this.btnSPGL.BtnFont = new System.Drawing.Font("微软雅黑", 17F);
            this.btnSPGL.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSPGL.BtnText = "商品管理";
            this.btnSPGL.ConerRadius = 1;
            this.btnSPGL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSPGL.EnabledMouseEffect = true;
            this.btnSPGL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.btnSPGL.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSPGL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSPGL.Image = ((System.Drawing.Image)(resources.GetObject("btnSPGL.Image")));
            this.btnSPGL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSPGL.ImageFontIcons = ((object)(resources.GetObject("btnSPGL.ImageFontIcons")));
            this.btnSPGL.IsRadius = false;
            this.btnSPGL.IsShowRect = false;
            this.btnSPGL.IsShowTips = false;
            this.btnSPGL.Location = new System.Drawing.Point(436, 0);
            this.btnSPGL.Margin = new System.Windows.Forms.Padding(0);
            this.btnSPGL.Name = "btnSPGL";
            this.btnSPGL.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(133)))), ((int)(((byte)(166)))));
            this.btnSPGL.RectWidth = 0;
            this.btnSPGL.Size = new System.Drawing.Size(155, 100);
            this.btnSPGL.TabIndex = 2;
            this.btnSPGL.TabStop = false;
            this.btnSPGL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSPGL.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnSPGL.TipsText = "";
            this.btnSPGL.BtnClick += new System.EventHandler(this.btnSPGL_BtnClick);
            // 
            // btnHYGL
            // 
            this.btnHYGL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnHYGL.BackColor = System.Drawing.Color.White;
            this.btnHYGL.BtnBackColor = System.Drawing.Color.White;
            this.btnHYGL.BtnFont = new System.Drawing.Font("微软雅黑", 17F);
            this.btnHYGL.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnHYGL.BtnText = "会员管理";
            this.btnHYGL.ConerRadius = 1;
            this.btnHYGL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHYGL.EnabledMouseEffect = true;
            this.btnHYGL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.btnHYGL.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnHYGL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnHYGL.Image = ((System.Drawing.Image)(resources.GetObject("btnHYGL.Image")));
            this.btnHYGL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHYGL.ImageFontIcons = ((object)(resources.GetObject("btnHYGL.ImageFontIcons")));
            this.btnHYGL.IsRadius = false;
            this.btnHYGL.IsShowRect = false;
            this.btnHYGL.IsShowTips = false;
            this.btnHYGL.Location = new System.Drawing.Point(281, 0);
            this.btnHYGL.Margin = new System.Windows.Forms.Padding(0);
            this.btnHYGL.Name = "btnHYGL";
            this.btnHYGL.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(133)))), ((int)(((byte)(166)))));
            this.btnHYGL.RectWidth = 0;
            this.btnHYGL.Size = new System.Drawing.Size(155, 100);
            this.btnHYGL.TabIndex = 1;
            this.btnHYGL.TabStop = false;
            this.btnHYGL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHYGL.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnHYGL.TipsText = "";
            this.btnHYGL.BtnClick += new System.EventHandler(this.btnHYGL_BtnClick);
            // 
            // btnXFSY
            // 
            this.btnXFSY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnXFSY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.btnXFSY.BtnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.btnXFSY.BtnFont = new System.Drawing.Font("微软雅黑", 17F);
            this.btnXFSY.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnXFSY.BtnText = "消费收银";
            this.btnXFSY.ConerRadius = 1;
            this.btnXFSY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXFSY.EnabledMouseEffect = true;
            this.btnXFSY.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.btnXFSY.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnXFSY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnXFSY.Image = ((System.Drawing.Image)(resources.GetObject("btnXFSY.Image")));
            this.btnXFSY.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXFSY.ImageFontIcons = ((object)(resources.GetObject("btnXFSY.ImageFontIcons")));
            this.btnXFSY.IsRadius = false;
            this.btnXFSY.IsShowRect = false;
            this.btnXFSY.IsShowTips = false;
            this.btnXFSY.Location = new System.Drawing.Point(127, 0);
            this.btnXFSY.Margin = new System.Windows.Forms.Padding(0);
            this.btnXFSY.Name = "btnXFSY";
            this.btnXFSY.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(133)))), ((int)(((byte)(166)))));
            this.btnXFSY.RectWidth = 0;
            this.btnXFSY.Size = new System.Drawing.Size(154, 100);
            this.btnXFSY.TabIndex = 0;
            this.btnXFSY.TabStop = false;
            this.btnXFSY.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXFSY.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnXFSY.TipsText = "";
            this.btnXFSY.BtnClick += new System.EventHandler(this.btnXFSY_BtnClick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panelCD);
            this.Controls.Add(this.panelsystem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "泰徕丰汽车美容会员";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelCD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsystem;
        private System.Windows.Forms.Panel panelCD;
        private HZH_Controls.Controls.UCBtnImg btnQT;
        private HZH_Controls.Controls.UCBtnImg btnDPFX;
        private HZH_Controls.Controls.UCBtnImg btnYGTC;
        private HZH_Controls.Controls.UCBtnImg btnSPGL;
        private HZH_Controls.Controls.UCBtnImg btnHYGL;
        private HZH_Controls.Controls.UCBtnImg btnXFSY;
    }
}

