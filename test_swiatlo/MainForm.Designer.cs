namespace Swiatlo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabInput = new System.Windows.Forms.TabPage();
            this.tabSerialPort = new System.Windows.Forms.TabPage();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.portNameLabel = new System.Windows.Forms.Label();
            this.parityLabel = new System.Windows.Forms.Label();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox_transmit = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbDataTransmit = new System.Windows.Forms.TextBox();
            this.groupBox_receive = new System.Windows.Forms.GroupBox();
            this.rxEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbDataReceive = new System.Windows.Forms.TextBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.tabInput.SuspendLayout();
            this.tabSerialPort.SuspendLayout();
            this.groupBox_settings.SuspendLayout();
            this.groupBox_transmit.SuspendLayout();
            this.groupBox_receive.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.label3);
            this.tabInput.Controls.Add(this.label2);
            this.tabInput.Controls.Add(this.label1);
            this.tabInput.Controls.Add(this.pictureBox1);
            this.tabInput.Location = new System.Drawing.Point(4, 22);
            this.tabInput.Name = "tabInput";
            this.tabInput.Size = new System.Drawing.Size(524, 446);
            this.tabInput.TabIndex = 1;
            this.tabInput.Text = "Authors";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // tabSerialPort
            // 
            this.tabSerialPort.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabSerialPort.Controls.Add(this.groupBox_settings);
            this.tabSerialPort.Controls.Add(this.groupBox_transmit);
            this.tabSerialPort.Controls.Add(this.groupBox_receive);
            this.tabSerialPort.Location = new System.Drawing.Point(4, 22);
            this.tabSerialPort.Name = "tabSerialPort";
            this.tabSerialPort.Padding = new System.Windows.Forms.Padding(3);
            this.tabSerialPort.Size = new System.Drawing.Size(524, 446);
            this.tabSerialPort.TabIndex = 0;
            this.tabSerialPort.Text = "Serial Port";
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_settings.Controls.Add(this.baudRateComboBox);
            this.groupBox_settings.Controls.Add(this.btnStop);
            this.groupBox_settings.Controls.Add(this.baudRateLabel);
            this.groupBox_settings.Controls.Add(this.btnStart);
            this.groupBox_settings.Controls.Add(this.stopBitsComboBox);
            this.groupBox_settings.Controls.Add(this.stopBitsLabel);
            this.groupBox_settings.Controls.Add(this.dataBitsLabel);
            this.groupBox_settings.Controls.Add(this.portNameComboBox);
            this.groupBox_settings.Controls.Add(this.dataBitsComboBox);
            this.groupBox_settings.Controls.Add(this.portNameLabel);
            this.groupBox_settings.Controls.Add(this.parityLabel);
            this.groupBox_settings.Controls.Add(this.parityComboBox);
            this.groupBox_settings.Location = new System.Drawing.Point(8, 6);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(511, 167);
            this.groupBox_settings.TabIndex = 11;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Serial Port Settings";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "BaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(108, 56);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(153, 21);
            this.baudRateComboBox.TabIndex = 2;
            this.baudRateComboBox.SelectedIndexChanged += new System.EventHandler(this.baudRateComboBox_SelectedIndexChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(340, 103);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(73, 23);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Disconnect";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(10, 59);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(61, 13);
            this.baudRateLabel.TabIndex = 1;
            this.baudRateLabel.Text = "Baud Rate:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(339, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(74, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Connect";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "StopBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(108, 137);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(153, 21);
            this.stopBitsComboBox.TabIndex = 10;
            // 
            // stopBitsLabel
            // 
            this.stopBitsLabel.AutoSize = true;
            this.stopBitsLabel.Location = new System.Drawing.Point(10, 140);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(52, 13);
            this.stopBitsLabel.TabIndex = 9;
            this.stopBitsLabel.Text = "Stop Bits:";
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Location = new System.Drawing.Point(10, 86);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(53, 13);
            this.dataBitsLabel.TabIndex = 3;
            this.dataBitsLabel.Text = "Data Bits:";
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(108, 32);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(153, 21);
            this.portNameComboBox.TabIndex = 8;
            this.portNameComboBox.SelectedIndexChanged += new System.EventHandler(this.portNameComboBox_SelectedIndexChanged);
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "DataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Location = new System.Drawing.Point(108, 83);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(153, 21);
            this.dataBitsComboBox.TabIndex = 4;
            // 
            // portNameLabel
            // 
            this.portNameLabel.AutoSize = true;
            this.portNameLabel.Location = new System.Drawing.Point(10, 32);
            this.portNameLabel.Name = "portNameLabel";
            this.portNameLabel.Size = new System.Drawing.Size(60, 13);
            this.portNameLabel.TabIndex = 7;
            this.portNameLabel.Text = "Port Name:";
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Location = new System.Drawing.Point(10, 113);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(36, 13);
            this.parityLabel.TabIndex = 5;
            this.parityLabel.Text = "Parity:";
            // 
            // parityComboBox
            // 
            this.parityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "Parity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Location = new System.Drawing.Point(108, 110);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(153, 21);
            this.parityComboBox.TabIndex = 6;
            // 
            // groupBox_transmit
            // 
            this.groupBox_transmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_transmit.Controls.Add(this.btnSend);
            this.groupBox_transmit.Controls.Add(this.tbDataTransmit);
            this.groupBox_transmit.Location = new System.Drawing.Point(8, 322);
            this.groupBox_transmit.Name = "groupBox_transmit";
            this.groupBox_transmit.Size = new System.Drawing.Size(511, 118);
            this.groupBox_transmit.TabIndex = 15;
            this.groupBox_transmit.TabStop = false;
            this.groupBox_transmit.Text = "Transmit";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(420, 43);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // tbDataTransmit
            // 
            this.tbDataTransmit.Location = new System.Drawing.Point(12, 19);
            this.tbDataTransmit.Name = "tbDataTransmit";
            this.tbDataTransmit.Size = new System.Drawing.Size(494, 20);
            this.tbDataTransmit.TabIndex = 0;
            // 
            // groupBox_receive
            // 
            this.groupBox_receive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_receive.Controls.Add(this.rxEnableCheckBox);
            this.groupBox_receive.Controls.Add(this.btnClear);
            this.groupBox_receive.Controls.Add(this.tbDataReceive);
            this.groupBox_receive.Location = new System.Drawing.Point(6, 179);
            this.groupBox_receive.Name = "groupBox_receive";
            this.groupBox_receive.Size = new System.Drawing.Size(511, 128);
            this.groupBox_receive.TabIndex = 14;
            this.groupBox_receive.TabStop = false;
            this.groupBox_receive.Text = "Receive";
            // 
            // rxEnableCheckBox
            // 
            this.rxEnableCheckBox.AutoSize = true;
            this.rxEnableCheckBox.Checked = true;
            this.rxEnableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rxEnableCheckBox.Location = new System.Drawing.Point(12, 106);
            this.rxEnableCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.rxEnableCheckBox.Name = "rxEnableCheckBox";
            this.rxEnableCheckBox.Size = new System.Drawing.Size(75, 17);
            this.rxEnableCheckBox.TabIndex = 15;
            this.rxEnableCheckBox.Text = "Rx Enable";
            this.rxEnableCheckBox.UseVisualStyleBackColor = true;
            this.rxEnableCheckBox.CheckedChanged += new System.EventHandler(this.RxEnableCheckBox_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(219, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // tbDataReceive
            // 
            this.tbDataReceive.Location = new System.Drawing.Point(6, 14);
            this.tbDataReceive.Multiline = true;
            this.tbDataReceive.Name = "tbDataReceive";
            this.tbDataReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDataReceive.Size = new System.Drawing.Size(494, 82);
            this.tbDataReceive.TabIndex = 13;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSerialPort);
            this.tabMain.Controls.Add(this.tabInput);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(532, 472);
            this.tabMain.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jakub Żuberek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miłosz Górny";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kornel Maćkowiak";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(532, 472);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Regulator Natezenia Swiatla";
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).EndInit();
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
            this.tabSerialPort.ResumeLayout(false);
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            this.groupBox_transmit.ResumeLayout(false);
            this.groupBox_transmit.PerformLayout();
            this.groupBox_receive.ResumeLayout(false);
            this.groupBox_receive.PerformLayout();
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource serialSettingsBindingSource;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabSerialPort;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.Label portNameLabel;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.GroupBox groupBox_transmit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbDataTransmit;
        private System.Windows.Forms.GroupBox groupBox_receive;
        private System.Windows.Forms.CheckBox rxEnableCheckBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbDataReceive;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

