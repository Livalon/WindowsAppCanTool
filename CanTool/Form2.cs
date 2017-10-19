﻿using System;
using System.Collections;
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

        private Form1.SetVisiableHandler m_setVisible;

        public Form2(Form1.SetVisiableHandler setvisible)
        {
            InitializeComponent();
            this.m_setVisible = setvisible;
        }

        private void ShowMessbutton_Click(object sender, EventArgs e)
        {
            #region
            /*for (int i = 0; i < 10; i++)   //添加10行数据
            {
                ListViewItem lvi = new ListViewItem();

                //lvi.ImageIndex = i;     //通过与imageList绑定，显示imageList中第i项图标

                lvi.Text = "subitem" + i; //第一列

                lvi.SubItems.Add("第2列,第" + i + "行");

                lvi.SubItems.Add("第3列,第" + i + "行");

                CanMesslistView.Items.Add(lvi);
            }*/
            #endregion



            Analysis ay = new Analysis();
            List<string> Cangets = new List<string>();
            Cangets.Add("t8561122334455667788");

            #region
            //Form1 nf = new Form1();
            //nf.RaiseEvent += new Form1.RaiseEventHandler(flushMesslist);
            //CanMessageReceiveTextBox.Text;
            //CanMessget;

            /*foreach (string CanData in ay.canReceiptAnalysis(Canget)) //该部分的显示方式不是刷新，是增加
            {
                string[] Data = CanData.Split(',');
                //Console.WriteLine(Data[0] + "----------" + Data[1]);
                ListViewItem listv = new ListViewItem();
                listv.Text = Data[0]; //第一列
                listv.SubItems.Add(Data[1]);
                CanMesslistView.Items.Add(listv);
            }*/
            #endregion

            flushMesslist(Cangets);
            textBox1.Text = "tttttttt";
        }

        public void flushMesslist(List<string> Cangets)
        {
            //CanMesslistView.Clear();
            CanMesslistView.Items.Clear();
            Analysis ay = new Analysis();
            //string Canget = "t8561122334455667788\r";
            foreach (string Canget in Cangets) //此处疑似有重复
            {
                ListViewItem listv = new ListViewItem();
                listv.Text = Canget;
                CanMesslistView.Items.Add(listv);
            }
            foreach (string Canget in Cangets)
            {
                foreach (string CanData in ay.canReceiptAnalysis(Canget))
                {
                    string[] Data = CanData.Split(',');
                    //Console.WriteLine(Data[0] + "----------" + Data[1]);
                    ListViewItem listv = new ListViewItem();
                    listv.Text = Data[0]; //第一列
                    listv.SubItems.Add(Data[1]); //没有报错提示
                    CanMesslistView.Items.Add(listv);
                }
            }

            textBox1.Text = "***************";
        }

        private void seletCanIDbutton_Click(object sender, EventArgs e)
        {
            Analysis ayselect = new Analysis();
            foreach (string CanID in ayselect.getCanIDFromDatabase())
            {
                CanIDcheckedListBox1.Items.Add(CanID);
            }
        }

        private void CanIDcheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectbuttonshow_Click(object sender, EventArgs e)
        {
            List<string> CanIDselected = new List<string>();
            for (int i = 0; i < CanIDcheckedListBox1.Items.Count; i++)
            {
                if (CanIDcheckedListBox1.GetItemChecked(i))
                {
                    CanIDselected.Add(CanIDcheckedListBox1.Items[i].ToString());
                }
            }
            flushMesslist(CanIDselected);
        }

        public List<string> CanIDselected()
        {
            List<string> CanIDselected = new List<string>();
            string str = "";
            for (int i = 0; i < CanIDcheckedListBox1.Items.Count; i++)
            {
                if (CanIDcheckedListBox1.GetItemChecked(i))
                {
                    str = CanIDcheckedListBox1.Items[i].ToString();
                    string[] strID = str.Split(':');
                    CanIDselected.Add(strID[1]);
                }
            }
            return CanIDselected;
        }

        public List<string> filterCanID(List<string> CanMesses, int len)
        {
            //如果包含该信息，不予显示
            List<string> CanIDsl = CanIDselected();
            List<string> getMess = new List<string>();
            string t = "";
            foreach (string canmess in CanMesses)
            {
                string str = canmess.Substring(1, len);
                string anaresult = (Int32.Parse(str, System.Globalization.NumberStyles.HexNumber)).ToString();
                if (CanIDsl.Contains(anaresult))
                {
                    getMess.Add(canmess);
                    t += canmess;
                }
            }
            textBox1.Text = t;
            return getMess;
        }

        private void selectbuttoninput_Click(object sender, EventArgs e)
        {
            //点击按钮，调出控件
            //读取数据库，用户输入相关值
            //打包解析为can信号
            //发送给comport，结束。该部分放入发送区
            if (this.m_setVisible != null)
            {
                this.m_setVisible();
            }
            //CanMessageReceiveTextBox = "**********";

            //获取用户选择的ID号
            Analysis ay = new Analysis();
            List<string> CanIDselect = new List<string>();
            ArrayList pList = new ArrayList();
            CanIDselect = CanIDselected();
            foreach (string CanID in CanIDselect)
            {
                List<string> CanInfos= ay.getCaninfoFromDatabase(CanID);

                foreach(string Caninfo in CanInfos)
                {
                    ListTree p = new ListTree();
                    p.ID = Caninfo;
                    p.Data = "0";
                    pList.Add(p);
                }
            }

             //通过ID获取元件

            treeList1.DataSource = pList;
            treeList1.RefreshDataSource();
        }

        public string test()
        {
            return textBox1.Text;
        }

        private void CanMessInputbutton_Click(object sender, EventArgs e)
        {
            int i;
            int count = this.treeList1.Nodes.Count;
            String ss = "";
            Analysis ay = new Analysis();

            for (i = 0; i < count; i++)
            {
                ss += treeList1.Nodes[i].GetValue(1)+ " ";
                textBox1.Text = ss;
            }

            List<string> CanIDselect = new List<string>();
            List<string> CanSignals =new List<string>();
            CanIDselect = CanIDselected();
            foreach (string CanID in CanIDselect)
            {
                ss = CanID;
                for(i=0;i<Convert.ToInt32(ay.getLongFromDatabase(CanID));i++)
                {
                    ss+=" "+treeList1.Nodes[i].GetValue(1);
                }
                CanSignals.Add(ss);
            }
            //返回CanSignals;
            textBox1.Text=ay.canSend(CanSignals); //放入发送信息

            if (this.m_setVisible != null)
            {
                this.m_setVisible();
            }
        }
    }

    public class ListTree
    {
        private string m_ID;
        private string m_Data = string.Empty;

        public string ID
        {
            get
            {
                return m_ID;
            }
            set
            {
                m_ID = value;
            }
        }

        public string Data
        {
            get
            {
                return m_Data;
            }
            set
            {
                m_Data = value;
            }
        }


    }
}
