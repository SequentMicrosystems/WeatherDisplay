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
using System.Globalization;

namespace WeatherDisplay
{
    enum W_IR
    {
        // BEGIN_IR_ADD = 30000,
        IR_4_20MA_IN_HI1,
        IR_4_20MA_IN_LO1,
        IR_4_20MA_IN_HI2,
        IR_4_20MA_IN_LO2,
        IR_0_5V_IN_HI,
        IR_0_5V_IN_LO,
        IR_RTD_HI,
        IR_RTD_LO,
        IR_PULSE_COUNTER,
        IR_PHOTO_HI,
        IR_PHOTO_LO,
        IR_INT_PRESS_HI,
        IR_INT_PRESS_LO,
        IR_INT_TEMP_HI,
        IR_INT_TEMP_LO,
        IR_PITCH_HI,
        IR_PITCH_LO,
        IR_ROLL_HI,
        IR_ROLL_LO,
        IR_EXT_PRESS_HI,
        IR_EXT_PRESS_LO,
        IR_EXT_TEMP_HI,
        IR_EXT_TEMP_LO,
        IR_EXT_HUM_HI,
        IR_EXT_HUM_LO,
        IR_PULSE_H,
        IR_PULSE_24H,
        IR_0_100MV_IN_HI,
        IR_0_100MV_IN_LO,
        IR_FW_VERSION,
        END_IR_ADD,
    }
    enum W_HR
    {
        //BEGIN_HR_ADD = 40000,
        HR_CALIB_VALUE_HI,
        HR_CALIB_VALUE_LO,
        HR_CALIB_CH,
        HR_BAUDRATE,
        HR_ADDRESS,
        HR_PARITY,
        HR_PARAM_RTD_SLOPE_HI,
        HR_PARAM_RTD_SLOPE_LO,
        HR_PARAM_RTD_INTERCEPT_HI,
        HR_PARAM_RTD_INTERCEPT_LO,
        HR_PARAM_VIN_SLOPE_HI,
        HR_PARAM_VIN_SLOPE_LO,
        HR_PARAM_VIN_INTERCEPT_HI,
        HR_PARAM_VIN_INTERCEPT_LO,
        HR_PARAM_CRT1_SLOPE_HI,
        HR_PARAM_CRT1_SLOPE_LO,
        HR_PARAM_CRT1_INTERCEPT_HI,
        HR_PARAM_CRT1_INTERCEPT_LO,
        HR_PARAM_CRT2_SLOPE_HI,
        HR_PARAM_CRT2_SLOPE_LO,
        HR_PARAM_CRT2_INTERCEPT_HI,
        HR_PARAM_CRT2_INTERCEPT_LO,
        HR_PARAM_PHOTO_SLOPE_HI,
        HR_PARAM_PHOTO_SLOPE_LO,
        HR_PARAM_PHOTO_INTERCEPT_HI,
        HR_PARAM_PHOTO_INTERCEPT_LO,
        HR_PARAM_BARO_SLOPE_HI,
        HR_PARAM_BARO_SLOPE_LO,
        HR_PARAM_BARO_INTERCEPT_HI,
        HR_PARAM_BARO_INTERCEPT_LO,
        HR_PARAM_ACC_X_1G_HI,
        HR_PARAM_ACC_X_1G_LO,
        HR_PARAM_ACC_X_OFFSET_HI,
        HR_PARAM_ACC_X_OFFSET_LO,
        HR_PARAM_ACC_Y_1G_HI,
        HR_PARAM_ACC_Y_1G_LO,
        HR_PARAM_ACC_Y_OFFSET_HI,
        HR_PARAM_ACC_Y_OFFSET_LO,
        HR_PARAM_ACC_Z_1G_HI,
        HR_PARAM_ACC_Z_1G_LO,
        HR_PARAM_ACC_Z_OFFSET_HI,
        HR_PARAM_ACC_Z_OFFSET_LO,
        HR_PARAM_PITCH_OFFST_HI,
        HR_PARAM_PITCH_OFFST_LO,
        HR_PARAM_ROLL_OFFSET_HI,
        HR_PARAM_ROLL_OFFSET_LO,
        HR_PARAM_MODBUS_BAUDRATE_HI,
        HR_PARAM_MODBUS_BAUDRATE_LO,
        HR_PARAM_MODBUS_SETTINGS_HI,
        HR_PARAM_MODBUS_SETTINGS_LO,
        HR_PARAM_VIN_RANGE_HI,
        HR_PARAM_VIN_RANGE_LO,
        HR_PARAM_MVIN_SLOPE_HI,
        HR_PARAM_MVIN_SLOPE_LO,
        HR_PARAM_MVIN_INTERCEPT_HI,
        HR_PARAM_MVIN_INTERCEPT_LO,
        HR_PARAM_RTD_LOW_LIMIT_HI,
        HR_PARAM_RTD_LOW_LIMIT_LO,
        HR_PARAM_RTD_HIGH_LIMIT_HI,
        HR_PARAM_RTD_HIGH_LIMIT_LO,
        HR_PARAM_VIN_LOW_LIMIT_HI,
        HR_PARAM_VIN_LOW_LIMIT_LO,
        HR_PARAM_VIN_HIGH_LIMIT_HI,
        HR_PARAM_VIN_HIGH_LIMIT_LO,
        HR_PARAM_CRT1_LOW_LIMIT_HI,
        HR_PARAM_CRT1_LOW_LIMIT_LO,
        HR_PARAM_CRT1_HIGH_LIMIT_HI,
        HR_PARAM_CRT1_HIGH_LIMIT_LO,
        HR_PARAM_CRT2_LOW_LIMIT_HI,
        HR_PARAM_CRT2_LOW_LIMIT_LO,
        HR_PARAM_CRT2_HIGH_LIMIT_HI,
        HR_PARAM_CRT2_HIGH_LIMIT_LO,
        HR_PARAM_PHOTO_LOW_LIMIT_HI,
        HR_PARAM_PHOTO_LOW_LIMIT_LO,
        HR_PARAM_PHOTO_HIGH_LIMIT_HI,
        HR_PARAM_PHOTO_HIGH_LIMIT_LO,
        HR_PARAM_BARO_LOW_LIMIT_HI,
        HR_PARAM_BARO_LOW_LIMIT_LO,
        HR_PARAM_BARO_HIGH_LIMIT_HI,
        HR_PARAM_BARO_HIGH_LIMIT_LO,
        HR_PARAM_MVIN_LOW_LIMIT_HI,
        HR_PARAM_MVIN_LOW_LIMIT_LO,
        HR_PARAM_MVIN_HIGH_LIMIT_HI,
        HR_PARAM_MVIN_HIGH_LIMIT_LO,
        HR_SPARE,
        END_HR_ADD,
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
            comboBox4.SelectedItem = "NONE";

