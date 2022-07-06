﻿/*
 * System libraries
 */
using System;
using System.Text;
using System.Windows.Forms;
using Swiatlo.Serial;
using System.Globalization;
using System.Diagnostics;

namespace Swiatlo

{
    /**
     * @breif Main form class. Inherit from form Form class.
     *        Partial definition -  remider of the class defined in 
     *        automatically generated file MainForm.designer.cs
     */
    public partial class MainForm : Form
    {
        //! Default constructor.
        public MainForm()
        {
            InitializeComponent();
            UserInitialization();
        }

        #region Fields

        private SerialPortManager _spManager;
        private string _adcStr;
        private double _plotTime;

        private ushort _dacValue;
        private readonly int _spMsgSize = 3;
        private readonly int _plotTimeMax = 100;
        private readonly double _plotTimeStep = 1;

        private readonly CultureInfo _cultureInfo = new CultureInfo("en-US");

        /** Custom serial port manager class object. */

        #endregion

        #region Event handlers

        /**
         * @brief Main form window closing event handling function.
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the form closing event data.
         */
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _spManager.Dispose();
        }

        /**
         * @brief New serial port data recived event handlig function. Update of "tbDataReceive" text box.
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the serial port event data.
         */
        private void SpManager_DataReveiced_UpdateTextblock(object sender, SerialDataEventArgs e)
        {
            if (InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                BeginInvoke(new EventHandler<SerialDataEventArgs>(SpManager_DataReveiced_UpdateTextblock), new object[] { sender, e });
                return;
            }

            int maxTextLength = 1000; // maximum text length in text box
            if (tbDataReceive.TextLength > maxTextLength)
                tbDataReceive.Text = tbDataReceive.Text.Remove(0, tbDataReceive.TextLength - maxTextLength);

            // Byte array to string
            string str = Encoding.ASCII.GetString(e.Data);

            tbDataReceive.AppendText(str);
            tbDataReceive.ScrollToCaret();
        }

