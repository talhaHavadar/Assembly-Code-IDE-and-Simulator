using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjeWithForm
{
    public partial class MainForm : Form
    {

        #region variables
        int mouseX;
        int mouseY;
        private string ASSEMBLY_OUTPUT_PATH = ".\\Outputs\\Assembly\\";
        bool DEBUG_MODE = false;
        int DEBUG_LINE_COUNTER = 0;
        int ASSEMBLY_LINE_SELECTOR = 0;
        public static TableSet tableSet;
        public static Register[] registers;
        OperandProcess processAssembly;
        private int stepCounter = 0;
        private bool prevInsExecuted = true;
        private string LAST_FILENAME = "";
        private string LAST_FILE_PATH = "";
        DataType lastSelectedConv = DataType.BINARY;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            tableSet = new TableSet();
            processAssembly = new OperandProcess(ref txtShowValue, ref txtShowOpcode);
            registers = new Register[10];
            //Initialize registers
            registers[0] = new Register(RegisterType.GENERAL_REGISTER); //Register 1
            registers[1] = new Register(RegisterType.GENERAL_REGISTER); //Register 2
            registers[2] = new Register(RegisterType.GENERAL_REGISTER); //Register 3
            registers[3] = new Register(RegisterType.GENERAL_REGISTER); //Register 4

            registers[4] = new Register(RegisterType.ADDRESS_REGISTER);
            registers[5] = new Register(RegisterType.INPUT_REGISTER); //Input register
            registers[6] = new Register(RegisterType.OUTPUT_REGISTER); //Output register
            registers[7] = new Register(RegisterType.INSTRUCTION_REGISTER);
            registers[8] = new Register(RegisterType.PROGRAM_COUNTER);
            registers[9] = new Register(RegisterType.STACK_POINTER);
            //Initialize register END
            defaultTheme();
            eDITToolStripMenuItem.Enabled = false;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbConvType.SelectedIndex = 0;
            btInRegister.Enabled = false;
            stepByStepToolStripMenuItem.Enabled = false;
            updateAllDataGridSource();
            updateAllRegisterTextBox();
            exportToolStripMenuItem.Enabled = false;
            createFolders();
            saveFileDialog.RestoreDirectory = true;
            
            EditAssemblyMenuItem.Click += EditAssemblyMenuItem_Click;
        }

        void createFolders()
        {
            if (!Directory.Exists(".\\Outputs"))
            {
                DirectoryInfo info = Directory.CreateDirectory(".\\Outputs\\");
                if (info.Exists)
                {
                    if (!Directory.Exists(".\\Outputs\\Assembly\\"))
                    {
                        Directory.CreateDirectory(".\\Outputs\\Assembly\\");
                    }
                    if (!Directory.Exists(".\\Outputs\\Hex\\"))
                    {
                        Directory.CreateDirectory(".\\Outputs\\Hex\\");
                    }
                    if (!Directory.Exists(".\\Outputs\\Mif\\"))
                    {
                        Directory.CreateDirectory(".\\Outputs\\Mif\\");
                    }
                }
            }
            else
            {
                if (!Directory.Exists(".\\Outputs\\Assembly\\"))
                {
                    Directory.CreateDirectory(".\\Outputs\\Assembly\\");
                }
                if (!Directory.Exists(".\\Outputs\\Hex\\"))
                {
                    Directory.CreateDirectory(".\\Outputs\\Hex\\");
                }
                if (!Directory.Exists(".\\Outputs\\Mif\\"))
                {
                    Directory.CreateDirectory(".\\Outputs\\Mif\\");
                }
            }
        }

        #region registerFunctions

        public static Register getRegister(RegisterType type)
        {
            if (type == RegisterType.ADDRESS_REGISTER)
            {
                return registers[4];
            }
            else if (RegisterType.INPUT_REGISTER == type)
            {
                return registers[5];
            }
            else if (RegisterType.OUTPUT_REGISTER == type)
            {
                return registers[6];
            }
            else if (type == RegisterType.INSTRUCTION_REGISTER)
            {
                return registers[7];
            }
            else if (type == RegisterType.PROGRAM_COUNTER)
            {
                return registers[8];
            }
            else
            {
                return registers[9];
            }
        }

        public void updateFlags()
        {
            lblOverflowFlag.Text = processAssembly.overFlow.ToString();
            lblOverflowFlag.ForeColor = processAssembly.overFlow ? Color.DarkGreen : Color.DarkRed;
            pbOverflowFlag.Visible = processAssembly.overFlow;


            lblCarryFlag.Text = processAssembly.carryOut.ToString();
            lblCarryFlag.ForeColor = processAssembly.carryOut ? Color.DarkGreen : Color.DarkRed;
            pbCarryFlag.Visible = processAssembly.carryOut;

            lblZeroFlag.Text = processAssembly.zero.ToString();
            lblZeroFlag.ForeColor = processAssembly.zero ? Color.DarkGreen : Color.DarkRed;
            pbZeroFlag.Visible = processAssembly.zero;

            lblEmptyFlag.Text = processAssembly.stackEmpty.ToString();
            lblEmptyFlag.ForeColor = processAssembly.stackEmpty ? Color.DarkGreen : Color.DarkRed;
            pbEmptyFlag.Visible = processAssembly.stackEmpty;

            lblFullFlag.Text = processAssembly.stackFull.ToString();
            lblFullFlag.ForeColor = processAssembly.stackFull ? Color.DarkGreen : Color.DarkRed;
            pbFullFlag.Visible = processAssembly.stackFull;

        }

        public static Register getGeneralRegister(int id)//Id must be 1,2,3,4 if others returns null
        {
            if (id == 1)
            {
                return registers[0];
            }
            else if (id == 2)
            {
                return registers[1];
            }
            else if (id == 3)
            {
                return registers[2];
            }
            else if (id == 4)
            {
                return registers[3];
            }
            else
            {
                return null;
            }
        }

        private void updateAllRegisterTextBox()
        {
            txtR1.Text = registers[0].data;
            txtR2.Text = registers[1].data;
            txtR3.Text = registers[2].data;
            txtR4.Text = registers[3].data;
            updateFlags();
            txtPC.Text = getRegister(RegisterType.PROGRAM_COUNTER).data;
            txtAR.Text = getRegister(RegisterType.ADDRESS_REGISTER).data;

            txtIN.Text = getRegister(RegisterType.INPUT_REGISTER).data;
            txtOUT.Text = getRegister(RegisterType.OUTPUT_REGISTER).data;

            txtIR.Text = getRegister(RegisterType.INSTRUCTION_REGISTER).data;
            txtSP.Text = getRegister(RegisterType.STACK_POINTER).data;
        }

        #endregion

        #region themeFunctions

        public void defaultTheme()
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MenuStripColorTable());
            cmsAssemblyCodeView.Renderer = new ToolStripProfessionalRenderer(new MenuStripColorTable());
            //cmsAssemblyCodeView.ForeColor = Color.Snow;

        }

        #endregion

        #region overrideArea

        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        /*
        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;
            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
            }
            base.WndProc(ref m);
        }
        */
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }

        #endregion

        #region headerPanel

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            if (e.Button == MouseButtons.Left)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            /*
            int a = 60;
            string b = Convert.ToString(a,2);
            MessageBox.Show(b
            */
        }

        #endregion

        #region formHeaderButton

        private void btMaxMinFrm_MouseEnter(object sender, EventArgs e)
        {
            btMaxMinFrm.ForeColor = Color.White;
        }

        private void btMaxMinFrm_MouseLeave(object sender, EventArgs e)
        {
            btMaxMinFrm.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void btMinimizeFrom_MouseEnter(object sender, EventArgs e)
        {
            btMinimizeFrm.ForeColor = Color.White;
        }

        private void btMinimizeFrom_MouseLeave(object sender, EventArgs e)
        {
            btMinimizeFrm.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void btMaxMinFrm_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btMinimizeFrm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region dataGridSourceUpdate

        public void updateAllDataGridSource()
        {
            updateDataGridSource(TableType.DATA_TABLE);
            updateDataGridSource(TableType.LABEL_TABLE);
            updateDataGridSource(TableType.INSTRUCTION_TABLE);
            updateDataGridSource(TableType.STACK_TABLE);
        }

        public void resetDataGrids()
        {
            tableSet.resetTables();
            updateAllDataGridSource();
        }

        public void updateDataGridSource(TableType type)
        {
            if (type == TableType.DATA_TABLE)
            {
                dGridData.DataSource = tableSet.getDataTable().values.Select(x => new { Value = x }).ToList();
                foreach (DataGridViewRow row in dGridData.Rows)
                {
                    row.HeaderCell.Value = (row.Index).ToString();
                }
                dGridData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
                dGridData.RowHeadersWidth = 45;
                dGridData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dGridData.CurrentCell = dGridData.Rows[getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt()].Cells[0];
            }
            else if (type == TableType.LABEL_TABLE)
            {
                dGridLabel.DataSource = tableSet.getLabelTable().values.Select(x => new { Value = x }).ToList();
            }
            else if (type == TableType.INSTRUCTION_TABLE)
            {
                dGridInstruction.DataSource = tableSet.getInstructionTable().values.Select(x => new { Value = x }).ToList();
                foreach (DataGridViewRow row in dGridInstruction.Rows)
                {
                    row.HeaderCell.Value = (row.Index).ToString();
                }
                dGridInstruction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
                dGridInstruction.RowHeadersWidth = 45;
                dGridInstruction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dGridInstruction.CurrentCell = dGridInstruction.Rows[getRegister(RegisterType.PROGRAM_COUNTER).convertDataToInt()].Cells[0];//DEBUG_LINE_COUNTER == 0 ? null : dGridInstruction.Rows[DEBUG_LINE_COUNTER - 1].Cells[0];
            }
            else if (type == TableType.STACK_TABLE)
            {
                dGridStack.DataSource = tableSet.getStackTable().values.Select(x => new { Value = x }).ToList();
                foreach (DataGridViewRow row in dGridStack.Rows)
                {
                    row.HeaderCell.Value = (row.Index).ToString();
                }
                dGridStack.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
                dGridStack.RowHeadersWidth = 45;
                dGridStack.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dGridStack.CurrentCell = dGridStack.Rows[getRegister(RegisterType.STACK_POINTER).convertDataToInt() >= dGridStack.Rows.Count ? 7 : getRegister(RegisterType.STACK_POINTER).convertDataToInt()].Cells[0];
            }
        }

        #endregion

        #region DebugFunctions

        private void startDebug()
        {
            DEBUG_MODE = true;
            lblDEU.ForeColor = Color.DeepPink;
            startDebugToolStripMenuItem.Enabled = false;
            btNextStep.Visible = true;
            btNextInstruction.Visible = true;
            nextInstructionToolStripMenuItem.Enabled = true;
            stepByStepToolStripMenuItem.Enabled = true;
            btInRegister.Enabled = true;
            openToolStripMenuItem_Click(null, null);
            DEBUG_LINE_COUNTER = 0;
            stepCounter = 0;
            lbAssemblyCodes.SelectedIndex = DEBUG_LINE_COUNTER;
            btStartStopDebugging.ImageIndex = 1;
            btStartStopDebugging.Text = "Stop";
            openToolStripMenuItem.Enabled = false;
            stopDebuggingToolStripMenuItem.Visible = true;
            txtShowOpcode.Text = "";
            txtShowValue.Text = "";
            stepByStepToolStripMenuItem.Visible = true;

        }

        private void stopDebug()
        {
            DEBUG_MODE = false;
            btStartStopDebugging.Text = "Start";
            stopDebuggingToolStripMenuItem.Visible = false;
            stepByStepToolStripMenuItem.Enabled = false;
            openToolStripMenuItem.Enabled = true;
            btNextInstruction.Visible = false;
            btNextStep.Visible = false;
            btInRegister.Enabled = false;
            rtbMicroOp.Text = "";
            lblDEU.ForeColor = Color.MediumBlue;
            processAssembly.stackEmpty = true;
            processAssembly.stackFull = false;
            stepByStepToolStripMenuItem.Visible = false;
            for (int i = 0; i < registers.Length; i++)
            {
                if (registers[i].RegisterType == RegisterType.STACK_POINTER)
                {
                    registers[i].setData("0", DataType.DECIMAL);
                }
                else
                    registers[i].setData("0", DataType.DECIMAL);
            }
            btStartStopDebugging.ImageIndex = 0;
            nextInstructionToolStripMenuItem.Enabled = false;
            startDebugToolStripMenuItem.Enabled = true;
            updateAllRegisterTextBox();
            DEBUG_LINE_COUNTER = 0;
            ASSEMBLY_LINE_SELECTOR = 0;
            processAssembly.resetFlags();
            dGridInstruction.CurrentCell = dGridInstruction.Rows[DEBUG_LINE_COUNTER].Cells[0];
            dGridInstruction.CurrentCell = null;
        }

        private void stepByStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int jumpRange = DEBUG_LINE_COUNTER;
            if (stepCounter == 0)
            {
                txtShowOpcode.Text = "";
                txtShowValue.Text = "";
                prevInsExecuted = false;
                processAssembly.fetch(ref registers[8], ref registers[7], ref registers[4], tableSet.getInstructionTable());
                rtbMicroOp.Text = OperandProcess.FETCH_STRING;
                dGridInstruction.CurrentCell = dGridInstruction.Rows[DEBUG_LINE_COUNTER].Cells[0];

                if (DEBUG_LINE_COUNTER < lbAssemblyCodes.Items.Count)
                {
                    lbAssemblyCodes.SelectedIndex = ASSEMBLY_LINE_SELECTOR;
                }
                DEBUG_LINE_COUNTER++;

                if (MainForm.getRegister(RegisterType.INSTRUCTION_REGISTER).convertDataToInt() != 0 || lbAssemblyCodes.Items[ASSEMBLY_LINE_SELECTOR].ToString().Contains("ORG"))
                {
                    ASSEMBLY_LINE_SELECTOR++;
                }
                updateAllRegisterTextBox();
            }
            else if (stepCounter == 1)
            {
                processAssembly.insTableLine = DEBUG_LINE_COUNTER;
                bool res = processAssembly.decode(ref registers, ref tableSet);
                DEBUG_LINE_COUNTER = processAssembly.insTableLine;
                jumpRange = DEBUG_LINE_COUNTER - jumpRange;
                if (jumpRange > 0 || processAssembly.Jump)
                {
                    jumpRange++;
                }
                ASSEMBLY_LINE_SELECTOR += jumpRange;
                if (!res)
                {
                    stopDebug();
                    return;
                }
                rtbMicroOp.Text += OperandProcess.DECODE_STRING;
                prevInsExecuted = true;
            }
            else if (stepCounter == 2)
            {
                rtbMicroOp.Text += processAssembly.EXECUTE_STRING;
                updateAllRegisterTextBox();
                updateAllDataGridSource();
                if (DEBUG_LINE_COUNTER >= dGridInstruction.Rows.Count)
                {
                    DEBUG_LINE_COUNTER = 0;
                    ASSEMBLY_LINE_SELECTOR = 0;
                }
            }
            colorMicroOps();
            stepCounter++;
            if (stepCounter > 2)
            {
                stepCounter = 0;
            }
        }

        private void nextInstructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtShowOpcode.Text = "";
            txtShowValue.Text = "";
            processAssembly.insTableLine = DEBUG_LINE_COUNTER;
            if (DEBUG_LINE_COUNTER < lbAssemblyCodes.Items.Count)
            {
                lbAssemblyCodes.SelectedIndex = ASSEMBLY_LINE_SELECTOR;
            }
            if (!prevInsExecuted)
            {
                processAssembly.decode(ref registers, ref tableSet);
            }
            prevInsExecuted = false;
            processAssembly.fetch(ref registers[8], ref registers[7], ref registers[4], tableSet.getInstructionTable());
            rtbMicroOp.Text = OperandProcess.FETCH_STRING;
            rtbMicroOp.Text += OperandProcess.DECODE_STRING;
            bool res = processAssembly.decode(ref registers, ref tableSet);
            if (!res)
            {
                stopDebug();
                return;
            }
            prevInsExecuted = true;
            rtbMicroOp.Text += processAssembly.EXECUTE_STRING;
            updateAllRegisterTextBox();
            updateAllDataGridSource();
            int jumpRange = DEBUG_LINE_COUNTER;
            DEBUG_LINE_COUNTER = processAssembly.insTableLine;
            jumpRange = DEBUG_LINE_COUNTER - jumpRange;
            ASSEMBLY_LINE_SELECTOR += jumpRange;
            dGridInstruction.CurrentCell = dGridInstruction.Rows[DEBUG_LINE_COUNTER].Cells[0];
            colorMicroOps();
            if (MainForm.getRegister(RegisterType.INSTRUCTION_REGISTER).convertDataToInt() != 0 || lbAssemblyCodes.Items[ASSEMBLY_LINE_SELECTOR].ToString().Contains("ORG"))
            {
                ASSEMBLY_LINE_SELECTOR++;
            }
            DEBUG_LINE_COUNTER++;
            if (DEBUG_LINE_COUNTER >= dGridInstruction.Rows.Count)
            {
                DEBUG_LINE_COUNTER = 0;
                ASSEMBLY_LINE_SELECTOR = 0;
            }

        }

        #endregion

        #region rtbFunctionsArea

        private void colorMicroOps()
        {
            for (int i = 0; i < rtbMicroOp.Lines.Length; i++)
            {
                string line = rtbMicroOp.Lines[i];
                int first = rtbMicroOp.GetFirstCharIndexFromLine(i);
                if (line.Contains("Fetch"))
                {
                    rtbMicroOp.Select(first + line.IndexOf('F'), 5);
                    rtbMicroOp.SelectionColor = Color.DarkGreen;
                }
                else if (line.Contains("Decode"))
                {
                    rtbMicroOp.Select(first + line.IndexOf('D'), 6);
                    rtbMicroOp.SelectionColor = Color.DarkOrange;
                }
                else if (line.Contains("Execute"))
                {
                    rtbMicroOp.Select(first + line.IndexOf("Execute"), 7);
                    rtbMicroOp.SelectionColor = Color.DarkRed;
                }
            }
        }

        bool rtbCodeViewReady = false;
        private void colorAssemblyCodeView()
        {
            for (int i = 0; i < rtbAssemblyCodeView.Lines.Length; i++)
            {
                string line = rtbAssemblyCodeView.Lines[i].ToUpper();
                int first = rtbAssemblyCodeView.GetFirstCharIndexFromLine(i);
                if (line.Contains("ORG"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("ORG"), 3);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("HLT"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("HLT"), 3);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("ADD"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("ADD"), 3);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("SUB"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("SUB"), 3);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("AND"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("AND"), 3);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("XOR"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("XOR"), 3);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("OR"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("OR"), 2);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("SHL"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("SHL"), 3);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("SHR"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("SHR"), 3);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("INC"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("INC"), 3);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("COMA"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("COMA"), 4);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("LD"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("LD"), 2);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("ST"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("ST"), 2);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("IN") && !line.Contains("BIN"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("IN"), 2);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("OUT"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("OUT"), 3);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("JMP"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("JMP"), 3);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("CALL"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("CALL"), 4);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("RET"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("RET"), 3);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("EMPTY"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("EMPTY"), 5);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
                else if (line.Contains("FULL"))
                {
                    rtbAssemblyCodeView.Select(first + line.IndexOf("FULL"), 4);
                    rtbAssemblyCodeView.SelectionColor = Color.Indigo;
                }
            }
            rtbCodeViewReady = true;
        }

        int lastLine = 0;
        private void HighlightCurrentLine()
        {
            // Save current selection
            int selectionStart = rtbAssemblyCodeView.SelectionStart;
            int selectionLength = rtbAssemblyCodeView.SelectionLength;

            // Get character positions for the current line
            int firstCharPosition = rtbAssemblyCodeView.GetFirstCharIndexOfCurrentLine();
            int lineNumber = rtbAssemblyCodeView.GetLineFromCharIndex(firstCharPosition);
            int lastCharPosition = rtbAssemblyCodeView.GetFirstCharIndexFromLine(lineNumber + 1);
            if (lastCharPosition == -1)
                lastCharPosition = rtbAssemblyCodeView.TextLength;

            // Clear any previous color
            if (lineNumber != lastLine)
            {
                int previousFirstCharPosition = rtbAssemblyCodeView.GetFirstCharIndexFromLine(lastLine);
                int previousLastCharPosition = rtbAssemblyCodeView.GetFirstCharIndexFromLine(lastLine + 1);
                if (previousLastCharPosition == -1)
                    previousLastCharPosition = rtbAssemblyCodeView.TextLength;

                rtbAssemblyCodeView.SelectionStart = previousFirstCharPosition;
                rtbAssemblyCodeView.SelectionLength = previousLastCharPosition - previousFirstCharPosition;
                rtbAssemblyCodeView.SelectionBackColor = SystemColors.Window;
                lastLine = lineNumber;
            }

            // Set new color
            rtbAssemblyCodeView.SelectionStart = firstCharPosition;
            rtbAssemblyCodeView.SelectionLength = lastCharPosition - firstCharPosition;
            if (rtbAssemblyCodeView.SelectionLength > 0)
                rtbAssemblyCodeView.SelectionBackColor = Color.FromArgb(196, 237, 114);

            // Reset selection
            rtbAssemblyCodeView.SelectionStart = selectionStart;
            rtbAssemblyCodeView.SelectionLength = selectionLength;
        }

        #endregion

        private string getCleanInstruction(string[] spltSpc)
        {
            string cleanInstruction = "";
            for (int j = 0; j < spltSpc.Length; j++)
            {
                if (!String.IsNullOrWhiteSpace(spltSpc[j]))
                {
                    cleanInstruction += spltSpc[j];
                }
                if (j != spltSpc.Length - 1)
                    cleanInstruction += " ";
            }
            return cleanInstruction;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Please select the assembly file";
            openFileDialog.Filter = "(*.asm)|*.asm|(*.basm)|*.basm";
            //openFileDialog.ShowDialog();

            if (DEBUG_MODE || openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Resetting some properties
                exportToolStripMenuItem.Enabled = true;
                eDITToolStripMenuItem.Enabled = true;
                EditAssemblyMenuItem.Enabled = true;
                processAssembly.orgInstructionIndex = 0;
                processAssembly.orgDataIndex = 0;
                processAssembly.LabelDict.Clear();
                cbConvType.SelectedIndex = 0;
                rtbAssemblyCodeView.Text = "";
                this.cbConvType_SelectedIndexChanged(sender, e);
                if (LAST_FILENAME == "")
                {
                    LAST_FILENAME = openFileDialog.FileName;
                    LAST_FILE_PATH = Path.GetFullPath(openFileDialog.FileName);

                }
                else if (!DEBUG_MODE && LAST_FILENAME != "")
                {
                    LAST_FILENAME = openFileDialog.FileName;
                    LAST_FILE_PATH = Path.GetFullPath(openFileDialog.FileName);
                }
                lbAssemblyCodes.Items.Clear();
                resetDataGrids();
                #region ParsingLabels
                using (StreamReader sr = new StreamReader(LAST_FILENAME))
                {
                    String line;

                    int lastORGDidx = 0;
                    int lastORGIidx = 0;
                    int lineCounter = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] splitWithTab = line.Split('\t');
                        lineCounter++;
                        for (int i = 0; i < splitWithTab.Length; i++)
                        {
                            if (!String.IsNullOrWhiteSpace(splitWithTab[i]) && !splitWithTab[i].Trim().StartsWith("#"))
                            {
                                if (splitWithTab[i].ToUpper().Contains("ORG "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    string memType = spltSpc[1];
                                    int value = Convert.ToInt32(spltSpc[2].Trim());
                                    if (memType.Trim().ToUpper() == "D")
                                    {
                                        lastORGDidx = value;
                                    }
                                    else if (memType.Trim().ToUpper() == "I")
                                    {
                                        lastORGIidx = value;
                                    }
                                }
                                else if (splitWithTab[i].Trim().EndsWith(":"))
                                {
                                    string process = "";
                                    for (int j = i + 1; j < splitWithTab.Length; j++)
                                    {
                                        if (splitWithTab[j] != "")
                                        {
                                            process += splitWithTab[j];
                                        }
                                    }

                                    string dataType = "";
                                    string dataValue = "";

                                    string[] spltSpc = process.Split(' ');
                                    dataType = spltSpc[0].Trim();
                                    dataValue = spltSpc[1].Trim();

                                    if (dataType == "HEX" || dataType == "BIN" || dataType == "DEC")
                                    {

                                        int valueBase = 2;
                                        if (dataType == "HEX")
                                        {
                                            valueBase = 16;
                                        }
                                        else if (dataType == "DEC")
                                        {
                                            valueBase = 10;
                                        }
                                        tableSet.addItomToTable(splitWithTab[i].Trim() + " " + lastORGDidx + " D", TableItemType.LABEL_TABLE_ITEM);
                                        DataType dataTableDataType = tableSet.getDataTable().valueType;
                                        if (dataTableDataType == DataType.BINARY)
                                        {
                                            tableSet.getDataTable().values[lastORGDidx] = Convert.ToString(Convert.ToInt32(dataValue, valueBase), 2).PadLeft(4, '0');
                                        }
                                        else if (dataTableDataType == DataType.DECIMAL)
                                        {
                                            tableSet.getDataTable().values[lastORGDidx] = Convert.ToString(Convert.ToInt32(dataValue, valueBase), 10);
                                        }
                                        else if (dataTableDataType == DataType.HEXADECIMAL)
                                        {
                                            tableSet.getDataTable().values[lastORGDidx] = Convert.ToString(Convert.ToInt32(dataValue, valueBase), 16);
                                        }
                                        lastORGDidx++;
                                    }
                                    else
                                    {
                                        LabelDictItem item = new LabelDictItem();
                                        int commentIndex = process.IndexOf('#');
                                        if (commentIndex != -1)
                                        {
                                            item.instructionCode = process.Substring(0, commentIndex).Trim();
                                        }
                                        else
                                            item.instructionCode = process.Trim();
                                        item.assemblyLineNum = lineCounter;
                                        item.instructionIndex = lastORGIidx;
                                        tableSet.addItomToTable(splitWithTab[i].Trim() + " " + lastORGIidx + " I", TableItemType.LABEL_TABLE_ITEM);
                                        processAssembly.LabelDict.Add(splitWithTab[i].Trim(), item);

                                    }
                                    updateDataGridSource(TableType.DATA_TABLE);
                                    updateDataGridSource(TableType.LABEL_TABLE);
                                }
                                else
                                {
                                    lastORGIidx++;
                                }

                            }

                        }
                        int comment = line.IndexOf('#');
                        if (comment != -1)
                        {
                            lbAssemblyCodes.Items.Add(line.Substring(0, comment));
                        }
                        else
                            lbAssemblyCodes.Items.Add(line);
                        rtbAssemblyCodeView.Text += line + Environment.NewLine;
                    }
                }
                #endregion

                #region ParsingInstruction

                for (int j = 0; j < rtbAssemblyCodeView.Lines.Length; j++)
                {
                    String line = rtbAssemblyCodeView.Lines[j];
                    string[] splitWithTab = line.Split('\t');

                    for (int i = 0; i < splitWithTab.Length; i++)
                    {
                        if (!String.IsNullOrWhiteSpace(splitWithTab[i]) && !splitWithTab[i].Trim().StartsWith("#") && !splitWithTab[i].Trim().EndsWith(":"))
                        {
                            #region ParsingInstructions

                            if (splitWithTab[i].Trim().EndsWith(":"))
                            {
                                if (processAssembly.LabelDict.ContainsKey(splitWithTab[i].Trim()))
                                {
                                    splitWithTab[i] = processAssembly.LabelDict[splitWithTab[i].Trim()].instructionCode;
                                }
                            }

                            if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "ORG")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                string memType = spltSpc[1];
                                int value = Convert.ToInt32(spltSpc[2].Trim());
                                processAssembly.writeToInstructionTable(Operation.ORG, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "LD")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.LD, cleanInstruction);

                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "ST")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.ST, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "ADD")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.ADD, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "SUB")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.SUB, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "AND")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.AND, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "OR")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.OR, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "XOR")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.XOR, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "SHL")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.SHL, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "SHR")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.SHR, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "INC")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.INC, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "COMA")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.COMA, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "IN" /*&& splitWithTab[i].ToUpper().Contains("IN ")*/)
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.IN, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "OUT")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.OUT, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "JMP")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.JMP, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "CALL")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.CALL, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "RET")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.RET, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "EMPTY")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.EMPTY, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "FULL")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.FULL, cleanInstruction);
                            }
                            else if (splitWithTab[i].ToUpper().Trim().Split(' ')[0].Trim() == "HLT")
                            {
                                string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                string cleanInstruction = getCleanInstruction(spltSpc);
                                processAssembly.writeToInstructionTable(Operation.HLT, cleanInstruction);
                            }
                            #endregion
                        }
                    }
                }

                #endregion
                updateAllDataGridSource();
                startDebugToolStripMenuItem.Enabled = true;
                btStartStopDebugging.Enabled = true;
                colorAssemblyCodeView();
            }


        }

        private void cbConvType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConvType.SelectedIndex == 0 && lastSelectedConv != DataType.BINARY)
            {
                //Binary
                tableSet.DataTable = tableSet.convertTableValuesTo(DataType.BINARY, tableSet.DataTable);
                tableSet.StackTable = tableSet.convertTableValuesTo(DataType.BINARY, tableSet.StackTable);
                tableSet.InstructionTable = tableSet.convertTableValuesTo(DataType.BINARY, tableSet.InstructionTable);
                //tableSet.DataTable.valueType = DataType.BINARY;
                updateAllDataGridSource();
                for (int i = 0; i < registers.Length; i++)
                {
                    registers[i].convertDataTo(DataType.BINARY);
                }
                updateAllRegisterTextBox();
                lastSelectedConv = DataType.BINARY;
            }
            else if (cbConvType.SelectedIndex == 1 && lastSelectedConv != DataType.HEXADECIMAL)
            {
                //Hexadecimal
                tableSet.DataTable = tableSet.convertTableValuesTo(DataType.HEXADECIMAL, tableSet.DataTable);
                tableSet.InstructionTable = tableSet.convertTableValuesTo(DataType.HEXADECIMAL, tableSet.InstructionTable);
                tableSet.StackTable = tableSet.convertTableValuesTo(DataType.HEXADECIMAL, tableSet.StackTable);
                updateAllDataGridSource();
                for (int i = 0; i < registers.Length; i++)
                {
                    registers[i].convertDataTo(DataType.HEXADECIMAL);
                }
                updateAllRegisterTextBox();
                lastSelectedConv = DataType.HEXADECIMAL;
            }
            else if (cbConvType.SelectedIndex == 2 && lastSelectedConv != DataType.DECIMAL)
            {
                tableSet.DataTable = tableSet.convertTableValuesTo(DataType.DECIMAL, tableSet.DataTable);
                tableSet.InstructionTable = tableSet.convertTableValuesTo(DataType.DECIMAL, tableSet.InstructionTable);
                tableSet.StackTable = tableSet.convertTableValuesTo(DataType.DECIMAL, tableSet.StackTable);
                updateAllDataGridSource();
                for (int i = 0; i < registers.Length; i++)
                {
                    registers[i].convertDataTo(DataType.DECIMAL);
                }
                updateAllRegisterTextBox();
                lastSelectedConv = DataType.DECIMAL;
            }
        }

        private void startDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startDebug();
        }

        private void btStartStopDebugging_Click(object sender, EventArgs e)
        {
            if (DEBUG_MODE)
            {
                stopDebug();
            }
            else
            {
                startDebug();
            }
        }

        private void stopDebuggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopDebug();
        }

        private void rtbAssemblyCodeView_MouseClick(object sender, MouseEventArgs e)
        {
            HighlightCurrentLine();
        }

        private void btInRegister_Click(object sender, EventArgs e)
        {
            
            if (btInRegister.Text == "Change")
            {
                txtIN.readOnly = !txtIN.readOnly;
                btInRegister.Text = "Accept";
            }
            else
            {
                try
                {
                    getRegister(RegisterType.INPUT_REGISTER).setData(txtIN.Text, getRegister(RegisterType.INPUT_REGISTER).dataType);
                    updateAllRegisterTextBox();
                    btInRegister.Text = "Change";
                    txtIN.readOnly = !txtIN.readOnly;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter Correct Values!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        void EditAssemblyMenuItem_Click(object sender, EventArgs e)
        {

            FrmEditAss edit = new FrmEditAss(rtbAssemblyCodeView.Text, LAST_FILE_PATH);
            edit.ShowDialog(this); //Creating an edit form

            DEBUG_MODE = true;
            openToolStripMenuItem_Click(null, null);
            DEBUG_MODE = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "New";
            saveFileDialog.OverwritePrompt = false;

            saveFileDialog.InitialDirectory = Path.GetFullPath(ASSEMBLY_OUTPUT_PATH);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(Path.GetFullPath(saveFileDialog.FileName)))
                {
                    MessageBox.Show("Permission denied!! Do not create a file which is already created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //If file doesnt exist then we can create a new one
                    File.Create(Path.GetFullPath(saveFileDialog.FileName)).Close();
                    if (File.Exists(Path.GetFullPath(saveFileDialog.FileName)))
                    {
                        LAST_FILENAME = saveFileDialog.FileName;
                        LAST_FILE_PATH = Path.GetFullPath(saveFileDialog.FileName);//Getting full path of new file
                        FrmEditAss edit = new FrmEditAss("", LAST_FILE_PATH);
                        edit.ShowDialog(this);//Create an edit form.
                    }
                    else
                    {
                        MessageBox.Show("File not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAssemblyMenuItem_Click(sender, e);//We need to open edit form.
        }

        private void asHEXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = ".\\Outputs\\Hex\\";
            path += Path.GetFileNameWithoutExtension(LAST_FILE_PATH) + ".hex";
            OperandProcess.exportAsHEX(Path.GetFullPath(path), tableSet.getInstructionTable());
        }

        private void asMIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = ".\\Outputs\\Mif\\";
            path += Path.GetFileNameWithoutExtension(LAST_FILE_PATH) + ".mif";
            OperandProcess.exportAsMIF(Path.GetFullPath(path), tableSet.getInstructionTable());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNextStep_Click(object sender, EventArgs e)
        {
            stepByStepToolStripMenuItem_Click(sender, e);
        }

        private void btNextInstruction_Click(object sender, EventArgs e)
        {
            nextInstructionToolStripMenuItem_Click(null, null);
        }

        private void usingGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGuide guide = new FrmGuide();
            guide.ShowDialog(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInfo info = new FrmInfo();
            info.ShowDialog(this);
        }

    }
}
