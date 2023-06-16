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
    public partial class OduncTakip : Form
    {
        public OduncTakip()
        {
            InitializeComponent();
        }

        public async void uye_listele()
        {
            IReadOnlyCollection<FirebaseObject<Odunc>> oduncler = await istemci.Child("Ödünçler").OrderByKey().OnceAsync<Odunc>();

            DataTable oduncler_table = new DataTable();

            oduncler_table.Columns.Add("Üye Kimlik No", typeof(string));
            oduncler_table.Columns.Add("Kitap Adı", typeof(string));
            oduncler_table.Columns.Add("Veriliş Tarihi", typeof(string));
            oduncler_table.Columns.Add("Tel No", typeof(string));

            foreach (FirebaseObject<Uye> odunc in oduncler)
            {
                uyeler_table.Rows.Add(uye.Key, uye.Object.uyeAdi, uye.Object.uyeSoyadi, uye.Object.telNo);
            }

            uyelisteleDgw.DataSource = uyeler_table;
        }
    }
}
