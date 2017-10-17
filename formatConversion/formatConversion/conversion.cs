using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.IO;

namespace formatConversion
{
    public class CanMessage
    {
        //CAN Message 属性
        public string CANmessageTAG; //CANmessage标识符
        public UInt32 mId; //CAN信息的id
        public string messageName; // messageName
        public char mSeparator; //分隔符
        public int DLC;  // CAN信息的DATA长度
        public string mNodeName; // 发送此信息的node名


    }

    public class CanSignal
    {
        //CAN Signal 属性
        public string CANsignalTAG; //CANsignal 标识符
        public string signalName; // Signal Name
        public char sSeparator; //分隔符
        public string startToEnd; //起始位|bit长度@bit格式
        public string AB; //(A,B)
        public string CD; //[C|D]
        public string unit; //物理单位
        public string sNodeName; // 发送此信息的node名

    }

    

    class ConversionFormat
    {
        public void conversionToXml (string fileName)
        { //将dbc文件转换为XML文件

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;
            List<CanMessage> cm = new List<CanMessage>();
            List<CanSignal> cs = new List<CanSignal>();
            int[] signalnum = new int [100];// 每条CAN信息中的CAN Signal的数目 不能够超过99，这个数组熊1开始

            while ((s = sr.ReadLine()) != null)
            {
                string[] arr = s.Split(' ');
                int cnt = 0;
                int snum = 0; // 每条CAN信息中的CAN Signal的数目
                if(string.IsNullOrWhiteSpace(s))
                {
                    continue;
                }
                else if (arr.Length== 5) //CAN message
                {
                    //Console.WriteLine(arr[0]);
                    //string tmp;
                    CanMessage tm = new CanMessage(); //信号为ts，与之相对应
                    tm.CANmessageTAG = arr[0];
                    tm.mId = Convert.ToUInt32(arr[1]);
                    int n;//表示“：”在数组中的位置；
                    n = arr[2].IndexOf(':');
                    tm.messageName = arr[2].Substring(0, n);
                    tm.mSeparator = arr[2][n];
                    tm.DLC = Convert.ToInt32(arr[3]);
                    tm.mNodeName = arr[4];
                    cm.Add(tm);

                    signalnum[cnt] = snum; // 这个数组从1开始
                    cnt++;
                    snum = 0;


                }
                else
                {
                    string[] arr1 = s.Split(' ');
                    CanSignal ts = new CanSignal();
                    ts.CANsignalTAG = arr1[0];
                    //Console.Write(arr1[0]);
                    //Console.Write(arr1[1]);
                    ts.signalName = arr1[1];
                    //Console.Write(arr1[2]);
                    ts.sSeparator = arr1[2][0];
                    ts.startToEnd = arr1[3];
                    ts.AB = arr1[4];
                    ts.CD = arr1[5];
                    ts.unit = arr1[6];
                    ts.sNodeName = arr1[7];
                    cs.Add(ts);
          
                    snum++;

                }
               
            }
           foreach (CanMessage t in cm)
            {
                Console.Write(t.CANmessageTAG);
                Console.Write(t.mId);
                Console.Write(t.messageName);
                Console.Write(t.mSeparator);
                Console.Write(t.DLC);
                Console.Write(t.mNodeName); 

            }
        }

        public void reconversionToXml(string fileName)
        {//将XML文件逆序列化成CAN信息和信号数据库格式
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;
            while ((s = sr.ReadLine()) != null)
            {

            }
        }



        public void conversionToJson(string fileName)
        {//将dbc文件转换为JSON文件
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;
            while ((s = sr.ReadLine()) != null)
            {

            }
        }

        public void reconversionToJson(string fileName)
        {//将XML文件逆序列化成CAN信息和信号数据库格式
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;
            while ((s = sr.ReadLine()) != null)
            {

            }
        }
    }
}
