using OtoGaleriOtomasyonu.DataAccess;
using OtoGaleriOtomasyonu.DataAccess.Concrete;
using OtoGaleriOtomasyonu.Entities.Domains;
using OtoGaleriOtomasyonu.Entities.Dtos;
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
    public partial class musteriislemleri : Form
    {
        OtoGaleriContext context = new OtoGaleriContext();
        MusteriDal musteriDal = new MusteriDal();
        Musteri seciliMusteri;

        public musteriislemleri()
        {
            InitializeComponent();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
            this.Hide();
        }

        private void musteriislemleri_Load(object sender, EventArgs e)
        {
            dgvMusteri.DataSource = musteriDal.GetirMusteriDetayDtolist();

            //cbCinsiyet.Items.AddRange(new[] { "Erkek", "Kadın" });
            cbCinsiyet.SelectedIndex = 0;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            var musteri = new Musteri
            {
                MAd = txtMAd.Text,
                MCinsiyet = cbCinsiyet.Text,
                MEposta = txtMEposta.Text,
                MSoyad = txtMSoyad.Text,
                MTelefon = txtMTel.Text
            };

            context.Musteriler.Add(musteri);
            var result = context.SaveChanges();
            if (result > 0)
            {
                MessageBox.Show("Kayıt başarıyla eklendi.");
                dgvMusteri.DataSource = musteriDal.GetirMusteriDetayDtolist();
                InputlariResetle();
            }
        }

        private void InputlariResetle()
        {
            txtMAd.Text = "";
            txtMEposta.Text = "";
            txtMSoyad.Text = "";
            txtMTel.Text = "";
            cbCinsiyet.SelectedIndex = 0;
        }

        private void dgvMusteri_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvMusteri.SelectedRows.Count > 0)
            //{
            //    var musteri = dgvMusteri.SelectedRows[0].DataBoundItem as MusteriDetayDto;

            //    txtMAd.Text = musteri.MusteriAdı;
            //    txtMEposta.Text = musteri.MusteriEPosta;
            //    txtMSoyad.Text = musteri.MusteriSoyadı;
            //    txtMTel.Text = musteri.MusteriTelefon;
            //    cbCinsiyet.SelectedIndex = musteri.MusteriCinsiyet =="Erkek" ? 0 : 1;

            //    seciliMusteri = context.Musteriler.SingleOrDefault(x => x.Id == musteri.Id);
            //}
            //else
            //{
            //    InputlariResetle();
            //}
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {            

            if (seciliMusteri == null)
            {
                MessageBox.Show("Güncelleme işlemi için lütfen önce listeden kayıt seçiniz");
                return;
            }
            seciliMusteri.MAd = txtMAd.Text;
            seciliMusteri.MCinsiyet = cbCinsiyet.Text;
            seciliMusteri.MEposta = txtMEposta.Text;
            seciliMusteri.MSoyad = txtMSoyad.Text;
            seciliMusteri.MTelefon = txtMTel.Text;
            context.SaveChanges();

            MessageBox.Show("Kayıt başarıyla güncellendi");

            dgvMusteri.DataSource = musteriDal.GetirMusteriDetayDtolist();

            InputlariResetle();
            seciliMusteri = null;

        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (seciliMusteri == null)
            {
                MessageBox.Show("Silme işlemi için önce kayıt seçiniz");
                return;
            }

            context.Musteriler.Remove(seciliMusteri);
            context.SaveChanges();
            MessageBox.Show("Kayıt başarıyla silindi");
            dgvMusteri.DataSource = musteriDal.GetirMusteriDetayDtolist();
            InputlariResetle();
            seciliMusteri = null;
        }

        private void dgvMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMusteri.SelectedRows.Count > 0)
            {
                var musteri = dgvMusteri.SelectedRows[0].DataBoundItem as MusteriDetayDto;

                txtMAd.Text = musteri.MusteriAdı;
                txtMEposta.Text = musteri.MusteriEPosta;
                txtMSoyad.Text = musteri.MusteriSoyadı;
                txtMTel.Text = musteri.MusteriTelefon;
                cbCinsiyet.SelectedIndex = musteri.MusteriCinsiyet == "Erkek" ? 0 : 1;

                seciliMusteri = context.Musteriler.SingleOrDefault(x => x.Id == musteri.Id);
            }
            else
            {
                InputlariResetle();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InputlariResetle();
            seciliMusteri = null;
        }
    }
}
