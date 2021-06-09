
namespace hypervSetting
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nameChangeBtn = new System.Windows.Forms.Button();
            this.new_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.old_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.portproxyDelBtn = new System.Windows.Forms.Button();
            this.connectaddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.connectport = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.listenport = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.defaultChk = new System.Windows.Forms.RadioButton();
            this.customChk = new System.Windows.Forms.RadioButton();
            this.pasteChk = new System.Windows.Forms.RadioButton();
            this.portproxyResetBtn = new System.Windows.Forms.Button();
            this.portproxyAddBtn = new System.Windows.Forms.Button();
            this.portproxyViewBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WAS_DEV = new System.Windows.Forms.TextBox();
            this.WAS_PRD = new System.Windows.Forms.TextBox();
            this.SAP_DEV = new System.Windows.Forms.TextBox();
            this.SAP_QAS = new System.Windows.Forms.TextBox();
            this.SAP_PRD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.new_Ip = new System.Windows.Forms.TextBox();
            this.ipChangeBtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.old_Ip = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.portproxyViewBox = new System.Windows.Forms.TextBox();
            this.portproxyViewBoxBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pasteBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listenport)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 532);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.nameChangeBtn);
            this.tabPage1.Controls.Add(this.new_Name);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.old_Name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HostName";
            // 
            // nameChangeBtn
            // 
            this.nameChangeBtn.BackColor = System.Drawing.Color.White;
            this.nameChangeBtn.Location = new System.Drawing.Point(326, 367);
            this.nameChangeBtn.Name = "nameChangeBtn";
            this.nameChangeBtn.Size = new System.Drawing.Size(182, 42);
            this.nameChangeBtn.TabIndex = 4;
            this.nameChangeBtn.Text = "변경";
            this.nameChangeBtn.UseVisualStyleBackColor = false;
            this.nameChangeBtn.Click += new System.EventHandler(this.nameChangeBtn_Click);
            // 
            // new_Name
            // 
            this.new_Name.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.new_Name.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.new_Name.Location = new System.Drawing.Point(437, 200);
            this.new_Name.MaxLength = 20;
            this.new_Name.Multiline = true;
            this.new_Name.Name = "new_Name";
            this.new_Name.Size = new System.Drawing.Size(261, 47);
            this.new_Name.TabIndex = 3;
            this.new_Name.Text = "local-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(162, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "변경할 호스트 네임 : ";
            // 
            // old_Name
            // 
            this.old_Name.AutoSize = true;
            this.old_Name.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.old_Name.Location = new System.Drawing.Point(456, 108);
            this.old_Name.Name = "old_Name";
            this.old_Name.Size = new System.Drawing.Size(128, 32);
            this.old_Name.TabIndex = 1;
            this.old_Name.Text = "HostName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(186, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재 호스트 네임 : ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.defaultChk);
            this.tabPage2.Controls.Add(this.customChk);
            this.tabPage2.Controls.Add(this.pasteChk);
            this.tabPage2.Controls.Add(this.portproxyResetBtn);
            this.tabPage2.Controls.Add(this.portproxyAddBtn);
            this.tabPage2.Controls.Add(this.portproxyViewBtn);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PortProxy";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.portproxyDelBtn);
            this.panel2.Controls.Add(this.connectaddress);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.connectport);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.listenport);
            this.panel2.Controls.Add(this.label13);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 446);
            this.panel2.TabIndex = 30;
            this.panel2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(484, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "※삭제 시에는 listenport만 적어도됨.";
            // 
            // portproxyDelBtn
            // 
            this.portproxyDelBtn.BackColor = System.Drawing.Color.White;
            this.portproxyDelBtn.Location = new System.Drawing.Point(296, 322);
            this.portproxyDelBtn.Name = "portproxyDelBtn";
            this.portproxyDelBtn.Size = new System.Drawing.Size(182, 42);
            this.portproxyDelBtn.TabIndex = 43;
            this.portproxyDelBtn.Text = "삭제";
            this.portproxyDelBtn.UseVisualStyleBackColor = false;
            this.portproxyDelBtn.Click += new System.EventHandler(this.portproxyDelBtn_Click);
            // 
            // connectaddress
            // 
            this.connectaddress.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.connectaddress.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.connectaddress.Location = new System.Drawing.Point(296, 246);
            this.connectaddress.MaxLength = 20;
            this.connectaddress.Multiline = true;
            this.connectaddress.Name = "connectaddress";
            this.connectaddress.Size = new System.Drawing.Size(386, 41);
            this.connectaddress.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(41, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 32);
            this.label11.TabIndex = 37;
            this.label11.Text = "connectaddress : ";
            // 
            // connectport
            // 
            this.connectport.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.connectport.Location = new System.Drawing.Point(373, 173);
            this.connectport.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.connectport.Name = "connectport";
            this.connectport.Size = new System.Drawing.Size(209, 35);
            this.connectport.TabIndex = 29;
            this.connectport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(78, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 32);
            this.label12.TabIndex = 36;
            this.label12.Text = "connectport : ";
            // 
            // listenport
            // 
            this.listenport.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listenport.Location = new System.Drawing.Point(373, 117);
            this.listenport.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.listenport.Name = "listenport";
            this.listenport.Size = new System.Drawing.Size(209, 35);
            this.listenport.TabIndex = 28;
            this.listenport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(106, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 32);
            this.label13.TabIndex = 30;
            this.label13.Text = "listenport : ";
            // 
            // defaultChk
            // 
            this.defaultChk.AutoSize = true;
            this.defaultChk.Checked = true;
            this.defaultChk.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.defaultChk.Location = new System.Drawing.Point(798, 15);
            this.defaultChk.Name = "defaultChk";
            this.defaultChk.Size = new System.Drawing.Size(80, 25);
            this.defaultChk.TabIndex = 45;
            this.defaultChk.TabStop = true;
            this.defaultChk.Text = "Default";
            this.defaultChk.UseVisualStyleBackColor = true;
            this.defaultChk.CheckedChanged += new System.EventHandler(this.defaultChk_CheckedChanged);
            // 
            // customChk
            // 
            this.customChk.AutoSize = true;
            this.customChk.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customChk.Location = new System.Drawing.Point(798, 68);
            this.customChk.Name = "customChk";
            this.customChk.Size = new System.Drawing.Size(84, 25);
            this.customChk.TabIndex = 44;
            this.customChk.Text = "Custom";
            this.customChk.UseVisualStyleBackColor = true;
            this.customChk.CheckedChanged += new System.EventHandler(this.customChk_CheckedChanged);
            // 
            // pasteChk
            // 
            this.pasteChk.AutoSize = true;
            this.pasteChk.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pasteChk.Location = new System.Drawing.Point(797, 121);
            this.pasteChk.Name = "pasteChk";
            this.pasteChk.Size = new System.Drawing.Size(67, 25);
            this.pasteChk.TabIndex = 43;
            this.pasteChk.Text = "Paste";
            this.pasteChk.UseVisualStyleBackColor = true;
            this.pasteChk.CheckedChanged += new System.EventHandler(this.pasteChk_CheckedChanged);
            // 
            // portproxyResetBtn
            // 
            this.portproxyResetBtn.BackColor = System.Drawing.Color.White;
            this.portproxyResetBtn.Location = new System.Drawing.Point(592, 458);
            this.portproxyResetBtn.Name = "portproxyResetBtn";
            this.portproxyResetBtn.Size = new System.Drawing.Size(182, 42);
            this.portproxyResetBtn.TabIndex = 42;
            this.portproxyResetBtn.Text = "초기화";
            this.portproxyResetBtn.UseVisualStyleBackColor = false;
            this.portproxyResetBtn.Click += new System.EventHandler(this.portproxyResetBtn_Click);
            // 
            // portproxyAddBtn
            // 
            this.portproxyAddBtn.BackColor = System.Drawing.Color.White;
            this.portproxyAddBtn.Location = new System.Drawing.Point(90, 458);
            this.portproxyAddBtn.Name = "portproxyAddBtn";
            this.portproxyAddBtn.Size = new System.Drawing.Size(182, 42);
            this.portproxyAddBtn.TabIndex = 6;
            this.portproxyAddBtn.Text = "추가";
            this.portproxyAddBtn.UseVisualStyleBackColor = false;
            this.portproxyAddBtn.Click += new System.EventHandler(this.portproxyAddBtn_Click);
            // 
            // portproxyViewBtn
            // 
            this.portproxyViewBtn.BackColor = System.Drawing.Color.White;
            this.portproxyViewBtn.Location = new System.Drawing.Point(341, 458);
            this.portproxyViewBtn.Name = "portproxyViewBtn";
            this.portproxyViewBtn.Size = new System.Drawing.Size(182, 42);
            this.portproxyViewBtn.TabIndex = 27;
            this.portproxyViewBtn.Text = "조회";
            this.portproxyViewBtn.UseVisualStyleBackColor = false;
            this.portproxyViewBtn.Click += new System.EventHandler(this.portproxyViewBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.WAS_DEV);
            this.panel1.Controls.Add(this.WAS_PRD);
            this.panel1.Controls.Add(this.SAP_DEV);
            this.panel1.Controls.Add(this.SAP_QAS);
            this.panel1.Controls.Add(this.SAP_PRD);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 443);
            this.panel1.TabIndex = 41;
            // 
            // WAS_DEV
            // 
            this.WAS_DEV.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WAS_DEV.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.WAS_DEV.Location = new System.Drawing.Point(259, 27);
            this.WAS_DEV.MaxLength = 20;
            this.WAS_DEV.Multiline = true;
            this.WAS_DEV.Name = "WAS_DEV";
            this.WAS_DEV.Size = new System.Drawing.Size(376, 42);
            this.WAS_DEV.TabIndex = 28;
            // 
            // WAS_PRD
            // 
            this.WAS_PRD.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WAS_PRD.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.WAS_PRD.Location = new System.Drawing.Point(259, 102);
            this.WAS_PRD.MaxLength = 20;
            this.WAS_PRD.Multiline = true;
            this.WAS_PRD.Name = "WAS_PRD";
            this.WAS_PRD.Size = new System.Drawing.Size(376, 42);
            this.WAS_PRD.TabIndex = 36;
            // 
            // SAP_DEV
            // 
            this.SAP_DEV.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SAP_DEV.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.SAP_DEV.Location = new System.Drawing.Point(259, 175);
            this.SAP_DEV.MaxLength = 20;
            this.SAP_DEV.Multiline = true;
            this.SAP_DEV.Name = "SAP_DEV";
            this.SAP_DEV.Size = new System.Drawing.Size(376, 42);
            this.SAP_DEV.TabIndex = 37;
            // 
            // SAP_QAS
            // 
            this.SAP_QAS.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SAP_QAS.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.SAP_QAS.Location = new System.Drawing.Point(259, 252);
            this.SAP_QAS.MaxLength = 20;
            this.SAP_QAS.Multiline = true;
            this.SAP_QAS.Name = "SAP_QAS";
            this.SAP_QAS.Size = new System.Drawing.Size(376, 42);
            this.SAP_QAS.TabIndex = 38;
            // 
            // SAP_PRD
            // 
            this.SAP_PRD.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SAP_PRD.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.SAP_PRD.Location = new System.Drawing.Point(259, 325);
            this.SAP_PRD.MaxLength = 20;
            this.SAP_PRD.Multiline = true;
            this.SAP_PRD.Name = "SAP_PRD";
            this.SAP_PRD.Size = new System.Drawing.Size(376, 42);
            this.SAP_PRD.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(45, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 32);
            this.label15.TabIndex = 35;
            this.label15.Text = "SAP PRD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(45, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 32);
            this.label14.TabIndex = 33;
            this.label14.Text = "SAP QAS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(49, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 32);
            this.label9.TabIndex = 31;
            this.label9.Text = "SAP DEV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(45, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 32);
            this.label8.TabIndex = 29;
            this.label8.Text = "WAS PRD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(45, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 32);
            this.label10.TabIndex = 26;
            this.label10.Text = "WAS DEV";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.new_Ip);
            this.tabPage3.Controls.Add(this.ipChangeBtn);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.old_Ip);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(885, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "IP";
            // 
            // new_Ip
            // 
            this.new_Ip.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.new_Ip.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.new_Ip.Location = new System.Drawing.Point(365, 195);
            this.new_Ip.MaxLength = 20;
            this.new_Ip.Multiline = true;
            this.new_Ip.Name = "new_Ip";
            this.new_Ip.Size = new System.Drawing.Size(376, 42);
            this.new_Ip.TabIndex = 101;
            // 
            // ipChangeBtn
            // 
            this.ipChangeBtn.BackColor = System.Drawing.Color.White;
            this.ipChangeBtn.Location = new System.Drawing.Point(351, 347);
            this.ipChangeBtn.Name = "ipChangeBtn";
            this.ipChangeBtn.Size = new System.Drawing.Size(182, 42);
            this.ipChangeBtn.TabIndex = 5;
            this.ipChangeBtn.Text = "변경";
            this.ipChangeBtn.UseVisualStyleBackColor = false;
            this.ipChangeBtn.Click += new System.EventHandler(this.ipChangeBtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(182, 197);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(168, 32);
            this.label19.TabIndex = 100;
            this.label19.Text = "변경 IP 정보 : ";
            // 
            // old_Ip
            // 
            this.old_Ip.AutoSize = true;
            this.old_Ip.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.old_Ip.Location = new System.Drawing.Point(476, 149);
            this.old_Ip.Name = "old_Ip";
            this.old_Ip.Size = new System.Drawing.Size(35, 32);
            this.old_Ip.TabIndex = 100;
            this.old_Ip.Text = "IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(182, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 32);
            this.label5.TabIndex = 100;
            this.label5.Text = "현재 IP 정보 : ";
            // 
            // portproxyViewBox
            // 
            this.portproxyViewBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.portproxyViewBox.Location = new System.Drawing.Point(0, 0);
            this.portproxyViewBox.Margin = new System.Windows.Forms.Padding(0);
            this.portproxyViewBox.Multiline = true;
            this.portproxyViewBox.Name = "portproxyViewBox";
            this.portproxyViewBox.ReadOnly = true;
            this.portproxyViewBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.portproxyViewBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.portproxyViewBox.Size = new System.Drawing.Size(892, 447);
            this.portproxyViewBox.TabIndex = 45;
            // 
            // portproxyViewBoxBtn
            // 
            this.portproxyViewBoxBtn.Location = new System.Drawing.Point(372, 459);
            this.portproxyViewBoxBtn.Name = "portproxyViewBoxBtn";
            this.portproxyViewBoxBtn.Size = new System.Drawing.Size(107, 41);
            this.portproxyViewBoxBtn.TabIndex = 46;
            this.portproxyViewBoxBtn.Text = "닫기";
            this.portproxyViewBoxBtn.UseVisualStyleBackColor = true;
            this.portproxyViewBoxBtn.Click += new System.EventHandler(this.portproxyViewBoxBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.portproxyViewBoxBtn);
            this.panel3.Controls.Add(this.portproxyViewBox);
            this.panel3.Location = new System.Drawing.Point(12, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 506);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pasteBox);
            this.panel4.Location = new System.Drawing.Point(3, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(782, 421);
            this.panel4.TabIndex = 46;
            // 
            // pasteBox
            // 
            this.pasteBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pasteBox.Location = new System.Drawing.Point(12, 0);
            this.pasteBox.Multiline = true;
            this.pasteBox.Name = "pasteBox";
            this.pasteBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pasteBox.Size = new System.Drawing.Size(770, 421);
            this.pasteBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(913, 538);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Unipost-Web 운영팀";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listenport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label old_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox new_Name;
        private System.Windows.Forms.Button nameChangeBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ipChangeBtn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label old_Ip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button portproxyAddBtn;
        private System.Windows.Forms.Button portproxyViewBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown connectport;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown listenport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox connectaddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SAP_PRD;
        private System.Windows.Forms.TextBox SAP_QAS;
        private System.Windows.Forms.TextBox SAP_DEV;
        private System.Windows.Forms.TextBox WAS_PRD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox WAS_DEV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox new_Ip;
        private System.Windows.Forms.Button portproxyResetBtn;
        private System.Windows.Forms.Button portproxyDelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portproxyViewBox;
        private System.Windows.Forms.Button portproxyViewBoxBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton customChk;
        private System.Windows.Forms.RadioButton pasteChk;
        private System.Windows.Forms.RadioButton defaultChk;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox pasteBox;
    }
}

