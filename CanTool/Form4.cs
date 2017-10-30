using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanTool
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void converttoJson_Click(object sender, EventArgs e)
        {
            ConversionFormat cf = new ConversionFormat();
            cf.conversionToJson("canmsg-sample.dbc");
        }

        private void conversionToXmlbutton_Click(object sender, EventArgs e)
        {
            ConversionFormat cf = new ConversionFormat();
            cf.conversionToXml("canmsg-sample.dbc");
        }

        private void Xmltodbcbutton_Click(object sender, EventArgs e)
        {
            ConversionFormat cf = new ConversionFormat();
            cf.reconversionToXml("canmsg-sample.dbc");
        }

        private void Jsontodbcbutton_Click(object sender, EventArgs e)
        {
            ConversionFormat cf = new ConversionFormat();
            cf.reconversionToJson("canmsg-sample.dbc");
        }

        private void DBCconvertbutton_Click(object sender, EventArgs e)
        {
            ConversionFormat cf = new ConversionFormat();
            cf.dbcPreprocess("canmsg-sample.dbc");
        }
    }
}
