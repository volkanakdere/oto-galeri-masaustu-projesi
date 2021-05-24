
namespace OtoGaleriOtomasyonu.WindowsFormUI.Views.Kullanici
{
    partial class aracekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSasi = new System.Windows.Forms.Label();
            this.lblRuhsat = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblYTur = new System.Windows.Forms.Label();
            this.lblMguc = new System.Windows.Forms.Label();
            this.lblMHacim = new System.Windows.Forms.Label();
            this.lblHKayit = new System.Windows.Forms.Label();
            this.lblHsrTutar = new System.Windows.Forms.Label();
            this.lblBakimT = new System.Windows.Forms.Label();
            this.lblMuayeneT = new System.Windows.Forms.Label();
            this.lblKilom = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblVites = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.lblSatis = new System.Windows.Forms.Label();
            this.lblAcik = new System.Windows.Forms.Label();
            this.txtSasi = new System.Windows.Forms.TextBox();
            this.txtRhst = new System.Windows.Forms.TextBox();
            this.txtPlk = new System.Windows.Forms.TextBox();
            this.cbVasitaTuru = new System.Windows.Forms.ComboBox();
            this.cbMrk = new System.Windows.Forms.ComboBox();
            this.cbMdl = new System.Windows.Forms.ComboBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.cbRenk = new System.Windows.Forms.ComboBox();
            this.cbYakitT = new System.Windows.Forms.ComboBox();
            this.cbMtrGuc = new System.Windows.Forms.ComboBox();
            this.cbMtrHac = new System.Windows.Forms.ComboBox();
            this.cbHasarD = new System.Windows.Forms.ComboBox();
            this.txtHasarT = new System.Windows.Forms.TextBox();
            this.txtKilometre = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.cbVites = new System.Windows.Forms.ComboBox();
            this.cbKasaT = new System.Windows.Forms.ComboBox();
            this.cbSatisD = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.btnAracGüncelle = new System.Windows.Forms.Button();
            this.btnAnasayfaD = new System.Windows.Forms.Button();
            this.dateBakim = new System.Windows.Forms.DateTimePicker();
            this.dateMuayene = new System.Windows.Forms.DateTimePicker();
            this.btnArcgtr = new System.Windows.Forms.Button();
            this.txtPlakayaGoreArcGtr = new System.Windows.Forms.TextBox();
            this.lblArcGtr = new System.Windows.Forms.Label();
            this.btnAracFormTemizle = new System.Windows.Forms.Button();
            this.btnTumArac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(689, 130);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblSasi
            // 
            this.lblSasi.AutoSize = true;
            this.lblSasi.Location = new System.Drawing.Point(26, 9);
            this.lblSasi.Name = "lblSasi";
            this.lblSasi.Size = new System.Drawing.Size(47, 13);
            this.lblSasi.TabIndex = 1;
            this.lblSasi.Text = "Şasi No:";
            // 
            // lblRuhsat
            // 
            this.lblRuhsat.AutoSize = true;
            this.lblRuhsat.Location = new System.Drawing.Point(12, 32);
            this.lblRuhsat.Name = "lblRuhsat";
            this.lblRuhsat.Size = new System.Drawing.Size(61, 13);
            this.lblRuhsat.TabIndex = 2;
            this.lblRuhsat.Text = "Ruhsat No:";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(30, 55);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(37, 13);
            this.lblPlaka.TabIndex = 3;
            this.lblPlaka.Text = "Plaka:";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(41, 81);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(26, 13);
            this.lblTur.TabIndex = 4;
            this.lblTur.Text = "Tür:";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(27, 107);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(40, 13);
            this.lblMarka.TabIndex = 5;
            this.lblMarka.Text = "Marka:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(26, 133);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model:";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Location = new System.Drawing.Point(10, 159);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(55, 13);
            this.lblYil.TabIndex = 7;
            this.lblYil.Text = "Model Yılı:";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(31, 185);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(36, 13);
            this.lblRenk.TabIndex = 8;
            this.lblRenk.Text = "Renk:";
            // 
            // lblYTur
            // 
            this.lblYTur.AutoSize = true;
            this.lblYTur.Location = new System.Drawing.Point(6, 214);
            this.lblYTur.Name = "lblYTur";
            this.lblYTur.Size = new System.Drawing.Size(59, 13);
            this.lblYTur.TabIndex = 9;
            this.lblYTur.Text = "Yakıt Türü:";
            // 
            // lblMguc
            // 
            this.lblMguc.AutoSize = true;
            this.lblMguc.Location = new System.Drawing.Point(253, 6);
            this.lblMguc.Name = "lblMguc";
            this.lblMguc.Size = new System.Drawing.Size(66, 13);
            this.lblMguc.TabIndex = 10;
            this.lblMguc.Text = "Motor Gücü:";
            // 
            // lblMHacim
            // 
            this.lblMHacim.AutoSize = true;
            this.lblMHacim.Location = new System.Drawing.Point(248, 32);
            this.lblMHacim.Name = "lblMHacim";
            this.lblMHacim.Size = new System.Drawing.Size(70, 13);
            this.lblMHacim.TabIndex = 11;
            this.lblMHacim.Text = "Motor Hacmi:";
            // 
            // lblHKayit
            // 
            this.lblHKayit.AutoSize = true;
            this.lblHKayit.Location = new System.Drawing.Point(214, 55);
            this.lblHKayit.Name = "lblHKayit";
            this.lblHKayit.Size = new System.Drawing.Size(104, 13);
            this.lblHKayit.TabIndex = 12;
            this.lblHKayit.Text = "Hasar Kayıt Durumu:";
            // 
            // lblHsrTutar
            // 
            this.lblHsrTutar.AutoSize = true;
            this.lblHsrTutar.Location = new System.Drawing.Point(224, 81);
            this.lblHsrTutar.Name = "lblHsrTutar";
            this.lblHsrTutar.Size = new System.Drawing.Size(94, 13);
            this.lblHsrTutar.TabIndex = 13;
            this.lblHsrTutar.Text = "Hasar Kayıt Tutarı:";
            // 
            // lblBakimT
            // 
            this.lblBakimT.AutoSize = true;
            this.lblBakimT.Location = new System.Drawing.Point(229, 107);
            this.lblBakimT.Name = "lblBakimT";
            this.lblBakimT.Size = new System.Drawing.Size(90, 13);
            this.lblBakimT.TabIndex = 14;
            this.lblBakimT.Text = "Son Bakım Tarihi:";
            // 
            // lblMuayeneT
            // 
            this.lblMuayeneT.AutoSize = true;
            this.lblMuayeneT.Location = new System.Drawing.Point(214, 133);
            this.lblMuayeneT.Name = "lblMuayeneT";
            this.lblMuayeneT.Size = new System.Drawing.Size(105, 13);
            this.lblMuayeneT.TabIndex = 15;
            this.lblMuayeneT.Text = "Son Muayene Tarihi:";
            // 
            // lblKilom
            // 
            this.lblKilom.AutoSize = true;
            this.lblKilom.Location = new System.Drawing.Point(266, 156);
            this.lblKilom.Name = "lblKilom";
            this.lblKilom.Size = new System.Drawing.Size(53, 13);
            this.lblKilom.TabIndex = 16;
            this.lblKilom.Text = "Kilometre:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(286, 182);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(32, 13);
            this.lblFiyat.TabIndex = 17;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblVites
            // 
            this.lblVites.AutoSize = true;
            this.lblVites.Location = new System.Drawing.Point(266, 209);
            this.lblVites.Name = "lblVites";
            this.lblVites.Size = new System.Drawing.Size(53, 13);
            this.lblVites.TabIndex = 18;
            this.lblVites.Text = "Vites Tipi:";
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.Location = new System.Drawing.Point(13, 244);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(54, 13);
            this.lblKasa.TabIndex = 19;
            this.lblKasa.Text = "Kasa Tipi:";
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.Location = new System.Drawing.Point(245, 244);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(73, 13);
            this.lblSatis.TabIndex = 20;
            this.lblSatis.Text = "Satış Durumu:";
            // 
            // lblAcik
            // 
            this.lblAcik.AutoSize = true;
            this.lblAcik.Location = new System.Drawing.Point(454, 15);
            this.lblAcik.Name = "lblAcik";
            this.lblAcik.Size = new System.Drawing.Size(53, 13);
            this.lblAcik.TabIndex = 21;
            this.lblAcik.Text = "Açıklama:";
            // 
            // txtSasi
            // 
            this.txtSasi.Location = new System.Drawing.Point(78, 6);
            this.txtSasi.Name = "txtSasi";
            this.txtSasi.Size = new System.Drawing.Size(116, 20);
            this.txtSasi.TabIndex = 22;
            // 
            // txtRhst
            // 
            this.txtRhst.Location = new System.Drawing.Point(78, 29);
            this.txtRhst.Name = "txtRhst";
            this.txtRhst.Size = new System.Drawing.Size(116, 20);
            this.txtRhst.TabIndex = 23;
            // 
            // txtPlk
            // 
            this.txtPlk.Location = new System.Drawing.Point(78, 52);
            this.txtPlk.Name = "txtPlk";
            this.txtPlk.Size = new System.Drawing.Size(116, 20);
            this.txtPlk.TabIndex = 24;
            // 
            // cbVasitaTuru
            // 
            this.cbVasitaTuru.FormattingEnabled = true;
            this.cbVasitaTuru.Location = new System.Drawing.Point(78, 78);
            this.cbVasitaTuru.Name = "cbVasitaTuru";
            this.cbVasitaTuru.Size = new System.Drawing.Size(116, 21);
            this.cbVasitaTuru.TabIndex = 25;
            // 
            // cbMrk
            // 
            this.cbMrk.FormattingEnabled = true;
            this.cbMrk.Location = new System.Drawing.Point(78, 105);
            this.cbMrk.Name = "cbMrk";
            this.cbMrk.Size = new System.Drawing.Size(116, 21);
            this.cbMrk.TabIndex = 26;
            this.cbMrk.SelectedIndexChanged += new System.EventHandler(this.cbMrk_SelectedIndexChanged);
            // 
            // cbMdl
            // 
            this.cbMdl.FormattingEnabled = true;
            this.cbMdl.Location = new System.Drawing.Point(78, 130);
            this.cbMdl.Name = "cbMdl";
            this.cbMdl.Size = new System.Drawing.Size(116, 21);
            this.cbMdl.TabIndex = 27;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(78, 156);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(116, 20);
            this.txtYil.TabIndex = 28;
            // 
            // cbRenk
            // 
            this.cbRenk.FormattingEnabled = true;
            this.cbRenk.Location = new System.Drawing.Point(78, 182);
            this.cbRenk.Name = "cbRenk";
            this.cbRenk.Size = new System.Drawing.Size(116, 21);
            this.cbRenk.TabIndex = 29;
            // 
            // cbYakitT
            // 
            this.cbYakitT.FormattingEnabled = true;
            this.cbYakitT.Location = new System.Drawing.Point(78, 209);
            this.cbYakitT.Name = "cbYakitT";
            this.cbYakitT.Size = new System.Drawing.Size(116, 21);
            this.cbYakitT.TabIndex = 30;
            // 
            // cbMtrGuc
            // 
            this.cbMtrGuc.FormattingEnabled = true;
            this.cbMtrGuc.Location = new System.Drawing.Point(324, 3);
            this.cbMtrGuc.Name = "cbMtrGuc";
            this.cbMtrGuc.Size = new System.Drawing.Size(116, 21);
            this.cbMtrGuc.TabIndex = 31;
            // 
            // cbMtrHac
            // 
            this.cbMtrHac.FormattingEnabled = true;
            this.cbMtrHac.Location = new System.Drawing.Point(324, 25);
            this.cbMtrHac.Name = "cbMtrHac";
            this.cbMtrHac.Size = new System.Drawing.Size(116, 21);
            this.cbMtrHac.TabIndex = 32;
            // 
            // cbHasarD
            // 
            this.cbHasarD.FormattingEnabled = true;
            this.cbHasarD.Location = new System.Drawing.Point(324, 47);
            this.cbHasarD.Name = "cbHasarD";
            this.cbHasarD.Size = new System.Drawing.Size(116, 21);
            this.cbHasarD.TabIndex = 33;
            // 
            // txtHasarT
            // 
            this.txtHasarT.Location = new System.Drawing.Point(324, 74);
            this.txtHasarT.Name = "txtHasarT";
            this.txtHasarT.Size = new System.Drawing.Size(116, 20);
            this.txtHasarT.TabIndex = 34;
            // 
            // txtKilometre
            // 
            this.txtKilometre.Location = new System.Drawing.Point(325, 153);
            this.txtKilometre.Name = "txtKilometre";
            this.txtKilometre.Size = new System.Drawing.Size(116, 20);
            this.txtKilometre.TabIndex = 37;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(324, 179);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(116, 20);
            this.txtFiyat.TabIndex = 38;
            // 
            // cbVites
            // 
            this.cbVites.FormattingEnabled = true;
            this.cbVites.Location = new System.Drawing.Point(324, 205);
            this.cbVites.Name = "cbVites";
            this.cbVites.Size = new System.Drawing.Size(116, 21);
            this.cbVites.TabIndex = 39;
            // 
            // cbKasaT
            // 
            this.cbKasaT.FormattingEnabled = true;
            this.cbKasaT.Location = new System.Drawing.Point(78, 236);
            this.cbKasaT.Name = "cbKasaT";
            this.cbKasaT.Size = new System.Drawing.Size(116, 21);
            this.cbKasaT.TabIndex = 40;
            // 
            // cbSatisD
            // 
            this.cbSatisD.FormattingEnabled = true;
            this.cbSatisD.Location = new System.Drawing.Point(324, 236);
            this.cbSatisD.Name = "cbSatisD";
            this.cbSatisD.Size = new System.Drawing.Size(116, 21);
            this.cbSatisD.TabIndex = 41;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(513, 12);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(160, 87);
            this.txtAciklama.TabIndex = 42;
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(9, 336);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(128, 32);
            this.btnAracEkle.TabIndex = 43;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnAracSil
            // 
            this.btnAracSil.Location = new System.Drawing.Point(177, 336);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(142, 32);
            this.btnAracSil.TabIndex = 44;
            this.btnAracSil.Text = "Araç Sil";
            this.btnAracSil.UseVisualStyleBackColor = true;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // btnAracGüncelle
            // 
            this.btnAracGüncelle.Location = new System.Drawing.Point(363, 336);
            this.btnAracGüncelle.Name = "btnAracGüncelle";
            this.btnAracGüncelle.Size = new System.Drawing.Size(144, 32);
            this.btnAracGüncelle.TabIndex = 45;
            this.btnAracGüncelle.Text = "Araç Güncelle";
            this.btnAracGüncelle.UseVisualStyleBackColor = true;
            this.btnAracGüncelle.Click += new System.EventHandler(this.btnAracGüncelle_Click);
            // 
            // btnAnasayfaD
            // 
            this.btnAnasayfaD.Location = new System.Drawing.Point(585, 175);
            this.btnAnasayfaD.Name = "btnAnasayfaD";
            this.btnAnasayfaD.Size = new System.Drawing.Size(88, 82);
            this.btnAnasayfaD.TabIndex = 46;
            this.btnAnasayfaD.Text = "Anasayfaya Dön";
            this.btnAnasayfaD.UseVisualStyleBackColor = true;
            this.btnAnasayfaD.Click += new System.EventHandler(this.btnAnasayfaD_Click);
            // 
            // dateBakim
            // 
            this.dateBakim.Location = new System.Drawing.Point(324, 101);
            this.dateBakim.Name = "dateBakim";
            this.dateBakim.Size = new System.Drawing.Size(116, 20);
            this.dateBakim.TabIndex = 47;
            // 
            // dateMuayene
            // 
            this.dateMuayene.Location = new System.Drawing.Point(324, 126);
            this.dateMuayene.Name = "dateMuayene";
            this.dateMuayene.Size = new System.Drawing.Size(116, 20);
            this.dateMuayene.TabIndex = 48;
            // 
            // btnArcgtr
            // 
            this.btnArcgtr.Location = new System.Drawing.Point(457, 284);
            this.btnArcgtr.Name = "btnArcgtr";
            this.btnArcgtr.Size = new System.Drawing.Size(124, 27);
            this.btnArcgtr.TabIndex = 49;
            this.btnArcgtr.Text = "Araç Bilgilerini Getir";
            this.btnArcgtr.UseVisualStyleBackColor = true;
            this.btnArcgtr.Click += new System.EventHandler(this.btnArcgtr_Click);
            // 
            // txtPlakayaGoreArcGtr
            // 
            this.txtPlakayaGoreArcGtr.Location = new System.Drawing.Point(267, 284);
            this.txtPlakayaGoreArcGtr.Multiline = true;
            this.txtPlakayaGoreArcGtr.Name = "txtPlakayaGoreArcGtr";
            this.txtPlakayaGoreArcGtr.Size = new System.Drawing.Size(184, 27);
            this.txtPlakayaGoreArcGtr.TabIndex = 50;
            // 
            // lblArcGtr
            // 
            this.lblArcGtr.AutoSize = true;
            this.lblArcGtr.Location = new System.Drawing.Point(10, 294);
            this.lblArcGtr.Name = "lblArcGtr";
            this.lblArcGtr.Size = new System.Drawing.Size(251, 13);
            this.lblArcGtr.TabIndex = 51;
            this.lblArcGtr.Text = "Bilgilerini Getirmek İstedğiniz Aracın Plakasını Giriniz:";
            // 
            // btnAracFormTemizle
            // 
            this.btnAracFormTemizle.Location = new System.Drawing.Point(513, 107);
            this.btnAracFormTemizle.Name = "btnAracFormTemizle";
            this.btnAracFormTemizle.Size = new System.Drawing.Size(160, 62);
            this.btnAracFormTemizle.TabIndex = 53;
            this.btnAracFormTemizle.Text = "Formu Temizle";
            this.btnAracFormTemizle.UseVisualStyleBackColor = true;
            this.btnAracFormTemizle.Click += new System.EventHandler(this.btnAracFormTemizle_Click);
            // 
            // btnTumArac
            // 
            this.btnTumArac.Location = new System.Drawing.Point(542, 336);
            this.btnTumArac.Name = "btnTumArac";
            this.btnTumArac.Size = new System.Drawing.Size(140, 32);
            this.btnTumArac.TabIndex = 54;
            this.btnTumArac.Text = "Tüm Araçları Getir";
            this.btnTumArac.UseVisualStyleBackColor = true;
            this.btnTumArac.Click += new System.EventHandler(this.btnTumArac_Click);
            // 
            // aracekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 503);
            this.ControlBox = false;
            this.Controls.Add(this.btnTumArac);
            this.Controls.Add(this.btnAracFormTemizle);
            this.Controls.Add(this.lblArcGtr);
            this.Controls.Add(this.txtPlakayaGoreArcGtr);
            this.Controls.Add(this.btnArcgtr);
            this.Controls.Add(this.dateMuayene);
            this.Controls.Add(this.dateBakim);
            this.Controls.Add(this.btnAnasayfaD);
            this.Controls.Add(this.btnAracGüncelle);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.cbSatisD);
            this.Controls.Add(this.cbKasaT);
            this.Controls.Add(this.cbVites);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtKilometre);
            this.Controls.Add(this.txtHasarT);
            this.Controls.Add(this.cbHasarD);
            this.Controls.Add(this.cbMtrHac);
            this.Controls.Add(this.cbMtrGuc);
            this.Controls.Add(this.cbYakitT);
            this.Controls.Add(this.cbRenk);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.cbMdl);
            this.Controls.Add(this.cbMrk);
            this.Controls.Add(this.cbVasitaTuru);
            this.Controls.Add(this.txtPlk);
            this.Controls.Add(this.txtRhst);
            this.Controls.Add(this.txtSasi);
            this.Controls.Add(this.lblAcik);
            this.Controls.Add(this.lblSatis);
            this.Controls.Add(this.lblKasa);
            this.Controls.Add(this.lblVites);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblKilom);
            this.Controls.Add(this.lblMuayeneT);
            this.Controls.Add(this.lblBakimT);
            this.Controls.Add(this.lblHsrTutar);
            this.Controls.Add(this.lblHKayit);
            this.Controls.Add(this.lblMHacim);
            this.Controls.Add(this.lblMguc);
            this.Controls.Add(this.lblYTur);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.lblRuhsat);
            this.Controls.Add(this.lblSasi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "aracekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AKDERE OTOMOTİV | Araç Ekle - Araç Sil - Araç Güncelle";
            this.Load += new System.EventHandler(this.aracekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSasi;
        private System.Windows.Forms.Label lblRuhsat;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblYTur;
        private System.Windows.Forms.Label lblMguc;
        private System.Windows.Forms.Label lblMHacim;
        private System.Windows.Forms.Label lblHKayit;
        private System.Windows.Forms.Label lblHsrTutar;
        private System.Windows.Forms.Label lblBakimT;
        private System.Windows.Forms.Label lblMuayeneT;
        private System.Windows.Forms.Label lblKilom;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblVites;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Label lblSatis;
        private System.Windows.Forms.Label lblAcik;
        private System.Windows.Forms.TextBox txtSasi;
        private System.Windows.Forms.TextBox txtRhst;
        private System.Windows.Forms.TextBox txtPlk;
        private System.Windows.Forms.ComboBox cbVasitaTuru;
        private System.Windows.Forms.ComboBox cbMrk;
        private System.Windows.Forms.ComboBox cbMdl;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.ComboBox cbRenk;
        private System.Windows.Forms.ComboBox cbYakitT;
        private System.Windows.Forms.ComboBox cbMtrGuc;
        private System.Windows.Forms.ComboBox cbMtrHac;
        private System.Windows.Forms.ComboBox cbHasarD;
        private System.Windows.Forms.TextBox txtHasarT;
        private System.Windows.Forms.TextBox txtKilometre;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ComboBox cbVites;
        private System.Windows.Forms.ComboBox cbKasaT;
        private System.Windows.Forms.ComboBox cbSatisD;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.Button btnAracGüncelle;
        private System.Windows.Forms.Button btnAnasayfaD;
        private System.Windows.Forms.DateTimePicker dateBakim;
        private System.Windows.Forms.DateTimePicker dateMuayene;
        private System.Windows.Forms.Button btnArcgtr;
        private System.Windows.Forms.TextBox txtPlakayaGoreArcGtr;
        private System.Windows.Forms.Label lblArcGtr;
        private System.Windows.Forms.Button btnAracFormTemizle;
        private System.Windows.Forms.Button btnTumArac;
    }
}