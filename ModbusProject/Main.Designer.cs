namespace ModbusProject
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMasterType = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.txtDataBits = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHexStartAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSlaveId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtDecStartAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLargeFont = new System.Windows.Forms.Button();
            this.btnSmallFont = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.swLEDGreen = new DevExpress.XtraEditors.ToggleSwitch();
            this.swLEDRed = new DevExpress.XtraEditors.ToggleSwitch();
            this.swLEDBlue = new DevExpress.XtraEditors.ToggleSwitch();
            this.swLEDYellow = new DevExpress.XtraEditors.ToggleSwitch();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swLEDGreen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swLEDRed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swLEDBlue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swLEDYellow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMasterType);
            this.groupBox1.Controls.Add(this.cmbStopBits);
            this.groupBox1.Controls.Add(this.cmbParity);
            this.groupBox1.Controls.Add(this.txtDataBits);
            this.groupBox1.Controls.Add(this.txtBaudRate);
            this.groupBox1.Controls.Add(this.cmbComPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port Configuration";
            // 
            // cmbMasterType
            // 
            this.cmbMasterType.FormattingEnabled = true;
            this.cmbMasterType.Items.AddRange(new object[] {
            "Create Ascii",
            "Create Rtu"});
            this.cmbMasterType.Location = new System.Drawing.Point(95, 186);
            this.cmbMasterType.Name = "cmbMasterType";
            this.cmbMasterType.Size = new System.Drawing.Size(121, 21);
            this.cmbMasterType.TabIndex = 11;
            this.cmbMasterType.Text = "Create Ascii";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.cmbStopBits.Location = new System.Drawing.Point(95, 154);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 21);
            this.cmbStopBits.TabIndex = 10;
            this.cmbStopBits.Text = "One";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Mark",
            "Odd",
            "Even",
            "Space"});
            this.cmbParity.Location = new System.Drawing.Point(95, 122);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 21);
            this.cmbParity.TabIndex = 9;
            this.cmbParity.Text = "None";
            // 
            // txtDataBits
            // 
            this.txtDataBits.Location = new System.Drawing.Point(95, 91);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(121, 20);
            this.txtDataBits.TabIndex = 8;
            this.txtDataBits.Text = "8";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(95, 60);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(121, 20);
            this.txtBaudRate.TabIndex = 7;
            this.txtBaudRate.Text = "115200";
            // 
            // cmbComPort
            // 
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(95, 28);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(121, 21);
            this.cmbComPort.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Master Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stop Bits:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDecStartAddress);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtHexStartAddress);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSlaveId);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modbus Configuration";
            // 
            // txtHexStartAddress
            // 
            this.txtHexStartAddress.Location = new System.Drawing.Point(61, 61);
            this.txtHexStartAddress.Name = "txtHexStartAddress";
            this.txtHexStartAddress.Size = new System.Drawing.Size(155, 20);
            this.txtHexStartAddress.TabIndex = 11;
            this.txtHexStartAddress.Text = "0x2D";
            this.txtHexStartAddress.TextChanged += new System.EventHandler(this.txtStartAddress_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "HEX Add:";
            // 
            // txtSlaveId
            // 
            this.txtSlaveId.Location = new System.Drawing.Point(61, 29);
            this.txtSlaveId.Name = "txtSlaveId";
            this.txtSlaveId.Size = new System.Drawing.Size(155, 20);
            this.txtSlaveId.TabIndex = 9;
            this.txtSlaveId.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Slave Id:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnSendMessage);
            this.groupBox3.Controls.Add(this.txtMessage);
            this.groupBox3.Location = new System.Drawing.Point(255, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 334);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.swLEDBlue);
            this.groupBox4.Controls.Add(this.swLEDYellow);
            this.groupBox4.Controls.Add(this.swLEDRed);
            this.groupBox4.Controls.Add(this.swLEDGreen);
            this.groupBox4.Location = new System.Drawing.Point(9, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 42);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ascii Message Code:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 154);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(392, 95);
            this.textBox2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Message:";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(219, 255);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(179, 23);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(6, 32);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(392, 95);
            this.txtMessage.TabIndex = 0;
            // 
            // txtDecStartAddress
            // 
            this.txtDecStartAddress.Location = new System.Drawing.Point(61, 87);
            this.txtDecStartAddress.Name = "txtDecStartAddress";
            this.txtDecStartAddress.Size = new System.Drawing.Size(155, 20);
            this.txtDecStartAddress.TabIndex = 13;
            this.txtDecStartAddress.Text = "45";
            this.txtDecStartAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "DEC Add:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSmallFont);
            this.groupBox5.Controls.Add(this.btnLargeFont);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(255, 352);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(413, 53);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Font";
            // 
            // btnLargeFont
            // 
            this.btnLargeFont.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLargeFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargeFont.Location = new System.Drawing.Point(183, 18);
            this.btnLargeFont.Name = "btnLargeFont";
            this.btnLargeFont.Size = new System.Drawing.Size(118, 23);
            this.btnLargeFont.TabIndex = 11;
            this.btnLargeFont.Text = "Large Font";
            this.btnLargeFont.UseVisualStyleBackColor = false;
            this.btnLargeFont.Click += new System.EventHandler(this.btnLargeFont_Click);
            // 
            // btnSmallFont
            // 
            this.btnSmallFont.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSmallFont.Location = new System.Drawing.Point(59, 18);
            this.btnSmallFont.Name = "btnSmallFont";
            this.btnSmallFont.Size = new System.Drawing.Size(118, 23);
            this.btnSmallFont.TabIndex = 12;
            this.btnSmallFont.Text = "small font";
            this.btnSmallFont.UseVisualStyleBackColor = false;
            this.btnSmallFont.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // swLEDGreen
            // 
            this.swLEDGreen.Location = new System.Drawing.Point(6, 16);
            this.swLEDGreen.Name = "swLEDGreen";
            this.swLEDGreen.Properties.Appearance.BackColor = System.Drawing.Color.Lime;
            this.swLEDGreen.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.swLEDGreen.Properties.Appearance.Options.UseBackColor = true;
            this.swLEDGreen.Properties.Appearance.Options.UseForeColor = true;
            this.swLEDGreen.Properties.OffText = "خاموش";
            this.swLEDGreen.Properties.OnText = "روشن";
            this.swLEDGreen.Size = new System.Drawing.Size(86, 18);
            this.swLEDGreen.TabIndex = 12;
            this.swLEDGreen.Toggled += new System.EventHandler(this.swLEDGreen_Toggled);
            // 
            // swLEDRed
            // 
            this.swLEDRed.Location = new System.Drawing.Point(103, 16);
            this.swLEDRed.Name = "swLEDRed";
            this.swLEDRed.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.swLEDRed.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.swLEDRed.Properties.Appearance.Options.UseBackColor = true;
            this.swLEDRed.Properties.Appearance.Options.UseForeColor = true;
            this.swLEDRed.Properties.OffText = "خاموش";
            this.swLEDRed.Properties.OnText = "روشن";
            this.swLEDRed.Size = new System.Drawing.Size(86, 18);
            this.swLEDRed.TabIndex = 13;
            this.swLEDRed.Toggled += new System.EventHandler(this.swLEDRed_Toggled);
            // 
            // swLEDBlue
            // 
            this.swLEDBlue.Location = new System.Drawing.Point(297, 16);
            this.swLEDBlue.Name = "swLEDBlue";
            this.swLEDBlue.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.swLEDBlue.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.swLEDBlue.Properties.Appearance.Options.UseBackColor = true;
            this.swLEDBlue.Properties.Appearance.Options.UseForeColor = true;
            this.swLEDBlue.Properties.OffText = "خاموش";
            this.swLEDBlue.Properties.OnText = "روشن";
            this.swLEDBlue.Size = new System.Drawing.Size(86, 18);
            this.swLEDBlue.TabIndex = 15;
            this.swLEDBlue.Toggled += new System.EventHandler(this.swLEDBlue_Toggled);
            // 
            // swLEDYellow
            // 
            this.swLEDYellow.Location = new System.Drawing.Point(200, 16);
            this.swLEDYellow.Name = "swLEDYellow";
            this.swLEDYellow.Properties.Appearance.BackColor = System.Drawing.Color.Olive;
            this.swLEDYellow.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.swLEDYellow.Properties.Appearance.Options.UseBackColor = true;
            this.swLEDYellow.Properties.Appearance.Options.UseForeColor = true;
            this.swLEDYellow.Properties.OffText = "خاموش";
            this.swLEDYellow.Properties.OnText = "روشن";
            this.swLEDYellow.Size = new System.Drawing.Size(86, 18);
            this.swLEDYellow.TabIndex = 14;
            this.swLEDYellow.Toggled += new System.EventHandler(this.swLEDYellow_Toggled);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 432);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Main";
            this.Text = "Modbus ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swLEDGreen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swLEDRed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swLEDBlue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swLEDYellow.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMasterType;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.TextBox txtDataBits;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHexStartAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSlaveId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtDecStartAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSmallFont;
        private System.Windows.Forms.Button btnLargeFont;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.ToggleSwitch swLEDBlue;
        private DevExpress.XtraEditors.ToggleSwitch swLEDYellow;
        private DevExpress.XtraEditors.ToggleSwitch swLEDRed;
        private DevExpress.XtraEditors.ToggleSwitch swLEDGreen;
    }
}

