using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace stm32v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            string[] ports = SerialPort.GetPortNames();
            cbport.Items.AddRange(ports);
            tbrx.ForeColor = Color.BlueViolet;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // OPEN
        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Visible=true;
            try
            {
                serialPort1.PortName = cbport.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbbaud.Text);

                serialPort1.Open();
                btn1.Enabled = false;
                btn2.Enabled = true;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn1.Enabled = false;
                btn2.Enabled = false;
            }
        }

        // CLOSE
        private void btn2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                serialPort1.Close();
                btn1.Enabled = true;
                btn2.Enabled = false;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string strrx = serialPort1.ReadExisting();

            tbrx.Text += strrx;
            if(tbrx.Text.Length > 100)
            {
                tbrx.Text = "";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbrx.Text = "";
        }

        private void btntx_Click(object sender, EventArgs e)
        {
            string txstr;

            if (serialPort1.IsOpen)
            {
                txstr = tbtx.Text + '\n';
                serialPort1.Write(txstr);
            }
        }
    }
}
