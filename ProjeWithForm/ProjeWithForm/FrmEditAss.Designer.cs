namespace ProjeWithForm
{
    partial class FrmEditAss
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btFrmClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scintilla = new ScintillaNET.Scintilla();
            this.pnlHeader.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BackgroundImage = global::ProjeWithForm.Properties.Resources.formHeader2;
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.btFrmClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(484, 21);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(3, 2);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(112, 15);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "DEU - CE Simulator";
            // 
            // btFrmClose
            // 
            this.btFrmClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btFrmClose.FlatAppearance.BorderSize = 0;
            this.btFrmClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFrmClose.Font = new System.Drawing.Font("28 Days Later", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFrmClose.ForeColor = System.Drawing.Color.White;
            this.btFrmClose.Location = new System.Drawing.Point(452, 0);
            this.btFrmClose.Name = "btFrmClose";
            this.btFrmClose.Size = new System.Drawing.Size(28, 18);
            this.btFrmClose.TabIndex = 0;
            this.btFrmClose.Text = "X";
            this.btFrmClose.UseVisualStyleBackColor = false;
            this.btFrmClose.Click += new System.EventHandler(this.btFrmClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(222)))), ((int)(((byte)(39)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 540);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(222)))), ((int)(((byte)(39)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(482, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 540);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(222)))), ((int)(((byte)(39)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 559);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 2);
            this.panel3.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 21);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // scintilla
            // 
            this.scintilla.AdditionalSelectionTyping = true;
            this.scintilla.AutoCIgnoreCase = true;
            this.scintilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintilla.CaretForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scintilla.CaretLineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.scintilla.CaretLineVisible = true;
            this.scintilla.CaretStyle = ScintillaNET.CaretStyle.Block;
            this.scintilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla.FontQuality = ScintillaNET.FontQuality.LcdOptimized;
            this.scintilla.HighlightGuide = 0;
            this.scintilla.IndentationGuides = ScintillaNET.IndentView.LookForward;
            this.scintilla.Lexer = ScintillaNET.Lexer.Python;
            this.scintilla.Location = new System.Drawing.Point(2, 45);
            this.scintilla.MultipleSelection = true;
            this.scintilla.Name = "scintilla";
            this.scintilla.RectangularSelectionAnchor = 0;
            this.scintilla.RectangularSelectionAnchorVirtualSpace = 0;
            this.scintilla.RectangularSelectionCaret = 0;
            this.scintilla.RectangularSelectionCaretVirtualSpace = 0;
            this.scintilla.Size = new System.Drawing.Size(480, 514);
            this.scintilla.TabIndex = 4;
            this.scintilla.ViewWhitespace = ScintillaNET.WhitespaceMode.VisibleAfterIndent;
            this.scintilla.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.scintilla_CharAdded);
            this.scintilla.TextChanged += new System.EventHandler(this.scintilla_TextChanged);
            this.scintilla.MouseCaptureChanged += new System.EventHandler(this.scintilla_MouseCaptureChanged);
            // 
            // FrmEditAss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.ControlBox = false;
            this.Controls.Add(this.scintilla);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmEditAss";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEditAss";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btFrmClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private ScintillaNET.Scintilla scintilla;
        private System.Windows.Forms.Label lblHeader;
    }
}