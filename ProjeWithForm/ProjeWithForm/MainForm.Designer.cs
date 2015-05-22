namespace ProjeWithForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asHEXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asMIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEBUGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usingGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtR1 = new BorderedTextBox.TextBoxEx();
            this.txtR2 = new BorderedTextBox.TextBoxEx();
            this.txtR3 = new BorderedTextBox.TextBoxEx();
            this.txtR4 = new BorderedTextBox.TextBoxEx();
            this.ilStartStopButton = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.cbConvType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCodeBlock = new System.Windows.Forms.Panel();
            this.rtbAssemblyCodeView = new System.Windows.Forms.RichTextBox();
            this.cmsAssemblyCodeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAssemblyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAssemblyCodes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbMicroOp = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOverflowFlag = new System.Windows.Forms.Label();
            this.lblZeroFlag = new System.Windows.Forms.Label();
            this.lblCarryFlag = new System.Windows.Forms.Label();
            this.lblFullFlag = new System.Windows.Forms.Label();
            this.lblEmptyFlag = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btInRegister = new System.Windows.Forms.Button();
            this.txtSP = new BorderedTextBox.TextBoxEx();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIR = new BorderedTextBox.TextBoxEx();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOUT = new BorderedTextBox.TextBoxEx();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIN = new BorderedTextBox.TextBoxEx();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAR = new BorderedTextBox.TextBoxEx();
            this.txtPC = new BorderedTextBox.TextBoxEx();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAR = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtShowValue = new System.Windows.Forms.TextBox();
            this.dGridStack = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dGridInstruction = new System.Windows.Forms.DataGridView();
            this.txtShowOpcode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dGridData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dGridLabel = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pbOverflowFlag = new System.Windows.Forms.PictureBox();
            this.pbZeroFlag = new System.Windows.Forms.PictureBox();
            this.pbCarryFlag = new System.Windows.Forms.PictureBox();
            this.pbFullFlag = new System.Windows.Forms.PictureBox();
            this.pbEmptyFlag = new System.Windows.Forms.PictureBox();
            this.btNextStep = new System.Windows.Forms.Button();
            this.btNextInstruction = new System.Windows.Forms.Button();
            this.btStartStopDebugging = new System.Windows.Forms.Button();
            this.startDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopDebuggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextInstructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepByStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMinimizeFrm = new System.Windows.Forms.Button();
            this.btMaxMinFrm = new System.Windows.Forms.Button();
            this.btCloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDEU = new System.Windows.Forms.Label();
            this.lineNumbers_For_AssemblyCodeView = new LineNumbers.LineNumbers_For_RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.pnlCodeBlock.SuspendLayout();
            this.cmsAssemblyCodeView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridInstruction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverflowFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZeroFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarryFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFullFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmptyFlag)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.dEBUGToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fILEToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asHEXToolStripMenuItem,
            this.asMIFToolStripMenuItem});
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // asHEXToolStripMenuItem
            // 
            this.asHEXToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.asHEXToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.asHEXToolStripMenuItem.Name = "asHEXToolStripMenuItem";
            this.asHEXToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.asHEXToolStripMenuItem.Text = "As HEX";
            this.asHEXToolStripMenuItem.Click += new System.EventHandler(this.asHEXToolStripMenuItem_Click);
            // 
            // asMIFToolStripMenuItem
            // 
            this.asMIFToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.asMIFToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.asMIFToolStripMenuItem.Name = "asMIFToolStripMenuItem";
            this.asMIFToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.asMIFToolStripMenuItem.Text = "As MIF";
            this.asMIFToolStripMenuItem.Click += new System.EventHandler(this.asMIFToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // dEBUGToolStripMenuItem
            // 
            this.dEBUGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startDebugToolStripMenuItem,
            this.stopDebuggingToolStripMenuItem,
            this.nextInstructionToolStripMenuItem,
            this.stepByStepToolStripMenuItem});
            this.dEBUGToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.dEBUGToolStripMenuItem.Name = "dEBUGToolStripMenuItem";
            this.dEBUGToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.dEBUGToolStripMenuItem.Text = "DEBUG";
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usingGuideToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.hELPToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // usingGuideToolStripMenuItem
            // 
            this.usingGuideToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.usingGuideToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.usingGuideToolStripMenuItem.Name = "usingGuideToolStripMenuItem";
            this.usingGuideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.usingGuideToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.usingGuideToolStripMenuItem.Text = "Using Guide";
            this.usingGuideToolStripMenuItem.Click += new System.EventHandler(this.usingGuideToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txtR1
            // 
            this.txtR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtR1.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtR1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(240)))), ((int)(((byte)(19)))));
            this.txtR1.Location = new System.Drawing.Point(58, 85);
            this.txtR1.Name = "txtR1";
            this.txtR1.Padding = new System.Windows.Forms.Padding(1);
            this.txtR1.readOnly = true;
            this.txtR1.Size = new System.Drawing.Size(50, 23);
            this.txtR1.TabIndex = 2;
            this.txtR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtR1.textBoxFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtR1.textBoxSize = new System.Drawing.Size(50, 23);
            this.toolTip1.SetToolTip(this.txtR1, "Register 1");
            // 
            // txtR2
            // 
            this.txtR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtR2.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtR2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(240)))), ((int)(((byte)(19)))));
            this.txtR2.Location = new System.Drawing.Point(58, 114);
            this.txtR2.Name = "txtR2";
            this.txtR2.Padding = new System.Windows.Forms.Padding(1);
            this.txtR2.readOnly = true;
            this.txtR2.Size = new System.Drawing.Size(50, 23);
            this.txtR2.TabIndex = 4;
            this.txtR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtR2.textBoxFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtR2.textBoxSize = new System.Drawing.Size(50, 23);
            this.toolTip1.SetToolTip(this.txtR2, "Register 1");
            // 
            // txtR3
            // 
            this.txtR3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtR3.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtR3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(240)))), ((int)(((byte)(19)))));
            this.txtR3.Location = new System.Drawing.Point(58, 143);
            this.txtR3.Name = "txtR3";
            this.txtR3.Padding = new System.Windows.Forms.Padding(1);
            this.txtR3.readOnly = true;
            this.txtR3.Size = new System.Drawing.Size(50, 23);
            this.txtR3.TabIndex = 6;
            this.txtR3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtR3.textBoxFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtR3.textBoxSize = new System.Drawing.Size(50, 23);
            this.toolTip1.SetToolTip(this.txtR3, "Register 1");
            // 
            // txtR4
            // 
            this.txtR4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtR4.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtR4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(240)))), ((int)(((byte)(19)))));
            this.txtR4.Location = new System.Drawing.Point(58, 172);
            this.txtR4.Name = "txtR4";
            this.txtR4.Padding = new System.Windows.Forms.Padding(1);
            this.txtR4.readOnly = true;
            this.txtR4.Size = new System.Drawing.Size(50, 23);
            this.txtR4.TabIndex = 7;
            this.txtR4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtR4.textBoxFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR4.textBoxSize = new System.Drawing.Size(50, 23);
            this.toolTip1.SetToolTip(this.txtR4, "Register 1");
            // 
            // ilStartStopButton
            // 
            this.ilStartStopButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilStartStopButton.ImageStream")));
            this.ilStartStopButton.TransparentColor = System.Drawing.Color.Transparent;
            this.ilStartStopButton.Images.SetKeyName(0, "play_button_green_16.png");
            this.ilStartStopButton.Images.SetKeyName(1, "stop_button_16.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(222)))), ((int)(((byte)(39)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1199, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 651);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(222)))), ((int)(((byte)(39)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 651);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(222)))), ((int)(((byte)(39)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 699);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1198, 1);
            this.panel4.TabIndex = 4;
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.pnlTools.Controls.Add(this.btNextStep);
            this.pnlTools.Controls.Add(this.btNextInstruction);
            this.pnlTools.Controls.Add(this.btStartStopDebugging);
            this.pnlTools.Controls.Add(this.cbConvType);
            this.pnlTools.Controls.Add(this.label2);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Location = new System.Drawing.Point(1, 49);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(1198, 29);
            this.pnlTools.TabIndex = 5;
            // 
            // cbConvType
            // 
            this.cbConvType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConvType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbConvType.FormattingEnabled = true;
            this.cbConvType.Items.AddRange(new object[] {
            "Binary",
            "Hexadecimal",
            "Decimal"});
            this.cbConvType.Location = new System.Drawing.Point(102, 4);
            this.cbConvType.Name = "cbConvType";
            this.cbConvType.Size = new System.Drawing.Size(121, 21);
            this.cbConvType.TabIndex = 1;
            this.cbConvType.SelectedIndexChanged += new System.EventHandler(this.cbConvType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Conversion Type:";
            // 
            // pnlCodeBlock
            // 
            this.pnlCodeBlock.BackColor = System.Drawing.Color.LightGray;
            this.pnlCodeBlock.Controls.Add(this.lineNumbers_For_AssemblyCodeView);
            this.pnlCodeBlock.Controls.Add(this.rtbAssemblyCodeView);
            this.pnlCodeBlock.Controls.Add(this.lbAssemblyCodes);
            this.pnlCodeBlock.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCodeBlock.Location = new System.Drawing.Point(1, 78);
            this.pnlCodeBlock.Name = "pnlCodeBlock";
            this.pnlCodeBlock.Size = new System.Drawing.Size(270, 621);
            this.pnlCodeBlock.TabIndex = 6;
            // 
            // rtbAssemblyCodeView
            // 
            this.rtbAssemblyCodeView.AcceptsTab = true;
            this.rtbAssemblyCodeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbAssemblyCodeView.BackColor = System.Drawing.Color.White;
            this.rtbAssemblyCodeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAssemblyCodeView.ContextMenuStrip = this.cmsAssemblyCodeView;
            this.rtbAssemblyCodeView.Font = new System.Drawing.Font("Source Sans Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAssemblyCodeView.Location = new System.Drawing.Point(46, 324);
            this.rtbAssemblyCodeView.Name = "rtbAssemblyCodeView";
            this.rtbAssemblyCodeView.ReadOnly = true;
            this.rtbAssemblyCodeView.Size = new System.Drawing.Size(212, 286);
            this.rtbAssemblyCodeView.TabIndex = 1;
            this.rtbAssemblyCodeView.Text = "";
            this.rtbAssemblyCodeView.WordWrap = false;
            this.rtbAssemblyCodeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbAssemblyCodeView_MouseClick);
            // 
            // cmsAssemblyCodeView
            // 
            this.cmsAssemblyCodeView.BackColor = System.Drawing.Color.DarkGray;
            this.cmsAssemblyCodeView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmsAssemblyCodeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAssemblyMenuItem});
            this.cmsAssemblyCodeView.Name = "cmsAssemblyCodeView";
            this.cmsAssemblyCodeView.ShowImageMargin = false;
            this.cmsAssemblyCodeView.Size = new System.Drawing.Size(154, 26);
            // 
            // EditAssemblyMenuItem
            // 
            this.EditAssemblyMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.EditAssemblyMenuItem.Enabled = false;
            this.EditAssemblyMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(222)))), ((int)(((byte)(39)))));
            this.EditAssemblyMenuItem.Name = "EditAssemblyMenuItem";
            this.EditAssemblyMenuItem.Size = new System.Drawing.Size(153, 22);
            this.EditAssemblyMenuItem.Text = "Edit Assembly Code";
            // 
            // lbAssemblyCodes
            // 
            this.lbAssemblyCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAssemblyCodes.FormattingEnabled = true;
            this.lbAssemblyCodes.Location = new System.Drawing.Point(11, 19);
            this.lbAssemblyCodes.Name = "lbAssemblyCodes";
            this.lbAssemblyCodes.Size = new System.Drawing.Size(247, 303);
            this.lbAssemblyCodes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.rtbMicroOp);
            this.groupBox1.Location = new System.Drawing.Point(759, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 141);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Micro Operations";
            // 
            // rtbMicroOp
            // 
            this.rtbMicroOp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbMicroOp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMicroOp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbMicroOp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMicroOp.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMicroOp.Location = new System.Drawing.Point(3, 16);
            this.rtbMicroOp.Name = "rtbMicroOp";
            this.rtbMicroOp.ReadOnly = true;
            this.rtbMicroOp.Size = new System.Drawing.Size(431, 122);
            this.rtbMicroOp.TabIndex = 0;
            this.rtbMicroOp.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.pbOverflowFlag);
            this.groupBox2.Controls.Add(this.lblOverflowFlag);
            this.groupBox2.Controls.Add(this.pbZeroFlag);
            this.groupBox2.Controls.Add(this.lblZeroFlag);
            this.groupBox2.Controls.Add(this.pbCarryFlag);
            this.groupBox2.Controls.Add(this.lblCarryFlag);
            this.groupBox2.Controls.Add(this.pbFullFlag);
            this.groupBox2.Controls.Add(this.lblFullFlag);
            this.groupBox2.Controls.Add(this.lblEmptyFlag);
            this.groupBox2.Controls.Add(this.pbEmptyFlag);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(759, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 85);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flags";
            // 
            // lblOverflowFlag
            // 
            this.lblOverflowFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOverflowFlag.AutoSize = true;
            this.lblOverflowFlag.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOverflowFlag.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOverflowFlag.Location = new System.Drawing.Point(364, 40);
            this.lblOverflowFlag.Name = "lblOverflowFlag";
            this.lblOverflowFlag.Size = new System.Drawing.Size(30, 15);
            this.lblOverflowFlag.TabIndex = 13;
            this.lblOverflowFlag.Text = "True";
            // 
            // lblZeroFlag
            // 
            this.lblZeroFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZeroFlag.AutoSize = true;
            this.lblZeroFlag.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZeroFlag.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblZeroFlag.Location = new System.Drawing.Point(215, 55);
            this.lblZeroFlag.Name = "lblZeroFlag";
            this.lblZeroFlag.Size = new System.Drawing.Size(30, 15);
            this.lblZeroFlag.TabIndex = 11;
            this.lblZeroFlag.Text = "True";
            // 
            // lblCarryFlag
            // 
            this.lblCarryFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCarryFlag.AutoSize = true;
            this.lblCarryFlag.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarryFlag.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCarryFlag.Location = new System.Drawing.Point(215, 27);
            this.lblCarryFlag.Name = "lblCarryFlag";
            this.lblCarryFlag.Size = new System.Drawing.Size(30, 15);
            this.lblCarryFlag.TabIndex = 9;
            this.lblCarryFlag.Text = "True";
            // 
            // lblFullFlag
            // 
            this.lblFullFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullFlag.AutoSize = true;
            this.lblFullFlag.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFullFlag.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFullFlag.Location = new System.Drawing.Point(94, 55);
            this.lblFullFlag.Name = "lblFullFlag";
            this.lblFullFlag.Size = new System.Drawing.Size(30, 15);
            this.lblFullFlag.TabIndex = 7;
            this.lblFullFlag.Text = "True";
            // 
            // lblEmptyFlag
            // 
            this.lblEmptyFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyFlag.AutoSize = true;
            this.lblEmptyFlag.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmptyFlag.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEmptyFlag.Location = new System.Drawing.Point(94, 27);
            this.lblEmptyFlag.Name = "lblEmptyFlag";
            this.lblEmptyFlag.Size = new System.Drawing.Size(30, 15);
            this.lblEmptyFlag.TabIndex = 6;
            this.lblEmptyFlag.Text = "True";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(285, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 15);
            this.label22.TabIndex = 4;
            this.label22.Text = "OVERFLOW:";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(163, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 15);
            this.label21.TabIndex = 3;
            this.label21.Text = "CARRY:";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(170, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 15);
            this.label20.TabIndex = 2;
            this.label20.Text = "ZERO:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(56, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "FULL:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(44, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "EMPTY:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.btInRegister);
            this.groupBox3.Controls.Add(this.txtSP);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtIR);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtOUT);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtIN);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtAR);
            this.groupBox3.Controls.Add(this.txtPC);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblAR);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtR4);
            this.groupBox3.Controls.Add(this.txtR3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtR2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtR1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(277, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 232);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registers";
            // 
            // btInRegister
            // 
            this.btInRegister.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btInRegister.FlatAppearance.BorderSize = 0;
            this.btInRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btInRegister.ForeColor = System.Drawing.Color.DarkRed;
            this.btInRegister.Location = new System.Drawing.Point(400, 25);
            this.btInRegister.Name = "btInRegister";
            this.btInRegister.Size = new System.Drawing.Size(55, 23);
            this.btInRegister.TabIndex = 21;
            this.btInRegister.Text = "Change";
            this.btInRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInRegister.UseVisualStyleBackColor = true;
            this.btInRegister.Click += new System.EventHandler(this.btInRegister_Click);
            // 
            // txtSP
            // 
            this.txtSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSP.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSP.FocusedBorderColor = System.Drawing.Color.Orange;
            this.txtSP.Location = new System.Drawing.Point(265, 140);
            this.txtSP.Name = "txtSP";
            this.txtSP.Padding = new System.Windows.Forms.Padding(1);
            this.txtSP.readOnly = true;
            this.txtSP.Size = new System.Drawing.Size(135, 23);
            this.txtSP.TabIndex = 20;
            this.txtSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSP.textBoxFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtSP.textBoxSize = new System.Drawing.Size(135, 23);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(167, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Stack Pointer:";
            // 
            // txtIR
            // 
            this.txtIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIR.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIR.FocusedBorderColor = System.Drawing.Color.Orange;
            this.txtIR.Location = new System.Drawing.Point(265, 114);
            this.txtIR.Name = "txtIR";
            this.txtIR.Padding = new System.Windows.Forms.Padding(1);
            this.txtIR.readOnly = true;
            this.txtIR.Size = new System.Drawing.Size(135, 23);
            this.txtIR.TabIndex = 18;
            this.txtIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIR.textBoxFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtIR.textBoxSize = new System.Drawing.Size(135, 23);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(128, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Instruction Register:";
            // 
            // txtOUT
            // 
            this.txtOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOUT.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOUT.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.txtOUT.Location = new System.Drawing.Point(327, 49);
            this.txtOUT.Name = "txtOUT";
            this.txtOUT.Padding = new System.Windows.Forms.Padding(1);
            this.txtOUT.readOnly = true;
            this.txtOUT.Size = new System.Drawing.Size(73, 23);
            this.txtOUT.TabIndex = 16;
            this.txtOUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOUT.textBoxFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOUT.textBoxSize = new System.Drawing.Size(73, 23);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(212, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Output Register:";
            // 
            // txtIN
            // 
            this.txtIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIN.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIN.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.txtIN.Location = new System.Drawing.Point(327, 25);
            this.txtIN.Name = "txtIN";
            this.txtIN.Padding = new System.Windows.Forms.Padding(1);
            this.txtIN.readOnly = true;
            this.txtIN.Size = new System.Drawing.Size(73, 23);
            this.txtIN.TabIndex = 14;
            this.txtIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIN.textBoxFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIN.textBoxSize = new System.Drawing.Size(73, 23);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(223, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Input Register:";
            // 
            // txtAR
            // 
            this.txtAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAR.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAR.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.txtAR.Location = new System.Drawing.Point(131, 49);
            this.txtAR.Name = "txtAR";
            this.txtAR.Padding = new System.Windows.Forms.Padding(1);
            this.txtAR.readOnly = true;
            this.txtAR.Size = new System.Drawing.Size(73, 23);
            this.txtAR.TabIndex = 12;
            this.txtAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAR.textBoxFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAR.textBoxSize = new System.Drawing.Size(73, 23);
            // 
            // txtPC
            // 
            this.txtPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPC.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPC.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.txtPC.Location = new System.Drawing.Point(131, 25);
            this.txtPC.Name = "txtPC";
            this.txtPC.Padding = new System.Windows.Forms.Padding(1);
            this.txtPC.readOnly = true;
            this.txtPC.Size = new System.Drawing.Size(73, 23);
            this.txtPC.TabIndex = 11;
            this.txtPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPC.textBoxFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPC.textBoxSize = new System.Drawing.Size(73, 23);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Program Counter:";
            // 
            // lblAR
            // 
            this.lblAR.AutoSize = true;
            this.lblAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAR.Location = new System.Drawing.Point(11, 49);
            this.lblAR.Name = "lblAR";
            this.lblAR.Size = new System.Drawing.Size(114, 17);
            this.lblAR.TabIndex = 9;
            this.lblAR.Text = "Address Register:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(28, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "R4:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(28, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "R3:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(28, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "R2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(28, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "R1:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.txtShowValue);
            this.groupBox4.Controls.Add(this.dGridStack);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.dGridInstruction);
            this.groupBox4.Controls.Add(this.txtShowOpcode);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dGridData);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dGridLabel);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(277, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(919, 377);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Memories";
            // 
            // txtShowValue
            // 
            this.txtShowValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtShowValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtShowValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtShowValue.Location = new System.Drawing.Point(469, 43);
            this.txtShowValue.Name = "txtShowValue";
            this.txtShowValue.ReadOnly = true;
            this.txtShowValue.Size = new System.Drawing.Size(83, 23);
            this.txtShowValue.TabIndex = 4;
            this.txtShowValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dGridStack
            // 
            this.dGridStack.AllowUserToAddRows = false;
            this.dGridStack.AllowUserToDeleteRows = false;
            this.dGridStack.AllowUserToResizeColumns = false;
            this.dGridStack.AllowUserToResizeRows = false;
            this.dGridStack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dGridStack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridStack.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGridStack.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGridStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridStack.ColumnHeadersVisible = false;
            this.dGridStack.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dGridStack.Location = new System.Drawing.Point(687, 106);
            this.dGridStack.MultiSelect = false;
            this.dGridStack.Name = "dGridStack";
            this.dGridStack.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGridStack.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGridStack.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGridStack.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dGridStack.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
            this.dGridStack.Size = new System.Drawing.Size(140, 255);
            this.dGridStack.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(684, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stack:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(492, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "Value";
            // 
            // dGridInstruction
            // 
            this.dGridInstruction.AllowUserToAddRows = false;
            this.dGridInstruction.AllowUserToDeleteRows = false;
            this.dGridInstruction.AllowUserToResizeColumns = false;
            this.dGridInstruction.AllowUserToResizeRows = false;
            this.dGridInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dGridInstruction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridInstruction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGridInstruction.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGridInstruction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridInstruction.ColumnHeadersVisible = false;
            this.dGridInstruction.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dGridInstruction.Location = new System.Drawing.Point(469, 106);
            this.dGridInstruction.MultiSelect = false;
            this.dGridInstruction.Name = "dGridInstruction";
            this.dGridInstruction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGridInstruction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGridInstruction.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGridInstruction.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dGridInstruction.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
            this.dGridInstruction.Size = new System.Drawing.Size(174, 255);
            this.dGridInstruction.TabIndex = 5;
            // 
            // txtShowOpcode
            // 
            this.txtShowOpcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtShowOpcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtShowOpcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtShowOpcode.Location = new System.Drawing.Point(347, 43);
            this.txtShowOpcode.Name = "txtShowOpcode";
            this.txtShowOpcode.ReadOnly = true;
            this.txtShowOpcode.Size = new System.Drawing.Size(83, 23);
            this.txtShowOpcode.TabIndex = 1;
            this.txtShowOpcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(364, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Opcode";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(285, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data:";
            // 
            // dGridData
            // 
            this.dGridData.AllowUserToAddRows = false;
            this.dGridData.AllowUserToDeleteRows = false;
            this.dGridData.AllowUserToResizeColumns = false;
            this.dGridData.AllowUserToResizeRows = false;
            this.dGridData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dGridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGridData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridData.ColumnHeadersVisible = false;
            this.dGridData.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dGridData.Location = new System.Drawing.Point(288, 106);
            this.dGridData.MultiSelect = false;
            this.dGridData.Name = "dGridData";
            this.dGridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGridData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGridData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dGridData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
            this.dGridData.Size = new System.Drawing.Size(140, 255);
            this.dGridData.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(466, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Instruction:";
            // 
            // dGridLabel
            // 
            this.dGridLabel.AllowUserToAddRows = false;
            this.dGridLabel.AllowUserToDeleteRows = false;
            this.dGridLabel.AllowUserToResizeColumns = false;
            this.dGridLabel.AllowUserToResizeRows = false;
            this.dGridLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dGridLabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridLabel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGridLabel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGridLabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridLabel.ColumnHeadersVisible = false;
            this.dGridLabel.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dGridLabel.Location = new System.Drawing.Point(100, 106);
            this.dGridLabel.MultiSelect = false;
            this.dGridLabel.Name = "dGridLabel";
            this.dGridLabel.RowHeadersVisible = false;
            this.dGridLabel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGridLabel.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGridLabel.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dGridLabel.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
            this.dGridLabel.Size = new System.Drawing.Size(140, 255);
            this.dGridLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Label:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.InitialDirectory = "./";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.AutoUpgradeEnabled = false;
            this.saveFileDialog.DefaultExt = "asm";
            this.saveFileDialog.Filter = "Assembly|*.asm|Binary Assembly|*.basm";
            this.saveFileDialog.InitialDirectory = ".\\outputs\\Assembly\\";
            this.saveFileDialog.Title = "New";
            // 
            // pbOverflowFlag
            // 
            this.pbOverflowFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbOverflowFlag.BackgroundImage = global::ProjeWithForm.Properties.Resources.flag_up;
            this.pbOverflowFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOverflowFlag.InitialImage = null;
            this.pbOverflowFlag.Location = new System.Drawing.Point(395, 38);
            this.pbOverflowFlag.Name = "pbOverflowFlag";
            this.pbOverflowFlag.Size = new System.Drawing.Size(20, 20);
            this.pbOverflowFlag.TabIndex = 14;
            this.pbOverflowFlag.TabStop = false;
            // 
            // pbZeroFlag
            // 
            this.pbZeroFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbZeroFlag.BackgroundImage = global::ProjeWithForm.Properties.Resources.flag_up;
            this.pbZeroFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbZeroFlag.InitialImage = null;
            this.pbZeroFlag.Location = new System.Drawing.Point(246, 53);
            this.pbZeroFlag.Name = "pbZeroFlag";
            this.pbZeroFlag.Size = new System.Drawing.Size(20, 20);
            this.pbZeroFlag.TabIndex = 12;
            this.pbZeroFlag.TabStop = false;
            // 
            // pbCarryFlag
            // 
            this.pbCarryFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCarryFlag.BackgroundImage = global::ProjeWithForm.Properties.Resources.flag_up;
            this.pbCarryFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCarryFlag.InitialImage = null;
            this.pbCarryFlag.Location = new System.Drawing.Point(246, 25);
            this.pbCarryFlag.Name = "pbCarryFlag";
            this.pbCarryFlag.Size = new System.Drawing.Size(20, 20);
            this.pbCarryFlag.TabIndex = 10;
            this.pbCarryFlag.TabStop = false;
            // 
            // pbFullFlag
            // 
            this.pbFullFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFullFlag.BackgroundImage = global::ProjeWithForm.Properties.Resources.flag_up;
            this.pbFullFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFullFlag.InitialImage = null;
            this.pbFullFlag.Location = new System.Drawing.Point(125, 53);
            this.pbFullFlag.Name = "pbFullFlag";
            this.pbFullFlag.Size = new System.Drawing.Size(20, 20);
            this.pbFullFlag.TabIndex = 8;
            this.pbFullFlag.TabStop = false;
            // 
            // pbEmptyFlag
            // 
            this.pbEmptyFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbEmptyFlag.BackgroundImage = global::ProjeWithForm.Properties.Resources.flag_up;
            this.pbEmptyFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEmptyFlag.InitialImage = null;
            this.pbEmptyFlag.Location = new System.Drawing.Point(125, 25);
            this.pbEmptyFlag.Name = "pbEmptyFlag";
            this.pbEmptyFlag.Size = new System.Drawing.Size(20, 20);
            this.pbEmptyFlag.TabIndex = 5;
            this.pbEmptyFlag.TabStop = false;
            // 
            // btNextStep
            // 
            this.btNextStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btNextStep.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btNextStep.FlatAppearance.BorderSize = 0;
            this.btNextStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btNextStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btNextStep.ForeColor = System.Drawing.Color.Snow;
            this.btNextStep.Image = global::ProjeWithForm.Properties.Resources.arrow_step_over_icon;
            this.btNextStep.Location = new System.Drawing.Point(317, 0);
            this.btNextStep.Margin = new System.Windows.Forms.Padding(0);
            this.btNextStep.Name = "btNextStep";
            this.btNextStep.Size = new System.Drawing.Size(27, 29);
            this.btNextStep.TabIndex = 12;
            this.btNextStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btNextStep, "Next Step");
            this.btNextStep.UseVisualStyleBackColor = false;
            this.btNextStep.Visible = false;
            this.btNextStep.Click += new System.EventHandler(this.btNextStep_Click);
            // 
            // btNextInstruction
            // 
            this.btNextInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btNextInstruction.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btNextInstruction.FlatAppearance.BorderSize = 0;
            this.btNextInstruction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btNextInstruction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btNextInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNextInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btNextInstruction.ForeColor = System.Drawing.Color.Snow;
            this.btNextInstruction.Image = global::ProjeWithForm.Properties.Resources.Arrow_Next_16;
            this.btNextInstruction.Location = new System.Drawing.Point(290, 0);
            this.btNextInstruction.Margin = new System.Windows.Forms.Padding(0);
            this.btNextInstruction.Name = "btNextInstruction";
            this.btNextInstruction.Size = new System.Drawing.Size(27, 29);
            this.btNextInstruction.TabIndex = 11;
            this.btNextInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btNextInstruction, "Next Instruction");
            this.btNextInstruction.UseVisualStyleBackColor = false;
            this.btNextInstruction.Visible = false;
            this.btNextInstruction.Click += new System.EventHandler(this.btNextInstruction_Click);
            // 
            // btStartStopDebugging
            // 
            this.btStartStopDebugging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btStartStopDebugging.Enabled = false;
            this.btStartStopDebugging.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btStartStopDebugging.FlatAppearance.BorderSize = 0;
            this.btStartStopDebugging.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btStartStopDebugging.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btStartStopDebugging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStartStopDebugging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btStartStopDebugging.ForeColor = System.Drawing.Color.Snow;
            this.btStartStopDebugging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btStartStopDebugging.ImageIndex = 0;
            this.btStartStopDebugging.ImageList = this.ilStartStopButton;
            this.btStartStopDebugging.Location = new System.Drawing.Point(226, 0);
            this.btStartStopDebugging.Margin = new System.Windows.Forms.Padding(0);
            this.btStartStopDebugging.Name = "btStartStopDebugging";
            this.btStartStopDebugging.Size = new System.Drawing.Size(59, 29);
            this.btStartStopDebugging.TabIndex = 10;
            this.btStartStopDebugging.Text = "Start";
            this.btStartStopDebugging.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btStartStopDebugging, "Start Debugging");
            this.btStartStopDebugging.UseVisualStyleBackColor = false;
            this.btStartStopDebugging.Click += new System.EventHandler(this.btStartStopDebugging_Click);
            // 
            // startDebugToolStripMenuItem
            // 
            this.startDebugToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.startDebugToolStripMenuItem.Enabled = false;
            this.startDebugToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.startDebugToolStripMenuItem.Image = global::ProjeWithForm.Properties.Resources.play_button_green_16;
            this.startDebugToolStripMenuItem.Name = "startDebugToolStripMenuItem";
            this.startDebugToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.startDebugToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.startDebugToolStripMenuItem.Text = "Start Debug";
            this.startDebugToolStripMenuItem.Click += new System.EventHandler(this.startDebugToolStripMenuItem_Click);
            // 
            // stopDebuggingToolStripMenuItem
            // 
            this.stopDebuggingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.stopDebuggingToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.stopDebuggingToolStripMenuItem.Image = global::ProjeWithForm.Properties.Resources.stop_button_16;
            this.stopDebuggingToolStripMenuItem.Name = "stopDebuggingToolStripMenuItem";
            this.stopDebuggingToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.stopDebuggingToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.stopDebuggingToolStripMenuItem.Text = "Stop Debugging";
            this.stopDebuggingToolStripMenuItem.Visible = false;
            this.stopDebuggingToolStripMenuItem.Click += new System.EventHandler(this.stopDebuggingToolStripMenuItem_Click);
            // 
            // nextInstructionToolStripMenuItem
            // 
            this.nextInstructionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.nextInstructionToolStripMenuItem.Enabled = false;
            this.nextInstructionToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.nextInstructionToolStripMenuItem.Image = global::ProjeWithForm.Properties.Resources.Arrow_Next_16;
            this.nextInstructionToolStripMenuItem.Name = "nextInstructionToolStripMenuItem";
            this.nextInstructionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.nextInstructionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.nextInstructionToolStripMenuItem.Text = "Next Instruction";
            this.nextInstructionToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.nextInstructionToolStripMenuItem.Click += new System.EventHandler(this.nextInstructionToolStripMenuItem_Click);
            // 
            // stepByStepToolStripMenuItem
            // 
            this.stepByStepToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.stepByStepToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.stepByStepToolStripMenuItem.Image = global::ProjeWithForm.Properties.Resources.arrow_step_over_icon;
            this.stepByStepToolStripMenuItem.Name = "stepByStepToolStripMenuItem";
            this.stepByStepToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.stepByStepToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.stepByStepToolStripMenuItem.Text = "Step By Step";
            this.stepByStepToolStripMenuItem.Visible = false;
            this.stepByStepToolStripMenuItem.Click += new System.EventHandler(this.stepByStepToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProjeWithForm.Properties.Resources.formHeader2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btMinimizeFrm);
            this.panel1.Controls.Add(this.btMaxMinFrm);
            this.panel1.Controls.Add(this.btCloseForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDEU);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 25);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btMinimizeFrm
            // 
            this.btMinimizeFrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizeFrm.FlatAppearance.BorderSize = 0;
            this.btMinimizeFrm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(18)))), ((int)(((byte)(153)))));
            this.btMinimizeFrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(191)))));
            this.btMinimizeFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizeFrm.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btMinimizeFrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btMinimizeFrm.Location = new System.Drawing.Point(1086, -23);
            this.btMinimizeFrm.Name = "btMinimizeFrm";
            this.btMinimizeFrm.Size = new System.Drawing.Size(30, 43);
            this.btMinimizeFrm.TabIndex = 5;
            this.btMinimizeFrm.Text = "_";
            this.btMinimizeFrm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMinimizeFrm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btMinimizeFrm.UseVisualStyleBackColor = true;
            this.btMinimizeFrm.Click += new System.EventHandler(this.btMinimizeFrm_Click);
            this.btMinimizeFrm.MouseEnter += new System.EventHandler(this.btMinimizeFrom_MouseEnter);
            this.btMinimizeFrm.MouseLeave += new System.EventHandler(this.btMinimizeFrom_MouseLeave);
            // 
            // btMaxMinFrm
            // 
            this.btMaxMinFrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaxMinFrm.FlatAppearance.BorderSize = 0;
            this.btMaxMinFrm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(18)))), ((int)(((byte)(153)))));
            this.btMaxMinFrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(191)))));
            this.btMaxMinFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaxMinFrm.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMaxMinFrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btMaxMinFrm.Location = new System.Drawing.Point(1118, -8);
            this.btMaxMinFrm.Name = "btMaxMinFrm";
            this.btMaxMinFrm.Size = new System.Drawing.Size(30, 28);
            this.btMaxMinFrm.TabIndex = 4;
            this.btMaxMinFrm.Text = "+";
            this.btMaxMinFrm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMaxMinFrm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btMaxMinFrm.UseVisualStyleBackColor = true;
            this.btMaxMinFrm.Click += new System.EventHandler(this.btMaxMinFrm_Click);
            this.btMaxMinFrm.MouseEnter += new System.EventHandler(this.btMaxMinFrm_MouseEnter);
            this.btMaxMinFrm.MouseLeave += new System.EventHandler(this.btMaxMinFrm_MouseLeave);
            // 
            // btCloseForm
            // 
            this.btCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btCloseForm.FlatAppearance.BorderSize = 0;
            this.btCloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCloseForm.Font = new System.Drawing.Font("28 Days Later", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCloseForm.Location = new System.Drawing.Point(1149, 0);
            this.btCloseForm.Name = "btCloseForm";
            this.btCloseForm.Size = new System.Drawing.Size(44, 20);
            this.btCloseForm.TabIndex = 3;
            this.btCloseForm.Text = "X";
            this.btCloseForm.UseVisualStyleBackColor = false;
            this.btCloseForm.Click += new System.EventHandler(this.btCloseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "- CE Simulator";
            // 
            // lblDEU
            // 
            this.lblDEU.AutoSize = true;
            this.lblDEU.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDEU.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblDEU.Location = new System.Drawing.Point(44, 4);
            this.lblDEU.Name = "lblDEU";
            this.lblDEU.Size = new System.Drawing.Size(35, 17);
            this.lblDEU.TabIndex = 1;
            this.lblDEU.Text = "DEU";
            // 
            // lineNumbers_For_AssemblyCodeView
            // 
            this.lineNumbers_For_AssemblyCodeView._SeeThroughMode_ = false;
            this.lineNumbers_For_AssemblyCodeView.AutoSizing = false;
            this.lineNumbers_For_AssemblyCodeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lineNumbers_For_AssemblyCodeView.BackgroundGradient_AlphaColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lineNumbers_For_AssemblyCodeView.BackgroundGradient_BetaColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lineNumbers_For_AssemblyCodeView.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lineNumbers_For_AssemblyCodeView.BorderLines_Color = System.Drawing.Color.Snow;
            this.lineNumbers_For_AssemblyCodeView.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_AssemblyCodeView.BorderLines_Thickness = 1F;
            this.lineNumbers_For_AssemblyCodeView.DockSide = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Left;
            this.lineNumbers_For_AssemblyCodeView.Font = new System.Drawing.Font("Source Sans Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lineNumbers_For_AssemblyCodeView.ForeColor = System.Drawing.Color.Snow;
            this.lineNumbers_For_AssemblyCodeView.GridLines_Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(221)))), ((int)(((byte)(39)))));
            this.lineNumbers_For_AssemblyCodeView.GridLines_Style = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.lineNumbers_For_AssemblyCodeView.GridLines_Thickness = 1F;
            this.lineNumbers_For_AssemblyCodeView.LineNrs_Alignment = System.Drawing.ContentAlignment.TopRight;
            this.lineNumbers_For_AssemblyCodeView.LineNrs_AntiAlias = true;
            this.lineNumbers_For_AssemblyCodeView.LineNrs_AsHexadecimal = false;
            this.lineNumbers_For_AssemblyCodeView.LineNrs_ClippedByItemRectangle = false;
            this.lineNumbers_For_AssemblyCodeView.LineNrs_LeadingZeroes = false;
            this.lineNumbers_For_AssemblyCodeView.LineNrs_Offset = new System.Drawing.Size(-3, 1);
            this.lineNumbers_For_AssemblyCodeView.Location = new System.Drawing.Point(11, 324);
            this.lineNumbers_For_AssemblyCodeView.Margin = new System.Windows.Forms.Padding(0);
            this.lineNumbers_For_AssemblyCodeView.MarginLines_Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(221)))), ((int)(((byte)(39)))));
            this.lineNumbers_For_AssemblyCodeView.MarginLines_Side = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Left;
            this.lineNumbers_For_AssemblyCodeView.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.lineNumbers_For_AssemblyCodeView.MarginLines_Thickness = 1F;
            this.lineNumbers_For_AssemblyCodeView.Name = "lineNumbers_For_AssemblyCodeView";
            this.lineNumbers_For_AssemblyCodeView.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.lineNumbers_For_AssemblyCodeView.ParentRichTextBox = this.rtbAssemblyCodeView;
            this.lineNumbers_For_AssemblyCodeView.Show_BackgroundGradient = true;
            this.lineNumbers_For_AssemblyCodeView.Show_BorderLines = false;
            this.lineNumbers_For_AssemblyCodeView.Show_GridLines = true;
            this.lineNumbers_For_AssemblyCodeView.Show_LineNrs = true;
            this.lineNumbers_For_AssemblyCodeView.Show_MarginLines = true;
            this.lineNumbers_For_AssemblyCodeView.Size = new System.Drawing.Size(34, 286);
            this.lineNumbers_For_AssemblyCodeView.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlCodeBlock);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.pnlCodeBlock.ResumeLayout(false);
            this.cmsAssemblyCodeView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridInstruction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverflowFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZeroFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarryFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFullFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmptyFlag)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEBUGToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDEU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Panel pnlCodeBlock;
        private System.Windows.Forms.ListBox lbAssemblyCodes;
        private System.Windows.Forms.ComboBox cbConvType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dGridLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGridStack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dGridInstruction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dGridData;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btCloseForm;
        private System.Windows.Forms.Button btMaxMinFrm;
        private System.Windows.Forms.Button btMinimizeFrm;
        private System.Windows.Forms.Label label7;
        private BorderedTextBox.TextBoxEx txtR1;
        private BorderedTextBox.TextBoxEx txtR2;
        private System.Windows.Forms.Label label8;
        private BorderedTextBox.TextBoxEx txtR3;
        private System.Windows.Forms.Label label9;
        private BorderedTextBox.TextBoxEx txtR4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAR;
        private System.Windows.Forms.Label label11;
        private BorderedTextBox.TextBoxEx txtPC;
        private BorderedTextBox.TextBoxEx txtAR;
        private BorderedTextBox.TextBoxEx txtOUT;
        private System.Windows.Forms.Label label13;
        private BorderedTextBox.TextBoxEx txtIN;
        private System.Windows.Forms.Label label12;
        private BorderedTextBox.TextBoxEx txtIR;
        private System.Windows.Forms.Label label14;
        private BorderedTextBox.TextBoxEx txtSP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStripMenuItem startDebugToolStripMenuItem;
        private System.Windows.Forms.Button btStartStopDebugging;
        private System.Windows.Forms.ImageList ilStartStopButton;
        private System.Windows.Forms.ToolStripMenuItem nextInstructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopDebuggingToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbMicroOp;
        private System.Windows.Forms.ToolStripMenuItem stepByStepToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbAssemblyCodeView;
        private System.Windows.Forms.ContextMenuStrip cmsAssemblyCodeView;
        private System.Windows.Forms.ToolStripMenuItem EditAssemblyMenuItem;
        private LineNumbers.LineNumbers_For_RichTextBox lineNumbers_For_AssemblyCodeView;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtShowValue;
        public System.Windows.Forms.TextBox txtShowOpcode;
        private System.Windows.Forms.Button btInRegister;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pbEmptyFlag;
        private System.Windows.Forms.Label lblEmptyFlag;
        private System.Windows.Forms.PictureBox pbFullFlag;
        private System.Windows.Forms.Label lblFullFlag;
        private System.Windows.Forms.PictureBox pbOverflowFlag;
        private System.Windows.Forms.Label lblOverflowFlag;
        private System.Windows.Forms.PictureBox pbZeroFlag;
        private System.Windows.Forms.Label lblZeroFlag;
        private System.Windows.Forms.PictureBox pbCarryFlag;
        private System.Windows.Forms.Label lblCarryFlag;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem asHEXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asMIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btNextInstruction;
        private System.Windows.Forms.Button btNextStep;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usingGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

