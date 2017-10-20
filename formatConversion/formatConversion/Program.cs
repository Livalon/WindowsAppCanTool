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
         ConversionFormat c = new ConversionFormat();
         c.reconversionToXml("D:\\gitrepy\\CanTool\\WindowsAppCanTool\\formatConversion\\canmsg-sample.xml");
         System.Console.ReadKey();
        // Application.EnableVisualStyles();
        // Application.SetCompatibleTextRenderingDefault(false);
        // Application.Run(new conversionFormat());
        //("canmsg-sample.dbc");
        }
    }
}
