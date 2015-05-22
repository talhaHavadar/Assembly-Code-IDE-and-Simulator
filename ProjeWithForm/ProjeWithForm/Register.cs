using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjeWithForm
{
    public enum RegisterType
    {
        GENERAL_REGISTER, ADDRESS_REGISTER, PROGRAM_COUNTER, STACK_POINTER, INPUT_REGISTER, OUTPUT_REGISTER, INSTRUCTION_REGISTER
    }

    public class Register
    {
        private RegisterType type;
        public RegisterType RegisterType { get { return type; } }

        private int dataValueBase = 2;
        private int capacity = 0;
        public int bitCapacity { get { return capacity; } }

        private string dataValue;
        public string data { get { return dataValue; } }

        private DataType dType = DataType.BINARY;
        public DataType dataType { get { return dType; } }

        public Register(RegisterType type)
        {
            if (type == RegisterType.ADDRESS_REGISTER)
            {
                this.type = RegisterType.ADDRESS_REGISTER;
                capacity = 4;
            }
            else if (type == RegisterType.PROGRAM_COUNTER)
            {
                this.type = RegisterType.PROGRAM_COUNTER;
                capacity = 5;
            }
            else if (type == RegisterType.STACK_POINTER)
            {
                this.type = RegisterType.STACK_POINTER;
                capacity = 3;
            }
            else if (type == RegisterType.INPUT_REGISTER)
            {
                this.type = RegisterType.INPUT_REGISTER;
                capacity = 4;
            }
            else if (type == RegisterType.OUTPUT_REGISTER)
            {
                this.type = RegisterType.OUTPUT_REGISTER;
                capacity = 4;
            }
            else if (type == RegisterType.INSTRUCTION_REGISTER)
            {
                this.type = RegisterType.INSTRUCTION_REGISTER;
                capacity = 14;
            }
            else if (type == RegisterType.GENERAL_REGISTER)
            {
                this.type = RegisterType.GENERAL_REGISTER;
                capacity = 4;
            }

            dType = DataType.BINARY;

            for (int i = 0; i < capacity; i++)
            {
                dataValue += "0";
            }

        }


        public string convertDataTo(DataType type)
        {
            if (type == DataType.BINARY && dataType != DataType.BINARY)
            {
                int num = Convert.ToInt32(data, dataValueBase);
                string newData = Convert.ToString(num, 2);
                dataValue = newData.PadLeft(bitCapacity,'0');
                dType = DataType.BINARY;
                dataValueBase = 2;
                return data;
            }
            else if (type == DataType.HEXADECIMAL && dataType != DataType.HEXADECIMAL)
            {
                
                int num = Convert.ToInt32(data, dataValueBase);
                string newData = Convert.ToString(num, 16);
                dataValue = newData;
                dType = DataType.HEXADECIMAL;
                dataValueBase = 16;
                return data;
            }
            else if (type == DataType.DECIMAL && dataType != DataType.DECIMAL)
            {
                int num = Convert.ToInt32(data, dataValueBase);
                string newData = Convert.ToString(num, 10);
                dataValue = newData;
                dType = DataType.DECIMAL;
                dataValueBase = 10;
                return data;
            }
            return data;
        }

        public void setData(string newData, DataType baseType)
        {
            int toBase = 2;

            if (this.dataType == DataType.DECIMAL)
            {
                toBase = 10;
            }
            else if (this.dataType == DataType.HEXADECIMAL)
            {
                toBase = 16;
            }
            int fromBase = 2;
            if (baseType == DataType.DECIMAL)
	        {
                fromBase = 10;
            }
            else if (baseType == DataType.HEXADECIMAL)
            {
                fromBase = 16;
            }
            int data = Convert.ToInt32(newData, fromBase);
            if (this.RegisterType == RegisterType.INPUT_REGISTER && data > 15)
	        {
                MessageBox.Show("Please Enter Correct Values!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
	        }
            dataValue = Convert.ToString(data, toBase);
            if (this.dataType == DataType.BINARY)
            {
                dataValue = dataValue.PadLeft(bitCapacity, '0');
            }
        }

        public int convertDataToInt()
        {
            if (this.dataType == DataType.HEXADECIMAL)
            {
                return Convert.ToInt32(this.data, 16);
            }
            else if (this.dataType == DataType.BINARY)
            {
                return Convert.ToInt32(this.data, 2);
            }
            else
            {
                return Convert.ToInt32(this.data);
            }
        }

    }
}
