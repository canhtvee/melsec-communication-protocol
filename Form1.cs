using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

/* Please add TCP-MCprotocol-PortNo for the built-in ethernet port of the PLC 
 * I write this programe base-on NET.Framework 4.5, so it can run on the computer which has NET 4.5 
 * There is a problem with this program and I can not fix it yet. Because some thing wrong when I used
 * the socket netstream, this program can only connect to the PLC onetime every startup. If the connection be lost, 
 * you need to restart the programe to reconnect to the PLC.

 * The function of 5 buttons on this form are equal to the buttons on the button box
 * The textbox Target Frequency can be used to change the value on Word D50 directly,
 * tpye the demand value and press Enter key to apply the new target, or press Esc key to return,
 * the next 2 texbox used to change Value of 2 load coefficients stored on D550 and D552 
 */



namespace FCCTest
{
    public partial class Form1 : Form
    {
        short connectionStatus = 0;
        bool targetChange;                                          
        bool coeffChange;
        MCProtocol FCCClient = new MCProtocol();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (connectionStatus == 0)
            {
                connectionStatus = FCCClient.Connect(txtIP.Text, Convert.ToInt16(txtPort.Text));
                if (connectionStatus == 1)
                {
                    txtConnectStatus.Text = "Online";
                    txtConnectStatus.BackColor = Color.FromArgb(0, 255, 0);
                    btnConnect.Text = "Disconnect";
                    int _D50; 
                    FCCClient.ReadDword("000050", out _D50);
                    double _d_D50 = (double)_D50 / (double)100;
                    txtTarget.Text = Convert.ToString(_d_D50);
                    targetChange = false;
                    timer1.Enabled = true;
                }
            }
            else
            {
                connectionStatus = FCCClient.Disconnect();
                if (connectionStatus == 0)
                {
                    txtConnectStatus.Text = "Offline";
                    txtConnectStatus.BackColor = Color.FromArgb(255, 255, 255);
                    btnConnect.Text = "Connect";
                    timer1.Enabled = false;
                }
            }           
        }

        // timer1_Tick routine reads parameters from the PLC and displays them on the form every 500ms

        private void timer1_Tick(object sender, EventArgs e)
        {   
            short _Y20, _Y21, _Y22, _Y23, _Y24;
            FCCClient.ReadYDevice("000020", out _Y20);
            if (_Y20 == 0)
            {
                btnSTART.BackColor = Color.FromArgb(255, 255, 255);
            }
            if (_Y20 == 1)
            {
                btnSTART.BackColor = Color.FromArgb(0, 255, 0);
            }

            FCCClient.ReadYDevice("000021", out _Y21);
            if (_Y21 == 0)
            {
                btnSTOP.BackColor = Color.FromArgb(255, 255, 255);
            }
            if (_Y21 == 1)
            {
                btnSTOP.BackColor = Color.FromArgb(255, 0, 0);
            }

            FCCClient.ReadYDevice("000022", out _Y22);
            if (_Y22 == 1)
            {
                btnFR.BackColor = Color.FromArgb(250, 218, 94);
            }
            if (_Y22 == 0)
            {
                btnFR.BackColor = Color.FromArgb(255, 255, 255);
            }

            FCCClient.ReadYDevice("000023", out _Y23);
            if (_Y23 == 1)
            {
                btnUP.BackColor = Color.FromArgb(250, 218, 94);
            }
            if (_Y23 == 0)
            {
                btnUP.BackColor = Color.FromArgb(255, 255, 255);
            }

            FCCClient.ReadYDevice("000024", out _Y24);
            if (_Y24 == 1)
            {
                btnDOWN.BackColor = Color.FromArgb(250, 218, 94);
            }
            if (_Y24 == 0)
            {
                btnDOWN.BackColor = Color.FromArgb(255, 255, 255);
            }


            int _D0, _D10, _D204, _D214, _D201, _D211,  _D200, _D210, _D203, _D213;
            double _d_D0, _d_D10, _d_D204, _d_D214, _d_D201, _d_D211, _d_D200, _d_D210, _d_D203, _d_D213;
            //Command Frequency reading
            FCCClient.ReadDword("000000", out _D0);
            _d_D0 = (double)_D0 / (double)100;
            txtA1000FreqCmd .Text = Convert.ToString(_d_D0);
            FCCClient.ReadDword("000010", out _D10);
            _d_D10 = (double)_D10 / (double)100;
            txtG7FreqCmd.Text = Convert.ToString(_d_D10);

            //Ouput Frequency reading
            FCCClient.ReadDword("000204", out _D204);
            _d_D204 = (double)_D204 / (double)100;
            txtA1000OutFreq.Text = Convert.ToString(_d_D204);
            FCCClient.ReadDword("000214", out _D214);
            _d_D214 = (double)_D214 / (double)100;
            txtG7OutFreq.Text = Convert.ToString(_d_D214);

            //Ouput Current reading
            FCCClient.ReadDword("000201", out _D201);
            _d_D201 = (double)_D201 / (double)10;
            txtA1000OutCurrent.Text = Convert.ToString(_d_D201);
            FCCClient.ReadDword("000211", out _D211);
            _d_D211 = (double)_D211 / (double)10;
            txtG7OutCurrent.Text = Convert.ToString(_d_D211);

            //Ouput Voltage reading
            FCCClient.ReadDword("000200", out _D200);
            _d_D200 = (double)_D200 / (double)10;
            txtA1000OutVolt.Text = Convert.ToString(_d_D200);
            FCCClient.ReadDword("000210", out _D210);
            _d_D210 = (double)_D210 / (double)10;
            txtG7OutVolt.Text = Convert.ToString(_d_D210);

            //Ouput DC Voltage reading
            FCCClient.ReadDword("000203", out _D203);
            _d_D203 = (double)_D203 / (double)10;
            txtA1000DCVolt.Text = Convert.ToString(_d_D203);
            FCCClient.ReadDword("000213", out _D213);
            _d_D213 = (double)_D213 / (double)10;
            txtG7DCVolt.Text = Convert.ToString(_d_D213);
            txtA1000DCVolt.Text = Convert.ToString(_d_D213);

            //Read Target Frequency and display if there is no change event on this textbox
            //The value of targetChange var depend on some events below
            if (targetChange == false)
            {
                int _D50;
                FCCClient.ReadDword("000050", out _D50);
                double _d_D50 = (double)_D50 / (double)100;
                txtTarget.Text = Convert.ToString(_d_D50);
                targetChange = false;
            }
            //Read Load coefficients and display if there is no change event on this textbox
            //The value of coeffChange var depend on some events below
            if (coeffChange == false)
            {
                int _D550, _D552;
                FCCClient.ReadDword("000550", out _D550);
                txtCoeff1.Text = Convert.ToString(_D550);
                FCCClient.ReadDword("000552", out _D552);
                txtCoeff2.Text = Convert.ToString(_D552);
                coeffChange = false;
            }
        }

