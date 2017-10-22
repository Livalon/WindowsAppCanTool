namespace CanTool
{
    partial class Form3
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
            this.setSncomboBox = new System.Windows.Forms.ComboBox();
            this.setOKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setSncomboBox
            // 
            this.setSncomboBox.FormattingEnabled = true;
            this.setSncomboBox.Location = new System.Drawing.Point(12, 12);
            this.setSncomboBox.Name = "setSncomboBox";
            this.setSncomboBox.Size = new System.Drawing.Size(121, 23);
            this.setSncomboBox.TabIndex = 0;
            this.setSncomboBox.SelectedIndexChanged += new System.EventHandler(this.setSncomboBox_SelectedIndexChanged);
            // 
            // setOKbutton
            // 
            this.setOKbutton.Location = new System.Drawing.Point(12, 75);
            this.setOKbutton.Name = "setOKbutton";
            this.setOKbutton.Size = new System.Drawing.Size(75, 23);
            this.setOKbutton.TabIndex = 1;
            this.setOKbutton.Text = "确定";
            this.setOKbutton.UseVisualStyleBackColor = true;
            this.setOKbutton.Click += new System.EventHandler(this.setOKbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.setOKbutton);
            this.Controls.Add(this.setSncomboBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox setSncomboBox;
        private System.Windows.Forms.Button setOKbutton;
    }
}