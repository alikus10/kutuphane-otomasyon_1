using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
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

    public partial class AnaPencere : Form
    {
        private UserCredential kullanıcı_kimligi;
        private FirebaseClient firebaseIstemci;
        private Config ayarlar;
        public AnaPencere(UserCredential kullanici_kimligi)
        {
            InitializeComponent();
            ayarlar = new Config();

            this.kullanıcı_kimligi = kullanıcı_kimligi;
            this.Text = this.Text + " | " + kullanici_kimligi.User.Info.Email;

            try
            {
                firebaseIstemci = new FirebaseClient(ayarlar.FireBaseDomain,
                                                     new FirebaseOptions
                                                     {
                                                         AuthTokenAsyncFactory = () => kullanici_kimligi.User.GetIdTokenAsync()
                                                     });
            }
            catch(Exception exc) 
            {
                MessageBox.Show("Hata:" + exc.Message, "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnaPencere_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Kitap
        private async void KitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle newkitap = new KitapEkle(firebaseIstemci);
            newkitap.ShowDialog();
        }
        

        private void uyeekleBtn_Click(object sender, EventArgs e)
        {
            UyeEkle newuye = new UyeEkle(firebaseIstemci);
            newuye.ShowDialog();
        }

        private void ktplarıgörBtn_Click(object sender, EventArgs e)
        {
            KitaplariGor viewkitap = new KitaplariGor(firebaseIstemci);

            viewkitap.kitap_listele();         
            viewkitap.Show();
        }

        private void KullaniciIslemleriBtn_Click(object sender, EventArgs e)
        {
            Uyeİslemleri viewuye = new Uyeİslemleri(firebaseIstemci);
            viewuye.uye_listele();
            viewuye.Show();
        }

        private void oduncverBtn_Click(object sender, EventArgs e)
        {
            OduncVer viewodunc = new OduncVer(firebaseIstemci);
            viewodunc.uye_listele();
            viewodunc.kitap_listele();
            viewodunc.Show();
        }

        private void odunctakipBtn_Click(object sender, EventArgs e)
        {
            OduncTakip viewoduncler = new OduncTakip(firebaseIstemci);
            viewoduncler.odunc_listele();
            viewoduncler.Show();
        }
    }
}
