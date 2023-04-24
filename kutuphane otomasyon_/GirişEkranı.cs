using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
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
        private KullaniciGiris user;
        private YeniKullanıcı newUser;
        private FirebaseAuthClient client;
        public GirisEkranı(string AuthDomain, string ApiKey)
        {
            InitializeComponent();

            this.AuthDomain = AuthDomain;
            this.ApiKey = ApiKey;

            user = new KullaniciGiris();
            newUser = new YeniKullanıcı();

            GirisYapBtn_Click(this, EventArgs.Empty);

            this.user.girisBtn.Click += GirisBtn_Click;
            this.newUser.k_olusturBtn.Click += K_olusturBtn_Click;


            FirebaseAuthConfig config = new FirebaseAuthConfig
            {
                ApiKey = ApiKey,
                AuthDomain = AuthDomain,
                Providers = new FirebaseAuthProvider[]{new EmailProvider()},
               
            };

           this.client = new FirebaseAuthClient(config);
        }

        private async void GirisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserCredential kullanıcı_kimligi = await client.SignInWithEmailAndPasswordAsync(this.user.emailTxt.Text.Trim(),
                                                                                                this.user.sifreTxt.Text.Trim());
                MessageBox.Show(kullanıcı_kimligi.User.Uid);
            }

            catch (Exception exc) 
            {
                MessageBox.Show("HATA:"+exc.Message);
            }

            finally
            {

            }
        }

        private async void K_olusturBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var kullanıcı_kimligi = await client.CreateUserWithEmailAndPasswordAsync(this.newUser.yeniEmailTxt.Text.Trim(),
                                                                                         this.newUser.yeniSifreTxt.Text.Trim());
                MessageBox.Show(kullanıcı_kimligi.User.Uid);
            }

            catch (Exception exc)
            {
                MessageBox.Show("HATA:" + exc.Message);
            }

            finally
            {

            }
        }

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel1.Controls.Add(user);
        }

        private void YeniKullanıcıBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(newUser);
        }
    }
}
