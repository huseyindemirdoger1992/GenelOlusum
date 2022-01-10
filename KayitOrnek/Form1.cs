using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            string KayitHatti = null;
            KayitHatti = $@"Ad:{textBoxAd.Text} | Soyad:{textBoxSoyad.Text} |  {textBoxAd.Text.ToLower()}{textBoxSoyad.Text.ToLower()}@{comboBoxMail.Text}.com | Cinsiyet: {comboBoxCins.Text} | Doğum Yılı: {dateTimePickerDY.Value.ToShortDateString()}";
            listBox1.Items.Add(KayitHatti); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMail.Items.Add("gmail");
            comboBoxMail.Items.Add("hotmail");
            comboBoxMail.Items.Add("yahoo");
            comboBoxCins.Items.Add("Erkek");
            comboBoxCins.Items.Add("Bayan");
        }
    }
}
