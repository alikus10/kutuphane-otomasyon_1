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
        public AnaPencere(UserCredential kullanici_kimligi)
        {
            InitializeComponent();

            this.kullanıcı_kimligi = kullanıcı_kimligi;
            this.Text = this.Text + " | " + kullanici_kimligi.User.Info.Email;
            try
            {
                firebaseIstemci = new FirebaseClient("https://kutuphaneotomasyon-skybird-default-rtdb.europe-west1.firebasedatabase.app/",
                                                     new FirebaseOptions
                                                     {
                                                         AuthTokenAsyncFactory = () => kullanici_kimligi.User.GetIdTokenAsync()
                                                     });
                MessageBox.Show("FireBase için istemci bağlantısı başarılı :", " Başarılı ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async void button1_Click(object sender, EventArgs e)
        {
            Kitap ktp1 = new Kitap();
            ktp1.kitapAdi = "Yaş 35";
            Kitap ktp2 = new Kitap();
            ktp2.kitapAdi = "Dişi Kurt";

            await firebaseIstemci.Child("Kitaplar").Child("Şiir").PutAsync(ktp1);
            await firebaseIstemci.Child("Kitaplar").Child("Hikaye").PutAsync(ktp2);
        }
    }
}
