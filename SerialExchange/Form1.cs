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

namespace SerialExchange
{
    public partial class Form1 : Form
    {
        String dataOut;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            mcBoxCOMPORT.Items.AddRange(ports);
            scBoxCOMPORT.Items.AddRange(ports);
        }

        private void mbtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = mcBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(mcBoxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(mcBoxDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), mcBoxSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), mcBoxSTOPBITS.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mbtnClose_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 100;
            }
        }

        private void mSent_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                dataOut = tBoxDataOut.Text;
                serialPort1.Write(dataOut);
            }
        }

        private void sbtnOpen_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                serialPort2.PortName = scBoxCOMPORT.Text;
                serialPort2.BaudRate = Convert.ToInt32(scBoxBAUDRATE.Text);
                serialPort2.DataBits = Convert.ToInt32( scBoxDATABITS.Text);
                serialPort2.StopBits = (StopBits)Enum.Parse(typeof(StopBits), scBoxSTOPBITS.Text);
                serialPort2.Parity = (Parity)Enum.Parse(typeof(Parity), scBoxSTOPBITS.Text);

                serialPort2.Open();
                progressBar2.Value = 100;
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void sbtnSent_Click(object sender, EventArgs e)
        {
            if(serialPort2.IsOpen)
            {
                dataOut = tBoxDataOut.Text;
                serialPort2.Write(dataOut);

            }
        }
    }
}
