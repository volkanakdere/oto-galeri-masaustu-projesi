
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
            this.btnMusteriGetir = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.txtMTel = new System.Windows.Forms.TextBox();
            this.txtMAd = new System.Windows.Forms.TextBox();
            this.txtMSoyad = new System.Windows.Forms.TextBox();
            this.txtMEposta = new System.Windows.Forms.TextBox();
            this.lblMSattisNo = new System.Windows.Forms.Label();
            this.txtMRuhsatNo = new System.Windows.Forms.TextBox();
            this.lblMCins = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusteri
            // 
            this.dgvMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteri.Location = new System.Drawing.Point(-2, 242);
            this.dgvMusteri.Name = "dgvMusteri";
            this.dgvMusteri.Size = new System.Drawing.Size(620, 154);
            this.dgvMusteri.TabIndex = 0;
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
            this.btnMusteriEkle.Location = new System.Drawing.Point(12, 195);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(125, 41);
            this.btnMusteriEkle.TabIndex = 5;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(143, 195);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(142, 41);
            this.btnMusteriSil.TabIndex = 6;
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(291, 195);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(150, 41);
            this.btnMusteriGuncelle.TabIndex = 7;
            this.btnMusteriGuncelle.Text = "Müşteri Bilgilerini Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnMusteriGetir
            // 
            this.btnMusteriGetir.Location = new System.Drawing.Point(385, 63);
            this.btnMusteriGetir.Name = "btnMusteriGetir";
            this.btnMusteriGetir.Size = new System.Drawing.Size(124, 97);
            this.btnMusteriGetir.TabIndex = 8;
            this.btnMusteriGetir.Text = "Müşteri Bilgilerini Getir";
            this.btnMusteriGetir.UseVisualStyleBackColor = true;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Location = new System.Drawing.Point(447, 195);
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
            this.txtMTel.Size = new System.Drawing.Size(160, 20);
            this.txtMTel.TabIndex = 11;
            // 
            // txtMAd
            // 
            this.txtMAd.Location = new System.Drawing.Point(100, 17);
            this.txtMAd.Name = "txtMAd";
            this.txtMAd.Size = new System.Drawing.Size(160, 20);
            this.txtMAd.TabIndex = 12;
            // 
            // txtMSoyad
            // 
            this.txtMSoyad.Location = new System.Drawing.Point(100, 43);
            this.txtMSoyad.Name = "txtMSoyad";
            this.txtMSoyad.Size = new System.Drawing.Size(160, 20);
            this.txtMSoyad.TabIndex = 13;
            // 
            // txtMEposta
            // 
            this.txtMEposta.Location = new System.Drawing.Point(100, 98);
            this.txtMEposta.Name = "txtMEposta";
            this.txtMEposta.Size = new System.Drawing.Size(160, 20);
            this.txtMEposta.TabIndex = 14;
            // 
            // lblMSattisNo
            // 
            this.lblMSattisNo.AutoSize = true;
            this.lblMSattisNo.Location = new System.Drawing.Point(19, 166);
            this.lblMSattisNo.Name = "lblMSattisNo";
            this.lblMSattisNo.Size = new System.Drawing.Size(75, 13);
            this.lblMSattisNo.TabIndex = 16;
            this.lblMSattisNo.Text = "Araç Satış No:";
            // 
            // txtMRuhsatNo
            // 
            this.txtMRuhsatNo.Location = new System.Drawing.Point(100, 159);
            this.txtMRuhsatNo.Name = "txtMRuhsatNo";
            this.txtMRuhsatNo.Size = new System.Drawing.Size(160, 20);
            this.txtMRuhsatNo.TabIndex = 17;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // musteriislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 394);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMCins);
            this.Controls.Add(this.txtMRuhsatNo);
            this.Controls.Add(this.lblMSattisNo);
            this.Controls.Add(this.txtMEposta);
            this.Controls.Add(this.txtMSoyad);
            this.Controls.Add(this.txtMAd);
            this.Controls.Add(this.txtMTel);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnMusteriGetir);
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
        private System.Windows.Forms.Button btnMusteriGetir;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.TextBox txtMTel;
        private System.Windows.Forms.TextBox txtMAd;
        private System.Windows.Forms.TextBox txtMSoyad;
        private System.Windows.Forms.TextBox txtMEposta;
        private System.Windows.Forms.Label lblMSattisNo;
        private System.Windows.Forms.TextBox txtMRuhsatNo;
        private System.Windows.Forms.Label lblMCins;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}