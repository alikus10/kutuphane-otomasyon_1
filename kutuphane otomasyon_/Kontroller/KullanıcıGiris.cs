using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyon_.Kontroller
{
    public partial class KullanıcıGiris : UserControl
    {
        public KullanıcıGiris()
        {
            InitializeComponent();
        }

        private void gosterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (girisGosterCb.Checked)
                sifreTxt.PasswordChar = '\0';
            else
                sifreTxt.PasswordChar = '*';
        }

        
    }
}
