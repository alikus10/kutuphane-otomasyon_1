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
    public partial class Uyeİslemleri : Form
    {
        FirebaseClient istemci;
        private UserCredential kimlik;
        public Uyeİslemleri(FirebaseClient istemci, UserCredential kullanici_kimligi)
        {
            this.istemci = istemci;
            this.kimlik = kullanici_kimligi;

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

        private void uyelisteleDgw_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selected = e.RowIndex;
            UyeEkleDuzenle uyeDuzenle = new UyeEkleDuzenle(istemci, kimlik);
            uyeDuzenle.Text = "Üye Bilgilerini Güncelle";
            uyeDuzenle.adTxt.Text = uyelisteleDgw.Rows[selected].Cells["Adı"].Value.ToString();
            uyeDuzenle.soyadTxt.Text = uyelisteleDgw.Rows[selected].Cells["Soyadı"].Value.ToString();
            uyeDuzenle.kimliknoTxt.Text = uyelisteleDgw.Rows[selected].Cells["Kimlik No"].Value.ToString();
            uyeDuzenle.telnoTxt.Text = uyelisteleDgw.Rows[selected].Cells["Tel No"].Value.ToString();
            uyeDuzenle.uyeekleBtn.Text = "Güncelle";
            
            uyeDuzenle.ShowDialog();
            uye_listele();
        }
    }
}
