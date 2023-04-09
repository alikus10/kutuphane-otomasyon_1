using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyon_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gelenEposta = eposta_txt.Text;
            string gelenSifre =sifre_txt.Text;

            if (gelenEposta.Equals("admin") && gelenSifre.Equals("12345"))
            {
                MessageBox.Show("Giriş Başarılı");
            }

            else
            {
                MessageBox.Show("E-posta veya şifre hatalıdır!!");
            }
        }
    }
}
