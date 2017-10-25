using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace test
{
    class Program
    {
        public void Read(string path)
        {
            FileStream fs = new FileStream("E:\\tes.csv", FileMode.Create);
            StreamReader sr = new StreamReader(path, Encoding.Default);
            StreamWriter sw = new StreamWriter(fs);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                Write(line,sw);
            }
            sw.Close();
            fs.Close();
        }
        internal class byData
        {
        }
        public void Write(string line, StreamWriter sw)
        {
            //获得字节数组
            sw.WriteLine(line);


        }
        static void Main(string[] args)
        {

            Program p = new Program();
            p.Read("E:\\tes.txt");

        }
    }
}

