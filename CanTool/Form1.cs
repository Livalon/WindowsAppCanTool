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
using System.Runtime.InteropServices;
using System.IO;
using IniOperate;

namespace CanTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[] coms;
        private int[] databits = { 7, 8 };
        private string parity, stopbits;

        //暂时不让用户选择奇偶校验以及停止位

        private void openButton_Click(object sender, EventArgs e)
        {
            
            openButton.Enabled = false;
            closeButton.Enabled = true;

            try
            {
                OperateIniFile.WriteIniData("PORT", "NAME", ComComobox.Text, ".\\cantool.ini");
                OperateIniFile.WriteIniData("BaudRate", "NAME", BaudRatecomobox.Text, ".\\cantool.ini");

                serialPort1.PortName = ComComobox.Text;                                                                       //选择串口
                serialPort1.BaudRate = Convert.ToInt32(BaudRatecomobox.Text);                                                  //Baud Rate
                serialPort1.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), parity);           //Parity
                serialPort1.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), stopbits);  //StopBits
                serialPort1.DataBits = Convert.ToInt32(DataBitscomobox.Text);                                                  //Data bits                                                        //DataBits
                serialPort1.Open();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(CommDataReceived); //串口监听

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
        }

        #region
        public void CommDataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            CanMessageReceiveTextBox.Text = serialPort1.ReadExisting();
        }
        #endregion

        private void closeButton_Click(object sender, EventArgs e)
        {
            openButton.Enabled = true;
            closeButton.Enabled = false;

            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(CanMessageSendTextBox.Text + Environment.NewLine);
                    CanMessageSendTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream cantool = new FileStream("cantool.ini",
            FileMode.OpenOrCreate, FileAccess.ReadWrite);
            cantool.Close();

            coms = System.IO.Ports.SerialPort.GetPortNames();
            ComComobox.Items.AddRange(coms);
            ComComobox.SelectedIndex = 0;
            ComComobox.Text = OperateIniFile.ReadIniData("PORT", "NAME", "COM1", ".\\cantool.ini"); //从ini文件中读取上一次保存的串口

            BaudRatecomobox.SelectedIndex = 5; //波特率默认值9600
            BaudRatecomobox.Text=OperateIniFile.ReadIniData("BaudRate", "NAME", "9600", ".\\cantool.ini");

            //加入奇偶校验选择
            foreach (string str in Enum.GetNames(typeof(System.IO.Ports.Parity)))
            {
                (Paritycomobox).Items.Add(str);
            }

            Paritycomobox.SelectedIndex = 0;
            parity = Paritycomobox.Text;

            //停止位选择
            foreach (string str in Enum.GetNames(typeof(System.IO.Ports.StopBits)))
            {
                (StopBitscomobox).Items.Add(str);
            }

            StopBitscomobox.SelectedIndex = 1;
            stopbits = StopBitscomobox.Text;

            //数据位选择

            for (int i = 0; i < databits.Length; i++)
            {
                DataBitscomobox.Items.Add(Convert.ToString(databits[i]));
            }

            DataBitscomobox.SelectedText = "8"; //默认填入8


        }


    }
}

namespace IniOperate
{
    public class OperateIniFile
    {
        #region API函数声明

        [DllImport("kernel32")]//返回0表示失败，非0为成功
        private static extern long WritePrivateProfileString(string section, string key,
            string val, string filePath);

        [DllImport("kernel32")]//返回取得字符串缓冲区的长度
        private static extern long GetPrivateProfileString(string section, string key,
            string def, StringBuilder retVal, int size, string filePath);


        #endregion

        #region 读Ini文件

        public static string ReadIniData(string Section, string Key, string NoText, string iniFilePath)
        {
            if (File.Exists(iniFilePath))
            {
                StringBuilder temp = new StringBuilder(1024);
                GetPrivateProfileString(Section, Key, NoText, temp, 1024, iniFilePath);
                return temp.ToString();
            }
            else
            {
                return String.Empty;
            }
        }

        #endregion

        #region 写Ini文件

        public static bool WriteIniData(string Section, string Key, string Value, string iniFilePath)
        {
            if (File.Exists(iniFilePath))
            {
                long OpStation = WritePrivateProfileString(Section, Key, Value, iniFilePath);
                if (OpStation == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion



    }
}