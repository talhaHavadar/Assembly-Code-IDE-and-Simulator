using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjeWithForm
{
    public enum TableItemType
    {
        INSTRUCTION_TABLE_ITEM, DATA_TABLE_ITEM, STACK_TABLE_ITEM, LABEL_TABLE_ITEM
    }
    public enum TableType
    {
        INSTRUCTION_TABLE, DATA_TABLE, STACK_TABLE, LABEL_TABLE
    }
    public enum DataType
    {
        BINARY, HEXADECIMAL, DECIMAL
    }

    public struct Table
    {
        public int lastAvailableIndex;
        public bool full;
        public TableType tableType;
        public DataType valueType;
        public int valueBase;
        public string[] values;
    }

    public class TableSet
    {

        

        public Table LabelTable;
        public Table InstructionTable;
        public Table DataTable;
        public Table StackTable;
        public TableSet()
        {
            LabelTable = new Table();
            LabelTable.values = new string[16];
            LabelTable.full = false;
            LabelTable.tableType = TableType.LABEL_TABLE;
            LabelTable.lastAvailableIndex = 0;
            LabelTable.valueBase = 2;
            LabelTable.valueType = DataType.BINARY;


            InstructionTable = new Table();
            InstructionTable.values = new string[32];
            InstructionTable.full = false;
            InstructionTable.lastAvailableIndex = 0;
            InstructionTable.valueBase = 2;
            InstructionTable.tableType = TableType.INSTRUCTION_TABLE;
            InstructionTable.valueType = DataType.BINARY;
            for (int i = 0; i < InstructionTable.values.Length; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    InstructionTable.values[i] += "0";
                }
            }


            DataTable = new Table();
            DataTable.values = new string[16];
            DataTable.full = false;
            DataTable.lastAvailableIndex = 0;
            DataTable.valueBase = 2;
            DataTable.tableType = TableType.DATA_TABLE;
            DataTable.valueType = DataType.BINARY;
            for (int i = 0; i < DataTable.values.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable.values[i] += "0";
                }
            }


            StackTable = new Table();
            StackTable.values = new string[8];
            StackTable.full = false;
            StackTable.lastAvailableIndex = 0;
            StackTable.valueBase = 2;
            StackTable.tableType = TableType.STACK_TABLE;
            StackTable.valueType = DataType.BINARY;
            for (int i = 0; i < StackTable.values.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    StackTable.values[i] += "0";
                }
            }
        }


        public void resetTables()
        {
            int valuebase = LabelTable.valueBase;
            for (int i = 0; i < LabelTable.values.Length; i++)
            {
                LabelTable.values[i] = "";
            }
            LabelTable.lastAvailableIndex = 0;
            valuebase = DataTable.valueBase;
            for (int i = 0; i < DataTable.values.Length; i++)
            {
                DataTable.values[i] = Convert.ToString(0, valuebase);
                if (valuebase == 2)
                {
                    DataTable.values[i] = DataTable.values[i].PadLeft(4, '0');
                }
            }
            DataTable.lastAvailableIndex = 0;
            valuebase = InstructionTable.valueBase;
            for (int i = 0; i < InstructionTable.values.Length; i++)
            {
                InstructionTable.values[i] = Convert.ToString(0, valuebase);
                if (valuebase == 2)
                {
                    InstructionTable.values[i] = InstructionTable.values[i].PadLeft(14, '0');
                }
            }
            InstructionTable.lastAvailableIndex = 0;
            valuebase = StackTable.valueBase;
            for (int i = 0; i < StackTable.values.Length; i++)
            {
                StackTable.values[i] = Convert.ToString(0, valuebase);
                if (valuebase == 2)
                {
                    StackTable.values[i] = StackTable.values[i].PadLeft(5, '0');
                }
            }
            StackTable.lastAvailableIndex = 0;
        }

        public Table convertTableValuesTo(DataType toType, Table table)
        {
            
            int toBase = 2;
            if (toType == DataType.DECIMAL && table.valueType != DataType.DECIMAL)
            {
                toBase = 10;
                table.valueType = DataType.DECIMAL;
            }
            else if (toType == DataType.HEXADECIMAL && table.valueType != DataType.HEXADECIMAL)
            {
                toBase = 16;
                table.valueType = DataType.HEXADECIMAL;

            }
            int currBase = table.valueBase;

            for (int i = 0; i < table.values.Length; i++)
            {
                table.values[i] = Convert.ToString(Convert.ToInt32(table.values[i], currBase), toBase);
                if (toType == DataType.BINARY)
                {
                    int padLeft = 4;
                    if (table.tableType == TableType.INSTRUCTION_TABLE)
                    {
                        padLeft = 14;
                    }
                    else if (table.tableType == TableType.DATA_TABLE)
                    {
                        padLeft = 4;
                    }
                    else if (table.tableType == TableType.STACK_TABLE)
                    {
                        padLeft = 5;
                    }
                    table.values[i] = table.values[i].PadLeft(padLeft,'0');
                    table.valueType = DataType.BINARY;
                }
            }
            table.valueBase = toBase;

            return table;
        }

        public void setTableItem(string value, DataType valueType, int tableIndex, TableType tableType)
        {
            if (tableType == TableType.DATA_TABLE)
            {
                if (tableIndex < DataTable.values.Length)
                {
                    int curBase = DataTable.valueBase;
                    int fromBase = valueType == DataType.DECIMAL ? 10 : valueType == DataType.HEXADECIMAL ? 16 : 2;
                    value = Convert.ToString(Convert.ToInt32(value, fromBase), curBase);
                    if (curBase == 2)
                    {
                        value = value.PadLeft(4, '0');
                    }
                    DataTable.values[tableIndex] = value;
                }
            }
            else if (tableType == TableType.INSTRUCTION_TABLE)
            {
                if (tableIndex < InstructionTable.values.Length)
                {
                    int curBase = InstructionTable.valueBase;
                    int fromBase = valueType == DataType.DECIMAL ? 10 : valueType == DataType.HEXADECIMAL ? 16 : 2;
                    value = Convert.ToString(Convert.ToInt32(value, fromBase), curBase);
                    if (curBase == 2)
                    {
                        value = value.PadLeft(14, '0');
                    }

                    InstructionTable.values[tableIndex] = value;
                }
            }
            else if (tableType == TableType.STACK_TABLE)
            {
                if (tableIndex < StackTable.values.Length)
                {
                    int curBase = StackTable.valueBase;
                    int fromBase = valueType == DataType.DECIMAL ? 10 : valueType == DataType.HEXADECIMAL ? 16 : 2;
                    value = Convert.ToString(Convert.ToInt32(value, fromBase), curBase);
                    if (curBase == 2)
                    {
                        value = value.PadLeft(5, '0');
                    }
                    StackTable.values[tableIndex] = value;
                }
            }
            else
            {
                MessageBox.Show("You can not change label table directly!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void addItomToTable(string value, TableItemType type)
        {
            if (type == TableItemType.DATA_TABLE_ITEM)
            {
                
                MessageBox.Show("You cant add item to data table without value type!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (type == TableItemType.LABEL_TABLE_ITEM)
            {
                if (!LabelTable.full)
                {
                    LabelTable.values[LabelTable.lastAvailableIndex] = value;
                    LabelTable.lastAvailableIndex++;
                    if (LabelTable.lastAvailableIndex >= LabelTable.values.Length)
                    {
                        LabelTable.full = true;
                    }
                }
                else
                {
                    MessageBox.Show("Label table is full!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (type == TableItemType.INSTRUCTION_TABLE_ITEM)
            {

                MessageBox.Show("You cant add item to instruction table without value type!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (type == TableItemType.STACK_TABLE_ITEM)
            {
                MessageBox.Show("You cant add item to stack table without value type!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Table getLabelTable()
        {
            return LabelTable;
        }

        public Table getInstructionTable()
        {
            return InstructionTable;
        }

        public Table getDataTable()
        {
            return DataTable;
        }

        public Table getStackTable()
        {
            return StackTable;
        }

    }
}
