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
        bool DEBUG_MODE = false;
        int DEBUG_LINE_COUNTER = 0;
        public static TableSet tableSet;
        public static Register[] registers;
        OperandProcess processAssembly;
        DataType lastSelectedConv = DataType.BINARY;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            tableSet = new TableSet();
            processAssembly = new OperandProcess();
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
            
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbConvType.SelectedIndex = 0;
            updateAllDataGridSource();
            updateAllRegisterTextBox();
            //dGridInstruction.CurrentCell = null;
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

        public void updateDataGridSource(TableType type)
        {
            if (type == TableType.DATA_TABLE)
            {
                dGridData.DataSource = tableSet.getDataTable().values.Select(x => new { Value = x}).ToList();
                foreach (DataGridViewRow row in dGridData.Rows)
                {
                    row.HeaderCell.Value = (row.Index).ToString();
                }
                dGridData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
                dGridData.RowHeadersWidth = 45;
                dGridData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            } 
            else if (type == TableType.LABEL_TABLE)
            {
                dGridLabel.DataSource = tableSet.getLabelTable().values.Select(x => new { Value = x}).ToList();
            }
            else if (type == TableType.INSTRUCTION_TABLE)
            {
                dGridInstruction.DataSource = tableSet.getInstructionTable().values.Select(x => new { Value = x}).ToList();
                foreach (DataGridViewRow row in dGridInstruction.Rows)
                {
                    row.HeaderCell.Value = (row.Index).ToString();
                }
                dGridInstruction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
                dGridInstruction.RowHeadersWidth = 45;
                dGridInstruction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dGridInstruction.CurrentCell = DEBUG_LINE_COUNTER == 0 ? null: dGridInstruction.Rows[DEBUG_LINE_COUNTER-1].Cells[0];
            }
            else if (type == TableType.STACK_TABLE)
            {
                dGridStack.DataSource = tableSet.getStackTable().values.Select(x => new { Value = x}).ToList();
                foreach (DataGridViewRow row in dGridStack.Rows)
                {
                    row.HeaderCell.Value = (row.Index).ToString();
                }
                dGridStack.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
                dGridStack.RowHeadersWidth = 45;
                dGridStack.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            }
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

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                lbAssemblyCodes.Items.Clear();
                #region ParsingLabels
                using (StreamReader sr = new StreamReader(fileName))
                {
                    String line;

                    int lastORGDidx = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] splitWithTab = line.Split('\t');

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
                                    int valueBase = 0;
                                    if (dataType == "HEX")
                                    {
                                        valueBase = 16;
                                    }
                                    else if (dataType == "DEC")
                                    {
                                        valueBase = 10;
                                    }
                                    tableSet.addItomToTable(splitWithTab[i].Trim() + " " + lastORGDidx, TableItemType.LABEL_TABLE_ITEM);
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
                                    updateDataGridSource(TableType.DATA_TABLE);
                                    updateDataGridSource(TableType.LABEL_TABLE);
                                }

                            }

                        }
                        lbAssemblyCodes.Items.Add(line);
                    }
                }
                #endregion

                #region ParsingInstruction
                using (StreamReader sr = new StreamReader(fileName))
                {
                    String line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] splitWithTab = line.Split('\t');

                        for (int i = 0; i < splitWithTab.Length; i++)
                        {
                            if (!String.IsNullOrWhiteSpace(splitWithTab[i]) && !splitWithTab[i].Trim().StartsWith("#") && !splitWithTab[i].Trim().EndsWith(":"))
                            {
                                #region ParsingInstructions
                                if (splitWithTab[i].ToUpper().Contains("ORG "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    string memType = spltSpc[1];
                                    int value = Convert.ToInt32(spltSpc[2].Trim());
                                    processAssembly.writeToInstructionTable(Operation.ORG, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("LD "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.LD, cleanInstruction);

                                }
                                else if (splitWithTab[i].ToUpper().Contains("ST "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.ST, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("ADD "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.ADD, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("SUB "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.SUB, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("AND "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.AND, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("OR "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.OR, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("XOR "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.XOR, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("SHL "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.SHL, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("SHR "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.SHR, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("INC "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.INC, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("COMA "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.COMA, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("IN "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.IN, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("OUT "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.OUT, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("JMP "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.JMP, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("CALL "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.CALL, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("RET "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.RET, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("EMPTY "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.EMPTY, cleanInstruction);
                                }
                                else if (splitWithTab[i].ToUpper().Contains("FULL "))
                                {
                                    string[] spltSpc = splitWithTab[i].Trim().Split(' ');
                                    string cleanInstruction = getCleanInstruction(spltSpc);
                                    processAssembly.writeToInstructionTable(Operation.FULL, cleanInstruction);
                                }
                                #endregion
                            }
                        }

                    }
                }
                #endregion
                updateAllDataGridSource();
                startDebugToolStripMenuItem.Enabled = true;
                btStartStopDebugging.Enabled = true;
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
            DEBUG_MODE = true;
            startDebugToolStripMenuItem.Enabled = false;
            nextInstructionToolStripMenuItem.Enabled = true;
            DEBUG_LINE_COUNTER = 0;
            lbAssemblyCodes.SelectedIndex = DEBUG_LINE_COUNTER;
        }

        private void nextInstructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DEBUG_LINE_COUNTER < lbAssemblyCodes.Items.Count)
            {
                lbAssemblyCodes.SelectedIndex = DEBUG_LINE_COUNTER;
                
            }
            processAssembly.fetch(ref registers[8], ref registers[7], tableSet.getInstructionTable());
            updateAllRegisterTextBox();
            dGridInstruction.CurrentCell = dGridInstruction.Rows[DEBUG_LINE_COUNTER].Cells[0];
            DEBUG_LINE_COUNTER++;
            if (DEBUG_LINE_COUNTER >= dGridInstruction.Rows.Count)
            {
                DEBUG_LINE_COUNTER = 0;
            }
            
        }

        private void btStartStopDebugging_Click(object sender, EventArgs e)
        {
            if (DEBUG_MODE)
            {
                DEBUG_MODE = false;
                btStartStopDebugging.Text = "Start";
                for (int i = 0; i < registers.Length; i++)
                {
                    registers[i].setData("0", DataType.DECIMAL);
                }
                btStartStopDebugging.ImageIndex = 0;
                nextInstructionToolStripMenuItem.Enabled = false;
                startDebugToolStripMenuItem.Enabled = true;
                updateAllRegisterTextBox();
                DEBUG_LINE_COUNTER = 0;
                dGridInstruction.CurrentCell = dGridInstruction.Rows[DEBUG_LINE_COUNTER].Cells[0];
                dGridInstruction.CurrentCell = null;
            }
            else
            {
                btStartStopDebugging.ImageIndex = 1;
                btStartStopDebugging.Text = "Stop";
                this.startDebugToolStripMenuItem_Click(sender, e);
            }
        }


    }
}
