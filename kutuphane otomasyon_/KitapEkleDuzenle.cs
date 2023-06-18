using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;

namespace kutuphane_otomasyon_
{
    public partial class KitapEkleDuzenle : Form
    {
        FirebaseClient istemci;
        private UserCredential kimlik;
        public KitapEkleDuzenle(FirebaseClient istemci, UserCredential kullanici_kimligi)
        {
            InitializeComponent();
            this.istemci = istemci;
            this.kimlik = kullanici_kimligi;
        }

        private async void kitapekleBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                Kitap yeniKitap = new Kitap();
                yeniKitap.kitapAdi = kitapadıTxt.Text;

                await istemci.Child("Kitaplar").Child(kitaptürüTxt.Text).PutAsync(yeniKitap);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Hata:" + ex.Message, "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