            // initialize parameter table (editable floats composed of 2 holding registers)
            InitializeParamTable();
        }

        // Build DataGridView rows for parameter floats using W_HR entries starting at HR_PARAM_*
        private void InitializeParamTable()
        {
            // Clear any existing rows
            dataGridViewParams.Rows.Clear();

            int start = (int)W_HR.HR_PARAM_RTD_SLOPE_HI; // first "HR_PARAM_*_HI"
            int endMarker = (int)W_HR.HR_SPARE; // stop before spare
            // For each pair (HI, LO) create one editable float row
            for (int addr = start; addr + 1 < endMarker; addr += 2)
            {
                string nameHi = Enum.GetName(typeof(W_HR), addr);
                string nameLo = Enum.GetName(typeof(W_HR), addr + 1);
                string displayName;
                if (!string.IsNullOrEmpty(nameHi))
                {
                    displayName = nameHi;
                }
                else if (!string.IsNullOrEmpty(nameLo))
                {
                    displayName = nameLo;
                }
                else
                {
                    displayName = $"HR_{addr}";
                }

                // Clean display name: remove HR_PARAM_, _HI/_LO, replace underscores with spaces
                displayName = displayName.Replace("HR_PARAM_", "");
                displayName = displayName.Remove(displayName.Length - 3);

                // Add row: Address, Name, Value (initially blank)
                dataGridViewParams.Rows.Add(addr, displayName, "");
            }

            // Ensure only Value column is editable
            if (dataGridViewParams.Columns.Count >= 3)
            {
                dataGridViewParams.Columns[0].ReadOnly = true;
                dataGridViewParams.Columns[1].ReadOnly = true;
                dataGridViewParams.Columns[2].ReadOnly = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (mbConnect == 0 && comboBox1.SelectedItem != null)
            {
                modbusClient = new ModbusClient(comboBox1.SelectedItem.ToString());//communication settings
                modbusClient.UnitIdentifier =  Convert.ToByte(comboBox3.SelectedItem.ToString());
                modbusClient.Baudrate = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                modbusClient.Parity = System.IO.Ports.Parity.None;
                if(comboBox4.SelectedItem.ToString() == "EVEN")
                {
                    modbusClient.Parity = System.IO.Ports.Parity.Even;
                }
                else if (comboBox4.SelectedItem.ToString() == "ODD")
                {
                    modbusClient.Parity = System.IO.Ports.Parity.Odd;
                }
                modbusClient.StopBits = System.IO.Ports.StopBits.One;
                modbusClient.ConnectionTimeout = 100;
                try
                {
                    modbusClient.Connect();
                    mbConnect = 1;
                    button1.Text = "CLOSE";
                    button2.Enabled = true;
                    groupBox1.Enabled = true;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;

                    // enable params read/write buttons when connected
                    buttonReadParams.Enabled = true;
                    buttonWriteParams.Enabled = true;
                    buttonReadFW.Enabled = true; // enable firmware read button
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
                    groupBox1.Enabled = false;
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
                    comboBox3.Enabled= true;
                    comboBox4.Enabled= true;

                    buttonReadParams.Enabled = false;
                    buttonWriteParams.Enabled = false;
                    buttonReadFW.Enabled = false; // disable when closed
                }
                catch(IOException ex)
                {
                    
                }
            }
        }

        // New: read firmware version (IR_FW_VERSION), high byte = major, low byte = minor
        private void buttonReadFW_Click(object sender, EventArgs e)
        {
            if (mbConnect == 0 || modbusClient == null)
            {
                errorMsg.Text = "Not connected";
                return;
            }

            try
            {
                // Read one input register at IR_FW_VERSION
                int[] regs = modbusClient.ReadInputRegisters((int)W_IR.IR_FW_VERSION, 1);
                if (regs == null || regs.Length < 1)
                {
                    errorMsg.Text = "No data";
                    return;
                }

                int reg = regs[0] & 0xFFFF;
                int revHigh = (reg >> 8) & 0xFF;
                int revLow = reg & 0xFF;

                string version = $"{revHigh}.{revLow}";
                errorMsg.Text = "";
                MessageBox.Show(this, $"Firmware version: {version}", "Firmware", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                errorMsg.Text = "Modbus read error";
            }
        }

        private void Weather_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (mbConnect != 0 )
            {
                modbusClient.Disconnect();
            }
        }
        private float ExtractFloat(int[] array, int index)
        {
            // index refers to register index inside the provided 'array' (first of the two registers)
            float result = 0;
            byte[] source = new byte[4];

            source[0] = (byte)(array[index] & 0xff);
            source[1] = (byte)((array[index] >> 8) & 0xff);
            source[2] = (byte)(array[index + 1] & 0xff);
            source[3] = (byte)((array[index+1] >> 8) & 0xff);
            result = System.BitConverter.ToSingle(source, 0);

            return result;
        }

        private void ExractRegs(out int[] array, float val)
        {
            array = new int[2];
            byte[] source = BitConverter.GetBytes(val);
            array[0] = source[0] | (source[1] << 8);
            array[1] = source[2] | (source[3] << 8);

        }


        // Helper: convert two 16-bit registers (low-word, high-word) into a single-precision float.
        // This uses the same ordering as ExtractFloat: low register first, then high register; little-endian byte order within each register.
        private float RegistersToFloat(int lowRegister, int highRegister)
        {
            byte[] b = new byte[4];
            b[0] = (byte)(lowRegister & 0xFF);
            b[1] = (byte)((lowRegister >> 8) & 0xFF);
            b[2] = (byte)(highRegister & 0xFF);
            b[3] = (byte)((highRegister >> 8) & 0xFF);
            return BitConverter.ToSingle(b, 0);
        }
        private void ReadData()
        {
            byte[] source = new byte[4];
            
            if(mbConnect == 0)
            {
                return;
            }
            
            //modbusClient.UnitIdentifier = 1;
            
            try
            {
                registers = modbusClient.ReadInputRegisters((int)W_IR.IR_4_20MA_IN_HI1, (int)W_IR.END_IR_ADD);
                errorMsg.Text = "";
            }
            catch (Exception)
            {
                errorMsg.Text = "Modbus Error";
                return;
            }
            char degreeSymbol = (char)176;
            label_I1.Text = "I1: " + ExtractFloat(registers, (int)W_IR.IR_4_20MA_IN_HI1).ToString("F") ;
            label_I2.Text = "I2: " + ExtractFloat(registers, (int)W_IR.IR_4_20MA_IN_HI2).ToString("F") ;
            label_0_5V.Text = "0_5V: " + ExtractFloat(registers, (int)W_IR.IR_0_5V_IN_HI).ToString("F");
            label_RTD.Text = "RTD: " + ExtractFloat(registers, (int)W_IR.IR_RTD_HI).ToString("F") + degreeSymbol + "C";
            label_CNT.Text = "Count: " + (registers[(int)W_IR.IR_PULSE_COUNTER]).ToString();
            label_Photo.Text = "Photo: " + ExtractFloat(registers, (int)W_IR.IR_PHOTO_HI).ToString("F") ;
          
            label_Int_Prs.Text = "Int Press: " + ExtractFloat(registers, (int)W_IR.IR_INT_PRESS_HI) + " mbar";
            label_int_temp.Text = "Int Temp: " + ExtractFloat(registers, (int)W_IR.IR_INT_TEMP_HI).ToString() + degreeSymbol+ "C";
            label_pitch.Text = "Pitch: " + ExtractFloat(registers, (int)W_IR.IR_PITCH_HI).ToString("F") + degreeSymbol;
            label_roll.Text = "Roll: " + ExtractFloat(registers, (int)W_IR.IR_ROLL_HI).ToString("F") + degreeSymbol;
           
            label_ext_press.Text = "Ext Press: " + ExtractFloat(registers, (int)W_IR.IR_EXT_PRESS_HI).ToString() + " mbar";
            label_ext_temp.Text = "Ext Temp: " + ExtractFloat(registers, (int)W_IR.IR_EXT_TEMP_HI).ToString() + degreeSymbol +"C";
            label_ext_hum.Text = "Humidity: " + ExtractFloat(registers, (int)W_IR.IR_EXT_HUM_HI).ToString() + " %";
            label_pulse_h.Text = "Pulses per Hour: " + (registers[(int)W_IR.IR_PULSE_H]).ToString();
            label_pulse_day.Text = "Pulses per Day: " + (registers[(int)W_IR.IR_PULSE_24H]).ToString();
            label_100mV.Text = "0_100mV: " + ExtractFloat(registers, (int)W_IR.IR_0_100MV_IN_HI).ToString("F");
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

        private void button3_Click(object sender, EventArgs e)
        {
            int[] regs = new int[3];
            int[] floatParts = new int[1];
            float val = (float)numericUpDown1.Value;
            ExractRegs(out floatParts, val);
            regs[0] = (Int16)floatParts[0];
            regs[1] = (Int16)floatParts[1];
            regs[2] = Convert.ToInt16(SelectCalCh.Text.Substring(0, 2));

         
            if (mbConnect == 0)
            {
                return;
            }
            modbusClient.WriteMultipleRegisters((int)W_HR.HR_CALIB_VALUE_HI, regs);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Button handler: read all parameter holding registers and populate the grid values
        private void buttonReadParams_Click(object sender, EventArgs e)
        {
            if (mbConnect == 0 || modbusClient == null)
            {
                errorMsg.Text = "Not connected";
                return;
            }

            int start = (int)W_HR.HR_PARAM_RTD_SLOPE_HI;
            int endMarker = (int)W_HR.HR_SPARE; // stop before spare
            int count = endMarker - start; // number of registers to read (covers all HR_PARAM_* entries)

            if (count <= 0)
            {
                errorMsg.Text = "No parameters defined";
                return;
            }

            try
            {
                int[] hr = modbusClient.ReadHoldingRegisters(start, count);
                errorMsg.Text = "";

                // Iterate grid rows and extract float for each pair
                foreach (DataGridViewRow row in dataGridViewParams.Rows)
                {
                    if (row.IsNewRow) continue;
                    int addr = Convert.ToInt32(row.Cells[0].Value); // enum index used as register address
                    int index = addr - start;
                    if (index >= 0 && index + 1 < hr.Length)
                    {
                        // ExtractFloat expects an int[] containing registers starting at index.
                        float v = ExtractFloat(hr, index);
                        row.Cells[2].Value = v.ToString("F4", CultureInfo.InvariantCulture);
                        row.Cells[2].Style.BackColor = Color.White;
                    }
                    else
                    {
                        row.Cells[2].Value = "";
                    }
                }
            }
            catch (Exception)
            {
                errorMsg.Text = "Modbus read holding error";
            }
        }

        // New: write all parameter rows to device when user clicks the separate button
        private void buttonWriteParams_Click(object sender, EventArgs e)
        {
            if (mbConnect == 0 || modbusClient == null)
            {
                errorMsg.Text = "Not connected";
                return;
            }

            try
            {
                foreach (DataGridViewRow row in dataGridViewParams.Rows)
                {
                    if (row.IsNewRow) continue;

                    object addrObj = row.Cells[0].Value;
                    object valObj = row.Cells[2].Value;
                    if (addrObj == null || valObj == null) continue;

                    int addr = Convert.ToInt32(addrObj);
                    string strVal = valObj.ToString().Trim();
                    if (string.IsNullOrEmpty(strVal)) continue;

                    if (!float.TryParse(strVal, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out float newVal))
                    {
                        errorMsg.Text = $"Invalid float at address {addr}";
                        return;
                    }

                    // Convert float into two registers using existing endian/packing logic
                    int[] regs;
                    ExractRegs(out regs, newVal);
                    int[] toWrite = new int[2];
                    toWrite[0] = (short)regs[0];
                    toWrite[1] = (short)regs[1];

                    // Write the two registers for this parameter
                    modbusClient.WriteMultipleRegisters(addr, toWrite);

                    // mark as written
                    row.Cells[2].Style.BackColor = Color.White;
                }

                errorMsg.Text = "Parameters written";
            }
            catch (Exception)
            {
                errorMsg.Text = "Modbus write error";
            }
        }

        // Keep CellEndEdit as local validation only (no immediate write)
        private void dataGridViewParams_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Only handle edits in the value column (index 2)
            if (e.ColumnIndex != 2) return;

            var row = dataGridViewParams.Rows[e.RowIndex];
            if (row == null) return;

            string strVal = Convert.ToString(row.Cells[2].Value);
            if (string.IsNullOrWhiteSpace(strVal))
            {
                // allow empty (user might clear)
                errorMsg.Text = "";
                row.Cells[2].Style.BackColor = Color.White;
                return;
            }

            if (!float.TryParse(strVal, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out float newVal))
            {
                errorMsg.Text = "Invalid float format";
                // optionally restore from device immediately
                // buttonReadParams_Click(null, null);
                return;
            }

            // Mark the cell visually to indicate pending write (optional)
            row.Cells[2].Style.BackColor = Color.LightYellow;
            errorMsg.Text = "Edits pending. Click WRITE PARAMS to save.";
        }

        // Save current parameter grid to CSV (Address, "Name", Value) — values use invariant culture
        private void buttonSaveParams_Click(object sender, EventArgs e)
        {
            if (dataGridViewParams.Rows.Count == 0)
            {
                errorMsg.Text = "No parameters to save";
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                sfd.FileName = "params.csv";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (var sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        // header
                        sw.WriteLine("Address,Name,Value");
                        foreach (DataGridViewRow row in dataGridViewParams.Rows)
                        {
                            if (row.IsNewRow) continue;
                            object addrObj = row.Cells[0].Value;
                            object nameObj = row.Cells[1].Value;
                            object valObj = row.Cells[2].Value;
                            int addr = addrObj != null ? Convert.ToInt32(addrObj) : -1;
                            string name = nameObj != null ? nameObj.ToString() : "";
                            string valStr = valObj != null ? Convert.ToString(valObj, CultureInfo.InvariantCulture) : "";
                            // escape name with quotes and double internal quotes
                            string nameEsc = "\"" + name.Replace("\"", "\"\"") + "\"";
                            sw.WriteLine($"{addr},{nameEsc},{valStr}");
                        }
                    }
                    errorMsg.Text = "Parameters saved";
                }
                catch (Exception)
                {
                    errorMsg.Text = "Error saving parameters";
                }
            }
        }

        // Load parameter values from CSV — only updates Value cells matching Address.
        // Does not write to device; user must click WRITE PARAMS to commit.
        private void buttonLoadParams_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                    bool headerSkipped = false;
                    int updated = 0;
                    for (int i = 0; i < lines.Length; i++)
                    {
                        var line = lines[i].Trim();
                        if (string.IsNullOrEmpty(line)) continue;
                        if (!headerSkipped)
                        {
                            // skip header if present
                            if (line.StartsWith("Address", StringComparison.OrdinalIgnoreCase))
                            {
                                headerSkipped = true;
                                continue;
                            }
                            headerSkipped = true;
                        }

                        var fields = ParseCsvLine(line);
                        if (fields.Count < 3) continue;

                        if (!int.TryParse(fields[0], out int addr)) continue;
                        string name = fields[1];
                        string valueField = fields[2];

                        // Find grid row with same address
                        DataGridViewRow match = null;
                        foreach (DataGridViewRow row in dataGridViewParams.Rows)
                        {
                            if (row.IsNewRow) continue;
                            if (row.Cells[0].Value == null) continue;
                            if (Convert.ToInt32(row.Cells[0].Value) == addr)
                            {
                                match = row;
                                break;
                            }
                        }

                        if (match == null) continue;

                        // Validate float and set cell
                        if (string.IsNullOrWhiteSpace(valueField))
                        {
                            match.Cells[2].Value = "";
                            updated++;
                            continue;
                        }

                        if (float.TryParse(valueField, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out float f))
                        {
                            match.Cells[2].Value = f.ToString("F4", CultureInfo.InvariantCulture);
                            match.Cells[2].Style.BackColor = Color.LightYellow; // indicate pending write
                            updated++;
                        }
                        else
                        {
                            // try parsing with current culture as fallback
                            if (float.TryParse(valueField, out float f2))
                            {
                                match.Cells[2].Value = f2.ToString("F4", CultureInfo.InvariantCulture);
                                match.Cells[2].Style.BackColor = Color.LightYellow;
                                updated++;
                            }
                            else
                            {
                                // invalid value: skip
                            }
                        }
                    }

                    errorMsg.Text = $"Loaded {updated} parameter(s). Click WRITE PARAMS to save.";
                }
                catch (Exception)
                {
                    errorMsg.Text = "Error loading parameters";
                }
            }
        }

        // Simple CSV parser that handles quoted fields with doubled quotes.
        private List<string> ParseCsvLine(string line)
        {
            var result = new List<string>();
            if (line == null) return result;

            var sb = new StringBuilder();
            bool inQuotes = false;
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (inQuotes)
                {
                    if (c == '"')
                    {
                        // Possible escaped quote
                        if (i + 1 < line.Length && line[i + 1] == '"')
                        {
                            sb.Append('"');
                            i++; // skip next
                        }
                        else
                        {
                            inQuotes = false;
                        }
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
                else
                {
                    if (c == ',')
                    {
                        result.Add(sb.ToString());
                        sb.Clear();
                    }
                    else if (c == '"')
                    {
                        inQuotes = true;
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
            }
            result.Add(sb.ToString());
            return result;
        }

    }
}
