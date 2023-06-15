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
                kitap_listele();
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
            kitap_listele();
        }

        public async void kitap_listele()
        {
            IReadOnlyCollection<FirebaseObject<Kitap>> kitaplar = await firebaseIstemci.Child("Kitaplar").OrderByKey().OnceAsync<Kitap>();

            DataTable kitaplar_table = new DataTable();

            kitaplar_table.Columns.Add("Kitap Türü", typeof(string));
            kitaplar_table.Columns.Add("Kitap Adı", typeof(string));


            foreach (FirebaseObject<Kitap> kitap in kitaplar)
            {
                kitaplar_table.Rows.Add(kitap.Key, kitap.Object.kitapAdi);
            }

            //dataGridView1.DataSource = kitaplar_table;
        }

        private void uyeekleBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
