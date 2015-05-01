using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ProjeWithForm
{
    public enum Operation
    {
        ORG,HLT,ADD,SUB,AND,OR,XOR,SHL,SHR,INC,COMA,LD,ST,IN,OUT,JMP,CALL,RET,EMPTY,END,FULL
    }
    class OperandProcess
    {

        

        #region variables
        private static int maskFor4Bit = 15;

        private int orgInstructionIndex;
        private int orgDataIndex;
        Hashtable insOpTable;
        private bool carryOut = false;
        private bool overFlow = false;
        private bool zero = true;
        private int sequenceCounter = 0;
        #endregion

        public OperandProcess()
        {
            orgInstructionIndex = 0;
            orgDataIndex = 0;
            insOpTable = new Hashtable();
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

        private string getRegisterBinary(string registerInString)
        {
            switch (registerInString.ToLower())
            {
                case "r1":
                    return "00";
                case "r2":
                    return "01";
                case "r3":
                    return "10";
                case "r4":
                    return "11";
                default:
                    return null;
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
            string insMemmory = "";
            insMemmory = insOpTable[insParam[0].Trim().ToUpper()].ToString();
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

                    break;
                case Operation.ADD: case Operation.SUB: case Operation.AND: case Operation.OR: case Operation.XOR:

                    values = insParam[1].Split(',');
                    insMemmory += getRegisterBinary(values[0].Trim()) + getRegisterBinary(values[1].Trim());
                    if (insParam.Length > 2 && insParam[2].Trim().ToUpper() == "B")
                    {
                        insMemmory += "1";
                    }
                    else
                    {
                        insMemmory += "0";
                    }
                    insMemmory += Convert.ToString(getValueData(values[2]), 2).PadLeft(4, '0');

                    break;
                case Operation.SHL: case Operation.SHR: case Operation.INC: case Operation.COMA:

                    values = insParam[1].Split(',');
                    insMemmory += getRegisterBinary(values[0].Trim()) + getRegisterBinary(values[1].Trim());
                    insMemmory = insMemmory.PadRight(14, '0');

                    break;
                case Operation.LD:

                    values = insParam[1].Split(',');
                    insMemmory += getRegisterBinary(values[0].Trim()) + "000";
                    insMemmory += Convert.ToString(getValueData(values[1]), 2).PadLeft(4, '0');
                    break;
                case Operation.ST:

                    values = insParam[1].Split(',');
                    insMemmory += "00" + getRegisterBinary(values[0].Trim()) + "0";
                    insMemmory += Convert.ToString(getValueIndex(values[1]), 2).PadLeft(4, '0');
                    break;
                case Operation.IN:

                    values = insParam[1].Split(',');
                    insMemmory += getRegisterBinary(values[0].Trim()) + "00";
                    if (insParam.Length > 2 && insParam[2].Trim().ToUpper() == "B")
                    {
                        insMemmory += "1";
                    }
                    else
                    {
                        insMemmory += "0";
                    }
                    insMemmory += Convert.ToString(getValueData(values[1]), 2).PadLeft(4, '0');
                    break;
                case Operation.OUT:

                    values = insParam[1].Split(',');
                    insMemmory += "00" + getRegisterBinary(values[0].Trim());
                    if (insParam.Length > 2 && insParam[2].Trim().ToUpper() == "B")
                    {
                        insMemmory += "1";
                    }
                    else
                    {
                        insMemmory += "0";
                    }
                    break;
                case Operation.JMP:
                    //Will write

                    break;
                case Operation.CALL:
                    break;
                case Operation.RET:
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
                MainForm.tableSet.getInstructionTable().values[orgInstructionIndex] = insMemmory;
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

        public void fetch(ref Register programCounter, ref Register instructionRegister, Table instructionTable)
        {
            //instruction table'dan program counterin gösterdiği adresteki değeri instructionRegister'in datasına atıp 
            //programCounterin datasını 1 arttıracağız
            int pcValue = programCounter.convertDataToInt();
            string instruction = instructionTable.values[pcValue];
            instructionRegister.setData(instruction, instructionTable.valueType);
            pcValue++;
            if (pcValue >= instructionTable.values.Length)
            {
                pcValue = 0;
            }
            programCounter.setData(pcValue.ToString(), DataType.DECIMAL);
        }

        public void decode(Register[] registers)
        {
            
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

            rDestination.setData(Convert.ToString(destination), DataType.DECIMAL);

        }
        void And(ref Register rDestination,ref Register source, int data, bool bFlag)
        {
            if (bFlag)
            {
                String destination = "";
                String source2 = source.data;
                Register dataString = new Register(RegisterType.GENERAL_REGISTER);
                dataString.setData(Convert.ToString(data), DataType.DECIMAL);
                for (int i = 0; i < 4; i++)
                {
                    if (dataString.data.Substring(i, 1) == source2.Substring(i, 1))
                    {
                        destination = destination + "1";
                    }
                    else
                    {
                        destination = destination + "0";
                    }
                }
                if (rDestination.dataType == DataType.DECIMAL)
                {
                    rDestination.setData(destination, DataType.DECIMAL);
                }
                else if (rDestination.dataType == DataType.BINARY)
                {
                    rDestination.setData(destination, DataType.BINARY);
                }
                else if (rDestination.dataType == DataType.HEXADECIMAL)
                {
                    rDestination.setData(destination, DataType.HEXADECIMAL);
                }
            }
            else
            {
            }
        }
        void Or(ref Register rDestination,ref Register source, int data, bool bFlag)
        {
            if (bFlag)
            {
                String destination = "";
                String source2 = source.data;
                Register dataString = new Register(RegisterType.GENERAL_REGISTER);
                dataString.setData(Convert.ToString(data), DataType.DECIMAL);
                for (int i = 0; i < 4; i++)
                {
                    if (dataString.data.Substring(i, 1) == "1" || source2.Substring(i, 1) == "1")
                    {
                        destination = destination + "1";
                    }
                    else
                    {
                        destination = destination + "0";
                    }
                }
                if (rDestination.dataType == DataType.DECIMAL)
                {
                    rDestination.setData(destination, DataType.DECIMAL);
                }
                else if (rDestination.dataType == DataType.BINARY)
                {
                    rDestination.setData(destination, DataType.BINARY);
                }
                else if (rDestination.dataType == DataType.HEXADECIMAL)
                {
                    rDestination.setData(destination, DataType.HEXADECIMAL);
                }
            }
            else
            {
                
            }
        }
        void xOr(ref Register rDestination,ref Register source, int data, bool bFlag)
        {
            if (bFlag)
            {
                String destination = "";
                String source2 = source.data;
                Register dataString = new Register(RegisterType.GENERAL_REGISTER);
                dataString.setData(Convert.ToString(data), DataType.DECIMAL);
                for (int i = 0; i < 4; i++)
                {
                    if (dataString.data.Substring(i, 1) != source2.Substring(i, 1))
                    {
                        destination = destination + "1";
                    }
                    else
                    {
                        destination = destination + "0";
                    }
                }
                if (rDestination.dataType == DataType.DECIMAL)
                {
                    rDestination.setData(destination, DataType.DECIMAL);
                }
                else if (rDestination.dataType == DataType.BINARY)
                {
                    rDestination.setData(destination, DataType.BINARY);
                }
                else if (rDestination.dataType == DataType.HEXADECIMAL)
                {
                    rDestination.setData(destination, DataType.HEXADECIMAL);
                }
            }
            else
            {
            }
        }
        void shiftLeft(ref Register rDestination,ref Register source)
        {

            String destination = "";
            String source2 = source.data;


            for (int i = 1; i < 4; i++)
            {

                destination = destination + source2.Substring(i, 1);

            }
            destination = destination + "0";
            if (rDestination.dataType == DataType.DECIMAL)
            {
                rDestination.setData(destination, DataType.DECIMAL);
            }
            else if (rDestination.dataType == DataType.BINARY)
            {
                rDestination.setData(destination, DataType.BINARY);
            }
            else if (rDestination.dataType == DataType.HEXADECIMAL)
            {
                rDestination.setData(destination, DataType.HEXADECIMAL);
            }
        }
        void shiftRight(ref Register rDestination,ref Register source)
        {
            String destination = "";
            String source2 = source.data;
            destination = destination + "0";
            for (int i = 0; i < 3; i++)
            {
                destination = destination + source2.Substring(i, 1);
            }
            destination = destination + "0";
            if (rDestination.dataType == DataType.DECIMAL)
            {
                rDestination.setData(destination, DataType.DECIMAL);
            }
            else if (rDestination.dataType == DataType.BINARY)
            {
                rDestination.setData(destination, DataType.BINARY);
            }
            else if (rDestination.dataType == DataType.HEXADECIMAL)
            {
                rDestination.setData(destination, DataType.HEXADECIMAL);
            }
        }

    }
}
