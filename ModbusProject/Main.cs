

using Modbus.Device;
using Modbus.Serial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                cmbComPort.Items.Clear();
                cmbComPort.Items.AddRange(ports);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string ComPort = cmbComPort.Text;
            using (SerialPort port = new SerialPort(ComPort))
            {
                // configure serial port
                port.BaudRate = 115200;
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();


                // create modbus master
                byte slaveId = byte.Parse(txtSlaveId.Text);
                ushort startAddress = ushort.Parse(txtDecStartAddress.Text);
                ushort ApplyCodeBlue = 101;
                ushort ApplyCodeYellow = 44;
                var adapter = new SerialPortAdapter(port);
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                //master.WriteSingleRegister(slaveId, 102, 1);
                //  master.WriteSingleRegister(slaveId,startAddress, 1);
                ModbusHelper.ModbusSerialAsciiMasterWriteString(master, slaveId, startAddress, txtMessage.Text);
                master.WriteSingleRegister(slaveId, ApplyCodeBlue, 1);
                master.WriteSingleRegister(slaveId, ApplyCodeYellow, 1);

            }
        }

        private void txtStartAddress_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var hexValue = txtHexStartAddress.Text;
                txtDecStartAddress.Text = Convert.ToInt32(hexValue, 16).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            string ComPort = cmbComPort.Text;
            using (SerialPort port = new SerialPort(ComPort))
            {
                port.BaudRate = int.Parse(txtBaudRate.Text);
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();
                // create modbus master
                byte slaveId = byte.Parse(txtSlaveId.Text);
                var adapter = new SerialPortAdapter(port);
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                ModbusHelper.TurnLED(master, slaveId, "Green", 2);
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            string ComPort = cmbComPort.Text;
            using (SerialPort port = new SerialPort(ComPort))
            {
                port.BaudRate = int.Parse(txtBaudRate.Text);
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();
                // create modbus master
                byte slaveId = byte.Parse(txtSlaveId.Text);
                var adapter = new SerialPortAdapter(port);
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                ModbusHelper.TurnLED(master, slaveId, "Red", 2);
            }
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            string ComPort = cmbComPort.Text;
            using (SerialPort port = new SerialPort(ComPort))
            {
                port.BaudRate = int.Parse(txtBaudRate.Text);
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();
                // create modbus master
                byte slaveId = byte.Parse(txtSlaveId.Text);
                var adapter = new SerialPortAdapter(port);
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                ModbusHelper.TurnLED(master, slaveId, "Yellow", 2);
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            string ComPort = cmbComPort.Text;
            using (SerialPort port = new SerialPort(ComPort))
            {
                port.BaudRate = int.Parse(txtBaudRate.Text);
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();
                // create modbus master
                byte slaveId = byte.Parse(txtSlaveId.Text);
                var adapter = new SerialPortAdapter(port);
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                ModbusHelper.TurnLED(master, slaveId, "Blue", 2);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ComPort = cmbComPort.Text;
            using (SerialPort port = new SerialPort(ComPort))
            {
                port.BaudRate = int.Parse(txtBaudRate.Text);
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();
                // create modbus master
                byte slaveId = byte.Parse(txtSlaveId.Text);
                var adapter = new SerialPortAdapter(port);
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                ModbusHelper.Fonts(master, slaveId, 0);
            }
        }

        private void btnLargeFont_Click(object sender, EventArgs e)
        {
            string ComPort = cmbComPort.Text;
            using (SerialPort port = new SerialPort(ComPort))
            {
                port.BaudRate = int.Parse(txtBaudRate.Text);
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();
                // create modbus master
                byte slaveId = byte.Parse(txtSlaveId.Text);
                var adapter = new SerialPortAdapter(port);
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                ModbusHelper.Fonts(master, slaveId, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ComPort = cmbComPort.Text;
            using (SerialPort port = new SerialPort(ComPort))
            {
                // configure serial port
                port.BaudRate = 115200;
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();
                byte slaveId = byte.Parse(txtSlaveId.Text);
                ushort startAddress = ushort.Parse(txtDecStartAddress.Text);
                var adapter = new SerialPortAdapter(port);
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                master.WriteSingleRegister(slaveId, 102, 1);

            }
        }

        private void swLEDGreen_Toggled(object sender, EventArgs e)
        {

            string ComPort = cmbComPort.Text;
            using (SerialPort port = new SerialPort(ComPort))
            {
                port.BaudRate = int.Parse(txtBaudRate.Text);
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();
                // create modbus master
                byte slaveId = byte.Parse(txtSlaveId.Text);
                var adapter = new SerialPortAdapter(port);
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                if (swLEDGreen.IsOn)
                {
                    ModbusHelper.TurnLED(master, slaveId, "Green", 2);
                }
                else
                {
                    ModbusHelper.TurnLED(master, slaveId, "Green", 0);
                }

            }
        }

        private void swLEDRed_Toggled(object sender, EventArgs e)
        {
            string ComPort = cmbComPort.Text;
            using (SerialPort port = new SerialPort(ComPort))
            {
                port.BaudRate = int.Parse(txtBaudRate.Text);
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();
                // create modbus master
                byte slaveId = byte.Parse(txtSlaveId.Text);
                var adapter = new SerialPortAdapter(port);
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                if (swLEDRed.IsOn)
                {
                    ModbusHelper.TurnLED(master, slaveId, "Red", 2);
                }
                else
                {
                    ModbusHelper.TurnLED(master, slaveId, "Red", 0);
                }

            }
        }

        private void swLEDYellow_Toggled(object sender, EventArgs e)
        {
            string ComPort = cmbComPort.Text;
            using (SerialPort port = new SerialPort(ComPort))
            {
                port.BaudRate = int.Parse(txtBaudRate.Text);
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();
                // create modbus master
                byte slaveId = byte.Parse(txtSlaveId.Text);
                var adapter = new SerialPortAdapter(port);
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                if (swLEDYellow.IsOn)
                {
                    ModbusHelper.TurnLED(master, slaveId, "Yellow", 2);
                }
                else
                {
                    ModbusHelper.TurnLED(master, slaveId, "Yellow", 0);
                }

            }
        }

        private void swLEDBlue_Toggled(object sender, EventArgs e)
        {
            string ComPort = cmbComPort.Text;
            using (SerialPort port = new SerialPort(ComPort))
            {
                port.BaudRate = int.Parse(txtBaudRate.Text);
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();
                // create modbus master
                byte slaveId = byte.Parse(txtSlaveId.Text);
                var adapter = new SerialPortAdapter(port);
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                if (swLEDBlue.IsOn)
                {
                    ModbusHelper.TurnLED(master, slaveId, "Blue", 2);
                }
                else
                {
                    ModbusHelper.TurnLED(master, slaveId, "Blue", 0);
                }

            }
        }
    }
}
