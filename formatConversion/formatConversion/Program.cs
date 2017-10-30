using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formatConversion
{
     
    class Program
    {
        static void Main(string[] args)
        {
            string path = "canmsg-sample.dbc";
         ConversionFormat c = new ConversionFormat();
         c.dbcPreprocess(path);
            //c.conversionToJson;
            //    c.conversionToXml;
            //c.reconversionToJson;
            //    c.reconversionToXml;



         System.Console.ReadKey();
        // Application.EnableVisualStyles();
        // Application.SetCompatibleTextRenderingDefault(false);
        // Application.Run(new conversionFormat());
        //("canmsg-sample.dbc");
        }
    }
}
