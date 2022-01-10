namespace KayitOrnek
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.dateTimePickerDY = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMail = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCins = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(12, 28);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(100, 22);
            this.textBoxAd.TabIndex = 1;
            // 
            // dateTimePickerDY
            // 
            this.dateTimePickerDY.Location = new System.Drawing.Point(486, 28);
            this.dateTimePickerDY.Name = "dateTimePickerDY";
            this.dateTimePickerDY.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDY.TabIndex = 2;
            // 
            // comboBoxMail
            // 
            this.comboBoxMail.FormattingEnabled = true;
            this.comboBoxMail.Location = new System.Drawing.Point(229, 28);
            this.comboBoxMail.Name = "comboBoxMail";
            this.comboBoxMail.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMail.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1177, 372);
            this.listBox1.TabIndex = 4;
            // 
            // BtnKayit
            // 
            this.BtnKayit.Location = new System.Drawing.Point(701, 28);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(491, 23);
            this.BtnKayit.TabIndex = 5;
            this.BtnKayit.Text = "Kayıt Et ";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(118, 28);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(100, 22);
            this.textBoxSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinsiyet";
            // 
            // comboBoxCins
            // 
            this.comboBoxCins.FormattingEnabled = true;
            this.comboBoxCins.Location = new System.Drawing.Point(359, 28);
            this.comboBoxCins.Name = "comboBoxCins";
            this.comboBoxCins.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCins.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doğum Yılı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 455);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxCins);
            this.Controls.Add(this.comboBoxMail);
            this.Controls.Add(this.dateTimePickerDY);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDY;
        private System.Windows.Forms.ComboBox comboBoxMail;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCins;
        private System.Windows.Forms.Label label5;
    }
}

