using DevExpress.Data.Browsing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace test
{
    public partial class Led : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        List<String> values = new List<string>();
        int index = 0;
        public Led()
        {
            InitializeComponent();
            var query = from t in db.LED1
                        select t;
            foreach (LED1 item in query)
            {
                values.Add(item.data);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < values.Count)
            { 
                this.digitalGauge1.Text = values[index];
                index++;
            }
            //DataClasses1DataContext db = new DataClasses1DataContext();
            //int i = 1;
            //while (i<3)
            //{

            //    var query = from t in db.LED1
            //                //where t.id == i
            //                select t;
            //    foreach (LED1 item in query)
            //    {
            //        this.digitalGauge1.Text = item.data;
            //    }
            //    i++;
            //}

        }

    }
}
