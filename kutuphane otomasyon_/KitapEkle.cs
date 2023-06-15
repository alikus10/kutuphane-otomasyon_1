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
using Firebase.Database;
using Firebase.Database.Query;

namespace kutuphane_otomasyon_
{
    public partial class KitapEkle : Form
    {
        FirebaseClient istemci;
        public KitapEkle(FirebaseClient istemci)
        {
            InitializeComponent();
            this.istemci = istemci;
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
                kitap_listele();
            }
        }
    }
}
