using OtoGaleriOtomasyonu.DataAccess;
using OtoGaleriOtomasyonu.DataAccess.Concrete;
using OtoGaleriOtomasyonu.Entities.Domains;
using OtoGaleriOtomasyonu.Entities.Dtos;
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
        Arac seciliArac;
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
        private void InputlariResetle()
        {
            txtSasi.Text = "";
            txtRhst.Text = "";
            txtPlk.Text = "";
            cbVasitaTuru.SelectedIndex = 0;
            cbMrk.SelectedIndex = 0;
            cbMdl.SelectedIndex = 0;
            txtYil.Text = "";
            cbRenk.SelectedIndex = 0;
            cbYakitT.SelectedIndex = 0;
            cbKasaT.SelectedIndex = 0;
            cbMtrGuc.SelectedIndex = 0;
            cbMtrHac.SelectedIndex = 0;
            cbHasarD.SelectedIndex = 1;
            txtHasarT.Text = "";
            dateBakim.Value = DateTime.Now;
            dateMuayene.Value = DateTime.Now;
            txtKilometre.Text = "";
            txtFiyat.Text = "";
            cbVites.SelectedIndex = 0;
            cbSatisD.SelectedIndex = 0;
            txtAciklama.Text = "";
        }

        private void btnAracGüncelle_Click(object sender, EventArgs e)
        {

            if (seciliArac == null)
            {
                MessageBox.Show("Güncelleme işlemi için lütfen önce listeden kayıt seçiniz");
                return;
            }
            seciliArac.Aciklama = txtAciklama.Text;
            seciliArac.Fiyat = Convert.ToDecimal(txtFiyat.Text);
            seciliArac.HasarKaydiTutari = Convert.ToDecimal(txtHasarT.Text);
            seciliArac.HasarKaydiVarMi = cbHasarD.Text;
            seciliArac.KasaTipId = (int)cbKasaT.SelectedValue;
            seciliArac.Kilometre = Convert.ToInt32(txtKilometre.Text);
            seciliArac.MarkaId = (int)cbMrk.SelectedValue;
            seciliArac.ModelId = (int)cbMdl.SelectedValue;
            seciliArac.ModelYili = Convert.ToInt32(txtYil.Text);
            seciliArac.MotorGucu = cbMtrGuc.Text;
            seciliArac.MotorHacmi = cbMtrHac.Text;
            seciliArac.Plaka = txtPlk.Text;
            seciliArac.Renk = cbRenk.Text;
            seciliArac.RuhsatNo = txtRhst.Text;
            seciliArac.SasiNo = txtSasi.Text;
            seciliArac.SatildiMi = Convert.ToBoolean(cbSatisD.SelectedValue);
            seciliArac.SonBakimTarihi = dateBakim.Value;
            seciliArac.SonMuayeneTarihi = dateMuayene.Value;
            seciliArac.VasitaTurId = (int)cbVasitaTuru.SelectedValue;
            seciliArac.VitesTipId = (int)cbVites.SelectedValue;
            seciliArac.YakitTurId = (int)cbYakitT.SelectedValue;

           
            context.SaveChanges();

            MessageBox.Show("Kayıt başarıyla güncellendi");

            dataGridView1.DataSource = aracDal.GetirAracDetayDtoList();

            InputlariResetle();
            seciliArac = null;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var araclar = dataGridView1.SelectedRows[0].DataBoundItem as AracDetayDto;

                seciliArac = context.Araclar.SingleOrDefault(x => x.Id == araclar.Id);

                txtSasi.Text = seciliArac.SasiNo;
                txtRhst.Text = seciliArac.RuhsatNo;
                txtPlk.Text = seciliArac.Plaka;
                cbVasitaTuru.SelectedValue = seciliArac.VasitaTurId;
                cbMrk.SelectedValue = seciliArac.MarkaId;
                cbMdl.SelectedValue = seciliArac.ModelId;
                cbRenk.Text = seciliArac.Renk;
                txtYil.Text = seciliArac.ModelYili.ToString();
                cbMtrGuc.Text = seciliArac.MotorGucu;
                cbMtrHac.Text = seciliArac.MotorHacmi;
                cbHasarD.Text = seciliArac.HasarKaydiVarMi;
                txtHasarT.Text = seciliArac.HasarKaydiTutari.ToString();
                dateBakim.Value = seciliArac.SonBakimTarihi;
                dateMuayene.Value = seciliArac.SonMuayeneTarihi == DateTime.MinValue ? DateTime.Now : seciliArac.SonMuayeneTarihi;
                txtKilometre.Text = seciliArac.Kilometre.ToString();
                txtFiyat.Text = seciliArac.Fiyat.ToString();
                cbVites.SelectedValue = seciliArac.VitesTipId;
                cbSatisD.Text = araclar.SatilmaDurumu;
                txtAciklama.Text = seciliArac.Aciklama;

            }
            else
            {
                InputlariResetle();
            }
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliArac == null)
                {
                    MessageBox.Show("Silme işlemi için önce kayıt seçiniz");
                    return;
                }

                context.Araclar.Remove(seciliArac);
                context.SaveChanges();
                MessageBox.Show("Kayıt başarıyla silindi");
                dataGridView1.DataSource = aracDal.GetirAracDetayDtoList();
                InputlariResetle();
                seciliArac = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Seçilen araç silme işlemine yetkiniz yoktur.");
            }
        }

        private void btnAracFormTemizle_Click(object sender, EventArgs e)
        {
            InputlariResetle();
            seciliArac = null;
        }

        private void btnTumArac_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = aracDal.GetirAracDetayDtoList();
        }
    }
}
