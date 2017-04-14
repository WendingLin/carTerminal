using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace WifiVideo
{
	
	
    public partial class Form1 : Form
    {
        int count_Name = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //声明读写INI文件的API函数
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);
        static string FileName = Application.StartupPath + "\\Config.ini"; 
        public string ReadIni(string Section, string Ident, string Default)
        {
            Byte[] Buffer = new Byte[65535];
            int bufLen = GetPrivateProfileString(Section, Ident, Default, Buffer, Buffer.GetUpperBound(0), FileName);
            string s = Encoding.GetEncoding(0).GetString(Buffer);
            s = s.Substring(0, bufLen);
            return s.Trim();
        }

         string CameraIp = "";
         string ControlIp = "192.168.8.1";
         string Port = "2001";
         string CMD_Forward = "", CMD_Backward = "", CMD_TurnLeft = "", CMD_TurnRight = "", CMD_TurnLeft1 = "", CMD_TurnRight1 = "", CMD_TurnLeft2 = "", CMD_TurnRight2 = "", CMD_Stop = "", CMD_EngineUp = "", CMD_EngineDown = "", CMD_Engineleft = "", CMD_Engineright = "", CMD_ledon = "", CMD_ledoff = "";


        private void button1_Click(object sender, EventArgs e)
        {
                timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = CameraIp;// "http://192.168.1.1:8080/?action=snapshot";
			if(pictureBox1.Image!=null){
               // pictureBox1.Image.Save("G:\\orchard\\" + change_Number(count_Name) + ".jpg");
                count_Name++;
			}
			
        }
      
        void SendData(string data)
        {
            IPAddress ips = IPAddress.Parse("192.168.8.1");//("192.168.2.1");
            IPEndPoint ipe = new IPEndPoint(ips, Convert.ToInt32(Port.ToString()));//把ip和端口转化为IPEndPoint实例
            Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建一个Socket

            try
            {
                c.Connect(ipe);//连接到服务器

            }
            catch (Exception e)
            {
            }


            try
            { 
                c.Send(Encoding.ASCII.GetBytes("MD_Qian\r"));
                byte[] result = new byte[1024];
                int receiveLength = c.Receive(result);
                string restring = Encoding.ASCII.GetString(result, 0, receiveLength);
            }
            catch
            {
                c.Shutdown(SocketShutdown.Both);
                c.Close();
            }
            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //start
            if (pictureBox1.Image != null)
            {
                Process p = new Process();
                string path = "E:\\tree.bat";
                ProcessStartInfo pi = new ProcessStartInfo(path, "a.jpg 240 90 100 130 b.jpg");
                pi.UseShellExecute = false;
                pi.RedirectStandardOutput = true;
                p.StartInfo = pi;
                p.Start();
                p.WaitForExit();
                string output = p.StandardOutput.ReadToEnd();
                //SendData(CMD_Forward);
                //F1:0~9 找叔
                //T100_20
                //CC
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //SendData(CMD_Backward);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // SendData(CMD_TurnLeft);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SendData(CMD_TurnRight);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            //SendData(CMD_TurnLeft1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //SendData(CMD_TurnRight1);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //SendData(CMD_TurnLeft2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //SendData(CMD_TurnRight2);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Config cfg = new Config();
            cfg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetIni();
            buttonForward.BackColor = Color.LightBlue;
            buttonBackward.BackColor = Color.LightBlue;
            buttonLeft.BackColor = Color.LightBlue;
            buttonRight.BackColor = Color.LightBlue;
            buttonLeft1.BackColor = Color.LightBlue;
            buttonRight1.BackColor = Color.LightBlue;
            buttonLeft2.BackColor = Color.LightBlue;
            buttonRight2.BackColor = Color.LightBlue;
            buttonStop.BackColor = Color.LightBlue;
            btnEngineUp.BackColor = Color.LightBlue;
            btnEngineDown.BackColor = Color.LightBlue;
            btnEngineleft.BackColor = Color.LightBlue;
            btnEngineright.BackColor = Color.LightBlue;
        }
        private void GetIni()
        {
            CameraIp = ReadIni("VideoUrl", "videoUrl", "");
            ControlIp = ReadIni("ControlUrl", "controlUrl", "");
            Port = ReadIni("ControlPort", "controlPort", "");
            CMD_Forward = ReadIni("ControlCommand", "CMD_Forward", "");
            CMD_Backward = ReadIni("ControlCommand", "CMD_Backward", "");
            CMD_TurnLeft = ReadIni("ControlCommand", "CMD_TurnLeft", "");
            CMD_TurnRight = ReadIni("ControlCommand", "CMD_TurnRight", "");
            CMD_TurnLeft1 = ReadIni("ControlCommand", "CMD_TurnLeft1", "");
            CMD_TurnRight1 = ReadIni("ControlCommand", "CMD_TurnRight1", "");
            CMD_TurnLeft2 = ReadIni("ControlCommand", "CMD_TurnLeft2", "");
            CMD_TurnRight2 = ReadIni("ControlCommand", "CMD_TurnRight2", "");
            CMD_Stop = ReadIni("ControlCommand", "CMD_Stop", "");
            CMD_EngineUp = ReadIni("ControlCommand", "CMD_EngineUp", "");
            CMD_EngineDown = ReadIni("ControlCommand", "CMD_EngineDown", "");
            CMD_Engineleft = ReadIni("ControlCommand", "CMD_Engineleft", "");
            CMD_Engineright = ReadIni("ControlCommand", "CMD_Engineright", "");
            CMD_ledon = ReadIni("ControlCommand", "CMD_ledon", "");
            CMD_ledoff = ReadIni("ControlCommand", "CMD_ledoff", "");
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W)
            {
                buttonForward.BackColor = Color.DarkGray;
                buttonForward.PerformClick();
               
            }
            else if (e.KeyCode == Keys.S)
            {
                buttonBackward.BackColor = Color.DarkGray;
                buttonBackward.PerformClick();
               
            }
            else if (e.KeyCode == Keys.A)
            {
                buttonLeft.BackColor = Color.DarkGray;
                buttonLeft.PerformClick();
               
            }
            else if (e.KeyCode == Keys.D)
            {
                buttonRight.BackColor = Color.DarkGray;
                buttonRight.PerformClick();
               
            }
                            
            else if (e.KeyCode == Keys.Q)
            {
                buttonLeft1.BackColor = Color.DarkGray;
                buttonLeft1.PerformClick();
               
            }
            else if (e.KeyCode == Keys.E)
            {
                buttonRight1.BackColor = Color.DarkGray;
                buttonRight1.PerformClick();
               
            }
                
            else if (e.KeyCode == Keys.Z)
            {
                buttonLeft2.BackColor = Color.DarkGray;
                buttonLeft2.PerformClick();
               
            }
            else if (e.KeyCode == Keys.C)
            {
                buttonRight2.BackColor = Color.DarkGray;
                buttonRight2.PerformClick();
               
            }
            else if (e.KeyCode == Keys.X)
            {
                buttonStop.BackColor = Color.DarkGray;
                buttonStop.PerformClick();
               
            }
            else if (e.KeyCode == Keys.I)
            {
                btnEngineUp.BackColor = Color.DarkGray;
                btnEngineUp.PerformClick();

            }
            else if (e.KeyCode == Keys.K)
            {
                btnEngineDown.BackColor = Color.DarkGray;
                btnEngineDown.PerformClick();

            }
            else if (e.KeyCode == Keys.J)
            {
                btnEngineleft.BackColor = Color.DarkGray;
                btnEngineleft.PerformClick();

            }
            else if (e.KeyCode == Keys.L)
            {
                btnEngineright.BackColor = Color.DarkGray;
                btnEngineright.PerformClick();

            }
            else if (e.KeyCode == Keys.N)
            {

                ledon.BackColor = Color.DarkGray;
                ledon.PerformClick();
                
            }
            else if (e.KeyCode == Keys.M)
            {
                ledoff.BackColor = Color.DarkGray;
                ledoff.PerformClick();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            buttonStop.PerformClick();
            buttonForward.BackColor = Color.LightBlue;
            buttonBackward.BackColor = Color.LightBlue;
            buttonLeft.BackColor = Color.LightBlue;
            buttonRight.BackColor = Color.LightBlue;
            buttonLeft1.BackColor = Color.LightBlue;
            buttonRight1.BackColor = Color.LightBlue;
            buttonLeft2.BackColor = Color.LightBlue;
            buttonRight2.BackColor = Color.LightBlue;
            btnEngineUp.BackColor = Color.LightBlue;
            btnEngineDown.BackColor = Color.LightBlue;
            btnEngineleft.BackColor = Color.LightBlue;
            btnEngineright.BackColor = Color.LightBlue;
            ledon.BackColor = Color.LightBlue;
            ledoff.BackColor = Color.LightBlue;
        }

        private void btnEngineUp_Click(object sender, EventArgs e)
        {
            SendData(CMD_EngineUp);
        }

        private void btnEngineDown_Click(object sender, EventArgs e)
        {
            SendData(CMD_EngineDown);
        }
        private void btnEngineleft_Click(object sender, EventArgs e)
        {
            SendData(CMD_Engineleft);
        }

        private void btnEngineright_Click(object sender, EventArgs e)
        {
            SendData(CMD_Engineright);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            SendData(CMD_Stop);
        }
        private void ledon_Click(object sender, EventArgs e)
        {
            SendData(CMD_ledon);
        }
        private void ledoff_Click(object sender, EventArgs e)
        {
            SendData(CMD_ledoff);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
		
		private string change_Number(int num)
		{
			if(num<10)
				return "000"+num.ToString();
			else if (num>9 & num<100)
				return "00"+num.ToString();
			else if (num>999 & num<1000)
				return "0"+num.ToString();
			else
				return num.ToString();
		}
   

       

    }
}
