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
using Firebase.Database.Query;
using Firebase.Auth;


namespace kutuphane_otomasyon_
{
    public partial class KitaplariGor : Form
    {
        FirebaseClient istemci;
        private UserCredential kimlik;
        public KitaplariGor(FirebaseClient istemci, UserCredential kimlik)
        {
            this.istemci = istemci;
            InitializeComponent();
            this.kimlik = kimlik;
        }

        public async void kitap_listele()
        {
            IReadOnlyCollection<FirebaseObject<Kitap>> kitaplar = await istemci.Child("Kitaplar").OrderByKey().OnceAsync<Kitap>();

            DataTable kitaplar_table = new DataTable();

            kitaplar_table.Columns.Add("Kitap Türü", typeof(string));
            kitaplar_table.Columns.Add("Kitap Adı", typeof(string));


            foreach (FirebaseObject<Kitap> kitap in kitaplar)
            {
                kitaplar_table.Rows.Add(kitap.Key, kitap.Object.kitapAdi);
            }

            kitaplisteleDgw.DataSource = kitaplar_table;
        }

        private void kitaplisteleDgw_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selected = e.RowIndex;
            KitapEkleDuzenle kitapDuzenle = new KitapEkleDuzenle(istemci, kimlik);
            kitapDuzenle.Text = "Kitap Bilgilerini Güncelle";
            kitapDuzenle.kitapadıTxt.Text = kitaplisteleDgw.Rows[selected].Cells["Kitap Adı"].Value.ToString();
            kitapDuzenle.kitaptürüTxt.Text = kitaplisteleDgw.Rows[selected].Cells["Kitap Türü"].Value.ToString();

            kitapDuzenle.kitapekleBtn.Text = "Güncelle";

            kitapDuzenle.ShowDialog();
            kitap_listele();
        }
    }

}

