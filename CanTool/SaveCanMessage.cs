using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanTool
{
    class SaveCanMessage
    {
        public void Read(string path)
        {
            FileStream fs = new FileStream("tes.csv", FileMode.Create);
            StreamReader sr = new StreamReader(path, Encoding.Default);
            StreamWriter sw = new StreamWriter(fs);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                Write(line, sw);
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
    }
}
