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
            this.CanMesslistView = new System.Windows.Forms.ListView();
            this.CanIDcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CanMessValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowMessbutton = new System.Windows.Forms.Button();
            this.seletCanIDbutton = new System.Windows.Forms.Button();
            this.CanIDcheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.selectbuttonshow = new System.Windows.Forms.Button();
            this.selectbuttoninput = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CanMesslistView
            // 
            this.CanMesslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CanIDcolumn,
            this.CanMessValue});
            this.CanMesslistView.Location = new System.Drawing.Point(12, 31);
            this.CanMesslistView.Name = "CanMesslistView";
            this.CanMesslistView.Size = new System.Drawing.Size(382, 457);
            this.CanMesslistView.TabIndex = 0;
            this.CanMesslistView.UseCompatibleStateImageBehavior = false;
            this.CanMesslistView.View = System.Windows.Forms.View.Details;
            // 
            // CanIDcolumn
            // 
            this.CanIDcolumn.Text = "Caninfo";
            this.CanIDcolumn.Width = 94;
            // 
            // CanMessValue
            // 
            this.CanMessValue.Text = "Message";
            this.CanMessValue.Width = 106;
            // 
            // ShowMessbutton
            // 
            this.ShowMessbutton.Location = new System.Drawing.Point(12, 2);
            this.ShowMessbutton.Name = "ShowMessbutton";
            this.ShowMessbutton.Size = new System.Drawing.Size(174, 23);
            this.ShowMessbutton.TabIndex = 1;
            this.ShowMessbutton.Text = "显示CanMessage";
            this.ShowMessbutton.UseVisualStyleBackColor = true;
            this.ShowMessbutton.Click += new System.EventHandler(this.ShowMessbutton_Click);
            // 
            // seletCanIDbutton
            // 
            this.seletCanIDbutton.Location = new System.Drawing.Point(455, 31);
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
            this.CanIDcheckedListBox1.Location = new System.Drawing.Point(419, 60);
            this.CanIDcheckedListBox1.Name = "CanIDcheckedListBox1";
            this.CanIDcheckedListBox1.Size = new System.Drawing.Size(209, 364);
            this.CanIDcheckedListBox1.TabIndex = 3;
            this.CanIDcheckedListBox1.SelectedIndexChanged += new System.EventHandler(this.CanIDcheckedListBox1_SelectedIndexChanged);
            // 
            // selectbuttonshow
            // 
            this.selectbuttonshow.Location = new System.Drawing.Point(419, 440);
            this.selectbuttonshow.Name = "selectbuttonshow";
            this.selectbuttonshow.Size = new System.Drawing.Size(100, 23);
            this.selectbuttonshow.TabIndex = 4;
            this.selectbuttonshow.Text = "选择ID显示";
            this.selectbuttonshow.UseVisualStyleBackColor = true;
            this.selectbuttonshow.Click += new System.EventHandler(this.selectbuttonshow_Click);
            // 
            // selectbuttoninput
            // 
            this.selectbuttoninput.Location = new System.Drawing.Point(525, 440);
            this.selectbuttoninput.Name = "selectbuttoninput";
            this.selectbuttoninput.Size = new System.Drawing.Size(103, 23);
            this.selectbuttoninput.TabIndex = 5;
            this.selectbuttoninput.Text = "选择ID输入";
            this.selectbuttoninput.UseVisualStyleBackColor = true;
            this.selectbuttoninput.Click += new System.EventHandler(this.selectbuttoninput_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(712, 393);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 52);
            this.textBox1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 500);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.selectbuttoninput);
            this.Controls.Add(this.selectbuttonshow);
            this.Controls.Add(this.CanIDcheckedListBox1);
            this.Controls.Add(this.seletCanIDbutton);
            this.Controls.Add(this.ShowMessbutton);
            this.Controls.Add(this.CanMesslistView);
            this.Name = "Form2";
            this.Text = "Form2";
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
    }
}