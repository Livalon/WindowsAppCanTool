using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanTool
{
    class Analysis
    {
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


        public string canReceiptAnalysis(string CanSignal)//解析接收的Can信号
        {
            int i, j;
            string anaresult = CanSignal;
            anaresult = CanSignal.Substring(0, 1);


            //现在扩展帧，标准帧分别默认为3位和8位十进制数，后期按相应16进制进行解析
            //暂时不写扩展帧的解析

            if (string.Equals(anaresult, "t")) //标准帧
            {
                anaresult = CanSignal.Substring(1, 3);

                FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string s;
                while ((s = sr.ReadLine()) != "")
                {
                    string[] arr = s.Split(' ');
                    if (s.Length > 5 && string.Equals(arr[1], anaresult)) //查找ID数
                    {
                        Console.WriteLine(arr[1]);
                    }

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
                        Console.WriteLine(arr1[0] + ":" + Phy); //显示该值  
                    }
                    break;
                    Console.WriteLine(s);
                }
            }
            else if (string.Equals(anaresult, "T")) //扩展帧
            {
                anaresult = CanSignal.Substring(1, 3);
            }








            return anaresult;
        }

        public double phyCalculate(int x, double A, double B) //计算Phy值
        {
            double Phy;
            Phy = A * x + B;
            return Phy;
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

        public string canSendAnalysis(string CanSignal)//把用户输入的内容转化为Can信息
        {
            string anaresult = null;
            return anaresult;
        }

        public string canSend(string CanSignal)//向CanTool装置发送信息
        {
            string anaresult = null;
            return anaresult;
        }


        public void test()
        {
            Console.WriteLine("*****");
        }
    }
}
