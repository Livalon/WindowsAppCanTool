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
            this.SuspendLayout();
            // 
            // CanMesslistView
            // 
            this.CanMesslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CanIDcolumn,
            this.CanMessValue});
            this.CanMesslistView.Location = new System.Drawing.Point(12, 31);
            this.CanMesslistView.Name = "CanMesslistView";
            this.CanMesslistView.Size = new System.Drawing.Size(382, 336);
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
            this.ShowMessbutton.Location = new System.Drawing.Point(468, 31);
            this.ShowMessbutton.Name = "ShowMessbutton";
            this.ShowMessbutton.Size = new System.Drawing.Size(174, 23);
            this.ShowMessbutton.TabIndex = 1;
            this.ShowMessbutton.Text = "显示CanMessage";
            this.ShowMessbutton.UseVisualStyleBackColor = true;
            this.ShowMessbutton.Click += new System.EventHandler(this.ShowMessbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 391);
            this.Controls.Add(this.ShowMessbutton);
            this.Controls.Add(this.CanMesslistView);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CanMesslistView;
        private System.Windows.Forms.ColumnHeader CanIDcolumn;
        private System.Windows.Forms.ColumnHeader CanMessValue;
        private System.Windows.Forms.Button ShowMessbutton;
    }
}