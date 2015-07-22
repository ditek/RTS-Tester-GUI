using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Collections;
using System.Globalization;

namespace RT_Tester_Interface
{
    public partial class Form1 : Form
    {
        delegate void DataReceivedCallback(string text);
        string InputData = String.Empty;
        char[] writeBuffer = new char[10];
        string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        //AppDomain.CurrentDomain.BaseDirectory

        void disable_buttons()
        {
            btnStartTest.Enabled = btnMem.Enabled = btnConf.Enabled = btnMemPC.Enabled = false;
        }

        void enable_buttons()
        {
            btnStartTest.Enabled = btnMem.Enabled = btnConf.Enabled = btnMemPC.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
            dlgOpen.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void cboPorts_Click(object sender, EventArgs e)
        {
            cboPorts.Items.Clear();
            string[] portNames = SerialPort.GetPortNames();
            foreach (string portName in portNames)
                cboPorts.Items.Add(portName);
            cboPorts.Text = portNames[0];
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (btnOpenPort.Text == "Open Port")
            {
                try
                {
                    if (serialPort1.IsOpen)
                        throw new Exception("Port is already open!\r\n");
                    serialPort1.Open();
                    btnOpenPort.Text = "Close Port";
                    enable_buttons();
                    cboPorts.Enabled = false;
                }
                catch (UnauthorizedAccessException ex)
                {
                    txtStatus.AppendText(ex.Message);
                }
                catch (Exception ex)
                {
                    txtStatus.AppendText(ex.Message);
                }
            }

            else if (btnOpenPort.Text == "Close Port")
            {
                try
                {
                    serialPort1.Close();
                    btnOpenPort.Text = "Open Port";
                    disable_buttons();
                }
                catch (UnauthorizedAccessException ex) { txtStatus.AppendText(ex.Message); }
                catch (Exception ex) { txtStatus.AppendText("Problem with port, tester may need a reset. Refresh ports list. \r\n"); }
                finally { cboPorts.Enabled = true; }
            }

            if (serialPort1.IsOpen)
                txtStatus.AppendText("Port is open\r\n");
            else
                txtStatus.AppendText("Port is closed\r\n");
        }

        private void DataReceived(string data)
        {
            txtStatus.AppendText(data);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadExisting();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new DataReceivedCallback(DataReceived), new object[] { InputData });
            }
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            // Testing should be performed twice to procuce valid data because of a bug in the tester IP
            disable_buttons();
            // Empty the receive buffer in case something extra was sent
            serialPort1.DiscardInBuffer();
            writeBuffer[0] = 't';
            serialPort1.Write(writeBuffer, 0, 1);
            serialPort1.ReadTimeout = Int32.Parse(txtTimeout.Text);
            txtStatus.AppendText("Testing...\r\n");
            try
            {
                string message = serialPort1.ReadLine();
                if (message == "s")
                {
                    serialPort1.Write(writeBuffer, 0, 1);
                    message = serialPort1.ReadLine();
                    if (message == "s")
                        txtStatus.AppendText("Test successful.\r\n");
                    else
                        txtStatus.AppendText("Test failed.\r\n");
                }
                else
                    txtStatus.AppendText("Test failed.\r\n");
            }
            catch (TimeoutException) { txtStatus.AppendText("Command timed out. No answer from tester\r\n"); }
            catch (Exception ex) { txtStatus.AppendText(ex.Message); }
            finally
            {
                txtStatus.AppendText(Environment.NewLine);
                enable_buttons();
            }
        }

