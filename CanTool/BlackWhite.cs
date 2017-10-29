using CanTool;
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
    public partial class BlackWhite : Form
    {
        List<Rect> rs = new List<Rect>();
        public BlackWhite()
        {
            InitializeComponent();
        }
        public void draw()
        {
            int rowNum = 7;
            int colNum = 0;
            int basic = 7;
            int basic1 = 15;
            int basic2 = 23;
            int basic3 = 31;
            int basic4 = 39;
            int basic5 = 47;
            int basic6 = 55;
            int basic7 = 63;
            int id = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Rect rect = new Rect();
                    rect.i = i;
                    rect.j = j;
                    Panel p = new Panel();
                    if (i != 0 && j != 0)
                    {
                        p.Name = id+"";
                        id++;
                    }
                    p.SetBounds(j * 100, i * 50, 100, 50);
                    rect.panel = p;
                    p.BorderStyle = BorderStyle.FixedSingle;
                    Label l = new Label();
                    if (i == 0 && j == 0)
                    {
                        p.BackColor = Color.Gray;
                    }
                    if (i == 0 && j != 0)
                    {
                        l.Text = rowNum+"";
                        rowNum--;
                        p.BackColor = Color.Gray;
                    }
                     else if (i != 0 && j == 0)
                    {
                        l.Text = colNum+"";
                        colNum++;
                        p.BackColor = Color.Gray;
                    }
                    else if (j != 0 && i == 1)
                    {
                        l.Text = basic + "";
                        basic--;
                    }
                    else if (j != 0 && i == 2)
                    {
                        l.Text = basic1 + "";
                        basic1--;
                    }
                    else if (j != 0 && i == 3)
                    {
                        l.Text = basic2 + "";
                        basic2--;
                    }
                    else if (j != 0 && i == 4)
                    {
                        l.Text = basic3 + "";
                        basic3--;
                    }
                    else if (j != 0 && i == 5)
                    {
                        l.Text = basic4 + "";
                        basic4--;
                    }
                    else if (j != 0 && i == 6)
                    {
                        l.Text = basic5 + "";
                        basic5--;
                    }
                    else if (j != 0 && i == 7)
                    {
                        l.Text = basic6 + "";
                        basic6--;
                    }
                    else if (j != 0 && i == 8)
                    {
                        l.Text = basic7 + "";
                        basic7--;
                    }
                    p.Controls.Add(l);
                    this.panel1.Controls.Add(rect.panel);
                    rs.Add(rect);
                }
            }    
        }
        //int id = i * 8 - j;
        public void changeBackColor1(int i, int j, int len,Color c)
        {
            int id = 8 * i + j - 9;
            string s = id + "";
            while (len != 0)
            {
                Panel p = (Panel)panel1.Controls.Find(s, false)[0];
                len--;
                id++;
                s = id + "";
                p.BackColor = c;
            }
        }
        public void changeBackColor2(string s, Color c)
        {
            string sub = "";
            for(int i = 0; i < s.Length; i++)
            {
                sub = s.Substring(i, 1);
                string id = i + "";
                if (sub.Equals("1"))
                {
                    Panel p = (Panel)panel1.Controls.Find(id, false)[0];
                    p.BackColor = c;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            draw();
        }
    }
}
