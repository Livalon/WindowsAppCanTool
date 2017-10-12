namespace CanTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StopBitscomobox = new System.Windows.Forms.ComboBox();
            this.DataBitscomobox = new System.Windows.Forms.ComboBox();
            this.Paritycomobox = new System.Windows.Forms.ComboBox();
            this.BaudRatecomobox = new System.Windows.Forms.ComboBox();
            this.ComComobox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CanMessageReceiveTextBox = new System.Windows.Forms.TextBox();
            this.CanMessageSendTextBox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Canform = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Canform);
            this.groupBox1.Controls.Add(this.closeButton);
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StopBitscomobox);
            this.groupBox1.Controls.Add(this.DataBitscomobox);
            this.groupBox1.Controls.Add(this.Paritycomobox);
            this.groupBox1.Controls.Add(this.BaudRatecomobox);
            this.groupBox1.Controls.Add(this.ComComobox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(142, 281);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(20, 281);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 10;
            this.openButton.Text = "open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stop Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM";
            // 
            // StopBitscomobox
            // 
            this.StopBitscomobox.FormattingEnabled = true;
            this.StopBitscomobox.Location = new System.Drawing.Point(96, 229);
            this.StopBitscomobox.Name = "StopBitscomobox";
            this.StopBitscomobox.Size = new System.Drawing.Size(121, 23);
            this.StopBitscomobox.TabIndex = 4;
            // 
            // DataBitscomobox
            // 
            this.DataBitscomobox.FormattingEnabled = true;
            this.DataBitscomobox.Location = new System.Drawing.Point(96, 176);
            this.DataBitscomobox.Name = "DataBitscomobox";
            this.DataBitscomobox.Size = new System.Drawing.Size(121, 23);
            this.DataBitscomobox.TabIndex = 3;
            // 
            // Paritycomobox
            // 
            this.Paritycomobox.FormattingEnabled = true;
            this.Paritycomobox.Location = new System.Drawing.Point(96, 125);
            this.Paritycomobox.Name = "Paritycomobox";
            this.Paritycomobox.Size = new System.Drawing.Size(121, 23);
            this.Paritycomobox.TabIndex = 2;
            // 
            // BaudRatecomobox
            // 
            this.BaudRatecomobox.FormattingEnabled = true;
            this.BaudRatecomobox.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
            this.BaudRatecomobox.Location = new System.Drawing.Point(96, 73);
            this.BaudRatecomobox.Name = "BaudRatecomobox";
            this.BaudRatecomobox.Size = new System.Drawing.Size(121, 23);
            this.BaudRatecomobox.TabIndex = 1;
            // 
            // ComComobox
            // 
            this.ComComobox.FormattingEnabled = true;
            this.ComComobox.Location = new System.Drawing.Point(96, 24);
            this.ComComobox.Name = "ComComobox";
            this.ComComobox.Size = new System.Drawing.Size(121, 23);
            this.ComComobox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SendButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CanMessageReceiveTextBox);
            this.groupBox2.Controls.Add(this.CanMessageSendTextBox);
            this.groupBox2.Location = new System.Drawing.Point(265, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CanMessage";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(305, 142);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 11;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Receive";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Send";
            // 
            // CanMessageReceiveTextBox
            // 
            this.CanMessageReceiveTextBox.Location = new System.Drawing.Point(16, 200);
            this.CanMessageReceiveTextBox.Multiline = true;
            this.CanMessageReceiveTextBox.Name = "CanMessageReceiveTextBox";
            this.CanMessageReceiveTextBox.Size = new System.Drawing.Size(364, 104);
            this.CanMessageReceiveTextBox.TabIndex = 1;
            // 
            // CanMessageSendTextBox
            // 
            this.CanMessageSendTextBox.Location = new System.Drawing.Point(16, 42);
            this.CanMessageSendTextBox.Multiline = true;
            this.CanMessageSendTextBox.Name = "CanMessageSendTextBox";
            this.CanMessageSendTextBox.Size = new System.Drawing.Size(364, 94);
            this.CanMessageSendTextBox.TabIndex = 0;
            // 
            // Canform
            // 
            this.Canform.Location = new System.Drawing.Point(65, 312);
            this.Canform.Name = "Canform";
            this.Canform.Size = new System.Drawing.Size(110, 23);
            this.Canform.TabIndex = 12;
            this.Canform.Text = "CanMessage";
            this.Canform.UseVisualStyleBackColor = true;
            this.Canform.Click += new System.EventHandler(this.Canform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StopBitscomobox;
        private System.Windows.Forms.ComboBox DataBitscomobox;
        private System.Windows.Forms.ComboBox Paritycomobox;
        private System.Windows.Forms.ComboBox BaudRatecomobox;
        private System.Windows.Forms.ComboBox ComComobox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CanMessageReceiveTextBox;
        private System.Windows.Forms.TextBox CanMessageSendTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Canform;
    }
}

