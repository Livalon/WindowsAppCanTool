using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanTool
{
    class Analysis
    {
        List<string> CanIDselect = new List<string>();

        public void canReceipt(string CantoolMessage) //接收CanTool装置的信息
        {

            string s = Console.ReadLine();

            if (string.Equals(s, "\\r"))
            {
                Console.WriteLine("open ok");
            }
            else if (string.Equals(s, "\\BEL"))
            {
                Console.WriteLine("Failure");
            }


        }

        public List<string> getCanIDFromDatabase()
        {
            List<string> CanIDs = new List<string>();
            FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;


            while ((s = sr.ReadLine()) != null)
            {
                string[] arr = s.Split(' ');
                if (arr.Length == 3)
                {
                    CanIDs.Add(arr[0] + arr[1]);
                }
            }
            return CanIDs;
        }

        public List<string> getCaninfoFromDatabase(string CanID) //通过ID获取具体的信息格式
        {
            int i;
            List<string> CanInfos = new List<string>();
            FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] arr = s.Split(' ');
                    if (s.Length > 5 && string.Equals(arr[1], CanID))
                    {
                        s = sr.ReadLine();
                        int Canline = Convert.ToInt32(s);
                        s = sr.ReadLine(); //跳过空行
                        for (i = 0; i < Canline; i++)
                        {
                            s = sr.ReadLine(); //跳到有效行
                            string[] arr1 = s.Split(' ');
                            CanInfos.Add(arr1[0]);
                        }
                    }
                }
            return CanInfos;
        }

        public List<string> canReceiptAnalysis(string CanSignal)//解析接收的Can信号
        {
            int i, j;
            string anaresult = CanSignal;
            anaresult = CanSignal.Substring(0, 1);
            List<string> CanDatas = new List<string>();


            //现在扩展帧，标准帧分别默认为3位和8位十进制数，后期按相应16进制进行解析
            //暂时不写扩展帧的解析

            if (string.Equals(anaresult, "t")) //标准帧
            {
                anaresult = CanSignal.Substring(1, 3);
                anaresult = (Int32.Parse(anaresult, System.Globalization.NumberStyles.HexNumber)).ToString(); //16转10进制



                FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] arr = s.Split(' ');
                    if (s.Length > 5 && string.Equals(arr[1], anaresult)) //查找ID数
                    {
                        Console.WriteLine(arr[1]);
                        anaresult = CanSignal.Substring(4, 16);
                        string binarycandata = tobinaryCanData(anaresult); //转化为二进制

                        s = sr.ReadLine();
                        Console.WriteLine(s);
                        int Canline = Convert.ToInt32(s); //读入对应ID的Can信息行数
                        s = sr.ReadLine(); //跳过空行

                        int start, len;


                        for (i = 0; i < Canline; i++)
                        {
                            s = sr.ReadLine(); //跳到有效行
                            string[] arr1 = s.Split(' '); //将每一行每一部分的有效信息放入arr1数组
                                                          //arr1[1] arr[2]分别表示起始编号 长度
                            start = Convert.ToInt32(arr1[1]);
                            len = Convert.ToInt32(arr1[2]);

                            int substart = start / 8 * 8 - start % 8 + 7;         //解析can信号，start+8-start%8-1 即在二进制字符中的真实起始位置
                                                                                  //int subend = substart + len-1;
                                                                                  //Console.WriteLine("start:"+substart+"len:"+len); //显示在二进制的起始位和长度
                            string caninfo = binarycandata.Substring(substart, len); //选取指定位置的can信息
                                                                                     //Console.WriteLine("binarycandata:"+caninfo); //显示二进制can信息
                            int x = Convert.ToInt32(caninfo, 2);
                            //Console.WriteLine("x的值"+x); //显示x的数值
                            double Phy = phyCalculate(x, Convert.ToDouble(arr1[4]), Convert.ToDouble(arr1[5])); //计算用户能看懂的物理值
                                                                                                                //Console.WriteLine(arr1[0]+":"+Phy); //顺序显示CanMessage数值！！！

                            CanDatas.Add(arr1[0] + ',' + Phy);


                        }
                        foreach (string CanData in CanDatas)
                        {
                            string[] Data = CanData.Split(',');
                            Console.WriteLine(Data[0] + "----------" + Data[1]);
                        }
                        break;
                        //Console.WriteLine(s);
                    }


                }
            }
            else if (string.Equals(anaresult, "T")) //扩展帧
            {
                anaresult = CanSignal.Substring(1, 8);
            }
            return CanDatas;
        }

        public double phyCalculate(int x, double A, double B) //计算Phy值
        {
            double Phy;
            Phy = A * x + B;
            return Phy;
        }

        public int xCalculate(double phy, double A, double B) //从x转化为Phy
        {
            int x;
            x = (int)((phy - B) / A);
            return x;
        }

        public string tobinaryCanData(string anaresult)//将CanData转化为二进制数（输入字符串，输出二进制形式字符串）
        {
            int i;
            #region //把字符串DATA转化为2进制数，以后考虑用函数封装(anaresult->binarycandata)

            byte[] returnBytes = new byte[anaresult.Length / 2];
            for (i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(anaresult.Substring(i * 2, 2), 16);
            string returnStr = "";
            if (returnBytes != null)
            {
                for (i = 0; i < returnBytes.Length; i++)
                {
                    returnStr += returnBytes[i].ToString("X2");
                }
            }


            string t, binarycandata = "";
            for (i = 0; i < returnBytes.Length; i++)
            {
                t = System.Convert.ToString(returnBytes[i], 2);
                t = t.ToString().PadLeft(8, '0');//高位用0补足
                binarycandata += t;
            }

            Console.WriteLine(returnStr);
            Console.WriteLine(binarycandata);
            #endregion

            /* #region //临时区域

             int  test=Convert.ToInt32("11", 2);
             Console.WriteLine(test);

             #endregion*/

            return binarycandata;
        }

        public string to16CanData(string anaresult) //8个8位二进制数转化为16进制
        {
            string CanData16 = "";
            for(int i=0;i<8;i++)
            {
                string subana=anaresult.Substring(i * 8, 8);
                byte Bytes = Convert.ToByte(subana, 2);
                string t=Bytes.ToString("x2");//16进制数
                CanData16 += t;
            }
            return CanData16;
        }

        public string canSendAnalysis(string CanSignal)//把用户输入的内容转化为Can信息 string格式为ID+数据 最后
        {

            string anaresult = null;
            string candata = CanSignal;

            //将用户输入数值按顺序解析，生成CanData
            //查找位置

            int i, j;
            anaresult = candata;
            string[] candatablock = candata.Split(' ');
            //Console.WriteLine("*****************");
            string binaryCanID_Data = "0000000000000000000";//标准帧的CanID和Data

            //ID放入binaryCanID_Data
            string CanID16 = Convert.ToString(Convert.ToInt32(candatablock[0]), 16);//16进制的CanID
            //Console.WriteLine(CanID16);
            binaryCanID_Data = binaryCanID_Data.Remove(3 - CanID16.Length, CanID16.Length);
            binaryCanID_Data = binaryCanID_Data.Insert(3 - CanID16.Length, CanID16);
            //Console.WriteLine(binaryCanID_Data);
            //现在扩展帧，标准帧分别默认为3位和8位十进制数，后期按相应16进制进行解析
            //暂时不写扩展帧的解析


            FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] arr = s.Split(' ');
                if (s.Length > 5 && string.Equals(arr[1], candatablock[0])) //查找ID数
                {

                    s = sr.ReadLine();
                    //Console.WriteLine(s);
                    int Canline = Convert.ToInt32(s); //读入对应ID的Can信息行数
                    s = sr.ReadLine(); //跳过空行

                    string binarycandata = tobinaryCanData("0000000000000000"); //转化为二进制
                    int start, len;
                    for (i = 0; i < Canline; i++)
                    {
                        s = sr.ReadLine(); //跳到有效行
                        //Console.WriteLine(s);
                        string[] arr1 = s.Split(' '); //将每一行每一部分的有效信息放入arr1数组
                                                      //arr1[1] arr[2]分别表示起始编号 长度
                        double phy = Convert.ToInt32(candatablock[i + 1]);//根据第i行解析
                        //Console.WriteLine(phy);
                        int x = xCalculate(phy, Convert.ToDouble(arr1[4]), Convert.ToDouble(arr1[5]));//获取一行的x
                        //Console.WriteLine(x);
                        string binaryx_value = System.Convert.ToString(x, 2);

                        start = Convert.ToInt32(arr1[1]);
                        len = Convert.ToInt32(arr1[2]);
                        int substart = start / 8 * 8 - start % 8 + 7;
                        int sublen = len - binaryx_value.Length;

                        binarycandata = binarycandata.Remove(substart + sublen, binaryx_value.Length); //
                        binarycandata = binarycandata.Insert(substart + sublen, binaryx_value);
                    }
                    anaresult = to16CanData(binarycandata);
                    binaryCanID_Data = binaryCanID_Data.Remove(3, 16);
                    binaryCanID_Data = binaryCanID_Data.Insert(3, anaresult);
                }

            }

            //Console.WriteLine(binaryCanID_Data);

            //暂定为标准帧
            binaryCanID_Data = "t" + binaryCanID_Data;
            return binaryCanID_Data;
        }

        public string getLongFromDatabase(string CanID)
        {
            string lenth;
            FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] arr = s.Split(' ');
                if (s.Length > 5 && string.Equals(arr[1], CanID))
                {
                    s = sr.ReadLine();
                    break;
                }
            }
            lenth = s;
            return lenth;
        }

        public string canSend(List<string> CanSignals)//向CanTool装置发送信息
        {
            //给出一个can信息格式：candata = "61 2 2 2";
            //解析为Can信息格式发送
            string anaresult = "";

            foreach(string cansignal in CanSignals)
            {
                anaresult += canSendAnalysis(cansignal)+"\r";
            }
            return anaresult;
        }
        public void test()
        {
            Console.WriteLine("*****");
        }
    }
}
