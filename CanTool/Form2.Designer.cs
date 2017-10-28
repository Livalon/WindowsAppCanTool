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
            this.ShowMessbutton = new System.Windows.Forms.Button();
            this.seletCanIDbutton = new System.Windows.Forms.Button();
            this.CanIDcheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.selectbuttonshow = new System.Windows.Forms.Button();
            this.selectbuttoninput = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.CanMessInputbutton = new System.Windows.Forms.Button();
            this.getDatabasebutton = new System.Windows.Forms.Button();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.treeshow = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            this.SuspendLayout();
            // 
            // CanMesslistView
            // 
            this.CanMesslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CanIDcolumn,
            this.CanMessValue});
            this.CanMesslistView.Location = new System.Drawing.Point(12, 12);
            this.CanMesslistView.Name = "CanMesslistView";
            this.CanMesslistView.Size = new System.Drawing.Size(382, 479);
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
            // ShowMessbutton
            // 
            this.ShowMessbutton.Location = new System.Drawing.Point(424, 2);
            this.ShowMessbutton.Name = "ShowMessbutton";
            this.ShowMessbutton.Size = new System.Drawing.Size(174, 23);
            this.ShowMessbutton.TabIndex = 1;
            this.ShowMessbutton.Text = "显示CanMessage";
            this.ShowMessbutton.UseVisualStyleBackColor = true;
            this.ShowMessbutton.Click += new System.EventHandler(this.ShowMessbutton_Click);
            // 
            // seletCanIDbutton
            // 
            this.seletCanIDbutton.Location = new System.Drawing.Point(530, 31);
            this.seletCanIDbutton.Name = "seletCanIDbutton";
            this.seletCanIDbutton.Size = new System.Drawing.Size(105, 23);
            this.seletCanIDbutton.TabIndex = 2;
            this.seletCanIDbutton.Text = "选择ID";
            this.seletCanIDbutton.UseVisualStyleBackColor = true;
            this.seletCanIDbutton.Click += new System.EventHandler(this.seletCanIDbutton_Click);
            // 
            // CanIDcheckedListBox1
            // 
            this.CanIDcheckedListBox1.FormattingEnabled = true;
            this.CanIDcheckedListBox1.Location = new System.Drawing.Point(400, 60);
            this.CanIDcheckedListBox1.Name = "CanIDcheckedListBox1";
            this.CanIDcheckedListBox1.Size = new System.Drawing.Size(246, 404);
            this.CanIDcheckedListBox1.TabIndex = 3;
            this.CanIDcheckedListBox1.SelectedIndexChanged += new System.EventHandler(this.CanIDcheckedListBox1_SelectedIndexChanged);
            // 
            // selectbuttonshow
            // 
            this.selectbuttonshow.Location = new System.Drawing.Point(400, 468);
            this.selectbuttonshow.Name = "selectbuttonshow";
            this.selectbuttonshow.Size = new System.Drawing.Size(100, 23);
            this.selectbuttonshow.TabIndex = 4;
            this.selectbuttonshow.Text = "选择ID显示";
            this.selectbuttonshow.UseVisualStyleBackColor = true;
            this.selectbuttonshow.Click += new System.EventHandler(this.selectbuttonshow_Click);
            // 
            // selectbuttoninput
            // 
            this.selectbuttoninput.Location = new System.Drawing.Point(543, 468);
            this.selectbuttoninput.Name = "selectbuttoninput";
            this.selectbuttoninput.Size = new System.Drawing.Size(103, 23);
            this.selectbuttoninput.TabIndex = 5;
            this.selectbuttoninput.Text = "选择ID输入";
            this.selectbuttoninput.UseVisualStyleBackColor = true;
            this.selectbuttoninput.Click += new System.EventHandler(this.selectbuttoninput_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(661, 439);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 52);
            this.textBox1.TabIndex = 6;
            // 
            // treeList1
            // 
            this.treeList1.Location = new System.Drawing.Point(652, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowCheckBoxes = true;
            this.treeList1.Size = new System.Drawing.Size(413, 412);
            this.treeList1.TabIndex = 7;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            // 
            // CanMessInputbutton
            // 
            this.CanMessInputbutton.Location = new System.Drawing.Point(1019, 441);
            this.CanMessInputbutton.Name = "CanMessInputbutton";
            this.CanMessInputbutton.Size = new System.Drawing.Size(75, 23);
            this.CanMessInputbutton.TabIndex = 8;
            this.CanMessInputbutton.Text = "确定";
            this.CanMessInputbutton.UseVisualStyleBackColor = true;
            this.CanMessInputbutton.Click += new System.EventHandler(this.CanMessInputbutton_Click);
            // 
            // getDatabasebutton
            // 
            this.getDatabasebutton.Location = new System.Drawing.Point(411, 31);
            this.getDatabasebutton.Name = "getDatabasebutton";
            this.getDatabasebutton.Size = new System.Drawing.Size(96, 23);
            this.getDatabasebutton.TabIndex = 9;
            this.getDatabasebutton.Text = "加载数据库";
            this.getDatabasebutton.UseVisualStyleBackColor = true;
            this.getDatabasebutton.Click += new System.EventHandler(this.getDatabasebutton_Click);
            // 
            // treeList2
            // 
            this.treeList2.Location = new System.Drawing.Point(1071, 13);
            this.treeList2.Name = "treeList2";
            this.treeList2.Size = new System.Drawing.Size(453, 411);
            this.treeList2.TabIndex = 10;
            this.treeList2.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList2_FocusedNodeChanged);
            // 
            // treeshow
            // 
            this.treeshow.Location = new System.Drawing.Point(1433, 455);
            this.treeshow.Name = "treeshow";
            this.treeshow.Size = new System.Drawing.Size(91, 23);
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
            this.button1.Location = new System.Drawing.Point(1333, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "停止";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 562);
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
            this.Controls.Add(this.ShowMessbutton);
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
        private System.Windows.Forms.Button ShowMessbutton;
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
    }
}