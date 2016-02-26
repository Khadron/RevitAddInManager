namespace Autumn.RevitAddInManager
{
	partial class FrmMain
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
			if(disposing && (components != null)) {
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtAppDllPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCmdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSchema = new System.Windows.Forms.ComboBox();
            this.btnAppSelect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxVersion = new System.Windows.Forms.ComboBox();
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.grgCmd = new System.Windows.Forms.GroupBox();
            this.btnCmdNewGuid = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbxVisibleMode = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkLBScope = new System.Windows.Forms.CheckedListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCmdText = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCmdDescription = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCmdAvailability = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCmdAssemblyFullName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCmdGuid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCmdDllPath = new System.Windows.Forms.TextBox();
            this.btnCmdSelect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grgApp = new System.Windows.Forms.GroupBox();
            this.btnAppNewGuid = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtAppAssemblyFullName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAppGuid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVendorId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVendorDescription = new System.Windows.Forms.TextBox();
            this.chkBxAtuoLoad = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAddInName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.flpContainer.SuspendLayout();
            this.grgCmd.SuspendLayout();
            this.grgApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(605, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成addin文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAppDllPath
            // 
            this.txtAppDllPath.Location = new System.Drawing.Point(142, 106);
            this.txtAppDllPath.Name = "txtAppDllPath";
            this.txtAppDllPath.ReadOnly = true;
            this.txtAppDllPath.Size = new System.Drawing.Size(353, 21);
            this.txtAppDllPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "扩展程序dll名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "命令名称：";
            // 
            // txtCmdName
            // 
            this.txtCmdName.Location = new System.Drawing.Point(142, 19);
            this.txtCmdName.Name = "txtCmdName";
            this.txtCmdName.Size = new System.Drawing.Size(129, 21);
            this.txtCmdName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "扩展模式：";
            // 
            // cbxSchema
            // 
            this.cbxSchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSchema.FormattingEnabled = true;
            this.cbxSchema.Location = new System.Drawing.Point(90, 53);
            this.cbxSchema.Name = "cbxSchema";
            this.cbxSchema.Size = new System.Drawing.Size(166, 20);
            this.cbxSchema.TabIndex = 6;
            this.cbxSchema.SelectedIndexChanged += new System.EventHandler(this.cbxSchema_SelectedIndexChanged);
            // 
            // btnAppSelect
            // 
            this.btnAppSelect.Location = new System.Drawing.Point(501, 104);
            this.btnAppSelect.Name = "btnAppSelect";
            this.btnAppSelect.Size = new System.Drawing.Size(49, 22);
            this.btnAppSelect.TabIndex = 7;
            this.btnAppSelect.Text = "选择";
            this.btnAppSelect.UseVisualStyleBackColor = true;
            this.btnAppSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "适用版本：";
            // 
            // cbxVersion
            // 
            this.cbxVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVersion.FormattingEnabled = true;
            this.cbxVersion.Location = new System.Drawing.Point(90, 84);
            this.cbxVersion.Name = "cbxVersion";
            this.cbxVersion.Size = new System.Drawing.Size(166, 20);
            this.cbxVersion.Sorted = true;
            this.cbxVersion.TabIndex = 9;
            // 
            // flpContainer
            // 
            this.flpContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpContainer.Controls.Add(this.grgCmd);
            this.flpContainer.Controls.Add(this.grgApp);
            this.flpContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContainer.Location = new System.Drawing.Point(14, 110);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(579, 446);
            this.flpContainer.TabIndex = 10;
            // 
            // grgCmd
            // 
            this.grgCmd.Controls.Add(this.btnCmdNewGuid);
            this.grgCmd.Controls.Add(this.label25);
            this.grgCmd.Controls.Add(this.label24);
            this.grgCmd.Controls.Add(this.label22);
            this.grgCmd.Controls.Add(this.cbxVisibleMode);
            this.grgCmd.Controls.Add(this.label20);
            this.grgCmd.Controls.Add(this.chkLBScope);
            this.grgCmd.Controls.Add(this.label18);
            this.grgCmd.Controls.Add(this.txtCmdText);
            this.grgCmd.Controls.Add(this.label17);
            this.grgCmd.Controls.Add(this.txtCmdDescription);
            this.grgCmd.Controls.Add(this.label16);
            this.grgCmd.Controls.Add(this.txtCmdAvailability);
            this.grgCmd.Controls.Add(this.label15);
            this.grgCmd.Controls.Add(this.txtCmdAssemblyFullName);
            this.grgCmd.Controls.Add(this.label9);
            this.grgCmd.Controls.Add(this.txtCmdGuid);
            this.grgCmd.Controls.Add(this.label7);
            this.grgCmd.Controls.Add(this.txtCmdDllPath);
            this.grgCmd.Controls.Add(this.btnCmdSelect);
            this.grgCmd.Controls.Add(this.label6);
            this.grgCmd.Controls.Add(this.label2);
            this.grgCmd.Controls.Add(this.txtCmdName);
            this.grgCmd.Location = new System.Drawing.Point(3, 3);
            this.grgCmd.Name = "grgCmd";
            this.grgCmd.Size = new System.Drawing.Size(562, 250);
            this.grgCmd.TabIndex = 0;
            this.grgCmd.TabStop = false;
            this.grgCmd.Text = "命令";
            // 
            // btnCmdNewGuid
            // 
            this.btnCmdNewGuid.Location = new System.Drawing.Point(501, 17);
            this.btnCmdNewGuid.Name = "btnCmdNewGuid";
            this.btnCmdNewGuid.Size = new System.Drawing.Size(49, 22);
            this.btnCmdNewGuid.TabIndex = 32;
            this.btnCmdNewGuid.Text = "新建";
            this.btnCmdNewGuid.UseVisualStyleBackColor = true;
            this.btnCmdNewGuid.Click += new System.EventHandler(this.btnCmdNewGuid_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(277, 97);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(11, 12);
            this.label25.TabIndex = 31;
            this.label25.Text = "*";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(277, 58);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(11, 12);
            this.label24.TabIndex = 30;
            this.label24.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(277, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(11, 12);
            this.label22.TabIndex = 28;
            this.label22.Text = "*";
            // 
            // cbxVisibleMode
            // 
            this.cbxVisibleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVisibleMode.FormattingEnabled = true;
            this.cbxVisibleMode.Location = new System.Drawing.Point(142, 163);
            this.cbxVisibleMode.Name = "cbxVisibleMode";
            this.cbxVisibleMode.Size = new System.Drawing.Size(206, 20);
            this.cbxVisibleMode.TabIndex = 27;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(71, 166);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 26;
            this.label20.Text = "启用条件：";
            // 
            // chkLBScope
            // 
            this.chkLBScope.CheckOnClick = true;
            this.chkLBScope.FormattingEnabled = true;
            this.chkLBScope.HorizontalScrollbar = true;
            this.chkLBScope.Location = new System.Drawing.Point(364, 101);
            this.chkLBScope.Name = "chkLBScope";
            this.chkLBScope.Size = new System.Drawing.Size(188, 132);
            this.chkLBScope.Sorted = true;
            this.chkLBScope.TabIndex = 25;
            this.chkLBScope.SelectedValueChanged += new System.EventHandler(this.chkLBScope_SelectedValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(295, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 23;
            this.label18.Text = "应用范围：";
            // 
            // txtCmdText
            // 
            this.txtCmdText.Location = new System.Drawing.Point(142, 94);
            this.txtCmdText.Name = "txtCmdText";
            this.txtCmdText.Size = new System.Drawing.Size(129, 21);
            this.txtCmdText.TabIndex = 22;
            this.txtCmdText.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(71, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 21;
            this.label17.Text = "按钮文本：";
            this.label17.Visible = false;
            // 
            // txtCmdDescription
            // 
            this.txtCmdDescription.Location = new System.Drawing.Point(366, 58);
            this.txtCmdDescription.Name = "txtCmdDescription";
            this.txtCmdDescription.Size = new System.Drawing.Size(129, 21);
            this.txtCmdDescription.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(295, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "命令描述：";
            // 
            // txtCmdAvailability
            // 
            this.txtCmdAvailability.Location = new System.Drawing.Point(142, 127);
            this.txtCmdAvailability.Name = "txtCmdAvailability";
            this.txtCmdAvailability.Size = new System.Drawing.Size(129, 21);
            this.txtCmdAvailability.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 12);
            this.label15.TabIndex = 17;
            this.label15.Text = "检查命令有效性类名：";
            // 
            // txtCmdAssemblyFullName
            // 
            this.txtCmdAssemblyFullName.Location = new System.Drawing.Point(142, 55);
            this.txtCmdAssemblyFullName.Name = "txtCmdAssemblyFullName";
            this.txtCmdAssemblyFullName.Size = new System.Drawing.Size(129, 21);
            this.txtCmdAssemblyFullName.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "实现命令全名称：";
            // 
            // txtCmdGuid
            // 
            this.txtCmdGuid.Location = new System.Drawing.Point(366, 19);
            this.txtCmdGuid.Name = "txtCmdGuid";
            this.txtCmdGuid.Size = new System.Drawing.Size(129, 21);
            this.txtCmdGuid.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Guid：";
            // 
            // txtCmdDllPath
            // 
            this.txtCmdDllPath.Location = new System.Drawing.Point(142, 206);
            this.txtCmdDllPath.Name = "txtCmdDllPath";
            this.txtCmdDllPath.ReadOnly = true;
            this.txtCmdDllPath.Size = new System.Drawing.Size(149, 21);
            this.txtCmdDllPath.TabIndex = 8;
            // 
            // btnCmdSelect
            // 
            this.btnCmdSelect.Location = new System.Drawing.Point(299, 204);
            this.btnCmdSelect.Name = "btnCmdSelect";
            this.btnCmdSelect.Size = new System.Drawing.Size(49, 22);
            this.btnCmdSelect.TabIndex = 10;
            this.btnCmdSelect.Text = "选择";
            this.btnCmdSelect.UseVisualStyleBackColor = true;
            this.btnCmdSelect.Click += new System.EventHandler(this.btnCmdSelect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "扩展命令dll名称：";
            // 
            // grgApp
            // 
            this.grgApp.Controls.Add(this.btnAppNewGuid);
            this.grgApp.Controls.Add(this.label27);
            this.grgApp.Controls.Add(this.label26);
            this.grgApp.Controls.Add(this.txtAppAssemblyFullName);
            this.grgApp.Controls.Add(this.label10);
            this.grgApp.Controls.Add(this.txtAppGuid);
            this.grgApp.Controls.Add(this.label8);
            this.grgApp.Controls.Add(this.txtAppName);
            this.grgApp.Controls.Add(this.txtAppDllPath);
            this.grgApp.Controls.Add(this.btnAppSelect);
            this.grgApp.Controls.Add(this.label5);
            this.grgApp.Controls.Add(this.label1);
            this.grgApp.Location = new System.Drawing.Point(3, 259);
            this.grgApp.Name = "grgApp";
            this.grgApp.Size = new System.Drawing.Size(562, 162);
            this.grgApp.TabIndex = 1;
            this.grgApp.TabStop = false;
            this.grgApp.Text = "程序";
            // 
            // btnAppNewGuid
            // 
            this.btnAppNewGuid.Location = new System.Drawing.Point(501, 63);
            this.btnAppNewGuid.Name = "btnAppNewGuid";
            this.btnAppNewGuid.Size = new System.Drawing.Size(49, 22);
            this.btnAppNewGuid.TabIndex = 33;
            this.btnAppNewGuid.Text = "新建";
            this.btnAppNewGuid.UseVisualStyleBackColor = true;
            this.btnAppNewGuid.Click += new System.EventHandler(this.btnAppNewGuid_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(277, 33);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(11, 12);
            this.label27.TabIndex = 32;
            this.label27.Text = "*";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(277, 68);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(11, 12);
            this.label26.TabIndex = 31;
            this.label26.Text = "*";
            // 
            // txtAppAssemblyFullName
            // 
            this.txtAppAssemblyFullName.Location = new System.Drawing.Point(142, 67);
            this.txtAppAssemblyFullName.Name = "txtAppAssemblyFullName";
            this.txtAppAssemblyFullName.Size = new System.Drawing.Size(129, 21);
            this.txtAppAssemblyFullName.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "实现命令全名称：";
            // 
            // txtAppGuid
            // 
            this.txtAppGuid.Location = new System.Drawing.Point(366, 64);
            this.txtAppGuid.Name = "txtAppGuid";
            this.txtAppGuid.Size = new System.Drawing.Size(129, 21);
            this.txtAppGuid.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Guid：";
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(142, 30);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(129, 21);
            this.txtAppName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "程序名称：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "供应商Id：";
            // 
            // txtVendorId
            // 
            this.txtVendorId.Location = new System.Drawing.Point(371, 19);
            this.txtVendorId.Name = "txtVendorId";
            this.txtVendorId.Size = new System.Drawing.Size(166, 21);
            this.txtVendorId.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "供应商描述：";
            // 
            // txtVendorDescription
            // 
            this.txtVendorDescription.Location = new System.Drawing.Point(371, 53);
            this.txtVendorDescription.Name = "txtVendorDescription";
            this.txtVendorDescription.Size = new System.Drawing.Size(166, 21);
            this.txtVendorDescription.TabIndex = 18;
            // 
            // chkBxAtuoLoad
            // 
            this.chkBxAtuoLoad.AutoSize = true;
            this.chkBxAtuoLoad.Checked = true;
            this.chkBxAtuoLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxAtuoLoad.Location = new System.Drawing.Point(464, 86);
            this.chkBxAtuoLoad.Name = "chkBxAtuoLoad";
            this.chkBxAtuoLoad.Size = new System.Drawing.Size(96, 16);
            this.chkBxAtuoLoad.TabIndex = 21;
            this.chkBxAtuoLoad.Text = "是否自动加载";
            this.chkBxAtuoLoad.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 22;
            this.label19.Text = "文件名称：";
            // 
            // txtAddInName
            // 
            this.txtAddInName.Location = new System.Drawing.Point(90, 19);
            this.txtAddInName.Name = "txtAddInName";
            this.txtAddInName.Size = new System.Drawing.Size(166, 21);
            this.txtAddInName.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(544, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(544, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(262, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 12);
            this.label21.TabIndex = 26;
            this.label21.Text = "*";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 604);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAddInName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.chkBxAtuoLoad);
            this.Controls.Add(this.txtVendorDescription);
            this.Controls.Add(this.flpContainer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxVersion);
            this.Controls.Add(this.txtVendorId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxSchema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revit扩展addin文件生成器";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.flpContainer.ResumeLayout(false);
            this.grgCmd.ResumeLayout(false);
            this.grgCmd.PerformLayout();
            this.grgApp.ResumeLayout(false);
            this.grgApp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtAppDllPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCmdName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbxSchema;
		private System.Windows.Forms.Button btnAppSelect;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbxVersion;
		private System.Windows.Forms.FlowLayoutPanel flpContainer;
		private System.Windows.Forms.GroupBox grgCmd;
		private System.Windows.Forms.GroupBox grgApp;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtAppName;
		private System.Windows.Forms.TextBox txtCmdAssemblyFullName;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCmdGuid;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCmdDllPath;
		private System.Windows.Forms.Button btnCmdSelect;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAppAssemblyFullName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtAppGuid;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtVendorId;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtVendorDescription;
		private System.Windows.Forms.CheckBox chkBxAtuoLoad;
		private System.Windows.Forms.TextBox txtCmdAvailability;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtCmdDescription;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtCmdText;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.CheckedListBox chkLBScope;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtAddInName;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox cbxVisibleMode;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Button btnCmdNewGuid;
		private System.Windows.Forms.Button btnAppNewGuid;
	}
}