        /**
         * @brief Error handling function. Display message in groupBox "Exceptions".
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the event data.
         */
        private void SpManager_ErrorHandler(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<EventArgs>(SpManager_ErrorHandler), new object[] { sender, e });
                return;
            }
            
        }

        /**
         * @brief Handles the "Connect"-buttom click event
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the event data.
         */
        private void BtnStart_Click(object sender, EventArgs e)
        {
            Connect();
        }

        /**
         * @brief Handles the "Diconnect"-buttom click event
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the event data.
         */
        private void BtnStop_Click(object sender, EventArgs e)
        {
            Disonnect();
        }

        /**
         * @brief Handles the "Send"-buttom click event
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the event data.
         */
        private void BtnSend_Click(object sender, EventArgs e)
        {
            _spManager.Send(tbDataTransmit.Text);
        }

        /**
         * Handles the "Clear"-buttom click event
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the event data.
         */
        private void BtnClear_Click(object sender, EventArgs e)
        {
            tbDataReceive.Clear();
        }

        /**
         * Handles the "Clear error"-buttom click event
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the event data.
         */
        private void BtnClearError_Click(object sender, EventArgs e)
        {
           
        }

        /**
         * @brief Receive text box 'Rx Enable' check box click event method.
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the event data.
         */
        private void RxEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rxEnableCheckBox.Checked)
                RxTextBoxEnable();
            else
                RxTextBoxDisable();
        }

        /** !!! TODO !!!
         * @brief New serial port data recived event handlig function. Update of analog input data plot
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the serial port event data.
         */
        private void SpManager_DataReveiced_UpdateDataPlot(object sender, SerialDataEventArgs e)
        {
            if (InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                BeginInvoke(new EventHandler<SerialDataEventArgs>(SpManager_DataReveiced_UpdateDataPlot), new object[] { sender, e });
                return;
            }

            // TODO: PLOT UPDATE LOGIC

        }

        /** !!! TODO !!!
         * @brief Input plot 'Start' button click event method.
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the event data.
         */
        private void BtnPlotStart_Click(object sender, EventArgs e)
        {
            // TODO: PLOT START BUTTON LOGIC

        }

        /** !!! TODO !!!
         * @brief Input plot 'Pause' button click event method.
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the event data.
         */
        private void BtnPlotPause_Click(object sender, EventArgs e)
        {
            // TODO: PLOT PAUSE BUTTON LOGIC

        }

        /** !!! TODO !!!
         * @brief Input plot 'Stop' button click event method.
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the event data.
         */
        private void BtnPlotStop_Click(object sender, EventArgs e)
        {
            // TODO: PLOT STOP BUTTON LOGIC

        }

        /** !!! TODO !!!
         * @brief Output control track bar scroll event method.
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the event data.
         */
        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            // TODO: TRACK BAR SCROLL LOGIC

        }

        /** !!! TODO !!!
         * @brief Output control 'Set' button click event method.
         * @param[in] sender : contains a reference to the control/object that raised the event.
         * @param[in] e      : contains the event data.
         */
        private void BtnDacSet_Click(object sender, EventArgs e)
        {
            // TODO: DAC SET BUTTON LOGIC

        }

        #endregion

        #region Methods

        /**
         * @brief User custom initialization.
         */
        private void UserInitialization()
        {
            // New serial port manager
            _spManager = new SerialPortManager();

            // Read current serial port settings 
            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;

            // Bind serial port & user interface data sources with serial port settings
            serialSettingsBindingSource.DataSource = mySerialSettings;
            portNameComboBox.DataSource = mySerialSettings.PortNameCollection;
            baudRateComboBox.DataSource = mySerialSettings.BaudRateCollection;
            mySerialSettings.BaudRateCollectionUpdateHandler =
                () => baudRateComboBox.SelectedIndex = mySerialSettings.BaudRateCollection.IndexOf(115200);
            dataBitsComboBox.DataSource = mySerialSettings.DataBitsCollection;
            parityComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.Parity));
            stopBitsComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.StopBits));

            // Add evnet handling functions to serial port manager
            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(SpManager_DataReveiced_UpdateTextblock);
            _spManager.ErrorHandler += new EventHandler<EventArgs>(SpManager_ErrorHandler);

            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

            // Diable "Disconnect" button
            btnStop.Enabled = false;
        }

        /*
        * Connect procedure - open and start listening on COM port.
        */
        private void Connect()
        {
            if (_spManager.StartListening())
            {
                btnStop.Enabled = true;
                btnStart.Enabled = false;
                portNameComboBox.Enabled = false;
                baudRateComboBox.Enabled = false;
                dataBitsComboBox.Enabled = false;
                parityComboBox.Enabled = false;
                stopBitsComboBox.Enabled = false;
            }
        }

        /**
         * @brief Disconnect procedure - close and stop listening on COM port.
         */
        private void Disonnect()
        {
            _spManager.StopListening();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            portNameComboBox.Enabled = true;
            baudRateComboBox.Enabled = true;
            dataBitsComboBox.Enabled = true;
            parityComboBox.Enabled = true;
            stopBitsComboBox.Enabled = true;
        }

        /**
         * @brief Enables receive text box.
         */
        private void RxTextBoxEnable()
        {
            rxEnableCheckBox.Checked = true;
            tbDataReceive.Enabled = true;
            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(SpManager_DataReveiced_UpdateTextblock);
        }

        /**
         * @brief Disables receive text box.
         */
        private void RxTextBoxDisable()
        {
            rxEnableCheckBox.Checked = false;
            tbDataReceive.Enabled = false;
            _spManager.NewSerialDataRecieved -= new EventHandler<SerialDataEventArgs>(SpManager_DataReveiced_UpdateTextblock);
        }

        /**
         * @brief 12-bit register value to voltage in volts.
         * @param[in] reg : Register value: 12-bit unsiged integer [0x000-0xFFF].
         * @return Voltage in volts [0.0-3.3 V].
         */
        private double Reg2vol(ushort reg)
        {
            return (3.3 * reg / 4095.0);
        }

        /**
         * @brief Voltage in volts to 12-bit register.
         * @param[in] vol : Voltage in volts [0.0-3.3 V]. 
         * @return Register value: 12-bit unsiged integer [0x000-0xFFF].
         */
        private ushort Vol2reg(double vol)
        {
            return (ushort)(4095 * (vol / 3.3));
        }

        #endregion

        private void baudRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void portNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
