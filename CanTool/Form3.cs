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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string Sn;

        private string[] Sns = { "S0", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", };

        private void setSncomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Sns.Length; i++)
            {
                setSncomboBox.Items.Add(Convert.ToString(Sns[i]));
            }
        }

        private void setOKbutton_Click(object sender, EventArgs e)
        {
            Sn=setSncomboBox.Text;
        }
    }
}
