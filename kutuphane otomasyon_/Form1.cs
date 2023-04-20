using kutuphane_otomasyon_.Kontroller;
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
    public partial class GirisEkranı : Form
    {
        private string AuthDomain, ApiKey;

        public GirisEkranı(string AuthDomain, string ApiKey)
        {
            InitializeComponent();

            this.AuthDomain = AuthDomain;
            this.ApiKey = ApiKey;

            GirisYapBtn_Click(this, EventArgs.Empty);
        }

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {

            KullanıcıGiris user = new KullanıcıGiris();
            panel1.Controls.Clear();
            panel1.Controls.Add(user);
        }

        private void YeniKullanıcıBtn_Click(object sender, EventArgs e)
        {
            YeniKullanıcı newUser = new YeniKullanıcı();
            panel1.Controls.Clear();
            panel1.Controls.Add(newUser);
        }


    }
}
