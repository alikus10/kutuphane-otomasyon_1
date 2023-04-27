using Firebase.Auth;
using Firebase.Database;
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
            }catch(Exception exc) 
            {
                MessageBox.Show("Hata:" + exc.Message, "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnaPencere_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
