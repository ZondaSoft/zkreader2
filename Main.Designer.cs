namespace StandaloneSDKDemo
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbSysOutputInfo = new System.Windows.Forms.ListBox();
            this.cmsDemoEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbVer = new System.Windows.Forms.Label();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicSmall = new System.Windows.Forms.PictureBox();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRTOutputInfo = new System.Windows.Forms.ListBox();
            this.cmsDeviceRTEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearInfoMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PrgSTA = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlMiddle = new System.Windows.Forms.Panel();
            this.pnlPersonalize = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.pnlAccess = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlTerminal = new System.Windows.Forms.Panel();
            this.labAD = new System.Windows.Forms.Label();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.cmsDemoEvent.SuspendLayout();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.PnlBottom.SuspendLayout();
            this.cmsDeviceRTEvent.SuspendLayout();
            this.PnlMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSysOutputInfo
            // 
            this.lbSysOutputInfo.ContextMenuStrip = this.cmsDemoEvent;
            this.lbSysOutputInfo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSysOutputInfo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSysOutputInfo.FormattingEnabled = true;
            this.lbSysOutputInfo.ItemHeight = 12;
            this.lbSysOutputInfo.Location = new System.Drawing.Point(3, 21);
            this.lbSysOutputInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbSysOutputInfo.Name = "lbSysOutputInfo";
            this.lbSysOutputInfo.Size = new System.Drawing.Size(584, 196);
            this.lbSysOutputInfo.TabIndex = 77;
            this.lbSysOutputInfo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbSysOutputInfo_DrawItem);
            // 
            // cmsDemoEvent
            // 
            this.cmsDemoEvent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDemoEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearInfoMenuItem});
            this.cmsDemoEvent.Name = "contextMenuStripDevice";
            this.cmsDemoEvent.Size = new System.Drawing.Size(113, 28);
            // 
            // ClearInfoMenuItem
            // 
            this.ClearInfoMenuItem.Name = "ClearInfoMenuItem";
            this.ClearInfoMenuItem.Size = new System.Drawing.Size(112, 24);
            this.ClearInfoMenuItem.Text = "Clear";
            this.ClearInfoMenuItem.Click += new System.EventHandler(this.ClearInfoMenuItem_Click);
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVer.ForeColor = System.Drawing.Color.Black;
            this.lbVer.Location = new System.Drawing.Point(397, 229);
            this.lbVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(191, 18);
            this.lbVer.TabIndex = 80;
            this.lbVer.Text = "Version:     SDK Version:";
            // 
            // PnlTop
            // 
            this.PnlTop.AutoSize = true;
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(67)))));
            this.PnlTop.Controls.Add(this.pictureBox1);
            this.PnlTop.Controls.Add(this.PicSmall);
            this.PnlTop.Controls.Add(this.PicClose);
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1247, 59);
            this.PnlTop.TabIndex = 83;
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.PnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            this.PnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicHome_MouseClick);
            // 
            // PicSmall
            // 
            this.PicSmall.Image = global::StandaloneSDKDemo.Properties.Resources.remove_circular;
            this.PicSmall.Location = new System.Drawing.Point(1143, 7);
            this.PicSmall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PicSmall.Name = "PicSmall";
            this.PicSmall.Size = new System.Drawing.Size(40, 40);
            this.PicSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSmall.TabIndex = 6;
            this.PicSmall.TabStop = false;
            this.PicSmall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicSmall_MouseClick);
            // 
            // PicClose
            // 
            this.PicClose.Image = global::StandaloneSDKDemo.Properties.Resources.delete_circular;
            this.PicClose.Location = new System.Drawing.Point(1197, 7);
            this.PicClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(40, 40);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClose.TabIndex = 2;
            this.PicClose.TabStop = false;
            this.PicClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicClose_MouseClick);
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PnlBottom.Controls.Add(this.label2);
            this.PnlBottom.Controls.Add(this.label1);
            this.PnlBottom.Controls.Add(this.lbRTOutputInfo);
            this.PnlBottom.Controls.Add(this.PrgSTA);
            this.PnlBottom.Controls.Add(this.label3);
            this.PnlBottom.Controls.Add(this.lbSysOutputInfo);
            this.PnlBottom.Controls.Add(this.lbVer);
            this.PnlBottom.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlBottom.Location = new System.Drawing.Point(0, 583);
            this.PnlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(1245, 256);
            this.PnlBottom.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 18);
            this.label2.TabIndex = 85;
            this.label2.Text = "Device Real-Time Event:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 84;
            this.label1.Text = "Demo Event:";
            // 
            // lbRTOutputInfo
            // 
            this.lbRTOutputInfo.ContextMenuStrip = this.cmsDeviceRTEvent;
            this.lbRTOutputInfo.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRTOutputInfo.FormattingEnabled = true;
            this.lbRTOutputInfo.ItemHeight = 14;
            this.lbRTOutputInfo.Location = new System.Drawing.Point(596, 21);
            this.lbRTOutputInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbRTOutputInfo.Name = "lbRTOutputInfo";
            this.lbRTOutputInfo.Size = new System.Drawing.Size(644, 186);
            this.lbRTOutputInfo.TabIndex = 83;
            // 
            // cmsDeviceRTEvent
            // 
            this.cmsDeviceRTEvent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDeviceRTEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearInfoMenuItem1});
            this.cmsDeviceRTEvent.Name = "contextMenuStripDevice";
            this.cmsDeviceRTEvent.Size = new System.Drawing.Size(113, 28);
            // 
            // ClearInfoMenuItem1
            // 
            this.ClearInfoMenuItem1.Name = "ClearInfoMenuItem1";
            this.ClearInfoMenuItem1.Size = new System.Drawing.Size(112, 24);
            this.ClearInfoMenuItem1.Text = "Clear";
            this.ClearInfoMenuItem1.Click += new System.EventHandler(this.ClearInfoMenuItem1_Click);
            // 
            // PrgSTA
            // 
            this.PrgSTA.Location = new System.Drawing.Point(1, 229);
            this.PrgSTA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrgSTA.Name = "PrgSTA";
            this.PrgSTA.Size = new System.Drawing.Size(376, 19);
            this.PrgSTA.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(764, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 18);
            this.label3.TabIndex = 81;
            this.label3.Text = "Copyright © 2017 ZKTECO CO., LTD. All Rights Reserved.";
            // 
            // PnlMiddle
            // 
            this.PnlMiddle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlMiddle.Controls.Add(this.label4);
            this.PnlMiddle.Controls.Add(this.pnlPersonalize);
            this.PnlMiddle.Controls.Add(this.pnlUser);
            this.PnlMiddle.Controls.Add(this.pnlOther);
            this.PnlMiddle.Controls.Add(this.pnlAccess);
            this.PnlMiddle.Controls.Add(this.pnlData);
            this.PnlMiddle.Controls.Add(this.pnlTerminal);
            this.PnlMiddle.Controls.Add(this.labAD);
            this.PnlMiddle.Location = new System.Drawing.Point(0, 55);
            this.PnlMiddle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlMiddle.Name = "PnlMiddle";
            this.PnlMiddle.Size = new System.Drawing.Size(1245, 520);
            this.PnlMiddle.TabIndex = 86;
            this.PnlMiddle.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMiddle_Paint);
            // 
            // pnlPersonalize
            // 
            this.pnlPersonalize.Location = new System.Drawing.Point(1143, 11);
            this.pnlPersonalize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPersonalize.Name = "pnlPersonalize";
            this.pnlPersonalize.Size = new System.Drawing.Size(21, 21);
            this.pnlPersonalize.TabIndex = 3;
            // 
            // pnlUser
            // 
            this.pnlUser.Location = new System.Drawing.Point(1123, 11);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(21, 21);
            this.pnlUser.TabIndex = 2;
            // 
            // pnlOther
            // 
            this.pnlOther.Location = new System.Drawing.Point(1201, 11);
            this.pnlOther.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOther.Name = "pnlOther";
            this.pnlOther.Size = new System.Drawing.Size(21, 21);
            this.pnlOther.TabIndex = 6;
            // 
            // pnlAccess
            // 
            this.pnlAccess.Location = new System.Drawing.Point(1181, 11);
            this.pnlAccess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAccess.Name = "pnlAccess";
            this.pnlAccess.Size = new System.Drawing.Size(21, 21);
            this.pnlAccess.TabIndex = 5;
            // 
            // pnlData
            // 
            this.pnlData.Location = new System.Drawing.Point(1161, 11);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(21, 21);
            this.pnlData.TabIndex = 4;
            // 
            // pnlTerminal
            // 
            this.pnlTerminal.Location = new System.Drawing.Point(1103, 11);
            this.pnlTerminal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTerminal.Name = "pnlTerminal";
            this.pnlTerminal.Size = new System.Drawing.Size(21, 21);
            this.pnlTerminal.TabIndex = 1;
            // 
            // labAD
            // 
            this.labAD.AutoSize = true;
            this.labAD.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAD.Location = new System.Drawing.Point(346, 146);
            this.labAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAD.Name = "labAD";
            this.labAD.Size = new System.Drawing.Size(512, 48);
            this.labAD.TabIndex = 0;
            this.labAD.Text = "Lector de relojes ZkTeco";
            this.labAD.Click += new System.EventHandler(this.labAD_Click);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.propertyToolStripMenuItem.Text = "Property";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(403, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "por Zonda Software v. 0.01";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 843);
            this.Controls.Add(this.PnlMiddle);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StandaloneSDKDemoV1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.cmsDemoEvent.ResumeLayout(false);
            this.PnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.PnlBottom.ResumeLayout(false);
            this.PnlBottom.PerformLayout();
            this.cmsDeviceRTEvent.ResumeLayout(false);
            this.PnlMiddle.ResumeLayout(false);
            this.PnlMiddle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel PnlMiddle;
        private System.Windows.Forms.PictureBox PicClose;
        private FirstMenu firstMenu1;
        private FirstMenu firstMenu3;
        private FirstMenu firstMenu2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PicSmall;
        private System.Windows.Forms.PictureBox pictureBox1;
        public  System.Windows.Forms.ListBox lbSysOutputInfo;
        public  System.Windows.Forms.ProgressBar PrgSTA;
        private FirstMenu firstMenu4;
        private System.Windows.Forms.Label labAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRTOutputInfo;
        private System.Windows.Forms.Label label2;
        private FirstMenu firstMenu5;
        private FirstMenu firstMenu6;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.Panel pnlAccess;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlPersonalize;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlTerminal;
        private System.Windows.Forms.ContextMenuStrip cmsDemoEvent;
        private System.Windows.Forms.ToolStripMenuItem ClearInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDeviceRTEvent;
        private System.Windows.Forms.ToolStripMenuItem ClearInfoMenuItem1;
        private System.Windows.Forms.Label label4;
    }
}

