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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ShowMessbutton_Click(object sender, EventArgs e)
        {
            Analysis ay = new Analysis();
            string Canget = "t8561122334455667788";

            foreach (string CanData in ay.canReceiptAnalysis(Canget))
            {
                string[] Data = CanData.Split(',');
                Console.WriteLine(Data[0] + "----------" + Data[1]);
                ListViewItem listv = new ListViewItem();
                listv.Text = Data[0]; //第一列
                listv.SubItems.Add(Data[1]);
                CanMesslistView.Items.Add(listv);
            }
        }
    }
}
