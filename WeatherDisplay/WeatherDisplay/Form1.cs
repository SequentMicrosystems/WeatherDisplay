using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace WeatherDisplay
{
    enum W_IR
    {
       // BEGIN_IR_ADD = 30000,
        IR_4_20MA_IN1,
        IR_4_20MA_IN2,
        IR_0_5V_IN,
        IR_RTD,
        IR_PULSE_COUNTER,
        IR_PHOTO,
        IR_INT_PRESS_HI,
        IR_INT_PRESS_LO,
        IR_INT_TEMP,
        IR_PITCH,
        IR_ROLL,
        IR_EXT_PRESS_HI,
        IR_EXT_PRESS_LO,
        IR_EXT_TEMP,
        IR_EXT_HUM,
        END_IR_ADD,
    }
    public partial class Weather : Form
    {
        byte mbConnect = 0;
        ModbusClient modbusClient;
        int[] registers = new int[(int)W_IR.END_IR_ADD + 1];

        public Weather()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Weather_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
            comboBox2.SelectedItem = "38400";
            comboBox3.SelectedItem = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (mbConnect == 0 && comboBox1.SelectedItem != null)
            {
                modbusClient = new ModbusClient(comboBox1.SelectedItem.ToString());//communication settings
                modbusClient.UnitIdentifier =  Convert.ToByte(comboBox3.SelectedItem.ToString());
                modbusClient.Baudrate = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                modbusClient.Parity = System.IO.Ports.Parity.None;
                modbusClient.StopBits = System.IO.Ports.StopBits.One;
                modbusClient.ConnectionTimeout = 100;
                try
                {
                    modbusClient.Connect();
                    mbConnect = 1;
                    button1.Text = "CLOSE";
                    button2.Enabled = true;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                }
                catch (IOException ex)
                {
                    throw new IOException("Can not open the port with exception:", ex);
                }
            }
            else
            {
                try
                {
                    modbusClient.Disconnect();
                    mbConnect = 0;
                    button1.Text = "OPEN";
                    button2.Enabled= false;
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
                    comboBox3.Enabled= true;
                }
                catch(IOException ex)
                {
                    
                }
            }
        }

        private void Weather_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (mbConnect != 0 )
            {
                modbusClient.Disconnect();
            }
        }
        private void ReadData()
        {
            byte[] source = new byte[4];
            float myFloat = 0;
            if(mbConnect == 0)
            {
                return;
            }
            
            //modbusClient.UnitIdentifier = 1;
            
            try
            {
                registers = modbusClient.ReadInputRegisters((int)W_IR.IR_4_20MA_IN1, (int)W_IR.IR_EXT_HUM + 1);
                errorMsg.Text = "";


            }
            catch (Exception)
            {
                errorMsg.Text = "Modbus Error";
                return;
            }
            label_I1.Text = "I1: " + (registers[(int)W_IR.IR_4_20MA_IN1] / 1000.0).ToString() + " mA";
            label_I2.Text = "I2: " + (registers[(int)W_IR.IR_4_20MA_IN2] / 1000.0).ToString() + " mA";
            label_0_5V.Text = "0_5V: " + (registers[(int)W_IR.IR_0_5V_IN] / 1000.0).ToString() + " mV";
            label_RTD.Text = "RTD: " + (registers[(int)W_IR.IR_RTD] / 100.0).ToString() + " deg C";
            label_CNT.Text = "Count: " + (registers[(int)W_IR.IR_PULSE_COUNTER]).ToString();
            label_Photo.Text = "Photo: " + (registers[(int)W_IR.IR_PHOTO] / 1000.0).ToString() + " V";
            source[0] = (byte)(registers[(int)W_IR.IR_INT_PRESS_HI] & 0xff);
            source[1] = (byte)((registers[(int)W_IR.IR_INT_PRESS_HI] >> 8) & 0xff);
            source[2] = (byte)(registers[(int)W_IR.IR_INT_PRESS_LO] & 0xff);
            source[3] = (byte)((registers[(int)W_IR.IR_INT_PRESS_LO] >> 8) & 0xff);
            myFloat = System.BitConverter.ToSingle(source, 0);
            label_Int_Prs.Text = "Int Press: " + myFloat.ToString() + " Pa";
            label_int_temp.Text = "Int Temp: " + (registers[(int)W_IR.IR_INT_TEMP] / 100.0).ToString() + " deg C";
            label_pitch.Text = "Pitch: " + (registers[(int)W_IR.IR_PITCH] / 100.0).ToString() + " deg";
            label_roll.Text = "Roll: " + (registers[(int)W_IR.IR_ROLL] / 100.0).ToString() + " deg";
            source[0] = (byte)(registers[(int)W_IR.IR_EXT_PRESS_HI] & 0xff);
            source[1] = (byte)((registers[(int)W_IR.IR_EXT_PRESS_HI] >> 8) & 0xff);
            source[2] = (byte)(registers[(int)W_IR.IR_EXT_PRESS_LO] & 0xff);
            source[3] = (byte)((registers[(int)W_IR.IR_EXT_PRESS_LO] >> 8) & 0xff);
            myFloat = System.BitConverter.ToSingle(source, 0);
            label_ext_press.Text = "Ext Press: " + myFloat.ToString() + " Pa";
            label_ext_temp.Text = "Ext Temp: " + (registers[(int)W_IR.IR_EXT_TEMP] / 100.0).ToString() + " deg C";
            label_ext_hum.Text = "Humidity: " + (registers[(int)W_IR.IR_EXT_HUM] / 100.0).ToString() + " %";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                ReadData();
            }
        }
    }
}
