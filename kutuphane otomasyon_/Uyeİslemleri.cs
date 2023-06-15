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
    public partial class Uyeİslemleri : Form
    {
        FirebaseClient istemci;
        public Uyeİslemleri(FirebaseClient istemci)
        {
            this.istemci = istemci;
            InitializeComponent();
        }


        public async void uye_listele()
        {
            IReadOnlyCollection<FirebaseObject<Uye>> uyeler = await istemci.Child("Üyeler").OrderByKey().OnceAsync<Uye>();

            DataTable uyeler_table = new DataTable();

            uyeler_table.Columns.Add("Kimlik No", typeof(string));
            uyeler_table.Columns.Add("Adı", typeof(string));
            uyeler_table.Columns.Add("Soyadı", typeof(string));
            uyeler_table.Columns.Add("Tel No", typeof(string));

            foreach (FirebaseObject<Uye> uye in uyeler)
            {
                uyeler_table.Rows.Add(uye.Key, uye.Object.uyeAdi, uye.Object.uyeSoyadi, uye.Object.telNo);
            }

            uyelisteleDgw.DataSource = uyeler_table;
        }
    }
}
