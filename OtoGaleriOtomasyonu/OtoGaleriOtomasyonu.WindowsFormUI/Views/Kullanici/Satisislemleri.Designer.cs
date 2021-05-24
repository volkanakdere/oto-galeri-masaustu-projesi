
namespace OtoGaleriOtomasyonu.WindowsFormUI.Views.Kullanici
{
    partial class satisislemleri
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
            this.lblAracNo = new System.Windows.Forms.Label();
            this.lblMNo = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.btnSatisaHazir = new System.Windows.Forms.Button();
            this.btnSat = new System.Windows.Forms.Button();
            this.btnAnasayfaD = new System.Windows.Forms.Button();
            this.dgvSatis = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cbMusteriler = new System.Windows.Forms.ComboBox();
            this.cbAraclar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAracNo
            // 
            this.lblAracNo.AutoSize = true;
            this.lblAracNo.Location = new System.Drawing.Point(24, 16);
            this.lblAracNo.Name = "lblAracNo";
            this.lblAracNo.Size = new System.Drawing.Size(54, 13);
            this.lblAracNo.TabIndex = 0;
            this.lblAracNo.Text = "Araç Seç:";
            // 
            // lblMNo
            // 
            this.lblMNo.AutoSize = true;
            this.lblMNo.Location = new System.Drawing.Point(12, 47);
            this.lblMNo.Name = "lblMNo";
            this.lblMNo.Size = new System.Drawing.Size(66, 13);
            this.lblMNo.TabIndex = 1;
            this.lblMNo.Text = "Müşteri Seç:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(13, 69);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(60, 13);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "Satış Fiyatı:";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(88, 66);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(228, 20);
            this.txtSatisFiyati.TabIndex = 6;
            // 
            // btnSatisaHazir
            // 
            this.btnSatisaHazir.Location = new System.Drawing.Point(409, 1);
            this.btnSatisaHazir.Name = "btnSatisaHazir";
            this.btnSatisaHazir.Size = new System.Drawing.Size(103, 93);
            this.btnSatisaHazir.TabIndex = 8;
            this.btnSatisaHazir.Text = "Satışa Hazır Araçları Göster";
            this.btnSatisaHazir.UseVisualStyleBackColor = true;
            this.btnSatisaHazir.Click += new System.EventHandler(this.btnSatisaHazir_Click);
            // 
            // btnSat
            // 
            this.btnSat.Location = new System.Drawing.Point(88, 92);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(154, 27);
            this.btnSat.TabIndex = 9;
            this.btnSat.Text = "Araç Sat";
            this.btnSat.UseVisualStyleBackColor = true;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // btnAnasayfaD
            // 
            this.btnAnasayfaD.Location = new System.Drawing.Point(409, 100);
            this.btnAnasayfaD.Name = "btnAnasayfaD";
            this.btnAnasayfaD.Size = new System.Drawing.Size(212, 42);
            this.btnAnasayfaD.TabIndex = 10;
            this.btnAnasayfaD.Text = "Anasayfaya Dön";
            this.btnAnasayfaD.UseVisualStyleBackColor = true;
            this.btnAnasayfaD.Click += new System.EventHandler(this.btnAnasayfaD_Click);
            // 
            // dgvSatis
            // 
            this.dgvSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatis.Location = new System.Drawing.Point(-5, 148);
            this.dgvSatis.Name = "dgvSatis";
            this.dgvSatis.Size = new System.Drawing.Size(626, 245);
            this.dgvSatis.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 93);
            this.button1.TabIndex = 15;
            this.button1.Text = "Satılan Araçları Göster";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbMusteriler
            // 
            this.cbMusteriler.FormattingEnabled = true;
            this.cbMusteriler.Location = new System.Drawing.Point(88, 39);
            this.cbMusteriler.Name = "cbMusteriler";
            this.cbMusteriler.Size = new System.Drawing.Size(228, 21);
            this.cbMusteriler.TabIndex = 16;
            // 
            // cbAraclar
            // 
            this.cbAraclar.FormattingEnabled = true;
            this.cbAraclar.Location = new System.Drawing.Point(88, 12);
            this.cbAraclar.Name = "cbAraclar";
            this.cbAraclar.Size = new System.Drawing.Size(228, 21);
            this.cbAraclar.TabIndex = 17;
            this.cbAraclar.SelectionChangeCommitted += new System.EventHandler(this.cbAraclar_SelectionChangeCommitted);
            // 
            // satisislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 397);
            this.ControlBox = false;
            this.Controls.Add(this.cbAraclar);
            this.Controls.Add(this.cbMusteriler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSatis);
            this.Controls.Add(this.btnAnasayfaD);
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.btnSatisaHazir);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblMNo);
            this.Controls.Add(this.lblAracNo);
            this.Name = "satisislemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AKDERE OTOMOTİV | Satış İşlemleri";
            this.Load += new System.EventHandler(this.satisislemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAracNo;
        private System.Windows.Forms.Label lblMNo;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Button btnSatisaHazir;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.Button btnAnasayfaD;
        private System.Windows.Forms.DataGridView dgvSatis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbMusteriler;
        private System.Windows.Forms.ComboBox cbAraclar;
    }
}