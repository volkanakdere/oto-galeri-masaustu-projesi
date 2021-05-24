using OtoGaleriOtomasyonu.DataAccess;
using OtoGaleriOtomasyonu.DataAccess.Concrete;
using OtoGaleriOtomasyonu.Entities.Domains;
using OtoGaleriOtomasyonu.WindowsFormUI.Models;
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
    public partial class satisislemleri : Form
    {
        OtoGaleriContext context = new OtoGaleriContext();
        AracDal aracDal = new AracDal();
        MusteriDal musteriDal = new MusteriDal();
        SatisDal satisDal = new SatisDal();

        public satisislemleri()
        {
            InitializeComponent();
        }

        private void btnAnasayfaD_Click(object sender, EventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
            this.Hide();
        }

        private void btnSatisaHazir_Click(object sender, EventArgs e)
        {
            dgvSatis.DataSource = aracDal.GetirSatılıkAracDetayDtoList();

        }
        

        private void satisislemleri_Load(object sender, EventArgs e)
        {
            DoldurCbAraclar();
            DoldurCbMusteriler();
            DoldurDgvSatis();
        }

        private void DoldurCbAraclar()
        {
            cbAraclar.DataSource = aracDal.GetirSatılıkAracDetayDtoList();
            cbAraclar.DisplayMember = "Plaka";
            cbAraclar.ValueMember = "Id";            
        }

        private void DoldurCbMusteriler()
        {
            cbMusteriler.DataSource = musteriDal.GetirMusteriDetayDtolist();
            cbMusteriler.DisplayMember = "FullName";
            cbMusteriler.ValueMember = "Id";
        }

        private void DoldurDgvSatis()
        {
            dgvSatis.DataSource = satisDal.GetirSatisDetayDtoList();
        }

        private void cbAraclar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var aracId = (int)cbAraclar.SelectedValue;
            dgvSatis.DataSource = aracDal.GetirAracDetayDtoByAracId(aracId);
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            var aracId = (int)cbAraclar.SelectedValue;
            var satis = new Satis
            {
                AracId = aracId,
                MusteriId = (int)cbMusteriler.SelectedValue,
                SatisFiyati= Convert.ToDecimal(txtSatisFiyati.Text),
                SatisTarihi = DateTime.Now
            };

            context.Satislar.Add(satis);
            var arac = context.Araclar.SingleOrDefault(x => x.Id == aracId);
            arac.SatildiMi = true;

            context.SaveChanges();
            MessageBox.Show("Araç satışı başarıyla gerçeklesti");
            DoldurCbAraclar();
        }

        private void btnSatilanAraclariGetir_Click(object sender, EventArgs e)
        {
            dgvSatis.DataSource = aracDal.GetirSatılanAracDetayDtoList();
        }
    }
}
