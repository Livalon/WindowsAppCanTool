using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Dash : Form
    {
        int index = 0;
        DataClasses1DataContext db = new DataClasses1DataContext();
        List<double?> values = new List<double?>();
        
        public Dash()
        {
            InitializeComponent();
            var query = from t in db.DashBoard1
                        select t;
            foreach (DashBoard1 item in query)
            {
                values.Add(item.data);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(index < values.Count) {
                this.arcScaleComponent1.Value = (float)values[index];
                index++;
            }  
        }
    }
}
