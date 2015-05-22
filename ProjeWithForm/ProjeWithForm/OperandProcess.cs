using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProjeWithForm
{
    public enum Operation
    {
        ORG,HLT,ADD,SUB,AND,OR,XOR,SHL,SHR,INC,COMA,LD,ST,IN,OUT,JMP,CALL,RET,EMPTY,END,FULL
    }

    public struct LabelDictItem {

        public string instructionCode;
        public int assemblyLineNum;
        public int instructionIndex;
    }

    class OperandProcess
    {

        #region variables
        private static int maskFor4Bit = 15;

        public string EXECUTE_STRING = "\tExecute ";
        public static string FETCH_STRING = "\tFetch \tT0: IR <- IM[PC]\n";
        public static string DECODE_STRING = "\tDecode  T1: A <- IR[13], B <- IR[4]\n\t\t\t IR(12-9) -> Decoding\n\t\t\t AR <- IR(3-0), PC <- PC + 1\n";

        public TextBox txtShowOpcode;
        public TextBox txtShowValue;

        public int orgInstructionIndex { get; set; }
        public int orgDataIndex { get; set; }
        Hashtable insOpTable;
        public bool carryOut = false;
        public bool overFlow = false;
        public bool zero = false;
        public bool Jump = false;
        public bool stackEmpty = true;
        public bool stackFull = false;

        public Dictionary<string,LabelDictItem> LabelDict;

        public int insTableLine = 0;
        #endregion

        public OperandProcess(ref TextBox txtValue, ref TextBox txtOpcode)
        {

            txtShowOpcode = txtOpcode;
            txtShowValue = txtValue;
            orgInstructionIndex = 0;
            orgDataIndex = 0;
            insOpTable = new Hashtable();
            LabelDict = new Dictionary<string, LabelDictItem>();
            
            //Adding instructions to hash
            insOpTable.Add("ORG", "00001");
            insOpTable.Add("HLT", "00010");

            insOpTable.Add("ADD", "10000");
            insOpTable.Add("SUB", "10001");
            insOpTable.Add("AND", "10100");
            insOpTable.Add("OR", "10101");
            insOpTable.Add("XOR", "10110");
            insOpTable.Add("SHL", "10010");
            insOpTable.Add("SHR", "10011");
            insOpTable.Add("INC", "11111");
            insOpTable.Add("COMA", "10111");
            
            insOpTable.Add("LD", "01100");
            insOpTable.Add("ST", "01101");

            insOpTable.Add("IN", "01110");
            insOpTable.Add("OUT", "01111");

            insOpTable.Add("JMP", "01001");
            insOpTable.Add("CALL", "01010");
            insOpTable.Add("RET", "01011");
            insOpTable.Add("EMPTY", "00110");
            insOpTable.Add("FULL", "00111");
            // end of the isntructions
        }

        public static void exportAsMIF(string path, Table instructionTable)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("DEPTH = " + instructionTable.values.Length + ";");
                writer.WriteLine("WIDTH = " + 14 + ";");
                writer.WriteLine("ADDRESS_RADIX = DEC;");
                writer.WriteLine("DATA_RADIX = BIN;");
                writer.WriteLine("CONTENT");
                writer.WriteLine("BEGIN");

                for (int i = 0; i < instructionTable.values.Length; i++)
                {
                    writer.WriteLine(i + " : " + Convert.ToString(Convert.ToInt32(instructionTable.values[i],instructionTable.valueBase), 2).PadLeft(14, '0') + ";");
                }
                writer.WriteLine("END;");
                writer.Close();
            }

            if (MessageBox.Show("Show in Explorer?", "Show", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(@Path.GetDirectoryName(path));
            }

        }

        public static void exportAsHEX(string path, Table instructionTable)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {

                for (int i = 0; i < instructionTable.values.Length; i++)
                {
                    string hexCommand = ":";
                    
                    string hexPair = "02";
                    string hexAddress = Convert.ToString(i, 16).PadLeft(4,'0');
                    string hexRecordType = "00";//Data
                    string hexData = Convert.ToString(Convert.ToInt32(instructionTable.values[i], instructionTable.valueBase), 16).PadLeft(4, '0');
                    int intPair = Convert.ToInt32(hexPair, 16);
                    int intAddress = Convert.ToInt32(hexAddress.Substring(0, 2), 16) + Convert.ToInt32(hexAddress.Substring(2, 2), 16);
                    int intData = Convert.ToInt32(hexData.Substring(0, 2), 16) + Convert.ToInt32(hexData.Substring(2, 2), 16);
                    int sum = intPair + intAddress + intData;
                    
                    string checkSum = Convert.ToString(sum, 16);
                    if (checkSum.Length > 2)
                    {
                        checkSum = checkSum.Substring(checkSum.Length - 2, 2);
                    }
                    sum = 255 - Convert.ToInt32(checkSum, 16);
                    checkSum = Convert.ToString(sum, 16).PadLeft(2,'F');

                    hexCommand += hexPair + hexAddress + hexRecordType + hexData + checkSum;
                    writer.WriteLine(hexCommand);
                }
                writer.WriteLine(":00000001FF");
                writer.Close();
            }
            if (MessageBox.Show("Show in Explorer?","Show",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(@Path.GetDirectoryName(path));
            }
            
        }

        private string getRegisterBinary(string registerInString)
        {
            switch (registerInString.ToLower())
            {
                case "r1":
                case "00":
                    return "00";
                case "r2":
                case "01":
                    return "01";
                case "r3":
                case "10":
                    return "10";
                case "r4":
                case "11":
                    return "11";
                default:
                    return "00";
            }
        }

        private int getValueIndex(string valueString)
        {
            valueString = valueString.Trim();
            int result;
            bool returned = int.TryParse(valueString, out result);
            if (!returned)
            {

                string[] labels = MainForm.tableSet.getLabelTable().values;
                int dataAddress = -1;
                foreach (string label in labels)
                {
                    if (!String.IsNullOrWhiteSpace(label))
                    {
                        string[] temp = label.Split(' ');
                        if (temp[0].Trim().Substring(0, temp[0].Trim().Length - 1) == valueString)
                        {
                            dataAddress = Convert.ToInt32(temp[1].Trim());
                            break;
                        }
                    }
                }
                if (dataAddress != -1)
                {
                    result = dataAddress;
                }
            }
            return result;
        }

        //Instructionda ki datayı döner eğer label varsa labelı data memmoryden bulup değeri döner.
        private int getValueData(string valueString)
        {
            valueString = valueString.Trim();
            switch (valueString.ToUpper())
            {
                case "R1":
                case "00":
                case "R2":
                case "01":
                case "R3":
                case "10":
                case "R4":
                case "11":
                    string rBin = getRegisterBinary(valueString.ToUpper());
                    int reg = Convert.ToInt32(rBin, 2);
                    return reg;
                default:
                    break;
            }
            int result;
            bool returned = int.TryParse(valueString, out result);
            if (!returned)
            {
                string[] labels = MainForm.tableSet.getLabelTable().values;
                int dataAddress = -1;
                foreach (string label in labels)
                {
                    if (!String.IsNullOrWhiteSpace(label))
                    {
                        string[] temp = label.Split(' ');
                        if (temp[0].Trim().Substring(0, temp[0].Trim().Length - 1) == valueString)
                        {
                            dataAddress = Convert.ToInt32(temp[1].Trim());
                            break;
                        }
                    }
                    
                }
                if (dataAddress != -1)
                {
                    string dataString = MainForm.tableSet.getDataTable().values[dataAddress];
                    DataType dataType = MainForm.tableSet.getDataTable().valueType;
                    int fromBase = 2;
                    if (dataType == DataType.DECIMAL)
                    {
                        fromBase = 10;
                    }
                    else if (dataType == DataType.HEXADECIMAL)
                    {
                        fromBase = 16;
                    }
                    result = Convert.ToInt32(dataString, fromBase);
                }
            }
            return result;
        }

        public void writeToInstructionTable(Operation op, string cleanOpString)
        {
            cleanOpString = cleanOpString.Trim();
            string[] insParam = cleanOpString.Split(' ');
            string insMemory = "";
            insMemory = insOpTable[insParam[0].Trim().ToUpper()].ToString();
            string[] values = null;//ew string[0];
            switch (op)
            {
                case Operation.ORG:
                    if (insParam[1].ToUpper() == "I")
                    {
                        orgInstructionIndex = Convert.ToInt16(insParam[2]);
                    }
                    else if (insParam[1].ToUpper() == "D")
                    {
                        orgDataIndex = Convert.ToInt16(insParam[2]);
                    }
                    break;
                case Operation.HLT:
                    insMemory = insMemory.PadRight(14, '0');
                    break;
                case Operation.ADD: case Operation.SUB: case Operation.AND: case Operation.OR: case Operation.XOR:

                    values = insParam[1].Split(',');
                    insMemory += getRegisterBinary(values[0].Trim()) + getRegisterBinary(values[1].Trim());
                    if (insParam.Length > 2 && insParam[2].Trim().ToUpper() == "B")
                    {
                        insMemory += "1";
                    }
                    else
                    {
                        insMemory += "0";
                    }
                    insMemory += Convert.ToString(getValueData(values[2]), 2).PadLeft(4, '0');

                    break;
                case Operation.SHL: case Operation.SHR: case Operation.INC: case Operation.COMA:

                    values = insParam[1].Split(',');
                    insMemory += getRegisterBinary(values[0].Trim()) + getRegisterBinary(values[1].Trim());
                    insMemory = insMemory.PadRight(14, '0');

                    break;
                case Operation.LD:

                    values = insParam[1].Split(',');
                    insMemory += getRegisterBinary(values[0].Trim()) + "000";
                    insMemory += Convert.ToString(getValueIndex(values[1]), 2).PadLeft(4, '0');
                    break;
                case Operation.ST:

                    values = insParam[1].Split(',');
                    insMemory += "00" + getRegisterBinary(values[0].Trim()) + "0";
                    insMemory += Convert.ToString(getValueIndex(values[1]), 2).PadLeft(4, '0');
                    break;
                case Operation.IN:

                    values = insParam[1].Split(',');
                    insMemory += getRegisterBinary(values[0].Trim()) + "00";
                    if (insParam.Length > 2 && insParam[2].Trim().ToUpper() == "B")
                    {
                        insMemory += "1";
                    }
                    else
                    {
                        insMemory += "0";
                    }
                    if (values.Length > 1 && !String.IsNullOrWhiteSpace(values[1]))
                    {
                        insMemory += Convert.ToString(getValueData(values[1]), 2).PadLeft(4, '0');
                    }
                    else
                    {
                        insMemory += "0000";
                    }
                    
                    break;
                case Operation.OUT:

                    values = insParam[1].Split(',');
                    insMemory += "00" + getRegisterBinary(values[0].Trim());
                    if (insParam.Length > 2 && insParam[2].Trim().ToUpper() == "B")
                    {
                        insMemory += "1";
                        insMemory += Convert.ToString(getValueData(values[0]), 2).PadLeft(4, '0');
                    }
                    else
                    {
                        insMemory += "0";
                        insMemory += "0000";
                    }
                    break;
                case Operation.JMP:
                    values = insParam[1].Split(',');
                    insMemory += getRegisterBinary(values[0].Trim()) + "00";
                    if (values.Length > 1 && LabelDict.ContainsKey(values[1].Trim() + ":"))
                    {
                        insMemory += Convert.ToString(LabelDict[values[1].Trim() + ":"].instructionIndex, 2).PadLeft(5, '0');
                    }
                    else
                    {
                        insMemory += Convert.ToString(Convert.ToInt32(values[1].Trim()), 2).PadLeft(5, '0');
                    }
                    break;
                case Operation.CALL:
                    values = insParam[1].Split(',');
                    insMemory += "0000";
                    if (LabelDict.ContainsKey(insParam[1].Trim() + ":"))
                    {
                        insMemory += Convert.ToString(LabelDict[insParam[1].Trim() + ":"].instructionIndex,2).PadLeft(5,'0');
                    }
                    else
                    {
                        insMemory += Convert.ToString(Convert.ToInt32(insParam[1].Trim()), 2).PadLeft(5, '0');
                    }
                    break;
                case Operation.RET:
                    insMemory = insMemory.PadRight(14, '0');
                    break;
                case Operation.EMPTY:
                    break;
                case Operation.END:
                    break;
                case Operation.FULL:
                    break;
                default:
                    break;
            }

            if (op != Operation.ORG)
            {
                MainForm.tableSet.getInstructionTable().values[orgInstructionIndex] = insMemory;
                orgInstructionIndex++;
            }

        }

        void ORG(string orgCommand)
        {

            orgCommand = orgCommand.Trim();
            string[] param = orgCommand.Split(' ');
            for (int i = 0; i < param.Length; i++)
            {
                if (param[i] == "I")
                {
                    for (int j = i + 1; j < param.Length; j++)
                    {
                        if (!String.IsNullOrWhiteSpace(param[i]))
                        {
                            orgInstructionIndex = Convert.ToInt32(param[i]);
                        }
                    }
                    break;
                }
                else if (param[i] == "D")
                {
                    for (int j = i + 1; j < param.Length; j++)
                    {
                        if (!String.IsNullOrWhiteSpace(param[i]))
                        {
                            orgDataIndex = Convert.ToInt32(param[i]);
                        }
                    }
                    break;
                }
            }
        }

        public void fetch(ref Register programCounter, ref Register instructionRegister, ref Register addressRegister, Table instructionTable)
        {
            //instruction table'dan program counterin gösterdiği adresteki değeri instructionRegister'in datasına atıp 
            //programCounterin datasını 1 arttıracağız
            Jump = false;
            int pcValue = programCounter.convertDataToInt();
            string instruction = instructionTable.values[pcValue];
            instructionRegister.setData(instruction, instructionTable.valueType);
            if (instruction[0] == '1')
            {
                resetFlags();
            }
            
            int instructionBase = instructionTable.valueType == DataType.DECIMAL ? 10 : instructionTable.valueType == DataType.HEXADECIMAL ? 16 : 2;
            if (instructionBase != 2)
            {
                instruction = Convert.ToString(Convert.ToInt32(instruction, instructionBase), 2).PadLeft(14,'0');
            }
            string address = instruction[10] + "" + instruction[11] + "" + instruction[12] + "" + instruction[13];
            addressRegister.setData(address, DataType.BINARY);
            pcValue++;
            if (pcValue >= instructionTable.values.Length)
            {
                pcValue = 0;
            }
            programCounter.setData(pcValue.ToString(), DataType.DECIMAL);
            
        }

        public bool decode(ref Register[] registers, ref TableSet tables)
        {
            EXECUTE_STRING = "\tExecute ";
            string instruction = MainForm.getRegister(RegisterType.INSTRUCTION_REGISTER).data;
            DataType insDataType = MainForm.getRegister(RegisterType.INSTRUCTION_REGISTER).dataType;
            int instructionBase = 2;
            instructionBase = insDataType == DataType.DECIMAL ? 10 : insDataType == DataType.HEXADECIMAL ? 16 : 2;
            if (instructionBase != 2)
            {
                instruction = Convert.ToString(Convert.ToInt32(instruction, instructionBase), 2).PadLeft(14, '0');
            }
            string insOpCode = instruction.Substring(0, 5);
            
            string destination = (Convert.ToInt32(instruction[5] + "" + instruction[6], 2) + 1).ToString();
            string source = (Convert.ToInt32(instruction[7] + "" + instruction[8], 2) + 1).ToString();
            string dataBS2 = instruction[9] + "" + instruction[10] + "" + instruction[11] + "" + instruction[12] + "" + instruction[13];
            string dataString = instruction[10] + "" + instruction[11] + "" + instruction[12] + "" + instruction[13];
            int data = Convert.ToInt32(dataString, 2);
            bool bFlag = false;

            //////////////////////////
            string showValue = "";
            string showOpcode = "";

            switch (insOpCode)
            {
                case "00010"://HLT
                    showOpcode = "HLT";
                    return false;
                case "10000"://ADD
                    EXECUTE_STRING += "ADD:\t R";
                    EXECUTE_STRING += destination;
                    showOpcode = "ADD";
                    if (instruction[9] == '1')
                    {
                        EXECUTE_STRING += " <- R" + source +" + AR, SC <- 0\n";
                        showValue = "R" + destination + ", R" + source + ", AR";
                        bFlag = true;
                    }
                    else
                    {
                        EXECUTE_STRING += " <- R" + source + " + R" + (MainForm.getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt() + 1) + ", SC <- 0\n";
                        showValue = "R" + destination + ", R" + source + ", R" + (MainForm.getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt() + 1);
                    }
                    ADD(ref registers[Convert.ToInt16(destination) - 1], ref registers[Convert.ToInt16(source) - 1], data, bFlag);
                    break;
                case "10001"://SUB
                    EXECUTE_STRING += "SUB:\t R";
                    showOpcode = "SUB";
                    EXECUTE_STRING += destination;
                    bFlag = false;
                    if (instruction[9] == '1')
                    {
                        EXECUTE_STRING += " <- R" + source +" - AR, SC <- 0\n";
                        showValue = "R" + destination + ", R" + source + ", AR";
                        bFlag = true;
                    }
                    else
                    {
                        EXECUTE_STRING += " <- R" + source + " - R" + (MainForm.getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt() + 1) + ", SC <- 0\n";
                        showValue = "R" + destination + ", R" + source + ", R" + (MainForm.getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt() + 1);
                    }
                    SUB(ref registers[Convert.ToInt16(destination) - 1], ref registers[Convert.ToInt16(source) - 1], data, bFlag);
                    break;
                case "10100"://AND
                    EXECUTE_STRING += "AND:\t R";
                    EXECUTE_STRING += destination;
                    showOpcode = "AND";
                    if (instruction[9] == '1')
                    {
                        EXECUTE_STRING += " <- R" + source + " ∧ AR, SC <- 0\n";
                        showValue = "R" + destination + ", R" + source + ", AR";
                        bFlag = true;
                    }
                    else
                    {
                        EXECUTE_STRING += " <- R" + source + " ∧ R" + (MainForm.getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt() + 1) + ", SC <- 0\n";
                        showValue = "R" + destination + ", R" + source + ", R" + (MainForm.getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt() + 1);
                    }
                    And(ref registers[Convert.ToInt32(destination) - 1], ref registers[Convert.ToInt32(source) - 1], data, bFlag);
                    break;
                case "10101"://OR
                    EXECUTE_STRING += "OR:\t R";
                    showOpcode = "OR";
                    EXECUTE_STRING += destination;
                    if (instruction[9] == '1')
                    {
                        EXECUTE_STRING += " <- R" + source + " V AR, SC <- 0\n";
                        showValue = "R" + destination + ", R" + source + ", AR";
                        bFlag = true;
                    }
                    else
                    {
                        EXECUTE_STRING += " <- R" + source + " V R" + (MainForm.getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt() + 1) + ", SC <- 0\n";
                        showValue = "R" + destination + ", R" + source + ", R" + (MainForm.getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt() + 1);
                    }
                    Or(ref registers[Convert.ToInt32(destination) - 1], ref registers[Convert.ToInt32(source) - 1], data, bFlag);
                    break;
                case "10110"://XOR
                    EXECUTE_STRING += "XOR:\t R";
                    EXECUTE_STRING += destination;
                    showOpcode = "XOR";
                    if (instruction[9] == '1')
                    {
                        EXECUTE_STRING += " <- R" + source + " ⊕ AR, SC <- 0\n";
                        showValue = "R" + destination + ", R" + source + ", AR";
                        bFlag = true;
                    }
                    else
                    {
                        EXECUTE_STRING += " <- R" + source + " ⊕ R" + (MainForm.getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt() + 1) + ", SC <- 0\n";
                        showValue = "R" + destination + ", R" + source + ", R" + (MainForm.getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt() + 1);
                    }
                    xOr(ref registers[Convert.ToInt32(destination) - 1], ref registers[Convert.ToInt32(source) - 1], data, bFlag);
                    break;
                case "10010"://SHL
                    EXECUTE_STRING += "SHL:\t R";
                    showOpcode = "SHL";
                    EXECUTE_STRING += destination;
                    EXECUTE_STRING += " <- shiftL R" + source + ", SC <- 0\n";
                    showValue = "R" + destination + ", R" + source;
                    shiftLeft(ref registers[Convert.ToInt32(destination) - 1], ref registers[Convert.ToInt32(source) - 1]);
                    break;
                case "10011"://SHR
                    EXECUTE_STRING += "SHR:\t R";
                    showOpcode = "SHR";
                    EXECUTE_STRING += destination;
                    EXECUTE_STRING += " <- shiftR R" + source + ", SC <- 0\n";
                    showValue = "R" + destination + ", R" + source;
                    shiftRight(ref registers[Convert.ToInt32(destination) - 1], ref registers[Convert.ToInt32(source) - 1]);
                    break;
                case "11111"://INC
                    EXECUTE_STRING += "INC:\t R";
                    showOpcode = "INC";
                    EXECUTE_STRING += destination;
                    EXECUTE_STRING += " <- R" + source + " + 1, SC <- 0\n";
                    showValue = "R" + destination + ", R" + source;
                    INC(ref registers[Convert.ToInt32(destination) - 1], ref registers[Convert.ToInt32(source) - 1]);
                    break;
                case "10111"://COMA
                    EXECUTE_STRING += "COMA:\t R";
                    showOpcode = "COMA";
                    EXECUTE_STRING += destination;
                    EXECUTE_STRING += " <- ¬R" + source + ", SC <- 0\n";
                    showValue = "R" + destination + ", R" + source;
                    COMA(ref registers[Convert.ToInt32(destination) - 1], ref registers[Convert.ToInt32(source) - 1]);
                    break;
                case "01100"://LD
                    EXECUTE_STRING += "LD:\t R";
                    showOpcode = "LD";
                    EXECUTE_STRING += destination;
                    EXECUTE_STRING += " <- DM[AR], SC <- 0\n";
                    showValue = "R" + destination + ", DM[AR]";
                    registers[Convert.ToInt16(destination) - 1].setData(tables.DataTable.values[MainForm.getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt()], tables.DataTable.valueType);
                    break;
                case "01101"://ST
                    EXECUTE_STRING += "ST:\t DM[AR] <- R";
                    EXECUTE_STRING += source;
                    showValue = "DM[AR], R" + source;
                    showOpcode = "ST";
                    EXECUTE_STRING += ", SC <- 0\n";
                    
                    tables.setTableItem(registers[Convert.ToInt32(source) - 1].data, registers[Convert.ToInt32(source) - 1].dataType, MainForm.getRegister(RegisterType.ADDRESS_REGISTER).convertDataToInt(), TableType.DATA_TABLE);
                    break;
                case "01110"://IN
                    showOpcode = "IN";
                    if (instruction[9] == '1')
                    {
                        EXECUTE_STRING += "IN:\t DM[AR] <- InR, SC <- 0\n";
                        showValue = "DM[AR], InR";
                        bFlag = true;
                    }
                    else
                    {
                        EXECUTE_STRING += "IN:\t R" + destination + " <- InR, SC <- 0\n";
                        showValue = "R" + destination +", InR";
                    }
                    IN(ref registers[Convert.ToInt32(destination) - 1], data, bFlag, ref tables);
                    break;
                case "01111"://OUT
                    showOpcode = "OUT";
                    if (instruction[9] == '1')
                    {
                        EXECUTE_STRING += "OUT:\t OuR <- DM[AR], SC <- 0\n";
                        bFlag = true;
                    }
                    else
                    {
                        EXECUTE_STRING += "OUT:\t OuR <- R" + source + ", SC <- 0\n";
                        showValue = "OuR, R" + source;
                    }
                    OUT(ref registers[6], ref registers[Convert.ToInt32(source) - 1], data, bFlag, ref tables);
                    break;
                case "01001"://JMP
                    showOpcode = "JMP";
                    bool jmpExecute = false;
                    if ((Convert.ToInt16(destination) == 1 && carryOut) || (Convert.ToInt16(destination) == 2 && zero) || 
                        (Convert.ToInt16(destination) == 3 && overFlow))
                    {
                        EXECUTE_STRING += "JMP:\t PC(4) <- B, PC(3-0) <- AR, SC <- 0\n";
                        jmpExecute = true;
                        
                    }
                    else
                    {
                        EXECUTE_STRING += "JMP:\t Not Executed!!";
                    }

                    if (jmpExecute)
                    {
                        JMP(ref registers[8], dataBS2);
                    }
                    
                    break;
                case "01010"://CALL
                    showOpcode = "CALL";
                    EXECUTE_STRING += "CALL:\t --(T2)-- SM[SP] <- PC\n\t\t --(T3) -- SP <- SP + 1, PC <- BS2, SC <- 0\n";
                    CALL(Convert.ToInt32(dataBS2, 2), ref registers[8], ref registers[9], ref tables);
                    break;
                case "01011"://RET
                    showOpcode = "RET";
                    EXECUTE_STRING += "CALL:\t --(T2)-- SP <- SP - 1\n\t\t --(T3) -- PC <- SM[SP], SC <- 0\n";
                    RET(ref registers[9], ref registers[8], ref tables);
                    break;
                case "00110"://EMPTY
                    showOpcode = "EMPTY";
                    break;
                case "00111"://FULL
                    showOpcode = "FULL";
                    break;
            }
            txtShowOpcode.Text = showOpcode;
            txtShowValue.Text = showValue;
            return true;
        }

        void JMP(ref Register programCounter, string BS2)
        {
            programCounter.setData(BS2, DataType.BINARY);
            insTableLine = Convert.ToInt32(BS2, 2)-1;
            Jump = true;
        }
        void ADD(ref Register rDestination,ref Register source, int data, bool bFlag)
        {
            int destination = 0;
            if (bFlag)
            {
                destination = data + source.convertDataToInt();
            }
            else
            {
                destination = source.convertDataToInt() + MainForm.registers[data].convertDataToInt();
            }
            if (destination > 15)
            {
                carryOut = true;
                overFlow = true;
                destination = destination & maskFor4Bit;
            }
            else if (destination == 0)
            {
                zero = true;
            }
            rDestination.setData(Convert.ToString(destination), DataType.DECIMAL);
            
        }
        void SUB(ref Register rDestination,ref Register source, int data, bool bFlag)
        {
            int destination = 0;
            if (bFlag)
            {
                destination = source.convertDataToInt() - data;
            }
            else
            {
                destination = source.convertDataToInt() - MainForm.registers[data].convertDataToInt();
            }
            if (destination < 0)
            {
                carryOut = true;
                overFlow = true;
                destination = destination & maskFor4Bit;
            }
            else if (destination == 0)
            {
                zero = true;
            }
            

            rDestination.setData(Convert.ToString(destination), DataType.DECIMAL);

        }
        void And(ref Register rDestination,ref Register source, int data, bool bFlag)
        {
            int sourceData = source.convertDataToInt();
            if (bFlag)
            {
                int registerData = MainForm.registers[Convert.ToInt32(data)].convertDataToInt();

                int res = sourceData & registerData;

                rDestination.setData(res.ToString(), DataType.DECIMAL);

            }
            else
            {
                int res = sourceData & data;
                rDestination.setData(res.ToString(), DataType.DECIMAL);
            }
        }
        void Or(ref Register rDestination,ref Register source, int data, bool bFlag)
        {
            int sourceData = source.convertDataToInt();
            
            if (bFlag)
            {
                int res = sourceData | data;
                rDestination.setData(res.ToString(), DataType.DECIMAL);   
            }
            else
            {
                int registerData = MainForm.registers[Convert.ToInt32(data)].convertDataToInt();
                int res = sourceData | registerData;
                rDestination.setData(res.ToString(), DataType.DECIMAL);
            }
        }
        void xOr(ref Register rDestination,ref Register source, int data, bool bFlag)
        {
            int sourceData = source.convertDataToInt();
            
            if (bFlag)
            {
                int res = sourceData ^ data;
                rDestination.setData(res.ToString(), DataType.DECIMAL);
            }
            else
            {
                int registerData = MainForm.registers[Convert.ToInt32(data)].convertDataToInt();
                int res = sourceData ^ registerData;
                rDestination.setData(res.ToString(), DataType.DECIMAL);
            }
        }
        void shiftLeft(ref Register rDestination, ref Register source)
        {
            int sourceData = source.convertDataToInt();
            sourceData = sourceData << 1;
            if (sourceData > 15)
            {
                overFlow = true;
                sourceData = sourceData & maskFor4Bit;
            }
            else if (sourceData == 0)
            {
                zero = true;
            }
            rDestination.setData(sourceData.ToString(), DataType.DECIMAL);
        }
        void shiftRight(ref Register rDestination,ref Register source)
        {
            int sourceData = source.convertDataToInt();
            sourceData = sourceData >> 1;
            if (sourceData == 0)
            {
                zero = true;
            }
            rDestination.setData(sourceData.ToString(), DataType.DECIMAL);
        }
        void INC(ref Register rDesination, ref Register rSource)
        {
            rDesination.setData((rSource.convertDataToInt() + 1).ToString(), DataType.DECIMAL);
        }
        void COMA(ref Register rDestination, ref Register rSource)
        {
            rDestination.setData((~rSource.convertDataToInt()).ToString(), DataType.DECIMAL);
        }
        void IN(ref Register rDestination, int S2, bool bFlag, ref TableSet tables)
        {
            if (bFlag)
            {
                tables.setTableItem(MainForm.getRegister(RegisterType.INPUT_REGISTER).data,
                    MainForm.getRegister(RegisterType.INPUT_REGISTER).dataType, S2, TableType.DATA_TABLE);
            }
            else
            {
                rDestination.setData(MainForm.getRegister(RegisterType.INPUT_REGISTER).data, MainForm.getRegister(RegisterType.INPUT_REGISTER).dataType);
            }
        }
        void OUT(ref Register outRegister, ref Register rSource, int S2, bool bFlag, ref TableSet tables)
        {
            if (bFlag)
            {
                string content = tables.DataTable.values[S2];
                outRegister.setData(content, tables.DataTable.valueType);
            }
            else
            {
                outRegister.setData(rSource.data, rSource.dataType);
            }
        }
        void CALL(int BS2, ref Register programCounter, ref Register stackPointer, ref TableSet tables)
        {
            string pcData = programCounter.data;
            tables.setTableItem(pcData, programCounter.dataType, stackPointer.convertDataToInt(), TableType.STACK_TABLE);
            int newSP = stackPointer.convertDataToInt() + 1;
            if (newSP > tables.StackTable.values.Length)
            {
                MessageBox.Show("Stack Overflow!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (newSP == tables.StackTable.values.Length)
            {
                stackFull = true;
            }
            stackEmpty = false;
            stackPointer.setData(newSP.ToString(), DataType.DECIMAL);
            programCounter.setData(BS2.ToString(), DataType.DECIMAL);
            insTableLine = BS2 - 1;
            Jump = true;
        }
        void RET(ref Register stackPointer, ref Register programCounter, ref TableSet tables)
        {
            int newSP = stackPointer.convertDataToInt() - 1;
            if (newSP < 0)
            {
                MessageBox.Show("Stack Overflow!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (newSP == 0)
            {
                stackEmpty = true;
                stackFull = false;
            }
            stackPointer.setData((stackPointer.convertDataToInt() - 1).ToString(), DataType.DECIMAL);
            programCounter.setData(tables.StackTable.values[stackPointer.convertDataToInt()], tables.StackTable.valueType);
            insTableLine = programCounter.convertDataToInt() - 1;
            Jump = true;
        }
        public void resetFlags()
        {
            zero = false;
            Jump = false;
            carryOut = false;
            overFlow = false;
        }

    }
}
