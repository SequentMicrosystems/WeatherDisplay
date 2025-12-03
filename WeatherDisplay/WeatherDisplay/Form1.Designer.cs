namespace WeatherDisplay
{
    partial class Weather
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.label_I1 = new System.Windows.Forms.Label();
            this.label_I2 = new System.Windows.Forms.Label();
            this.label_0_5V = new System.Windows.Forms.Label();
            this.label_RTD = new System.Windows.Forms.Label();
            this.label_int_temp = new System.Windows.Forms.Label();
            this.label_Int_Prs = new System.Windows.Forms.Label();
            this.label_Photo = new System.Windows.Forms.Label();
            this.label_CNT = new System.Windows.Forms.Label();
            this.label_ext_hum = new System.Windows.Forms.Label();
            this.label_ext_temp = new System.Windows.Forms.Label();
            this.label_ext_press = new System.Windows.Forms.Label();
            this.label_roll = new System.Windows.Forms.Label();
            this.label_pitch = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SelectCalCh = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_pulse_h = new System.Windows.Forms.Label();
            this.label_pulse_day = new System.Windows.Forms.Label();
            this.label_100mV = new System.Windows.Forms.Label();
            this.dataGridViewParams = new System.Windows.Forms.DataGridView();
            this.colParamAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParamValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonReadParams = new System.Windows.Forms.Button();
            this.buttonWriteParams = new System.Windows.Forms.Button();
            this.buttonSaveParams = new System.Windows.Forms.Button();
            this.buttonLoadParams = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonReadFW = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParams)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "OPEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(488, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "READ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Location = new System.Drawing.Point(32, 577);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(56, 20);
            this.errorMsg.TabIndex = 5;
            this.errorMsg.Text = "Status";
            // 
            // label_I1
            // 
            this.label_I1.AutoSize = true;
            this.label_I1.Location = new System.Drawing.Point(14, 32);
            this.label_I1.Name = "label_I1";
            this.label_I1.Padding = new System.Windows.Forms.Padding(1);
            this.label_I1.Size = new System.Drawing.Size(33, 22);
            this.label_I1.TabIndex = 6;
            this.label_I1.Text = "I1: ";
            // 
            // label_I2
            // 
            this.label_I2.AutoSize = true;
            this.label_I2.Location = new System.Drawing.Point(14, 59);
            this.label_I2.Name = "label_I2";
            this.label_I2.Padding = new System.Windows.Forms.Padding(1);
            this.label_I2.Size = new System.Drawing.Size(29, 22);
            this.label_I2.TabIndex = 7;
            this.label_I2.Text = "I2:";
            // 
            // label_0_5V
            // 
            this.label_0_5V.AutoSize = true;
            this.label_0_5V.Location = new System.Drawing.Point(14, 84);
            this.label_0_5V.Name = "label_0_5V";
            this.label_0_5V.Padding = new System.Windows.Forms.Padding(1);
            this.label_0_5V.Size = new System.Drawing.Size(53, 22);
            this.label_0_5V.TabIndex = 8;
            this.label_0_5V.Text = "0_5V:";
            // 
            // label_RTD
            // 
            this.label_RTD.AutoSize = true;
            this.label_RTD.Location = new System.Drawing.Point(14, 108);
            this.label_RTD.Name = "label_RTD";
            this.label_RTD.Padding = new System.Windows.Forms.Padding(1);
            this.label_RTD.Size = new System.Drawing.Size(44, 22);
            this.label_RTD.TabIndex = 9;
            this.label_RTD.Text = "RTD";
            // 
            // label_int_temp
            // 
            this.label_int_temp.AutoSize = true;
            this.label_int_temp.Location = new System.Drawing.Point(14, 200);
            this.label_int_temp.Name = "label_int_temp";
            this.label_int_temp.Padding = new System.Windows.Forms.Padding(1);
            this.label_int_temp.Size = new System.Drawing.Size(79, 22);
            this.label_int_temp.TabIndex = 13;
            this.label_int_temp.Text = "Int_Temp";
            // 
            // label_Int_Prs
            // 
            this.label_Int_Prs.AutoSize = true;
            this.label_Int_Prs.Location = new System.Drawing.Point(14, 176);
            this.label_Int_Prs.Name = "label_Int_Prs";
            this.label_Int_Prs.Padding = new System.Windows.Forms.Padding(1);
            this.label_Int_Prs.Size = new System.Drawing.Size(79, 22);
            this.label_Int_Prs.TabIndex = 12;
            this.label_Int_Prs.Text = "Int_Press";
            // 
            // label_Photo
            // 
            this.label_Photo.AutoSize = true;
            this.label_Photo.Location = new System.Drawing.Point(14, 152);
            this.label_Photo.Name = "label_Photo";
            this.label_Photo.Padding = new System.Windows.Forms.Padding(1);
            this.label_Photo.Size = new System.Drawing.Size(53, 22);
            this.label_Photo.TabIndex = 11;
            this.label_Photo.Text = "Photo";
            // 
            // label_CNT
            // 
            this.label_CNT.AutoSize = true;
            this.label_CNT.Location = new System.Drawing.Point(14, 129);
            this.label_CNT.Name = "label_CNT";
            this.label_CNT.Padding = new System.Windows.Forms.Padding(1);
            this.label_CNT.Size = new System.Drawing.Size(50, 22);
            this.label_CNT.TabIndex = 10;
            this.label_CNT.Text = "Pulse";
            // 
            // label_ext_hum
            // 
            this.label_ext_hum.AutoSize = true;
            this.label_ext_hum.Location = new System.Drawing.Point(269, 129);
            this.label_ext_hum.Name = "label_ext_hum";
            this.label_ext_hum.Padding = new System.Windows.Forms.Padding(1);
            this.label_ext_hum.Size = new System.Drawing.Size(104, 22);
            this.label_ext_hum.TabIndex = 18;
            this.label_ext_hum.Text = "Ext_Humidity";
            // 
            // label_ext_temp
            // 
            this.label_ext_temp.AutoSize = true;
            this.label_ext_temp.Location = new System.Drawing.Point(270, 106);
            this.label_ext_temp.Name = "label_ext_temp";
            this.label_ext_temp.Padding = new System.Windows.Forms.Padding(1);
            this.label_ext_temp.Size = new System.Drawing.Size(85, 22);
            this.label_ext_temp.TabIndex = 17;
            this.label_ext_temp.Text = "Ent_Temp";
            // 
            // label_ext_press
            // 
            this.label_ext_press.AutoSize = true;
            this.label_ext_press.Location = new System.Drawing.Point(269, 84);
            this.label_ext_press.Name = "label_ext_press";
            this.label_ext_press.Padding = new System.Windows.Forms.Padding(1);
            this.label_ext_press.Size = new System.Drawing.Size(83, 22);
            this.label_ext_press.TabIndex = 16;
            this.label_ext_press.Text = "Ext_Press";
            // 
            // label_roll
            // 
            this.label_roll.AutoSize = true;
            this.label_roll.Location = new System.Drawing.Point(270, 59);
            this.label_roll.Name = "label_roll";
            this.label_roll.Padding = new System.Windows.Forms.Padding(1);
            this.label_roll.Size = new System.Drawing.Size(38, 22);
            this.label_roll.TabIndex = 15;
            this.label_roll.Text = "Roll";
            // 
            // label_pitch
            // 
            this.label_pitch.AutoSize = true;
            this.label_pitch.Location = new System.Drawing.Point(269, 32);
            this.label_pitch.Name = "label_pitch";
            this.label_pitch.Padding = new System.Windows.Forms.Padding(1);
            this.label_pitch.Size = new System.Drawing.Size(46, 22);
            this.label_pitch.TabIndex = 14;
            this.label_pitch.Text = "Pitch";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(484, 65);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 24);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Read loop";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.comboBox2.Location = new System.Drawing.Point(118, 82);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(122, 28);
            this.comboBox2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Address";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(119, 148);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(77, 28);
            this.comboBox3.TabIndex = 23;
            // 
            // SelectCalCh
            // 
            this.SelectCalCh.DisplayMember = "1";
            this.SelectCalCh.FormattingEnabled = true;
            this.SelectCalCh.Items.AddRange(new object[] {
            "1 4-20mA Ch1",
            "2 4-20mA Ch2",
            "3 0-5V in",
            "4 0-100mV in",
            "5 Photodiode",
            "6 RTD res"});
            this.SelectCalCh.Location = new System.Drawing.Point(75, 35);
            this.SelectCalCh.Margin = new System.Windows.Forms.Padding(2);
            this.SelectCalCh.Name = "SelectCalCh";
            this.SelectCalCh.Size = new System.Drawing.Size(148, 28);
            this.SelectCalCh.TabIndex = 24;
            this.SelectCalCh.Text = "1 4-20mA Ch1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SelectCalCh);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(917, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(224, 199);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calibration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(75, 142);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 40);
            this.button3.TabIndex = 28;
            this.button3.Text = "CAL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 4;
            this.numericUpDown1.Location = new System.Drawing.Point(102, 98);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(119, 26);
            this.numericUpDown1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Channel";
            // 
            // label_pulse_h
            // 
            this.label_pulse_h.AutoSize = true;
            this.label_pulse_h.Location = new System.Drawing.Point(269, 152);
            this.label_pulse_h.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pulse_h.Name = "label_pulse_h";
            this.label_pulse_h.Size = new System.Drawing.Size(122, 20);
            this.label_pulse_h.TabIndex = 26;
            this.label_pulse_h.Text = "Pulses per Hour";
            // 
            // label_pulse_day
            // 
            this.label_pulse_day.AutoSize = true;
            this.label_pulse_day.Location = new System.Drawing.Point(269, 176);
            this.label_pulse_day.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pulse_day.Name = "label_pulse_day";
            this.label_pulse_day.Size = new System.Drawing.Size(115, 20);
            this.label_pulse_day.TabIndex = 27;
            this.label_pulse_day.Text = "Pulses per Day";
            // 
            // label_100mV
            // 
            this.label_100mV.AutoSize = true;
            this.label_100mV.Location = new System.Drawing.Point(269, 203);
            this.label_100mV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_100mV.Name = "label_100mV";
            this.label_100mV.Size = new System.Drawing.Size(86, 20);
            this.label_100mV.TabIndex = 28;
            this.label_100mV.Text = "0_100mV: ";
            // 
            // dataGridViewParams
            // 
            this.dataGridViewParams.AllowUserToAddRows = false;
            this.dataGridViewParams.AllowUserToDeleteRows = false;
            this.dataGridViewParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParamAddress,
            this.colParamName,
            this.colParamValue});
            this.dataGridViewParams.Location = new System.Drawing.Point(36, 253);
            this.dataGridViewParams.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewParams.Name = "dataGridViewParams";
            this.dataGridViewParams.RowHeadersVisible = false;
            this.dataGridViewParams.RowHeadersWidth = 102;
            this.dataGridViewParams.Size = new System.Drawing.Size(708, 286);
            this.dataGridViewParams.TabIndex = 90;
            this.dataGridViewParams.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParams_CellEndEdit);
            // 
            // colParamAddress
            // 
            this.colParamAddress.HeaderText = "Add";
            this.colParamAddress.MinimumWidth = 12;
            this.colParamAddress.Name = "colParamAddress";
            this.colParamAddress.ReadOnly = true;
            this.colParamAddress.Width = 60;
            // 
            // colParamName
            // 
            this.colParamName.HeaderText = "Name";
            this.colParamName.MinimumWidth = 12;
            this.colParamName.Name = "colParamName";
            this.colParamName.ReadOnly = true;
            this.colParamName.Width = 210;
            // 
            // colParamValue
            // 
            this.colParamValue.HeaderText = "Value (float)";
            this.colParamValue.MinimumWidth = 12;
            this.colParamValue.Name = "colParamValue";
            this.colParamValue.Width = 180;
            // 
            // buttonReadParams
            // 
            this.buttonReadParams.Enabled = false;
            this.buttonReadParams.Location = new System.Drawing.Point(750, 275);
            this.buttonReadParams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReadParams.Name = "buttonReadParams";
            this.buttonReadParams.Size = new System.Drawing.Size(188, 39);
            this.buttonReadParams.TabIndex = 100;
            this.buttonReadParams.Text = "READ FROM CARD";
            this.buttonReadParams.UseVisualStyleBackColor = true;
            this.buttonReadParams.Click += new System.EventHandler(this.buttonReadParams_Click);
            // 
            // buttonWriteParams
            // 
            this.buttonWriteParams.Enabled = false;
            this.buttonWriteParams.Location = new System.Drawing.Point(750, 320);
            this.buttonWriteParams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonWriteParams.Name = "buttonWriteParams";
            this.buttonWriteParams.Size = new System.Drawing.Size(188, 37);
            this.buttonWriteParams.TabIndex = 101;
            this.buttonWriteParams.Text = "WRITE TO CARD";
            this.buttonWriteParams.UseVisualStyleBackColor = true;
            this.buttonWriteParams.Click += new System.EventHandler(this.buttonWriteParams_Click);
            // 
            // buttonSaveParams
            // 
            this.buttonSaveParams.Location = new System.Drawing.Point(760, 434);
            this.buttonSaveParams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaveParams.Name = "buttonSaveParams";
            this.buttonSaveParams.Size = new System.Drawing.Size(178, 36);
            this.buttonSaveParams.TabIndex = 102;
            this.buttonSaveParams.Text = "SAVE TO FILE";
            this.buttonSaveParams.UseVisualStyleBackColor = true;
            this.buttonSaveParams.Click += new System.EventHandler(this.buttonSaveParams_Click);
            // 
            // buttonLoadParams
            // 
            this.buttonLoadParams.Location = new System.Drawing.Point(760, 478);
            this.buttonLoadParams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoadParams.Name = "buttonLoadParams";
            this.buttonLoadParams.Size = new System.Drawing.Size(178, 40);
            this.buttonLoadParams.TabIndex = 103;
            this.buttonLoadParams.Text = "LOAD FROM FILE";
            this.buttonLoadParams.UseVisualStyleBackColor = true;
            this.buttonLoadParams.Click += new System.EventHandler(this.buttonLoadParams_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Location = new System.Drawing.Point(650, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(247, 199);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Parity";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "NONE",
            "EVEN",
            "ODD"});
            this.comboBox4.Location = new System.Drawing.Point(119, 114);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(122, 28);
            this.comboBox4.TabIndex = 25;
            // 
            // buttonReadFW
            // 
            this.buttonReadFW.Enabled = false;
            this.buttonReadFW.Location = new System.Drawing.Point(484, 118);
            this.buttonReadFW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReadFW.Name = "buttonReadFW";
            this.buttonReadFW.Size = new System.Drawing.Size(99, 29);
            this.buttonReadFW.TabIndex = 104;
            this.buttonReadFW.Text = "READ FW";
            this.buttonReadFW.UseVisualStyleBackColor = true;
            this.buttonReadFW.Click += new System.EventHandler(this.buttonReadFW_Click);
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 625);
            this.Controls.Add(this.buttonReadFW);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonLoadParams);
            this.Controls.Add(this.buttonSaveParams);
            this.Controls.Add(this.buttonWriteParams);
            this.Controls.Add(this.dataGridViewParams);
            this.Controls.Add(this.buttonReadParams);
            this.Controls.Add(this.label_100mV);
            this.Controls.Add(this.label_pulse_day);
            this.Controls.Add(this.label_pulse_h);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label_ext_hum);
            this.Controls.Add(this.label_ext_temp);
            this.Controls.Add(this.label_ext_press);
            this.Controls.Add(this.label_roll);
            this.Controls.Add(this.label_pitch);
            this.Controls.Add(this.label_int_temp);
            this.Controls.Add(this.label_Int_Prs);
            this.Controls.Add(this.label_Photo);
            this.Controls.Add(this.label_CNT);
            this.Controls.Add(this.label_RTD);
            this.Controls.Add(this.label_0_5V);
            this.Controls.Add(this.label_I2);
            this.Controls.Add(this.label_I1);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Weather";
            this.Text = "Weather Station Data Display and Configuration v2.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Weather_FormClosing);
            this.Load += new System.EventHandler(this.Weather_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParams)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Label label_I1;
        private System.Windows.Forms.Label label_I2;
        private System.Windows.Forms.Label label_0_5V;
        private System.Windows.Forms.Label label_RTD;
        private System.Windows.Forms.Label label_int_temp;
        private System.Windows.Forms.Label label_Int_Prs;
        private System.Windows.Forms.Label label_Photo;
        private System.Windows.Forms.Label label_CNT;
        private System.Windows.Forms.Label label_ext_hum;
        private System.Windows.Forms.Label label_ext_temp;
        private System.Windows.Forms.Label label_ext_press;
        private System.Windows.Forms.Label label_roll;
        private System.Windows.Forms.Label label_pitch;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox SelectCalCh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_pulse_h;
        private System.Windows.Forms.Label label_pulse_day;
        private System.Windows.Forms.Label label_100mV;

        // NEW: controls for editable parameter floats (from holding registers)
        private System.Windows.Forms.DataGridView dataGridViewParams;
        private System.Windows.Forms.Button buttonReadParams;
        private System.Windows.Forms.Button buttonWriteParams;
        private System.Windows.Forms.Button buttonSaveParams;
        private System.Windows.Forms.Button buttonLoadParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParamAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParamValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button buttonReadFW;
    }
}

