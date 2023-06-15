using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;

namespace kutuphane_otomasyon_
{
    public partial class UyeEkle : Form
    {
        FirebaseClient istemci;
        public UyeEkle(FirebaseClient istemci)
        {   
            this.istemci = istemci;
            InitializeComponent();
        }

        private async void uyeekleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Uye yeniUye = new Uye();
                yeniUye.uyeAdi = adTxt.Text;
                yeniUye.uyeSoyadi = soyadTxt.Text;
                yeniUye.telNo = telnoTxt.Text;

                await istemci.Child("Üyeler").Child(kimliknoTxt.Text).PutAsync(yeniUye);
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
