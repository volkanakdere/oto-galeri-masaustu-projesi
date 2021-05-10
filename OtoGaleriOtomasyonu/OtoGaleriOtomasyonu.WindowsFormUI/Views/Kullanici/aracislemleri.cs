using OtoGaleriOtomasyonu.DataAccess;
using OtoGaleriOtomasyonu.Entities.Domains;
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
    public partial class aracislemleri : Form
    {
        OtoGaleriContext context = new OtoGaleriContext();

        public aracislemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aracekle frm = new aracekle();
            frm.Show();
            this.Hide();
        }

        private void aracislemleri_Load(object sender, EventArgs e)
        {

            cbVasitaTurleri.DataSource = context.VasitaTurleri.ToList();
            cbVasitaTurleri.DisplayMember = "VasitaTuru";
            cbVasitaTurleri.ValueMember = "Id";


            cbAracislemleriMarka.DataSource = context.Markalar.OrderBy(x => x.MarkaAdi).ToList();
            cbAracislemleriMarka.DisplayMember = "MarkaAdi";
            cbAracislemleriMarka.ValueMember = "Id";

        }

        private void btnAnasayfaD_Click(object sender, EventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
            this.Hide();
        }

        private void cbAracislemleriMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilenMarka = (Marka)cbAracislemleriMarka.SelectedItem;

            cbAracislemleriModel.DataSource = context.Modeller.Where(x => x.MarkaId == secilenMarka.Id).OrderBy(x => x.ModelAdi).ToList();
            cbAracislemleriModel.DisplayMember = "ModelAdi";
            cbAracislemleriModel.ValueMember = "Id";
        }

        private void btnAracislemListele_Click(object sender, EventArgs e)
        {
            var vasitaTurId = ((VasitaTur)cbVasitaTurleri.SelectedItem).Id;
            var markaId = ((Marka)cbAracislemleriMarka.SelectedItem).Id;
            var modelId = ((Model)cbAracislemleriModel.SelectedItem).Id;

            var araclar = context.Araclar
                            .Where(x => x.VasitaTurId == vasitaTurId)
                            .Where(x => x.MarkaId == markaId)
                            .Where(x => x.ModelId == modelId).ToList();



            dataGridView1.DataSource = araclar;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var ruhsatNo = txtAracislemRuhsatNo.Text;
            var plaka = txtAracislemPlaka.Text;

            if (string.IsNullOrEmpty(ruhsatNo) && string.IsNullOrEmpty(plaka))
            {
                MessageBox.Show("Lütfen arama yapmak için plaka veya ruhsat numarası giriniz");
                return;
            }

            if (string.IsNullOrEmpty(ruhsatNo) == false)
            {
                dataGridView1.DataSource = context.Araclar.Where(x => x.RuhsatNo == ruhsatNo).ToList();
            }

            if (string.IsNullOrEmpty(plaka) == false)
            {
                dataGridView1.DataSource = context.Araclar.Where(x => x.Plaka == plaka).ToList();
            }
        }

        private void btnTumArac_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Araclar.ToList();            
        }
    }
}
