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
    public partial class aracekle : Form
    {
        OtoGaleriContext context = new OtoGaleriContext();
        AracDal aracDal = new AracDal();
        public aracekle()
        {
            InitializeComponent();
        }

        private void btnAnasayfaD_Click(object sender, EventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
            this.Hide();
        }

        private void aracekle_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = aracDal.GetirAracDetayDtoList();

            cbKasaT.DataSource = context.KasaTipleri.ToList();
            cbKasaT.DisplayMember = "KasaTipi";
            cbKasaT.ValueMember = "Id";

            
            cbMrk.DataSource = context.Markalar.ToList();
            cbMrk.DisplayMember = "MarkaAdi";
            cbMrk.ValueMember = "Id";

            cbMtrGuc.Items.AddRange(ModelHelper.MotorGucleri);
            cbMtrGuc.SelectedIndex = 0;

            cbMtrHac.Items.AddRange(ModelHelper.MotorHacimleri);
            cbMtrHac.SelectedIndex = 0;

            cbRenk.Items.AddRange(ModelHelper.Renkler);
            cbRenk.SelectedIndex = 0;

            cbSatisD.DataSource = ModelHelper.SatildiMiComboboxModels;
            cbSatisD.DisplayMember = "DisplayValue";
            cbSatisD.ValueMember = "Value";

            cbVasitaTuru.DataSource = context.VasitaTurleri.ToList();
            cbVasitaTuru.DisplayMember = "VasitaTuru";
            cbVasitaTuru.ValueMember = "Id";

            cbVites.DataSource = context.VitesTipleri.ToList();
            cbVites.DisplayMember = "VitesTipi";
            cbVites.ValueMember = "Id";

            cbYakitT.DataSource = context.YakitTurleri.ToList();
            cbYakitT.DisplayMember = "YakitTuru";
            cbYakitT.ValueMember = "Id";

            cbHasarD.Items.AddRange(ModelHelper.HasarDurumlari);
            cbHasarD.SelectedIndex = 1;

        }

        private void btnArcgtr_Click(object sender, EventArgs e)
        {
            var plaka = txtPlakayaGoreArcGtr.Text;
            if (string.IsNullOrEmpty(plaka) == true)
            {
                MessageBox.Show("Lütfen getirmek istediğiniz aracın plakasını giriniz");
            }

            dataGridView1.DataSource = aracDal.GetirAracDetayDtoList(null, plaka);
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            var arac = new Arac
            {
                Aciklama = txtAciklama.Text,
                Fiyat = Convert.ToDecimal(txtFiyat.Text),
                HasarKaydiTutari = Convert.ToDecimal(txtHasarT.Text),
                HasarKaydiVarMi = cbHasarD.Text,
                KasaTipId = (int)cbKasaT.SelectedValue,
                Kilometre = Convert.ToInt32(txtKilometre.Text),
                MarkaId = (int) cbMrk.SelectedValue,
                ModelId =(int) cbMdl.SelectedValue,
                ModelYili = Convert.ToInt32(txtYil.Text),
                MotorGucu = cbMtrGuc.Text,
                MotorHacmi = cbMtrHac.Text,
                Plaka = txtPlk.Text,
                Renk = cbRenk.Text,
                RuhsatNo = txtRhst.Text,
                SasiNo= txtSasi.Text,
                SatildiMi = Convert.ToBoolean(cbSatisD.SelectedValue),
                SonBakimTarihi = dateBakim.Value,
                SonMuayeneTarihi = dateMuayene.Value,
                VasitaTurId = (int) cbVasitaTuru.SelectedValue,
                VitesTipId =(int) cbVites.SelectedValue,
                YakitTurId =(int) cbYakitT.SelectedValue,

            };


            context.Araclar.Add(arac);
            context.SaveChanges();

            MessageBox.Show("Araç Başarıyla Eklendi");

            dataGridView1.DataSource = aracDal.GetirAracDetayDtoList();
        }

        private void cbMrk_SelectedIndexChanged(object sender, EventArgs e)
        {            
            var markaId = ((Marka)cbMrk.SelectedItem).Id;
            cbMdl.DataSource = context.Modeller.Where(x => x.MarkaId == markaId).ToList();
            cbMdl.DisplayMember = "ModelAdi";
            cbMdl.ValueMember = "Id";
        }
    }
}
