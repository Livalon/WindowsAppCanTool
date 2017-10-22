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
using System.Xml;
using System.Xml.Serialization;

namespace formatConversion
{
    //以下的ToXml、 CanMessageAndSignal定义除了整体的层次结构
    //XmlRoot表明这个类对应的是XML文件中的根节点
    [System.Xml.Serialization.XmlRoot(ElementName = "ToXml")]
    public class ToXml
    {
        //XmlElement表明这个字段对应的是XML文件中当前父节点下面的一个子节点
        //ElementName就是XML里面显示的当前节点名称
        //类中的字段名称与对应的XML节点的名称可以不同(比如在这里类Config中的属性ClientDescription对应XML文件中根节点Config下面的子节点Description)
        [XmlElement(ElementName = "CanMessageAndSignal")]
        public  List<CanMessageAndSignal>  cmarr
        {
            get;
            set;
        }
    }

    public class CanMessageAndSignal
    {
        [XmlElement(ElementName = "CanMessage")]
        public CanMessage canm
        {
            get;
            set;
        }

        [XmlElement(ElementName = "CanSignal")]
        public List<CanSignal> cansarr
        {
            get;
            set;
        }
    }
    public class CanMessage
    {
        //CAN Message 属性
        [XmlElement(ElementName = "CANmessageTAG")]
        public string CANmessageTAG { get; set; } //CANmessage标识符
        [XmlElement(ElementName = "mId")]
        public UInt32 mId { get; set; } //CAN信息的id
        [XmlElement(ElementName = "messageName")]
        public string messageName { get; set; } // messageName
        [XmlElement(ElementName = "mSeparator")]
        public string mSeparator { get; set; } //分隔符
        [XmlElement(ElementName = "DLC")]
        public int DLC { get; set; } // CAN信息的DATA长度
        [XmlElement(ElementName = "mNodeName")]
        public string mNodeName { get; set; } // 发送此信息的node名


    }

    public class CanSignal
    {
        //CAN Signal 属性
        [XmlElement(ElementName = "CANsignalTAG")]
        public string CANsignalTAG { get; set; } //CANsignal 标识符
        [XmlElement(ElementName = "signalName")]
        public string signalName { get; set; }// Signal Name
        [XmlElement(ElementName = "sSeparator")]
        public string sSeparator { get; set; } //分隔符
        [XmlElement(ElementName = "startToEnd")]
        public string startToEnd { get; set; } //起始位|bit长度@bit格式
        [XmlElement(ElementName = "AB")]
        public string AB { get; set; } //(A,B)
        [XmlElement(ElementName = "CD")]
        public string CD { get; set; } //[C|D]
        [XmlElement(ElementName = "unit")]
        public string unit { get; set; } //物理单位
        [XmlElement(ElementName = "sNodeName")]
        public string sNodeName { get; set; } // 发送此信息的node名

    }

    

