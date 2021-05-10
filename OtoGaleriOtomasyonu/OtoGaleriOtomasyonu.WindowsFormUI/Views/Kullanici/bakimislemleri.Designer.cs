
namespace OtoGaleriOtomasyonu.WindowsFormUI.Views.Kullanici
{
    partial class bakimislemleri
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
            this.dgvbakim = new System.Windows.Forms.DataGridView();
            this.btnBakimTarihi = new System.Windows.Forms.Button();
            this.btnMuayeneTarihi = new System.Windows.Forms.Button();
            this.btnBakimTarGuncelle = new System.Windows.Forms.Button();
            this.btnMuayeneTarGuncelle = new System.Windows.Forms.Button();
            this.btnAnasayfaD = new System.Windows.Forms.Button();
            this.txtBakimRuhsatNo = new System.Windows.Forms.TextBox();
            this.txtBakimPlaka = new System.Windows.Forms.TextBox();
            this.dateTimeBakim = new System.Windows.Forms.DateTimePicker();
            this.lblBakimRuhsatNo = new System.Windows.Forms.Label();
            this.lblBakimPlaka = new System.Windows.Forms.Label();
            this.lblBakimTar = new System.Windows.Forms.Label();
            this.pictureBakim = new System.Windows.Forms.PictureBox();
            this.lblMuayeneTar = new System.Windows.Forms.Label();
            this.dateTimeMuayene = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbakim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBakim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbakim
            // 
            this.dgvbakim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbakim.Location = new System.Drawing.Point(3, 248);
            this.dgvbakim.Name = "dgvbakim";
            this.dgvbakim.Size = new System.Drawing.Size(669, 205);
            this.dgvbakim.TabIndex = 0;
            // 
            // btnBakimTarihi
            // 
            this.btnBakimTarihi.Location = new System.Drawing.Point(3, 192);
            this.btnBakimTarihi.Name = "btnBakimTarihi";
            this.btnBakimTarihi.Size = new System.Drawing.Size(121, 50);
            this.btnBakimTarihi.TabIndex = 1;
            this.btnBakimTarihi.Text = "Araçların Bakım Tarihlerini Getir";
            this.btnBakimTarihi.UseVisualStyleBackColor = true;
            // 
            // btnMuayeneTarihi
            // 
            this.btnMuayeneTarihi.Location = new System.Drawing.Point(157, 192);
            this.btnMuayeneTarihi.Name = "btnMuayeneTarihi";
            this.btnMuayeneTarihi.Size = new System.Drawing.Size(106, 50);
            this.btnMuayeneTarihi.TabIndex = 2;
            this.btnMuayeneTarihi.Text = "Araçların Muayane Tarihlerini Getir";
            this.btnMuayeneTarihi.UseVisualStyleBackColor = true;
            // 
            // btnBakimTarGuncelle
            // 
            this.btnBakimTarGuncelle.Location = new System.Drawing.Point(294, 192);
            this.btnBakimTarGuncelle.Name = "btnBakimTarGuncelle";
            this.btnBakimTarGuncelle.Size = new System.Drawing.Size(117, 50);
            this.btnBakimTarGuncelle.TabIndex = 3;
            this.btnBakimTarGuncelle.Text = "Bakım Tarihi Güncelle";
            this.btnBakimTarGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnMuayeneTarGuncelle
            // 
            this.btnMuayeneTarGuncelle.Location = new System.Drawing.Point(438, 192);
            this.btnMuayeneTarGuncelle.Name = "btnMuayeneTarGuncelle";
            this.btnMuayeneTarGuncelle.Size = new System.Drawing.Size(108, 50);
            this.btnMuayeneTarGuncelle.TabIndex = 4;
            this.btnMuayeneTarGuncelle.Text = "Muayene Tarihi Güncelle";
            this.btnMuayeneTarGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnAnasayfaD
            // 
            this.btnAnasayfaD.Location = new System.Drawing.Point(564, 192);
            this.btnAnasayfaD.Name = "btnAnasayfaD";
            this.btnAnasayfaD.Size = new System.Drawing.Size(92, 50);
            this.btnAnasayfaD.TabIndex = 5;
            this.btnAnasayfaD.Text = "Anasayfaya Dön";
            this.btnAnasayfaD.UseVisualStyleBackColor = true;
            this.btnAnasayfaD.Click += new System.EventHandler(this.btnAnasayfaD_Click);
            // 
            // txtBakimRuhsatNo
            // 
            this.txtBakimRuhsatNo.Location = new System.Drawing.Point(105, 12);
            this.txtBakimRuhsatNo.Name = "txtBakimRuhsatNo";
            this.txtBakimRuhsatNo.Size = new System.Drawing.Size(100, 20);
            this.txtBakimRuhsatNo.TabIndex = 6;
            // 
            // txtBakimPlaka
            // 
            this.txtBakimPlaka.Location = new System.Drawing.Point(105, 38);
            this.txtBakimPlaka.Name = "txtBakimPlaka";
            this.txtBakimPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtBakimPlaka.TabIndex = 7;
            // 
            // dateTimeBakim
            // 
            this.dateTimeBakim.Location = new System.Drawing.Point(105, 68);
            this.dateTimeBakim.Name = "dateTimeBakim";
            this.dateTimeBakim.Size = new System.Drawing.Size(200, 20);
            this.dateTimeBakim.TabIndex = 8;
            // 
            // lblBakimRuhsatNo
            // 
            this.lblBakimRuhsatNo.AutoSize = true;
            this.lblBakimRuhsatNo.Location = new System.Drawing.Point(13, 19);
            this.lblBakimRuhsatNo.Name = "lblBakimRuhsatNo";
            this.lblBakimRuhsatNo.Size = new System.Drawing.Size(86, 13);
            this.lblBakimRuhsatNo.TabIndex = 9;
            this.lblBakimRuhsatNo.Text = "Araç Ruhsat No:";
            // 
            // lblBakimPlaka
            // 
            this.lblBakimPlaka.AutoSize = true;
            this.lblBakimPlaka.Location = new System.Drawing.Point(30, 45);
            this.lblBakimPlaka.Name = "lblBakimPlaka";
            this.lblBakimPlaka.Size = new System.Drawing.Size(69, 13);
            this.lblBakimPlaka.TabIndex = 10;
            this.lblBakimPlaka.Text = "Araç Plakası:";
            // 
            // lblBakimTar
            // 
            this.lblBakimTar.AutoSize = true;
            this.lblBakimTar.Location = new System.Drawing.Point(30, 74);
            this.lblBakimTar.Name = "lblBakimTar";
            this.lblBakimTar.Size = new System.Drawing.Size(68, 13);
            this.lblBakimTar.TabIndex = 11;
            this.lblBakimTar.Text = "Bakım Tarihi:";
            // 
            // pictureBakim
            // 
            this.pictureBakim.Location = new System.Drawing.Point(402, 8);
            this.pictureBakim.Name = "pictureBakim";
            this.pictureBakim.Size = new System.Drawing.Size(237, 149);
            this.pictureBakim.TabIndex = 12;
            this.pictureBakim.TabStop = false;
            // 
            // lblMuayeneTar
            // 
            this.lblMuayeneTar.AutoSize = true;
            this.lblMuayeneTar.Location = new System.Drawing.Point(16, 103);
            this.lblMuayeneTar.Name = "lblMuayeneTar";
            this.lblMuayeneTar.Size = new System.Drawing.Size(83, 13);
            this.lblMuayeneTar.TabIndex = 13;
            this.lblMuayeneTar.Text = "Muayene Tarihi:";
            // 
            // dateTimeMuayene
            // 
            this.dateTimeMuayene.Location = new System.Drawing.Point(105, 97);
            this.dateTimeMuayene.Name = "dateTimeMuayene";
            this.dateTimeMuayene.Size = new System.Drawing.Size(200, 20);
            this.dateTimeMuayene.TabIndex = 14;
            // 
            // bakimislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimeMuayene);
            this.Controls.Add(this.lblMuayeneTar);
            this.Controls.Add(this.pictureBakim);
            this.Controls.Add(this.lblBakimTar);
            this.Controls.Add(this.lblBakimPlaka);
            this.Controls.Add(this.lblBakimRuhsatNo);
            this.Controls.Add(this.dateTimeBakim);
            this.Controls.Add(this.txtBakimPlaka);
            this.Controls.Add(this.txtBakimRuhsatNo);
            this.Controls.Add(this.btnAnasayfaD);
            this.Controls.Add(this.btnMuayeneTarGuncelle);
            this.Controls.Add(this.btnBakimTarGuncelle);
            this.Controls.Add(this.btnMuayeneTarihi);
            this.Controls.Add(this.btnBakimTarihi);
            this.Controls.Add(this.dgvbakim);
            this.Name = "bakimislemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AKDERE OTOMOTİV | Bakım İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvbakim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBakim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbakim;
        private System.Windows.Forms.Button btnBakimTarihi;
        private System.Windows.Forms.Button btnMuayeneTarihi;
        private System.Windows.Forms.Button btnBakimTarGuncelle;
        private System.Windows.Forms.Button btnMuayeneTarGuncelle;
        private System.Windows.Forms.Button btnAnasayfaD;
        private System.Windows.Forms.TextBox txtBakimRuhsatNo;
        private System.Windows.Forms.TextBox txtBakimPlaka;
        private System.Windows.Forms.DateTimePicker dateTimeBakim;
        private System.Windows.Forms.Label lblBakimRuhsatNo;
        private System.Windows.Forms.Label lblBakimPlaka;
        private System.Windows.Forms.Label lblBakimTar;
        private System.Windows.Forms.PictureBox pictureBakim;
        private System.Windows.Forms.Label lblMuayeneTar;
        private System.Windows.Forms.DateTimePicker dateTimeMuayene;
    }
}