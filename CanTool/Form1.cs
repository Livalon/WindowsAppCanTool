﻿using System;
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
        public string CanMessget;
        string buffread = ""; //缓冲区字符
        Form2 f2;
        Form3 f3;

        public int version = 0;
        public int open = 0;
        public int Sn = 0;
        public int Close = 1;

        int flushtype = 0;

        public bool opened = false;

        string origindatabase = "data.txt";
        string useddatabase = "usedata.txt";

        public delegate void SetVisiableHandler();

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
                serialPort1.ReceivedBytesThreshold = 1;//用来控制缓冲区的大小，接收足够的字符串后再接收处理，注意每次发送加的换行符占1字节而且算一次发送
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
        }

        #region
        public void CommDataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            int n = serialPort1.BytesToRead;
            byte[] buf = new byte[n];
            serialPort1.Read(buf, 0, n);//该部分取出后串口缓冲区的数据就没了
            buffread += System.Text.Encoding.Default.GetString(buf);

            //CanMessageReceiveTextBox.Text ="******";
            /*byte[] byteArray = System.Text.Encoding.Default.GetBytes(buffread);
            int a = byteArray[0];
            CanMessageReceiveTextBox.Text = a.ToString();*/
            //暂时不考虑/r后面有数据的情况

            if (version==2 || open==2 || Sn==2 || Close==2) //如果不是数据传输状态
            {
                Analysis ay = new Analysis();
                string show = ay.canReceipt(buffread, version, open, Sn, Close);
                version = ay.m_version;
                open = ay.m_open;
                Sn = ay.m_Sn;
                Close = ay.m_Close;
                MessageBox.Show(show);

                buffread = "";
            }
            else
            {
                string[] strlist = buffread.Split("\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries); //遇到/r就取出来
                string outp = "";
                SaveCanMessage savemes = new SaveCanMessage();
                List<string> Caninfos = new List<string>();
                if (buffread.Length != strlist[0].Length) //ifbuffread的长度不等于strlist第0项目的长度，说明有\r
                {
                    if (string.Equals(strlist[0].Substring(0, 1), "t") || string.Equals(strlist[0].Substring(0, 1), "T"))
                    {

                        if (strlist.Length > 1)
                        {
                            for (int i = 0; i < strlist.Length - 1; i++)
                            {
                                //输出所有ID信息
                                outp += strlist[i];
                                Caninfos.Add(strlist[i]);
                            }

                            //把strlist数组最后一个值赋给bufferead
                            if (string.Equals(buffread.Substring(buffread.Length - 1, 1), "\r"))
                            {
                                outp += strlist[strlist.Length - 1];
                                Caninfos.Add(strlist[strlist.Length - 1]);
                                //保存发送的数据
                                //savemes.Write(strlist[strlist.Length - 1]);
                            }
                            Control.CheckForIllegalCrossThreadCalls = false;
                            CanMessageReceiveTextBox.Text = outp;
                            buffread = strlist[strlist.Length - 1];
                        }
                        else
                        {
                            outp = strlist[0];
                            Caninfos.Add(strlist[0]);
                            Control.CheckForIllegalCrossThreadCalls = false;
                            CanMessageReceiveTextBox.Text = outp;
                        }
                        buffread = "";
                        //f2.filterCanID(Caninfos, 3);
                        //f2.flushMesslist(f2.filterCanID(Caninfos, 3), flushtype);
                        if (opened)
                        {

                            if (flushtype == 0)
                            {
                                //f3.changeLED("10,000");
                                f2.flushMesslist(f2.filterCanID(Caninfos, 3), flushtype);
                            }
                            else if (flushtype == 1)
                            {
                                f2.flushf3test(f2.filterCanID(Caninfos, 3), flushtype, f3);
                            }
                        }

                        //设置后，刷新的时候返回具体的值
                        //f2.flushMesslist(f2.filterCanID(Caninfos, 3),1);
                    }
                    /*else
                    {
                        Analysis ay = new Analysis();
                        string get=ay.canReceipt(strlist[0]);
                        CanMessageReceiveTextBox.Text = get;
                    }*/
                    buffread = "";
                }
            }


        }
        #endregion

        /*public void selectflushtype(int type, List<string> Caninfos)
        {
            if(type==0)
            {
                f2.flushMesslist(f2.filterCanID(Caninfos, 3),0);
            }
            else
            {
                f2.flushMesslist(f2.filterCanID(Caninfos, 3),1);
            }
        }*/

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
                    //serialPort1.WriteLine(CanMessageSendTextBox.Text);
                    //serialPort1.Write("t35881122334455667788\rt32081122334455667788\rt36081122334455667788\rt32181122334455667788\r");
                    //serialPort1.Write("t0648A802B70000000000\r");
                    serialPort1.Write("t0648E812270000000000\r");
                   
                    /*byte[] bsTest = new byte[1];
                    bsTest[0] = 0x07;
                    string t = System.Text.Encoding.Default.GetString(bsTest);

                    serialPort1.Write(t);*/
                    CanMessageSendTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetVisiable()
        {
            //CanMessageReceiveTextBox.Text = "**********";
            CanMessageReceiveTextBox.Text = f2.test();
        }

        private void SetVisiable1()
        {
            flushtype = 1;
        }

        private void SetVisiable0()
        {
            flushtype = 0;
        }

        private void Canform_Click(object sender, EventArgs e)
        {
            f2 = new Form2(new SetVisiableHandler(SetVisiable));
            f2.Show();
            //this.Hide(); //后期看是否需要隐藏之前的窗口
            opened = true;
        }

        private void getversionbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    version = 2;
                    serialPort1.Write("V\r");
                    CanMessageSendTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openCanToolbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    open = 2;
                    serialPort1.Write("O1\r");
                    CanMessageSendTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setSnbutton_Click(object sender, EventArgs e)
        {
            /*Form3 f3= new Form3();
            f3.Show();
            String Snstr = f3.Sn;*/
            
            string Snstr = setSncomboBox.Text;
            try
            {
                if (serialPort1.IsOpen)
                {
                    Sn = 2;
                    serialPort1.Write(Snstr+"\r");
                    CanMessageSendTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeCanToolbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    Close = 2;
                    serialPort1.Write("C\r");
                    CanMessageSendTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setSncomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showconwindbutton_Click(object sender, EventArgs e)
        {
            f3 = new Form3(new SetVisiableHandler(SetVisiable1), new SetVisiableHandler(SetVisiable0));
            f3.Show();
        }

        private void Paritycomobox_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            //设置Cantool速率
            string[] Sns = { "S0", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", };
            for (int i = 0; i < Sns.Length; i++)
            {
                setSncomboBox.Items.Add(Convert.ToString(Sns[i]));
            }

            //增加文件读取功能
            FileStream fsSource = new FileStream(origindatabase, FileMode.Open);
            FileStream fsTarget = new FileStream(useddatabase, FileMode.OpenOrCreate);
            fsTarget.Seek(0, SeekOrigin.Begin);
            fsTarget.SetLength(0);
            byte[] sourceArr = new byte[fsSource.Length];
            fsSource.Read(sourceArr, 0, sourceArr.Length);
            fsTarget.Position = fsTarget.Length;
            fsTarget.Write(sourceArr, 0, sourceArr.Length);
            fsSource.Close();
            fsTarget.Close();

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