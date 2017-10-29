namespace CanTool
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CanMesslistView = new System.Windows.Forms.ListView();
            this.CanIDcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CanMessValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.seletCanIDbutton = new System.Windows.Forms.Button();
            this.CanIDcheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.selectbuttonshow = new System.Windows.Forms.Button();
            this.selectbuttoninput = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Data = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Range = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CanMessInputbutton = new System.Windows.Forms.Button();
            this.getDatabasebutton = new System.Windows.Forms.Button();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.GetID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.GetName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.DLC = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.GetData = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeshow = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.showcanchartbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectSavebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            this.SuspendLayout();
            // 
            // CanMesslistView
            // 
            this.CanMesslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CanIDcolumn,
            this.CanMessValue});
            this.CanMesslistView.Location = new System.Drawing.Point(255, 32);
            this.CanMesslistView.Name = "CanMesslistView";
            this.CanMesslistView.Size = new System.Drawing.Size(264, 484);
            this.CanMesslistView.TabIndex = 0;
            this.CanMesslistView.UseCompatibleStateImageBehavior = false;
            this.CanMesslistView.View = System.Windows.Forms.View.Details;
            // 
            // CanIDcolumn
            // 
            this.CanIDcolumn.Text = "Caninfo";
            this.CanIDcolumn.Width = 131;
            // 
            // CanMessValue
            // 
            this.CanMessValue.Text = "Message";
            this.CanMessValue.Width = 106;
            // 
            // seletCanIDbutton
            // 
            this.seletCanIDbutton.Location = new System.Drawing.Point(144, 522);
            this.seletCanIDbutton.Name = "seletCanIDbutton";
            this.seletCanIDbutton.Size = new System.Drawing.Size(105, 28);
            this.seletCanIDbutton.TabIndex = 2;
            this.seletCanIDbutton.Text = "选择ID";
            this.seletCanIDbutton.UseVisualStyleBackColor = true;
            this.seletCanIDbutton.Click += new System.EventHandler(this.seletCanIDbutton_Click);
            // 
            // CanIDcheckedListBox1
            // 
            this.CanIDcheckedListBox1.FormattingEnabled = true;
            this.CanIDcheckedListBox1.Location = new System.Drawing.Point(3, 32);
            this.CanIDcheckedListBox1.Name = "CanIDcheckedListBox1";
            this.CanIDcheckedListBox1.Size = new System.Drawing.Size(246, 484);
            this.CanIDcheckedListBox1.TabIndex = 3;
            this.CanIDcheckedListBox1.SelectedIndexChanged += new System.EventHandler(this.CanIDcheckedListBox1_SelectedIndexChanged);
            // 
            // selectbuttonshow
            // 
            this.selectbuttonshow.Location = new System.Drawing.Point(255, 522);
            this.selectbuttonshow.Name = "selectbuttonshow";
            this.selectbuttonshow.Size = new System.Drawing.Size(100, 28);
            this.selectbuttonshow.TabIndex = 4;
            this.selectbuttonshow.Text = "显示选择ID";
            this.selectbuttonshow.UseVisualStyleBackColor = true;
            this.selectbuttonshow.Click += new System.EventHandler(this.selectbuttonshow_Click);
            // 
            // selectbuttoninput
            // 
            this.selectbuttoninput.Location = new System.Drawing.Point(1339, 524);
            this.selectbuttoninput.Name = "selectbuttoninput";
            this.selectbuttoninput.Size = new System.Drawing.Size(112, 28);
            this.selectbuttoninput.TabIndex = 5;
            this.selectbuttoninput.Text = "输入Can信息";
            this.selectbuttoninput.UseVisualStyleBackColor = true;
            this.selectbuttoninput.Click += new System.EventHandler(this.selectbuttoninput_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1125, 516);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 36);
            this.textBox1.TabIndex = 6;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ID,
            this.Data,
            this.Range});
            this.treeList1.Location = new System.Drawing.Point(1119, 32);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowCheckBoxes = true;
            this.treeList1.Size = new System.Drawing.Size(413, 484);
            this.treeList1.TabIndex = 7;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 32;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 222;
            // 
            // Data
            // 
            this.Data.Caption = "Data";
            this.Data.FieldName = "Data";
            this.Data.Name = "Data";
            this.Data.Visible = true;
            this.Data.VisibleIndex = 1;
            this.Data.Width = 49;
            // 
            // Range
            // 
            this.Range.Caption = "Range";
            this.Range.FieldName = "Range";
            this.Range.Name = "Range";
            this.Range.Visible = true;
            this.Range.VisibleIndex = 2;
            this.Range.Width = 124;
            // 
            // CanMessInputbutton
            // 
            this.CanMessInputbutton.Location = new System.Drawing.Point(1457, 524);
            this.CanMessInputbutton.Name = "CanMessInputbutton";
            this.CanMessInputbutton.Size = new System.Drawing.Size(75, 28);
            this.CanMessInputbutton.TabIndex = 8;
            this.CanMessInputbutton.Text = "确定";
            this.CanMessInputbutton.UseVisualStyleBackColor = true;
            this.CanMessInputbutton.Click += new System.EventHandler(this.CanMessInputbutton_Click);
            // 
            // getDatabasebutton
            // 
            this.getDatabasebutton.Location = new System.Drawing.Point(3, 522);
            this.getDatabasebutton.Name = "getDatabasebutton";
            this.getDatabasebutton.Size = new System.Drawing.Size(111, 28);
            this.getDatabasebutton.TabIndex = 9;
            this.getDatabasebutton.Text = "加载数据库";
            this.getDatabasebutton.UseVisualStyleBackColor = true;
            this.getDatabasebutton.Click += new System.EventHandler(this.getDatabasebutton_Click);
            // 
            // treeList2
            // 
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.GetID,
            this.GetName,
            this.DLC,
            this.GetData});
            this.treeList2.Location = new System.Drawing.Point(525, 32);
            this.treeList2.Name = "treeList2";
            this.treeList2.Size = new System.Drawing.Size(588, 484);
            this.treeList2.TabIndex = 10;
            this.treeList2.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList2_FocusedNodeChanged);
            // 
            // GetID
            // 
            this.GetID.Caption = "GetID";
            this.GetID.FieldName = "GetID";
            this.GetID.Name = "GetID";
            this.GetID.Visible = true;
            this.GetID.VisibleIndex = 0;
            this.GetID.Width = 91;
            // 
            // GetName
            // 
            this.GetName.Caption = "GetName";
            this.GetName.FieldName = "GetName";
            this.GetName.Name = "GetName";
            this.GetName.Visible = true;
            this.GetName.VisibleIndex = 1;
            this.GetName.Width = 212;
            // 
            // DLC
            // 
            this.DLC.Caption = "DLC";
            this.DLC.FieldName = "DLC";
            this.DLC.Name = "DLC";
            this.DLC.Visible = true;
            this.DLC.VisibleIndex = 2;
            this.DLC.Width = 77;
            // 
            // GetData
            // 
            this.GetData.Caption = "GetData";
            this.GetData.FieldName = "GetData";
            this.GetData.Name = "GetData";
            this.GetData.Visible = true;
            this.GetData.VisibleIndex = 3;
            this.GetData.Width = 190;
            // 
            // treeshow
            // 
            this.treeshow.Location = new System.Drawing.Point(934, 522);
            this.treeshow.Name = "treeshow";
            this.treeshow.Size = new System.Drawing.Size(98, 28);
            this.treeshow.TabIndex = 11;
            this.treeshow.Text = "树状图显示";
            this.treeshow.UseVisualStyleBackColor = true;
            this.treeshow.Click += new System.EventHandler(this.treeshow_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1038, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "停止";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showcanchartbutton
            // 
            this.showcanchartbutton.Location = new System.Drawing.Point(525, 522);
            this.showcanchartbutton.Name = "showcanchartbutton";
            this.showcanchartbutton.Size = new System.Drawing.Size(115, 28);
            this.showcanchartbutton.TabIndex = 13;
            this.showcanchartbutton.Text = "显示Can图表";
            this.showcanchartbutton.UseVisualStyleBackColor = true;
            this.showcanchartbutton.Click += new System.EventHandler(this.showcanchartbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "选择数据";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "显示数据";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "树状图";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1129, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "输入发送数据";
            // 
            // selectSavebutton
            // 
            this.selectSavebutton.Location = new System.Drawing.Point(656, 522);
            this.selectSavebutton.Name = "selectSavebutton";
            this.selectSavebutton.Size = new System.Drawing.Size(112, 28);
            this.selectSavebutton.TabIndex = 18;
            this.selectSavebutton.Text = "另存数据库";
            this.selectSavebutton.UseVisualStyleBackColor = true;
            this.selectSavebutton.Click += new System.EventHandler(this.selectSavebutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 553);
            this.Controls.Add(this.selectSavebutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showcanchartbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeshow);
            this.Controls.Add(this.treeList2);
            this.Controls.Add(this.getDatabasebutton);
            this.Controls.Add(this.CanMessInputbutton);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.selectbuttoninput);
            this.Controls.Add(this.selectbuttonshow);
            this.Controls.Add(this.CanIDcheckedListBox1);
            this.Controls.Add(this.seletCanIDbutton);
            this.Controls.Add(this.CanMesslistView);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CanMesslistView;
        private System.Windows.Forms.ColumnHeader CanIDcolumn;
        private System.Windows.Forms.ColumnHeader CanMessValue;
        private System.Windows.Forms.Button seletCanIDbutton;
        private System.Windows.Forms.CheckedListBox CanIDcheckedListBox1;
        private System.Windows.Forms.Button selectbuttonshow;
        private System.Windows.Forms.Button selectbuttoninput;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.Windows.Forms.Button CanMessInputbutton;
        private System.Windows.Forms.Button getDatabasebutton;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private System.Windows.Forms.Button treeshow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showcanchartbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Data;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Range;
        private DevExpress.XtraTreeList.Columns.TreeListColumn GetID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn GetName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn DLC;
        private DevExpress.XtraTreeList.Columns.TreeListColumn GetData;
        private System.Windows.Forms.Button selectSavebutton;
    }
}