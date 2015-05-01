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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUILDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEBUGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextInstructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtR1 = new BorderedTextBox.TextBoxEx();
            this.txtR2 = new BorderedTextBox.TextBoxEx();
            this.txtR3 = new BorderedTextBox.TextBoxEx();
            this.txtR4 = new BorderedTextBox.TextBoxEx();
            this.btStartStopDebugging = new System.Windows.Forms.Button();
            this.ilStartStopButton = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.cbConvType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCodeBlock = new System.Windows.Forms.Panel();
            this.lbAssemblyCodes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.dGridStack = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dGridInstruction = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dGridData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dGridLabel = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMinimizeFrm = new System.Windows.Forms.Button();
            this.btMaxMinFrm = new System.Windows.Forms.Button();
            this.btCloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDEU = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.pnlCodeBlock.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridInstruction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridLabel)).BeginInit();
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
            this.bUILDToolStripMenuItem,
            this.dEBUGToolStripMenuItem});
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
            this.saveToolStripMenuItem});
            this.fILEToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.denemeToolStripMenuItem});
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.denemeToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.denemeToolStripMenuItem.Text = "Deneme";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // bUILDToolStripMenuItem
            // 
            this.bUILDToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.bUILDToolStripMenuItem.Name = "bUILDToolStripMenuItem";
            this.bUILDToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.bUILDToolStripMenuItem.Text = "BUILD";
            // 
            // dEBUGToolStripMenuItem
            // 
            this.dEBUGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startDebugToolStripMenuItem,
            this.nextInstructionToolStripMenuItem});
            this.dEBUGToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.dEBUGToolStripMenuItem.Name = "dEBUGToolStripMenuItem";
            this.dEBUGToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.dEBUGToolStripMenuItem.Text = "DEBUG";
            // 
            // startDebugToolStripMenuItem
            // 
            this.startDebugToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.startDebugToolStripMenuItem.Enabled = false;
            this.startDebugToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.startDebugToolStripMenuItem.Image = global::ProjeWithForm.Properties.Resources.play_button_green_16;
            this.startDebugToolStripMenuItem.Name = "startDebugToolStripMenuItem";
            this.startDebugToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.startDebugToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.startDebugToolStripMenuItem.Text = "Start Debug";
            this.startDebugToolStripMenuItem.Click += new System.EventHandler(this.startDebugToolStripMenuItem_Click);
            // 
            // nextInstructionToolStripMenuItem
            // 
            this.nextInstructionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.nextInstructionToolStripMenuItem.Enabled = false;
            this.nextInstructionToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.nextInstructionToolStripMenuItem.Image = global::ProjeWithForm.Properties.Resources.Arrow_Next_16;
            this.nextInstructionToolStripMenuItem.Name = "nextInstructionToolStripMenuItem";
            this.nextInstructionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.nextInstructionToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nextInstructionToolStripMenuItem.Text = "Next Instruction";
            this.nextInstructionToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.nextInstructionToolStripMenuItem.Click += new System.EventHandler(this.nextInstructionToolStripMenuItem_Click);
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
            this.pnlCodeBlock.Controls.Add(this.lbAssemblyCodes);
            this.pnlCodeBlock.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCodeBlock.Location = new System.Drawing.Point(1, 78);
            this.pnlCodeBlock.Name = "pnlCodeBlock";
            this.pnlCodeBlock.Size = new System.Drawing.Size(270, 621);
            this.pnlCodeBlock.TabIndex = 6;
            // 
            // lbAssemblyCodes
            // 
            this.lbAssemblyCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAssemblyCodes.FormattingEnabled = true;
            this.lbAssemblyCodes.Location = new System.Drawing.Point(11, 19);
            this.lbAssemblyCodes.Name = "lbAssemblyCodes";
            this.lbAssemblyCodes.Size = new System.Drawing.Size(247, 576);
            this.lbAssemblyCodes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(759, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 141);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Micro Operations";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(759, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 85);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flags";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.groupBox4.Controls.Add(this.dGridStack);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dGridInstruction);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.InitialDirectory = "./";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridInstruction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridLabel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUILDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEBUGToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDEU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
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
    }
}

