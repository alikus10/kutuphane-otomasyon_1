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
    public partial class AnaPencere : Form
    {
        public AnaPencere()
        {
            InitializeComponent();
        }

        private void AnaPencere_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
