﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;

namespace kutuphane_otomasyon_
{
    public partial class UyeEkle : Form
    {
        private FirebaseClient istemci;
        private string resim_url = "";
        private UserCredential kimlik;
        private Config ayarlar;
        public UyeEkle(FirebaseClient istemci, UserCredential kullanici_kimligi)
        {   
            this.istemci = istemci;
            this.kimlik = kullanici_kimligi;
            ayarlar = new Config();
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
                yeniUye.resim = String.Format("ÜyeProfilResimleri/{0}/profil.png", kimliknoTxt.Text);

                if (resim_url != "")
                {
                    FirebaseStorage depolama = new FirebaseStorage(ayarlar.FireStorageDomain, new FirebaseStorageOptions
                    {
                        AuthTokenAsyncFactory = () => kimlik.User.GetIdTokenAsync(),
                        ThrowOnCancel = true,
                    });

                    FileStream stream = File.Open(resim_url, FileMode.Open);

                    FirebaseStorageTask gonder = depolama.Child("ÜyeProfilResimleri").Child(kimliknoTxt.Text).Child("profil.png").PutAsync(stream);

                    gonder.Progress.ProgressChanged += (s, evnt) => uyeeklePB.Value = evnt.Percentage;
                }

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

        private void resimsecBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimsec = new OpenFileDialog();
            if (resimsec.ShowDialog() == DialogResult.OK) 
            {
                FileStream stream = File.Open(resimsec.FileName, FileMode.Open);
                Image resim = (Image)Image.FromStream(stream).Clone();
                uyeresimPb.Image = resim;
                stream.Close();
                resim_url = resimsec.FileName;
            }
        }
    }
}