        private void txtTarget_TextChanged(object sender, EventArgs e)
        {
            targetChange = true;
        }

        private void txtTarget_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                targetChange = false;
            }
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = false;
                if (txtTarget.Text == "")
                {
                    txtTarget.Text = "0";
                    targetChange = false;
                }
                
                double _d_target = Convert.ToDouble(txtTarget.Text);
                int _int_target = Convert.ToInt16(_d_target*100);
                FCCClient.WriteDword("000050", _int_target);
                targetChange = false;
                timer1.Enabled = true;              
                FCCClient.FirstRead();
            }
        }

        private void txtCoeff1_TextChanged(object sender, EventArgs e)
        {
            coeffChange = true;
        }

        private void txtCoeff2_TextChanged(object sender, EventArgs e)
        {
            coeffChange = true;
        }

        private void txtCoeff1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                coeffChange = false;
            }
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = false;
                if (txtCoeff1.Text == "")
                {
                    txtCoeff1.Text = "0";
                }
                int _coeff1 = Convert.ToInt16(txtCoeff1.Text);
                FCCClient.WriteDword("000550", _coeff1);
                coeffChange = false;
                timer1.Enabled = true;
                FCCClient.FirstRead();
            }
        }

        private void txtCoeff2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                coeffChange = false;
            }
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = false;
                if (txtCoeff2.Text == "")
                {
                    txtCoeff2.Text = "0";
                }
                int _coeff2 = Convert.ToInt16(txtCoeff2.Text);
                FCCClient.WriteDword("000552", _coeff2);
                coeffChange = false;
                timer1.Enabled = true;
                FCCClient.FirstRead();
            }
        }

        private void txtTarget_Move(object sender, EventArgs e)
        {
            targetChange = false;
        }

        private void btnSTART_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            FCCClient.WriteXDevice("000000", 1);
            btnSTART.BackColor = Color.FromArgb(0, 255, 0);
        }

        private void btnSTART_MouseUp(object sender, MouseEventArgs e)
        {

            FCCClient.WriteXDevice("000000", 0);
            btnSTART.BackColor = Color.FromArgb(255, 255, 255);
            timer1.Enabled = true;
            FCCClient.FirstRead();
        }

        private void btnSTOP_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            FCCClient.WriteXDevice("000001", 1);
            btnSTOP.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void btnSTOP_MouseUp(object sender, MouseEventArgs e)
        {
            FCCClient.WriteXDevice("000001", 0);
            btnSTOP.BackColor = Color.FromArgb(255, 255, 255);
            timer1.Enabled = true;
            FCCClient.FirstRead();
        }

        private void btnFR_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            FCCClient.WriteXDevice("000002", 1);
            Thread.Sleep(50);
            FCCClient.WriteXDevice("000002", 0);
            short _Y22;
            FCCClient.ReadYDevice("000022", out _Y22);
            if (_Y22 == 1)
            {
                btnFR.BackColor = Color.FromArgb(250, 218, 94);
            }
            else
            {
                btnFR.BackColor = Color.FromArgb(255, 255, 255);
            }
            timer1.Enabled = true;
            FCCClient.FirstRead();
        }

        private void btnUP_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            targetChange = false;
            FCCClient.WriteXDevice("000003", 1);
            btnUP.BackColor = Color.FromArgb(250, 218, 94);
        }

        private void btnUP_MouseUp(object sender, MouseEventArgs e)
        {
            targetChange = false;
            FCCClient.WriteXDevice("000003", 0);
            btnUP.BackColor = Color.FromArgb(255, 255, 255);
            timer1.Enabled = true;
            FCCClient.FirstRead();
        }

        private void btnDOWN_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            targetChange = false;
            FCCClient.WriteXDevice("000004", 1);
            btnDOWN.BackColor = Color.FromArgb(250, 218, 94);
        }

        private void btnDOWN_MouseUp(object sender, MouseEventArgs e)
        {
            targetChange = false;
            FCCClient.WriteXDevice("000004", 0);
            btnDOWN.BackColor = Color.FromArgb(255, 255, 255);
            timer1.Enabled = true;
            FCCClient.FirstRead();
        }
    }
    class MCProtocol
    {
        TcpClient tcpClient = new TcpClient();
        NetworkStream clientStream;
        ASCIIEncoding encoding = new ASCIIEncoding();
        public short Connect(string ipAdrr, int portNo)
        {
            try
            {           
                tcpClient.Connect(ipAdrr, portNo);
                clientStream = tcpClient.GetStream();
                return (1);
            }
            catch
            {
                return (0);
            }

        }
        public short Disconnect()
        {
            try
            {
                clientStream.Close();
                tcpClient.Close();
                return (0);
            }
            catch
            {
                return (1);
            }
        }

        public void ReadDword(string DeviceNumber, out int Value)
        {
            byte[] rspMess = new byte[30];
            string cmd = "500000FF03FF000018000804010000D*" + DeviceNumber + "0001";
            byte[] rqstMess = Encoding.ASCII.GetBytes(cmd);
            clientStream.Write(rqstMess, 0, rqstMess.Length);
            //After applying a Write action on the netstream the program need to take a short delay
            Thread.Sleep(4);
            clientStream.Read(rspMess, 0, rspMess.Length);
            string data = encoding.GetString(rspMess);
            data = data.Substring(22, 4);
            Value = Convert.ToInt16(data, 16);
        }

        public void ReadXDevice(string DeviceNumber, out short Value)
        {
            byte[] rspMess = new byte[30];
            string cmd = "500000FF03FF000018000804010001X*" + DeviceNumber + "0001";
            byte[] rqstMess = Encoding.ASCII.GetBytes(cmd);
            clientStream.Write(rqstMess, 0, rqstMess.Length);
            Thread.Sleep(4);
            clientStream.Read(rspMess, 0, rspMess.Length);
            string data = encoding.GetString(rspMess);
            data = data.Substring(22, 1);
            Value = Convert.ToByte(data,16);
        }

        public void ReadYDevice(string DeviceNumber, out short Value)
        {
            byte[] rspMess = new byte[30];
            string cmd = "500000FF03FF000018000804010001Y*" + DeviceNumber + "0001";
            byte[] rqstMess = Encoding.ASCII.GetBytes(cmd);
            clientStream.Write(rqstMess, 0, rqstMess.Length);
            Thread.Sleep(4);
            clientStream.Read(rspMess, 0, rspMess.Length);
            string data = encoding.GetString(rspMess);
            data = data.Substring(22, 1);
            Value = Convert.ToByte(data,16);
        }

        public void WriteDword(string DeviceNumber, int Value)
        {
            string cmd = "500000FF03FF00001c000814010000D*" + DeviceNumber + "0001";
            string hexVal = Convert.ToString(Value, 16);
            switch(hexVal.Length)
            {
                case 1:
                    cmd = cmd + "000" + hexVal;
                    break;
                case 2:
                    cmd = cmd + "00" + hexVal;
                    break;
                case 3:
                    cmd = cmd + "0" + hexVal;
                    break;
                default:
                    cmd = cmd + hexVal;
                    break;
            }
            byte[] rqstMess = Encoding.ASCII.GetBytes(cmd);
            clientStream.Write(rqstMess, 0, rqstMess.Length);
            Thread.Sleep(4);
        }

        public void WriteXDevice(string DeviceNumber, short Value)
        {
            string hexVal = Convert.ToString(Value, 16);
            string cmd = "500000FF03FF000019000814010001X*" + DeviceNumber + "0001" + hexVal;
            byte[] rqstMess = Encoding.ASCII.GetBytes(cmd);
            clientStream.Write(rqstMess, 0, rqstMess.Length);
            Thread.Sleep(4);
        }
        
        public void FirstRead()
        {
            //After applying Write action to PLC this method read all data from netstream, this action
            //equal to clear all data on netstream to prepare for the next Read action. 
            byte[] data = new byte[30];
            clientStream.Read(data, 0, data.Length);
        }
    }
}
