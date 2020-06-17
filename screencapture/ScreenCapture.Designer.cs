namespace screencapture
{
    partial class ScreenCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenCapture));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.停止抓屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtip = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pciDisplay = new System.Windows.Forms.PictureBox();
            this.cmbScreen = new System.Windows.Forms.ComboBox();
            this.imgfromat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtremotdir = new System.Windows.Forms.TextBox();
            this.txtimgname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnAddconfig = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_config = new System.Windows.Forms.DataGridView();
            this.screenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_s = new System.Windows.Forms.TextBox();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_h = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chk_reatart = new System.Windows.Forms.CheckBox();
            this.cmsNotify.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pciDisplay)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_config)).BeginInit();
            this.cmsDgv.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(292, 572);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 44);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "开始定时抓屏";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(503, 572);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(133, 44);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "停止定时抓屏";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cmsNotify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "定时抓屏软件";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cmsNotify
            // 
            this.cmsNotify.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.停止抓屏ToolStripMenuItem,
            this.退出服务ToolStripMenuItem});
            this.cmsNotify.Name = "contextMenuStrip1";
            this.cmsNotify.Size = new System.Drawing.Size(139, 52);
            // 
            // 停止抓屏ToolStripMenuItem
            // 
            this.停止抓屏ToolStripMenuItem.Name = "停止抓屏ToolStripMenuItem";
            this.停止抓屏ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.停止抓屏ToolStripMenuItem.Text = "停止抓屏";
            this.停止抓屏ToolStripMenuItem.Click += new System.EventHandler(this.停止抓屏ToolStripMenuItem_Click);
            // 
            // 退出服务ToolStripMenuItem
            // 
            this.退出服务ToolStripMenuItem.Name = "退出服务ToolStripMenuItem";
            this.退出服务ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.退出服务ToolStripMenuItem.Text = "退出服务";
            this.退出服务ToolStripMenuItem.Click += new System.EventHandler(this.退出服务ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtip);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pciDisplay);
            this.groupBox1.Controls.Add(this.cmbScreen);
            this.groupBox1.Controls.Add(this.imgfromat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtremotdir);
            this.groupBox1.Controls.Add(this.txtimgname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.btnSaveConfig);
            this.groupBox1.Controls.Add(this.btnAddconfig);
            this.groupBox1.Location = new System.Drawing.Point(19, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(629, 550);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置抓取屏幕参数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ftp密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ftp用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ftp地址：";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(105, 110);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.MaxLength = 20;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(211, 25);
            this.txtpass.TabIndex = 27;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(105, 76);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.MaxLength = 20;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(208, 25);
            this.txtusername.TabIndex = 23;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(281, 42);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(32, 25);
            this.txtPort.TabIndex = 19;
            this.txtPort.Text = "21";
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(105, 42);
            this.txtip.Margin = new System.Windows.Forms.Padding(4);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(148, 25);
            this.txtip.TabIndex = 20;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(463, 45);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.MaxLength = 20;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(141, 25);
            this.txtTime.TabIndex = 28;
            this.txtTime.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "抓屏时间间隔：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 175);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "屏幕图像：";
            // 
            // pciDisplay
            // 
            this.pciDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pciDisplay.Location = new System.Drawing.Point(17, 204);
            this.pciDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.pciDisplay.Name = "pciDisplay";
            this.pciDisplay.Size = new System.Drawing.Size(586, 338);
            this.pciDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pciDisplay.TabIndex = 17;
            this.pciDisplay.TabStop = false;
            // 
            // cmbScreen
            // 
            this.cmbScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScreen.FormattingEnabled = true;
            this.cmbScreen.Items.AddRange(new object[] {
            "jpg",
            "png"});
            this.cmbScreen.Location = new System.Drawing.Point(97, 171);
            this.cmbScreen.Margin = new System.Windows.Forms.Padding(4);
            this.cmbScreen.Name = "cmbScreen";
            this.cmbScreen.Size = new System.Drawing.Size(141, 23);
            this.cmbScreen.TabIndex = 15;
            this.cmbScreen.SelectionChangeCommitted += new System.EventHandler(this.cmbScreen_SelectionChangeCommitted);
            // 
            // imgfromat
            // 
            this.imgfromat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imgfromat.FormattingEnabled = true;
            this.imgfromat.Items.AddRange(new object[] {
            "jpg",
            "png"});
            this.imgfromat.Location = new System.Drawing.Point(552, 78);
            this.imgfromat.Margin = new System.Windows.Forms.Padding(4);
            this.imgfromat.Name = "imgfromat";
            this.imgfromat.Size = new System.Drawing.Size(52, 23);
            this.imgfromat.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "上传Ftp目录：";
            // 
            // txtremotdir
            // 
            this.txtremotdir.Location = new System.Drawing.Point(463, 110);
            this.txtremotdir.Margin = new System.Windows.Forms.Padding(4);
            this.txtremotdir.MaxLength = 50;
            this.txtremotdir.Name = "txtremotdir";
            this.txtremotdir.Size = new System.Drawing.Size(144, 25);
            this.txtremotdir.TabIndex = 11;
            // 
            // txtimgname
            // 
            this.txtimgname.Location = new System.Drawing.Point(463, 78);
            this.txtimgname.Margin = new System.Windows.Forms.Padding(4);
            this.txtimgname.MaxLength = 20;
            this.txtimgname.Name = "txtimgname";
            this.txtimgname.Size = new System.Drawing.Size(84, 25);
            this.txtimgname.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "保存名称：";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(489, 169);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(119, 28);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "导入配置信息";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(368, 169);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(119, 28);
            this.btnSaveConfig.TabIndex = 6;
            this.btnSaveConfig.Text = "保存配置信息";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnAddconfig
            // 
            this.btnAddconfig.Location = new System.Drawing.Point(248, 169);
            this.btnAddconfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddconfig.Name = "btnAddconfig";
            this.btnAddconfig.Size = new System.Drawing.Size(119, 28);
            this.btnAddconfig.TabIndex = 6;
            this.btnAddconfig.Text = "添加截取屏幕";
            this.btnAddconfig.UseVisualStyleBackColor = true;
            this.btnAddconfig.Click += new System.EventHandler(this.btnAddconfig_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_config);
            this.groupBox2.Location = new System.Drawing.Point(671, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(252, 339);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已添加屏幕";
            // 
            // dgv_config
            // 
            this.dgv_config.AllowUserToAddRows = false;
            this.dgv_config.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_config.BackgroundColor = System.Drawing.Color.White;
            this.dgv_config.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_config.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_config.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.screenName,
            this.savename});
            this.dgv_config.ContextMenuStrip = this.cmsDgv;
            this.dgv_config.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_config.Location = new System.Drawing.Point(4, 22);
            this.dgv_config.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_config.MultiSelect = false;
            this.dgv_config.Name = "dgv_config";
            this.dgv_config.ReadOnly = true;
            this.dgv_config.RowHeadersVisible = false;
            this.dgv_config.RowHeadersWidth = 51;
            this.dgv_config.RowTemplate.Height = 23;
            this.dgv_config.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_config.Size = new System.Drawing.Size(244, 313);
            this.dgv_config.TabIndex = 0;
            // 
            // screenName
            // 
            this.screenName.DataPropertyName = "ScreenName";
            this.screenName.HeaderText = "屏幕名称";
            this.screenName.MinimumWidth = 6;
            this.screenName.Name = "screenName";
            this.screenName.ReadOnly = true;
            // 
            // savename
            // 
            this.savename.DataPropertyName = "SaveName";
            this.savename.HeaderText = "保存文件名";
            this.savename.MinimumWidth = 6;
            this.savename.Name = "savename";
            this.savename.ReadOnly = true;
            // 
            // cmsDgv
            // 
            this.cmsDgv.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.cmsDgv.Name = "cmsDgv";
            this.cmsDgv.Size = new System.Drawing.Size(109, 28);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_s);
            this.groupBox3.Controls.Add(this.txt_m);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_h);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.chk_reatart);
            this.groupBox3.Location = new System.Drawing.Point(675, 364);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(248, 201);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "软件配置";
            // 
            // txt_s
            // 
            this.txt_s.Location = new System.Drawing.Point(172, 100);
            this.txt_s.Margin = new System.Windows.Forms.Padding(4);
            this.txt_s.Name = "txt_s";
            this.txt_s.Size = new System.Drawing.Size(47, 25);
            this.txt_s.TabIndex = 2;
            this.txt_s.Visible = false;
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(93, 100);
            this.txt_m.Margin = new System.Windows.Forms.Padding(4);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(47, 25);
            this.txt_m.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(149, 104);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = ":";
            this.label13.Visible = false;
            // 
            // txt_h
            // 
            this.txt_h.Location = new System.Drawing.Point(12, 100);
            this.txt_h.Margin = new System.Windows.Forms.Padding(4);
            this.txt_h.Name = "txt_h";
            this.txt_h.Size = new System.Drawing.Size(47, 25);
            this.txt_h.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 104);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "重启时间";
            // 
            // chk_reatart
            // 
            this.chk_reatart.AutoSize = true;
            this.chk_reatart.Location = new System.Drawing.Point(9, 39);
            this.chk_reatart.Margin = new System.Windows.Forms.Padding(4);
            this.chk_reatart.Name = "chk_reatart";
            this.chk_reatart.Size = new System.Drawing.Size(89, 19);
            this.chk_reatart.TabIndex = 0;
            this.chk_reatart.Text = "定时重启";
            this.chk_reatart.UseVisualStyleBackColor = true;
            this.chk_reatart.Click += new System.EventHandler(this.chk_reatart_Click);
            // 
            // ScreenCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 632);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ScreenCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定时抓屏软件1.2.4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScreenCapture_FormClosing);
            this.Load += new System.EventHandler(this.ScreenCapture_Load);
            this.cmsNotify.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pciDisplay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_config)).EndInit();
            this.cmsDgv.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.ToolStripMenuItem 停止抓屏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出服务ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pciDisplay;
        private System.Windows.Forms.ComboBox cmbScreen;
        private System.Windows.Forms.ComboBox imgfromat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtremotdir;
        private System.Windows.Forms.TextBox txtimgname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddconfig;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_config;
        private System.Windows.Forms.DataGridViewTextBoxColumn screenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn savename;
        private System.Windows.Forms.ContextMenuStrip cmsDgv;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_reatart;
        private System.Windows.Forms.TextBox txt_s;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_h;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
    }
}