        private void btnMem_Click(object sender, EventArgs e)
        {
            disable_buttons();
            // Empty the receive buffer in case something extra was sent
            serialPort1.DiscardInBuffer();
            writeBuffer[0] = 'm';
            serialPort1.Write(writeBuffer, 0, 1);
            serialPort1.ReadTimeout = Int32.Parse(txtTimeout.Text);
            bar1.Value = 0;
            txtStatus.AppendText("Memory read request.\r\n");
            try
            {
                string message = serialPort1.ReadLine();
                if (message == "s")
                    txtStatus.AppendText("SD card setup successful.\r\n");
                else
                {
                    txtStatus.AppendText("SD card setup failed.\r\n");
                    throw new Exception();
                }

                message = serialPort1.ReadLine();
                if (message == "m")
                    txtStatus.AppendText("Reading memory...\r\n");
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss") + ".rts";
                using (var writer = new StreamWriter(timestamp))
                {
                    for (int i = 0; i < 512; i++)
                    {
                        writer.Write(serialPort1.ReadLine());
                        bar1.Value = i;
                    }
                }
                message = serialPort1.ReadLine();
                if (message == "s")
                    txtStatus.AppendText("Memory read successfully. Result " + appPath + "\\" + timestamp + "\r\n\r\n");
            }
            catch (TimeoutException) { txtStatus.AppendText("Command timed out. No answer from tester. If problem presists reset the tester.\r\n"); }
            catch (InvalidExpressionException) { txtStatus.AppendText("Unexpected error. Process interrupted\r\n"); }
            catch (Exception ex) { txtStatus.AppendText(ex.Message); }
            finally
            {
                txtStatus.AppendText(Environment.NewLine);
                enable_buttons();
            }
        }

        private void btnMemPC_Click(object sender, EventArgs e)
        {
            disable_buttons();
            // Empty the receive buffer in case something extra was sent
            serialPort1.DiscardInBuffer();
            writeBuffer[0] = 'p';
            serialPort1.Write(writeBuffer, 0, 1);
            serialPort1.ReadTimeout = Int32.Parse(txtTimeout.Text);
            bar1.Value = 0;
            txtStatus.AppendText("Memory read request.\r\n");
            try
            {
                string message = serialPort1.ReadLine();
                if (message == "a")
                    txtStatus.AppendText("Command received by tester.\r\n");

                message = serialPort1.ReadLine();
                if (message == "m")
                    txtStatus.AppendText("Reading memory...\r\n");
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss") + ".rts";
                txtStatus.AppendText("\r\nTest result will be stored in " + appPath + "\\" + timestamp + "\r\n\r\n");
                using (var writer = new StreamWriter(timestamp))
                {
                    for (int i = 0; i < 512; i++)
                    {
                        writer.Write(serialPort1.ReadLine());
                        bar1.Value = i;
                        txtTest.Text = i.ToString();
                    }
                }
                message = serialPort1.ReadLine();
                if (message == "s")
                    txtStatus.AppendText("Memory read successfully.\r\n");
            }
            catch (TimeoutException) { txtStatus.AppendText("Command timed out. No answer from tester. If problem presists reset the tester.\r\n"); }
            catch (InvalidExpressionException) { txtStatus.AppendText("Unexpected error. Process interrupted\r\n"); }
            catch (Exception ex) { txtStatus.AppendText(ex.Message); }
            finally
            {
                txtStatus.AppendText(Environment.NewLine);
                enable_buttons();
            }
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            byte[] writeBufferByte = new byte[10];
            disable_buttons();
            // Empty the receive buffer in case something extra was sent
            serialPort1.DiscardInBuffer();
            writeBuffer[0] = 'c';
            serialPort1.Write(writeBuffer, 0, 1);
            serialPort1.ReadTimeout = Int32.Parse(txtTimeout.Text);
            bar1.Value = 0;
            txtStatus.AppendText("Configuration request.\r\n");
            try
            {
                string message = serialPort1.ReadLine();
                if (message == "a")
                    txtStatus.AppendText("Command received by tester.\r\n");

                writeBufferByte[0] = chkIntA.Checked ? byte.Parse(txtIntA.Text) : (byte)0;
                writeBufferByte[1] = chkIntB.Checked ? byte.Parse(txtIntB.Text) : (byte)0;
                writeBufferByte[2] = chkIntC.Checked ? byte.Parse(txtIntC.Text) : (byte)0;
                writeBufferByte[3] = chkIntD.Checked ? byte.Parse(txtIntD.Text) : (byte)0;
                writeBufferByte[4] = chkBurst.Checked ? (byte)1 : (byte)0;
                writeBufferByte[5] = byte.Parse(txtScaler.Text);
                writeBufferByte[6] = byte.Parse(txtHold.Text);
                writeBufferByte[7] = byte.Parse(txtDuration.Text);
                serialPort1.Write(writeBufferByte, 0, 8);

                message = serialPort1.ReadLine();
                if (message == "s")
                    txtStatus.AppendText("Tester configured successfully.\r\n");
                else
                    txtStatus.AppendText("Configuration failed. \r\n");
            }
            catch (TimeoutException) { txtStatus.AppendText("Command timed out. No answer from tester. If problem presists reset the tester.\r\n"); }
            catch (Exception ex) { txtStatus.AppendText(ex.Message); }
            finally
            {
                txtStatus.AppendText(Environment.NewLine);
                enable_buttons();
            }
        }

