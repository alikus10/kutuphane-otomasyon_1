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
        public GirisEkranı(string AuthDomain, string ApiKey)
        {
            InitializeComponent();

            this.AuthDomain = AuthDomain;
            this.ApiKey = ApiKey;
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
