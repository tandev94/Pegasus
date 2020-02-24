using PEGASUS.COM;
using PEGASUS.Protocol.lzru920_u921;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static PEGASUS.COM.ComDelegate;

namespace PEGASUS.Test
{
    public partial class Form1 : Form
    {
        IComPort com;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestCom_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (com == null)
            {
                com = new ComPort(1);
             //   com.OnComReaderReceived += new ComReaderReceived(this._port_DataReceived);
                check = com.Init();
            }
            if (check)
            {
                check = com.Connect();
                if (check)
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void _port_DataReceived(string cmd)
        {
            try
            {
                txt01.Invoke(new Action(() =>
                            {
                                txt01.Text = cmd;
                            }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

       

        private void btnTestSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (com != null&&com.IsConnected())
                {
                    //byte[] sysc = new byte[] { 0xFF, 0xFE, 0xFD, 0xFC };
                    //byte[] data = new byte[] { 0x01 };
                    ICommandBase comm = new SetRawDataMode();
                    byte[] datasend = comm.Serialize();
                    com.SendCommand(datasend);
                    //com.OnComReaderReceived += new ComReaderReceived(this._port_DataReceived);
                }
                else
                {
                    MessageBox.Show("Disconnected");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