    class ConversionFormat
    {
        public void conversionToXml (string fileName)
        { //将dbc文件转换为XML文件

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            ToXml tx = new ToXml();
            tx.cmarr = new List<CanMessageAndSignal>();
            CanMessage tm;
            CanMessageAndSignal cms = new CanMessageAndSignal();          
            string s;
            List<CanSignal> cs = new List<CanSignal>();
             //信号为ts，与之相对应
            int[] signalnum = new int [100];// 每条CAN信息中的CAN Signal的数目 不能够超过99，这个数组熊1开始

            while ((s = sr.ReadLine()) != null)
            {
                string[] arr = s.Split(' ');
                int cnt = 0;
                int snum = 0; // 每条CAN信息中的CAN Signal的数目
                if(string.IsNullOrWhiteSpace(s))
                {
                    cs = new List<CanSignal>();
                    continue;
                }
                else if (arr.Length== 5) //CAN message
                {
                    // cs = new List<CanSignal>();
                     cms = new CanMessageAndSignal();
                     tm = new CanMessage();
                     cs = new List<CanSignal>();
                     cms.canm = tm;
                     cms.cansarr = cs;
                    tx.cmarr.Add(cms);
                 
                    tm.CANmessageTAG = arr[0];
                    tm.mId = Convert.ToUInt32(arr[1]);
                    int n;//表示“：”在数组中的位置；
                    n = arr[2].IndexOf(':');
                    tm.messageName = arr[2].Substring(0, n);
                    tm.mSeparator = ":";
                    tm.DLC = Convert.ToInt32(arr[3]);
                    tm.mNodeName = arr[4];

                    signalnum[cnt] = snum; // 这个数组从1开始
                    cnt++;
                    snum = 0;


                }
                else
                {
                    string[] arr1 = s.Trim().Split(' ');
                    CanSignal ts = new CanSignal();
                    ts.CANsignalTAG = arr1[0];
                    //Console.Write(arr1[0]);
                    //Console.Write(arr1[1]);
                    ts.signalName = arr1[1];
                    //Console.Write(arr1[2]);
                    ts.sSeparator = arr1[2];
                    ts.startToEnd = arr1[3];
                    ts.AB = arr1[4];
                    ts.CD = arr1[5];
                    ts.unit = arr1[6];
                    ts.sNodeName = arr1[8];
                    cs.Add(ts);
          
                    snum++;

                }

            }
          
            if (!File.Exists("D:\\gitrepy\\CanTool\\WindowsAppCanTool\\formatConversion\\canmsg-sample.xml"))
            {
                string fn = "D:\\gitrepy\\CanTool\\WindowsAppCanTool\\formatConversion\\canmsg-sample.xml";
                FileStream fs1 = new FileStream("D:\\gitrepy\\CanTool\\WindowsAppCanTool\\formatConversion\\canmsg-sample.xml", FileMode.Create, FileAccess.Write);//创建写入文件 
                //StreamWriter sw1 = new StreamWriter(fs1);
                if (tx != null && !string.IsNullOrEmpty(fn))
                {

                    using (StreamWriter sw1 = new StreamWriter(fs1))
                    {
                        XmlSerializer xs = string.IsNullOrEmpty(null) ?
                            new XmlSerializer(tx.GetType()) :
                            new XmlSerializer(tx.GetType(), new XmlRootAttribute(null));
                        xs.Serialize(sw1, tx);
                        sw1.Close();
                    }
                }
            //sw.WriteLine(this.textBox3.Text.Trim() + "+" + this.textBox4.Text);//开始写入值

            fs1.Close();
               
            }
           
            else
            {
                string fn = "D:\\gitrepy\\CanTool\\WindowsAppCanTool\\formatConversion\\canmsg-sample.xml";
                FileStream fs1 = new FileStream("D:\\gitrepy\\CanTool\\WindowsAppCanTool\\formatConversion\\canmsg-sample.xml", FileMode.Create, FileAccess.Write);//创建写入文件 
                //StreamWriter sw1 = new StreamWriter(fs1);
                if (tx != null && !string.IsNullOrEmpty(fn))
                {

                    using (StreamWriter sw1 = new StreamWriter(fs1))
                    {
                        XmlSerializer xs = string.IsNullOrEmpty(null) ?
                            new XmlSerializer(tx.GetType()) :
                            new XmlSerializer(tx.GetType(), new XmlRootAttribute(null));
                        xs.Serialize(sw1, tx);
                       sw1.Close();
                    }
                }
                //sr.WriteLine(this.textBox3.Text.Trim() + "+" + this.textBox4.Text);//开始写入值
               
               fs1.Close();
            }

        }



