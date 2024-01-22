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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1116, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "OPEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1358, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 39);
            this.comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(1396, 255);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "READ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Location = new System.Drawing.Point(24, 823);
            this.errorMsg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(92, 32);
            this.errorMsg.TabIndex = 5;
            this.errorMsg.Text = "label1";
            // 
            // label_I1
            // 
            this.label_I1.AutoSize = true;
            this.label_I1.Location = new System.Drawing.Point(24, 50);
            this.label_I1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_I1.Name = "label_I1";
            this.label_I1.Padding = new System.Windows.Forms.Padding(2);
            this.label_I1.Size = new System.Drawing.Size(56, 36);
            this.label_I1.TabIndex = 6;
            this.label_I1.Text = "I1: ";
            // 
            // label_I2
            // 
            this.label_I2.AutoSize = true;
            this.label_I2.Location = new System.Drawing.Point(24, 91);
            this.label_I2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_I2.Name = "label_I2";
            this.label_I2.Padding = new System.Windows.Forms.Padding(2);
            this.label_I2.Size = new System.Drawing.Size(49, 36);
            this.label_I2.TabIndex = 7;
            this.label_I2.Text = "I2:";
            // 
            // label_0_5V
            // 
            this.label_0_5V.AutoSize = true;
            this.label_0_5V.Location = new System.Drawing.Point(24, 130);
            this.label_0_5V.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_0_5V.Name = "label_0_5V";
            this.label_0_5V.Padding = new System.Windows.Forms.Padding(2);
            this.label_0_5V.Size = new System.Drawing.Size(92, 36);
            this.label_0_5V.TabIndex = 8;
            this.label_0_5V.Text = "0_5V:";
            // 
            // label_RTD
            // 
            this.label_RTD.AutoSize = true;
            this.label_RTD.Location = new System.Drawing.Point(24, 167);
            this.label_RTD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_RTD.Name = "label_RTD";
            this.label_RTD.Padding = new System.Windows.Forms.Padding(2);
            this.label_RTD.Size = new System.Drawing.Size(75, 36);
            this.label_RTD.TabIndex = 9;
            this.label_RTD.Text = "RTD";
            // 
            // label_int_temp
            // 
            this.label_int_temp.AutoSize = true;
            this.label_int_temp.Location = new System.Drawing.Point(24, 310);
            this.label_int_temp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_int_temp.Name = "label_int_temp";
            this.label_int_temp.Padding = new System.Windows.Forms.Padding(2);
            this.label_int_temp.Size = new System.Drawing.Size(136, 36);
            this.label_int_temp.TabIndex = 13;
            this.label_int_temp.Text = "Int_Temp";
            // 
            // label_Int_Prs
            // 
            this.label_Int_Prs.AutoSize = true;
            this.label_Int_Prs.Location = new System.Drawing.Point(24, 273);
            this.label_Int_Prs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Int_Prs.Name = "label_Int_Prs";
            this.label_Int_Prs.Padding = new System.Windows.Forms.Padding(2);
            this.label_Int_Prs.Size = new System.Drawing.Size(136, 36);
            this.label_Int_Prs.TabIndex = 12;
            this.label_Int_Prs.Text = "Int_Press";
            // 
            // label_Photo
            // 
            this.label_Photo.AutoSize = true;
            this.label_Photo.Location = new System.Drawing.Point(24, 236);
            this.label_Photo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Photo.Name = "label_Photo";
            this.label_Photo.Padding = new System.Windows.Forms.Padding(2);
            this.label_Photo.Size = new System.Drawing.Size(93, 36);
            this.label_Photo.TabIndex = 11;
            this.label_Photo.Text = "Photo";
            // 
            // label_CNT
            // 
            this.label_CNT.AutoSize = true;
            this.label_CNT.Location = new System.Drawing.Point(24, 200);
            this.label_CNT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_CNT.Name = "label_CNT";
            this.label_CNT.Padding = new System.Windows.Forms.Padding(2);
            this.label_CNT.Size = new System.Drawing.Size(90, 36);
            this.label_CNT.TabIndex = 10;
            this.label_CNT.Text = "Pulse";
            // 
            // label_ext_hum
            // 
            this.label_ext_hum.AutoSize = true;
            this.label_ext_hum.Location = new System.Drawing.Point(24, 484);
            this.label_ext_hum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_ext_hum.Name = "label_ext_hum";
            this.label_ext_hum.Padding = new System.Windows.Forms.Padding(2);
            this.label_ext_hum.Size = new System.Drawing.Size(185, 36);
            this.label_ext_hum.TabIndex = 18;
            this.label_ext_hum.Text = "Ext_Humidity";
            // 
            // label_ext_temp
            // 
            this.label_ext_temp.AutoSize = true;
            this.label_ext_temp.Location = new System.Drawing.Point(24, 448);
            this.label_ext_temp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_ext_temp.Name = "label_ext_temp";
            this.label_ext_temp.Padding = new System.Windows.Forms.Padding(2);
            this.label_ext_temp.Size = new System.Drawing.Size(148, 36);
            this.label_ext_temp.TabIndex = 17;
            this.label_ext_temp.Text = "Ent_Temp";
            // 
            // label_ext_press
            // 
            this.label_ext_press.AutoSize = true;
            this.label_ext_press.Location = new System.Drawing.Point(24, 415);
            this.label_ext_press.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_ext_press.Name = "label_ext_press";
            this.label_ext_press.Padding = new System.Windows.Forms.Padding(2);
            this.label_ext_press.Size = new System.Drawing.Size(146, 36);
            this.label_ext_press.TabIndex = 16;
            this.label_ext_press.Text = "Ext_Press";
            // 
            // label_roll
            // 
            this.label_roll.AutoSize = true;
            this.label_roll.Location = new System.Drawing.Point(24, 378);
            this.label_roll.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_roll.Name = "label_roll";
            this.label_roll.Padding = new System.Windows.Forms.Padding(2);
            this.label_roll.Size = new System.Drawing.Size(68, 36);
            this.label_roll.TabIndex = 15;
            this.label_roll.Text = "Roll";
            // 
            // label_pitch
            // 
            this.label_pitch.AutoSize = true;
            this.label_pitch.Location = new System.Drawing.Point(24, 345);
            this.label_pitch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_pitch.Name = "label_pitch";
            this.label_pitch.Padding = new System.Windows.Forms.Padding(2);
            this.label_pitch.Size = new System.Drawing.Size(82, 36);
            this.label_pitch.TabIndex = 14;
            this.label_pitch.Text = "Pitch";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1390, 330);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 36);
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
            this.comboBox2.Location = new System.Drawing.Point(1358, 118);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 39);
            this.comboBox2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1166, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1190, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Address";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.comboBox3.Location = new System.Drawing.Point(1358, 194);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(134, 39);
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
            "4 Photodiode",
            "5 RTD res"});
            this.SelectCalCh.Location = new System.Drawing.Point(133, 54);
            this.SelectCalCh.Name = "SelectCalCh";
            this.SelectCalCh.Size = new System.Drawing.Size(260, 39);
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
            this.groupBox1.Location = new System.Drawing.Point(1189, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 350);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calibration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 62);
            this.button3.TabIndex = 28;
            this.button3.Text = "CAL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 4;
            this.numericUpDown1.Location = new System.Drawing.Point(182, 152);
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
            this.numericUpDown1.Size = new System.Drawing.Size(211, 38);
            this.numericUpDown1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Channel";
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Weather";
            this.Text = "Weather Station Data Display";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Weather_FormClosing);
            this.Load += new System.EventHandler(this.Weather_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
    }
}

