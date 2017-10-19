using System;
using System.Collections;
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

    public partial class ListTree : Form
    {
        public ListTree()
        {
            InitializeComponent();
        }
        //名称字段变量
        private string m_sName = string.Empty;
        private string m_sValue = string.Empty;
        //选择字段变量
        //private bool m_bIsChecked = false;
        //子Node节点ID变量
        private int m_iID = -1;
        //父Node节点ID变量
        private int m_iParentID = -1;

        
        public int ID
        {
            get
            {
                return m_iID;
            }
            set
            {
                m_iID = value;
            }
        }
        public int ParentID
        {
            get
            {
                return m_iParentID;
            }       
            set
            {
                m_iParentID = value;
            }
        }
        public string Name
        {
            get
            {
                return m_sName;
            }
            set
            {
                m_sName = value;
            }
        }
        //public bool IsChecked
        //{
        //    get
        //    {
        //        return m_bIsChecked;
        //    }
        //    set
        //    {
        //        m_bIsChecked = value;
        //    }
        //}
        public string Value
        {
            get
            {
                return m_sValue;
            }
            set
            {
                m_sValue = value;
            }
        }
        private void ListTree_Load(object sender, EventArgs e)
        {            
            ArrayList pList = new ArrayList();
            ListTree p = new ListTree();        
            p.Name = "测试1";
            //p.Value = "asdasd";
            //p.IsChecked = true;
            p.ID = 1;
            pList.Add(p);
            ListTree q = new ListTree();
            q.Name = "测试2";
            //q.IsChecked = false;
            q.ParentID = 1;
            q.ID = 2;
            pList.Add(q);
            ListTree m = new ListTree();
            m.Name = "测试3";
            m.ID = 3;
         // m.ParentID = 1;
            pList.Add(m);
            ListTree l = new ListTree();
            l.Name = "测试4";
            l.ID = 4;
            l.ParentID = 3;
            pList.Add(l);
            //for(int i = 5; i < 50; i++)
            //{
            //    ListTree a= new ListTree();
            //    a.Name = "aaa";
            //    a.ID = i;
            //    pList.Add(a);
            //}
            this.treeList1.DataSource = pList;
            this.treeList1.RefreshDataSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = this.treeList1.Nodes.Count;
            for (int i = 0; i < count; i++)
            {
                String ss = Convert.ToString(this.treeList1.Nodes[i].GetValue(1));
                Console.WriteLine(ss);
            }
          
        }
    }
}