        private void cboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cboPorts.Text;
            }
            catch (Exception ex) { txtStatus.AppendText(ex.Message); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void chkIntA_CheckedChanged(object sender, EventArgs e)
        {
            txtIntA.Enabled = chkIntA.Checked;
        }

        private void chkIntB_CheckedChanged(object sender, EventArgs e)
        {
            txtIntB.Enabled = chkIntB.Checked;
        }

        private void chkIntC_CheckedChanged(object sender, EventArgs e)
        {
            txtIntC.Enabled = chkIntC.Checked;
        }

        private void chkIntD_CheckedChanged(object sender, EventArgs e)
        {
            txtIntD.Enabled = chkIntD.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Another way of converting hex to binary
            //var int64 = Int64.Parse("57c0e800000082e8", NumberStyles.HexNumber);
            //var bytes = BitConverter.GetBytes(int64);
            //var bitArray = new BitArray(bytes);

            string type, int_str, ack_str, data, timestamp_str;
            List<string> type_lst = new List<string>();
            List<int> timestamp_lst = new List<int>();
            List<char[]> int_lst = new List<char[]>();
            List<char[]> ack_lst = new List<char[]>();
            List<string> int_str_lst = new List<string>();
            List<string> ack_str_lst = new List<string>();
            char[] int_arr = new char[4];
            char[] ack_arr = new char[4];

            string[] lines = txtHex.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                int_arr = new char[4];
                ack_arr = new char[4];
                string binary = String.Join(String.Empty, line.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));

                type = binary.Substring(4, 2);
                int_str = binary.Substring(6, 4);
                ack_str = binary.Substring(10, 4);
                data = binary.Substring(14, 7);
                timestamp_str = binary.Substring(21, 43);

                binary.CopyTo(6, int_arr, 0, 4);
                binary.CopyTo(10, ack_arr, 0, 4);

                type_lst.Add(type);
                int_lst.Add(int_arr);
                ack_lst.Add(ack_arr);
                timestamp_lst.Add(Convert.ToInt32(timestamp_str, 2));

                int_str_lst.Add(int_str);
                ack_str_lst.Add(ack_str);
            }
            for (int i = 0; i < type_lst.Count; i++)
                txtStatus.AppendText(string.Format("{0} {1} {2} {3}\n", i, int_str_lst[i], ack_str_lst[i], timestamp_lst[i]));
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables and lists to hold the extracted data
                string type, int_str, ack_str, data, timestamp_str;
                List<string> type_lst = new List<string>();
                List<int> timestamp_lst = new List<int>();
                List<char[]> int_lst = new List<char[]>();
                List<char[]> ack_lst = new List<char[]>();
                List<string> int_str_lst = new List<string>();
                List<string> ack_str_lst = new List<string>();
                char[] int_arr = new char[4];
                char[] ack_arr = new char[4];

                string[] lines = File.ReadAllLines(dlgOpen.FileName);

                // Extract information from hex lines in dump file
                foreach (string line in lines)
                {
                    int_arr = new char[4];
                    ack_arr = new char[4];
                    string binary = String.Join(String.Empty, line.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));

                    type = binary.Substring(4, 2);
                    int_str = binary.Substring(6, 4);
                    ack_str = binary.Substring(10, 4);
                    data = binary.Substring(14, 7);
                    timestamp_str = binary.Substring(21, 43);

                    binary.CopyTo(6, int_arr, 0, 4);
                    binary.CopyTo(10, ack_arr, 0, 4);

                    type_lst.Add(type);
                    int_lst.Add(int_arr);
                    ack_lst.Add(ack_arr);
                    timestamp_lst.Add(Convert.ToInt32(timestamp_str, 2));

                    int_str_lst.Add(int_str);
                    ack_str_lst.Add(ack_str);
                }

                // Process extracted informatoin
                int stamp1, stamp2, time;
                StringBuilder strBld = new StringBuilder();
                strBld.Append("***********************************************\r\n");
                for (int int_index = 0; int_index < 4; int_index++)
                {
                    int print_index = 1;
                    strBld.AppendFormat("\r\nINT{0}: \r\n", 3 - int_index);
                    strBld.Append("Index\tTime\r\n");
                    for (int i = 1; i < type_lst.Count; i++)
                    {
                        int j;
                        if (int_lst[i][int_index] == '1' && (int_lst[i - 1][int_index] == '0' || i == 1))
                        {
                            stamp1 = timestamp_lst[i];
                            stamp2 = 0;
                            for (j = i; j < type_lst.Count; j++)
                                if (ack_lst[j][int_index] == '1')
                                {
                                    stamp2 = timestamp_lst[j];
                                    break;
                                }
                            if (stamp2 > 0)
                            {
                                time = stamp2 - stamp1;
                                strBld.AppendFormat("{0}\t{1}\r\n", print_index++, time);
                            }
                        }
                    }
                }
                txtStatus.AppendText(strBld.ToString());
            }
            catch (Exception ex)
            {
                txtStatus.AppendText("Problem reading. Make sure file is open. \n");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dlgOpen.ShowDialog();
        }

        private void btnAnalyzeBasic_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables and lists to hold the extracted data
                string type, int_str, ack_str, data, timestamp_str;
                List<string> type_lst = new List<string>();
                List<int> timestamp_lst = new List<int>();
                List<char[]> int_lst = new List<char[]>();
                List<char[]> ack_lst = new List<char[]>();
                List<string> int_str_lst = new List<string>();
                List<string> ack_str_lst = new List<string>();
                List<string> data_lst = new List<string>();
                char[] int_arr = new char[4];
                char[] ack_arr = new char[4];

                string[] lines = File.ReadAllLines(dlgOpen.FileName);

                // Extract information from hex lines in dump file
                foreach (string line in lines)
                {
                    int_arr = new char[4];
                    ack_arr = new char[4];
                    string binary = String.Join(String.Empty, line.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));

                    type = binary.Substring(4, 2);
                    int_str = binary.Substring(6, 4);
                    ack_str = binary.Substring(10, 4);
                    data = binary.Substring(14, 7);
                    timestamp_str = binary.Substring(21, 43);

                    binary.CopyTo(6, int_arr, 0, 4);
                    binary.CopyTo(10, ack_arr, 0, 4);

                    type_lst.Add(type);
                    int_lst.Add(int_arr);
                    ack_lst.Add(ack_arr);
                    data_lst.Add(data);
                    timestamp_lst.Add(Convert.ToInt32(timestamp_str, 2));

                    int_str_lst.Add(int_str);
                    ack_str_lst.Add(ack_str);
                }
                // Process extracted informatoin
                StringBuilder strBld = new StringBuilder();
                txtStatus.AppendText("\r\nBasic Analysis: \r\nIndex\tType\tINT lines\tACK lines\tDATA lines\tTimestamp\r\n");
                for (int i = 0; i < type_lst.Count; i++)
                    strBld.AppendFormat("{0}\t{5}\t{1}\t\t{2}\t\t{3}\t\t{4}\r\n", i, int_str_lst[i], ack_str_lst[i], data_lst[i], timestamp_lst[i], type_lst[i]);
                txtStatus.AppendText(strBld.ToString());
            }
            catch (Exception ex)
            {
                txtStatus.AppendText("Problem reading. Make sure file is open. \n");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtStatus.SelectAll();
            txtStatus.Focus();
        }
    }
}