        public void reconversionToXml(string xmlFilePath)
        {//将XML文件逆序列化成CAN信息和信号数据库格式
         //FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
         // StreamReader sr = new StreamReader(fs);
         //string s;
         //while ((s = sr.ReadLine()) != null)
         // {

            // }
            ToXml tx = new ToXml();
            object result = null;
            if (File.Exists(xmlFilePath))
            {
                using (StreamReader reader = new StreamReader(xmlFilePath))
                {
                    XmlSerializer xs = new XmlSerializer(tx.GetType());
                    result = xs.Deserialize(reader);
                }
            }

            tx = result as ToXml;

            if (!File.Exists("D:\\gitrepy\\CanTool\\WindowsAppCanTool\\formatConversion\\canmsg-sample1.dbc"))
            {
                string fn = "D:\\gitrepy\\CanTool\\WindowsAppCanTool\\formatConversion\\canmsg-sample1.dbc";
                FileStream fs = new FileStream("D:\\gitrepy\\CanTool\\WindowsAppCanTool\\formatConversion\\canmsg-sample1.dbc", FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs);

                foreach (CanMessageAndSignal cmas in tx.cmarr)
                {
                    CanMessage canm1 = new CanMessage();
                    canm1 = cmas.canm;
                    string s;
                    s = canm1.CANmessageTAG + " " + canm1.mId + " " + canm1.messageName + canm1.mSeparator + " " + canm1.DLC + " " + canm1.mNodeName;
                    sw.WriteLine(s);
                    foreach(CanSignal cs in cmas.cansarr)
                    {
                        string s1;
                        s1 =" " +  cs.CANsignalTAG + " " + cs.signalName + " " + cs.sSeparator + " " + cs.startToEnd + " " + cs.AB + " " + cs.CD + " " + cs.unit + "  " + cs.sNodeName;
                        sw.WriteLine(s1);
                    }
                    sw.WriteLine();

                }
                //sw.WriteLine(this.textBox3.Text.Trim() + "+" + this.textBox4.Text);//开始写入值
                sw.Close();
                fs.Close();

            }

            else
            {
                string fn = "D:\\gitrepy\\CanTool\\WindowsAppCanTool\\formatConversion\\canmsg-sample1.dbc";
                FileStream fs = new FileStream("D:\\gitrepy\\CanTool\\WindowsAppCanTool\\formatConversion\\canmsg-sample1.dbc", FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs);

                foreach (CanMessageAndSignal cmas in tx.cmarr)
                {
                    CanMessage canm1 = new CanMessage();
                    canm1 = cmas.canm;
                    string s;
                    s = canm1.CANmessageTAG + " " + canm1.mId + " " + canm1.messageName + canm1.mSeparator + " " + canm1.DLC + " " + canm1.mNodeName;
                    sw.WriteLine(s);
                    foreach (CanSignal cs in cmas.cansarr)
                    {
                        string s1;
                        s1 =" " + cs.CANsignalTAG + " " + cs.signalName + " " + cs.sSeparator + " " + cs.startToEnd + " " + cs.AB + " " + cs.CD + " " + cs.unit + "  " + cs.sNodeName;
                        sw.WriteLine(s1);
                    }
                    sw.WriteLine();

                }
                //sw.WriteLine(this.textBox3.Text.Trim() + "+" + this.textBox4.Text);//开始写入值
                sw.Close();
                fs.Close();

            }
           
            

           /* FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;
            List<CanMessage> cm = new List<CanMessage>();
            List<CanSignal> cs = new List<CanSignal>();
            int[] signalnum = new int[100];// 每条CAN信息中的CAN Signal的数目 不能够超过99，这个数组熊1开始

            while ((s = sr.ReadLine()) != null)
            {
                string[] arr = s.Split(' ');
                int cnt = 0;
                int snum = 0; // 每条CAN信息中的CAN Signal的数目
                if (string.IsNullOrWhiteSpace(s))
                {
                    continue;
                }
                else if (arr.Length == 5) //CAN message
                {
                    //Console.WriteLine(arr[0]);
                    //string tmp;
                    CanMessage tm = new CanMessage(); //信号为ts，与之相对应
                    tm.CANmessageTAG = arr[0];
                    tm.mId = Convert.ToUInt32(arr[1]);
                    int n;//表示“：”在数组中的位置；
                    n = arr[2].IndexOf(':');
                    tm.messageName = arr[2].Substring(0, n);
                    tm.mSeparator =Convert.ToString( arr[2][n]);
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
                    ts.sSeparator = arr1[2];
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

            }*/
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
