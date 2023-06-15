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



namespace kutuphane_otomasyon_
{
    public partial class KitaplariGor : Form
    {
        FirebaseClient istemci;
        public KitaplariGor(FirebaseClient istemci)
        {
            this.istemci = istemci;
            InitializeComponent();
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
    }

}

