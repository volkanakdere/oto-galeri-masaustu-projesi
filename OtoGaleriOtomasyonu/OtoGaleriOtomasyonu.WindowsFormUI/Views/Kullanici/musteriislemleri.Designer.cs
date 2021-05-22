
namespace OtoGaleriOtomasyonu.WindowsFormUI.Views.Kullanici
{
    partial class musteriislemleri
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
            this.dgvMusteri = new System.Windows.Forms.DataGridView();
            this.lblMAd = new System.Windows.Forms.Label();
            this.lblMSoyad = new System.Windows.Forms.Label();
            this.lblMTel = new System.Windows.Forms.Label();
            this.lblMEposta = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.txtMTel = new System.Windows.Forms.TextBox();
            this.txtMAd = new System.Windows.Forms.TextBox();
            this.txtMSoyad = new System.Windows.Forms.TextBox();
            this.txtMEposta = new System.Windows.Forms.TextBox();
            this.lblMCins = new System.Windows.Forms.Label();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusteri
            // 
            this.dgvMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMusteri.Location = new System.Drawing.Point(0, 240);
            this.dgvMusteri.MultiSelect = false;
            this.dgvMusteri.Name = "dgvMusteri";
            this.dgvMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteri.ShowEditingIcon = false;
            this.dgvMusteri.Size = new System.Drawing.Size(621, 154);
            this.dgvMusteri.TabIndex = 0;
            this.dgvMusteri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteri_CellClick);
            this.dgvMusteri.SelectionChanged += new System.EventHandler(this.dgvMusteri_SelectionChanged);
            // 
            // lblMAd
            // 
            this.lblMAd.AutoSize = true;
            this.lblMAd.Location = new System.Drawing.Point(32, 24);
            this.lblMAd.Name = "lblMAd";
            this.lblMAd.Size = new System.Drawing.Size(62, 13);
            this.lblMAd.TabIndex = 1;
            this.lblMAd.Text = "Müşteri Adı:";
            // 
            // lblMSoyad
            // 
            this.lblMSoyad.AutoSize = true;
            this.lblMSoyad.Location = new System.Drawing.Point(15, 50);
            this.lblMSoyad.Name = "lblMSoyad";
            this.lblMSoyad.Size = new System.Drawing.Size(79, 13);
            this.lblMSoyad.TabIndex = 2;
            this.lblMSoyad.Text = "Müşteri Soyadı:";
            // 
            // lblMTel
            // 
            this.lblMTel.AutoSize = true;
            this.lblMTel.Location = new System.Drawing.Point(10, 79);
            this.lblMTel.Name = "lblMTel";
            this.lblMTel.Size = new System.Drawing.Size(83, 13);
            this.lblMTel.TabIndex = 3;
            this.lblMTel.Text = "Müşteri Telefon:";
            // 
            // lblMEposta
            // 
            this.lblMEposta.AutoSize = true;
            this.lblMEposta.Location = new System.Drawing.Point(9, 105);
            this.lblMEposta.Name = "lblMEposta";
            this.lblMEposta.Size = new System.Drawing.Size(84, 13);
            this.lblMEposta.TabIndex = 4;
            this.lblMEposta.Text = "Müşteri E-Posta:";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(100, 154);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(74, 23);
            this.btnMusteriEkle.TabIndex = 5;
            this.btnMusteriEkle.Text = "Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(0, 195);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(142, 41);
            this.btnMusteriSil.TabIndex = 6;
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(180, 154);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(77, 23);
            this.btnMusteriGuncelle.TabIndex = 7;
            this.btnMusteriGuncelle.Text = "Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Location = new System.Drawing.Point(148, 195);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(162, 41);
            this.btnAnasayfa.TabIndex = 9;
            this.btnAnasayfa.Text = "Anasayfaya Dön";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // txtMTel
            // 
            this.txtMTel.Location = new System.Drawing.Point(100, 72);
            this.txtMTel.Name = "txtMTel";
            this.txtMTel.Size = new System.Drawing.Size(250, 20);
            this.txtMTel.TabIndex = 11;
            // 
            // txtMAd
            // 
            this.txtMAd.Location = new System.Drawing.Point(100, 17);
            this.txtMAd.Name = "txtMAd";
            this.txtMAd.Size = new System.Drawing.Size(250, 20);
            this.txtMAd.TabIndex = 12;
            // 
            // txtMSoyad
            // 
            this.txtMSoyad.Location = new System.Drawing.Point(100, 43);
            this.txtMSoyad.Name = "txtMSoyad";
            this.txtMSoyad.Size = new System.Drawing.Size(250, 20);
            this.txtMSoyad.TabIndex = 13;
            // 
            // txtMEposta
            // 
            this.txtMEposta.Location = new System.Drawing.Point(100, 98);
            this.txtMEposta.Name = "txtMEposta";
            this.txtMEposta.Size = new System.Drawing.Size(250, 20);
            this.txtMEposta.TabIndex = 14;
            // 
            // lblMCins
            // 
            this.lblMCins.AutoSize = true;
            this.lblMCins.Location = new System.Drawing.Point(47, 135);
            this.lblMCins.Name = "lblMCins";
            this.lblMCins.Size = new System.Drawing.Size(46, 13);
            this.lblMCins.TabIndex = 18;
            this.lblMCins.Text = "Cinsiyet:";
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbCinsiyet.Location = new System.Drawing.Point(100, 127);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(250, 21);
            this.cbCinsiyet.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(263, 154);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 23);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Formu Temizle";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // musteriislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 394);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbCinsiyet);
            this.Controls.Add(this.lblMCins);
            this.Controls.Add(this.txtMEposta);
            this.Controls.Add(this.txtMSoyad);
            this.Controls.Add(this.txtMAd);
            this.Controls.Add(this.txtMTel);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.lblMEposta);
            this.Controls.Add(this.lblMTel);
            this.Controls.Add(this.lblMSoyad);
            this.Controls.Add(this.lblMAd);
            this.Controls.Add(this.dgvMusteri);
            this.Name = "musteriislemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AKDERE OTOMOTİV | Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.musteriislemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteri;
        private System.Windows.Forms.Label lblMAd;
        private System.Windows.Forms.Label lblMSoyad;
        private System.Windows.Forms.Label lblMTel;
        private System.Windows.Forms.Label lblMEposta;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.TextBox txtMTel;
        private System.Windows.Forms.TextBox txtMAd;
        private System.Windows.Forms.TextBox txtMSoyad;
        private System.Windows.Forms.TextBox txtMEposta;
        private System.Windows.Forms.Label lblMCins;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.Button btnReset;
    }
}