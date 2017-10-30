namespace CanTool
{
    partial class Form4
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
            this.conversionToXmlbutton = new System.Windows.Forms.Button();
            this.Xmltodbcbutton = new System.Windows.Forms.Button();
            this.converttoJson = new System.Windows.Forms.Button();
            this.Jsontodbcbutton = new System.Windows.Forms.Button();
            this.DBCconvertbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conversionToXmlbutton
            // 
            this.conversionToXmlbutton.Location = new System.Drawing.Point(43, 64);
            this.conversionToXmlbutton.Name = "conversionToXmlbutton";
            this.conversionToXmlbutton.Size = new System.Drawing.Size(124, 31);
            this.conversionToXmlbutton.TabIndex = 0;
            this.conversionToXmlbutton.Text = "转为Xml";
            this.conversionToXmlbutton.UseVisualStyleBackColor = true;
            this.conversionToXmlbutton.Click += new System.EventHandler(this.conversionToXmlbutton_Click);
            // 
            // Xmltodbcbutton
            // 
            this.Xmltodbcbutton.Location = new System.Drawing.Point(43, 125);
            this.Xmltodbcbutton.Name = "Xmltodbcbutton";
            this.Xmltodbcbutton.Size = new System.Drawing.Size(124, 31);
            this.Xmltodbcbutton.TabIndex = 1;
            this.Xmltodbcbutton.Text = "Xml转为数据库";
            this.Xmltodbcbutton.UseVisualStyleBackColor = true;
            this.Xmltodbcbutton.Click += new System.EventHandler(this.Xmltodbcbutton_Click);
            // 
            // converttoJson
            // 
            this.converttoJson.Location = new System.Drawing.Point(43, 182);
            this.converttoJson.Name = "converttoJson";
            this.converttoJson.Size = new System.Drawing.Size(124, 31);
            this.converttoJson.TabIndex = 2;
            this.converttoJson.Text = "转为Json";
            this.converttoJson.UseVisualStyleBackColor = true;
            this.converttoJson.Click += new System.EventHandler(this.converttoJson_Click);
            // 
            // Jsontodbcbutton
            // 
            this.Jsontodbcbutton.Location = new System.Drawing.Point(43, 235);
            this.Jsontodbcbutton.Name = "Jsontodbcbutton";
            this.Jsontodbcbutton.Size = new System.Drawing.Size(124, 31);
            this.Jsontodbcbutton.TabIndex = 3;
            this.Jsontodbcbutton.Text = "Json转为数据库";
            this.Jsontodbcbutton.UseVisualStyleBackColor = true;
            this.Jsontodbcbutton.Click += new System.EventHandler(this.Jsontodbcbutton_Click);
            // 
            // DBCconvertbutton
            // 
            this.DBCconvertbutton.Location = new System.Drawing.Point(43, 12);
            this.DBCconvertbutton.Name = "DBCconvertbutton";
            this.DBCconvertbutton.Size = new System.Drawing.Size(124, 31);
            this.DBCconvertbutton.TabIndex = 4;
            this.DBCconvertbutton.Text = "数据库转换";
            this.DBCconvertbutton.UseVisualStyleBackColor = true;
            this.DBCconvertbutton.Click += new System.EventHandler(this.DBCconvertbutton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 278);
            this.Controls.Add(this.DBCconvertbutton);
            this.Controls.Add(this.Jsontodbcbutton);
            this.Controls.Add(this.converttoJson);
            this.Controls.Add(this.Xmltodbcbutton);
            this.Controls.Add(this.conversionToXmlbutton);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button conversionToXmlbutton;
        private System.Windows.Forms.Button Xmltodbcbutton;
        private System.Windows.Forms.Button converttoJson;
        private System.Windows.Forms.Button Jsontodbcbutton;
        private System.Windows.Forms.Button DBCconvertbutton;
    }
}