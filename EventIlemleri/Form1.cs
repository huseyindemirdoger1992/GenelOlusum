using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventIlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Başarılı Olarak Çalıştı","Durum",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form Kapatılıyore", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
