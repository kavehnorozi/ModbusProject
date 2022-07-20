using Modbus.Device;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusProject
{
    public static class ModbusHelper
    {
        public static void ModbusSerialAsciiMasterWriteString(IModbusSerialMaster modbusport, byte slaveId,ushort Address, string str)
        {
            int lenght = str.Length;
            if (lenght % 2 == 1)
                str = string.Concat(str, " ");
            char[] ch = str.ToCharArray();
            for (ushort i = 0; i < lenght; i = (ushort)(i + 2))
            {
                modbusport.WriteSingleRegister(slaveId, Address, (ushort)(ch[i] | ch[i + 1] << 8));
            }
        }

        public static void TurnLED(IModbusSerialMaster modbusport, byte slaveId,string Led, ushort LedStatus)
        {
            switch (Led)
            {
               case "Red":
                 modbusport.WriteSingleRegister(slaveId, 0x70, LedStatus);
                break;
                case "Green":
                    modbusport.WriteSingleRegister(slaveId, 0x71, LedStatus);
                    break;
                case "Yellow":
                    modbusport.WriteSingleRegister(slaveId, 0x72, LedStatus);
                    break;
                case "Blue":
                    modbusport.WriteSingleRegister(slaveId, 0x73, LedStatus);
                    break;
                default:
                    break;
            }
           
            
        }
        public static void Fonts(IModbusSerialMaster modbusport, byte slaveId, ushort Font)
        {
            modbusport.WriteSingleRegister(slaveId,0x15, Font);
        }
    }
}
