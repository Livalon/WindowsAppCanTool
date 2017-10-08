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
            string anaresult = CanSignal;
            return anaresult;
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
            Console.WriteLine("********");
        }
    }
}
