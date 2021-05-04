using OtoGaleriOtomasyonu.DataAccess;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var eposta = tbxEposta.Text;
            var parola = tbxParola.Text;

            var context = new OtoGaleriContext();

            var kullanici = context.Kullanicilar.SingleOrDefault(k => k.KEposta == eposta && k.Parola == parola);

            if (kullanici== null)
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }
            else
            {
                MessageBox.Show(kullanici.KAd + " Hoşgeldiniz");
            }
        }
    }
}
