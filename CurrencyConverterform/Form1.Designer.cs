namespace CurrencyConverterform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxfrom = new System.Windows.Forms.ComboBox();
            this.comboBoxto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btnexchange = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxfrom
            // 
            this.comboBoxfrom.FormattingEnabled = true;
            this.comboBoxfrom.Location = new System.Drawing.Point(189, 60);
            this.comboBoxfrom.Name = "comboBoxfrom";
            this.comboBoxfrom.Size = new System.Drawing.Size(151, 28);
            this.comboBoxfrom.TabIndex = 0;
            // 
            // comboBoxto
            // 
            this.comboBoxto.FormattingEnabled = true;
            this.comboBoxto.Location = new System.Drawing.Point(563, 60);
            this.comboBoxto.Name = "comboBoxto";
            this.comboBoxto.Size = new System.Drawing.Size(151, 28);
            this.comboBoxto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "fromCurrency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "toCurrency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 27);
            this.textBox1.TabIndex = 5;
            // 
            // Btnexchange
            // 
            this.Btnexchange.Location = new System.Drawing.Point(195, 216);
            this.Btnexchange.Name = "Btnexchange";
            this.Btnexchange.Size = new System.Drawing.Size(94, 29);
            this.Btnexchange.TabIndex = 6;
            this.Btnexchange.Text = "exchange";
            this.Btnexchange.UseVisualStyleBackColor = true;
            this.Btnexchange.Click += new System.EventHandler(this.Btnexchange_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(450, 216);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(94, 29);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(563, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 27);
            this.textBox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "AmountExchange";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.Btnexchange);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxto);
            this.Controls.Add(this.comboBoxfrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxfrom;
        private ComboBox comboBoxto;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button Btnexchange;
        private Button btnclear;
        private TextBox textBox3;
        private Label label4;
    }
}