using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleriOtomasyonu.WindowsFormUI.Views.Kullanici
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void btnMusteris_Click(object sender, EventArgs e)
        {
            musteriislemleri frm = new musteriislemleri();
            frm.Show();
            this.Hide();
        }

        private void btnSatisis_Click(object sender, EventArgs e)
        {
            satisislemleri frm = new satisislemleri();
            frm.Show();
            this.Hide();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lblAnasayfaTarih_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAnasayfaTarih.Text = DateTime.Now.ToLongDateString();
            lblAnasayfaSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnAracislem_Click(object sender, EventArgs e)
        {
            aracislemleri frm = new aracislemleri();
            frm.Show();
            this.Hide();
        }
    }
}
