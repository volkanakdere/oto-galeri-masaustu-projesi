
namespace OtoGaleriOtomasyonu.WindowsFormUI.Views.Kullanici
{
    partial class aracislemleri
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
            this.btneklesil = new System.Windows.Forms.Button();
            this.btnTumArac = new System.Windows.Forms.Button();
            this.btnAnasayfaD = new System.Windows.Forms.Button();
            this.btnAracislemListele = new System.Windows.Forms.Button();
            this.txtAracislemRuhsatNo = new System.Windows.Forms.TextBox();
            this.cbVasitaTurleri = new System.Windows.Forms.ComboBox();
            this.lblAracislemTipi = new System.Windows.Forms.Label();
            this.lblAracislemMarka = new System.Windows.Forms.Label();
            this.lblAracislemModel = new System.Windows.Forms.Label();
            this.lblAracislemRuhsatNo = new System.Windows.Forms.Label();
            this.txtAracislemPlaka = new System.Windows.Forms.TextBox();
            this.lblAracislemPlaka = new System.Windows.Forms.Label();
            this.cbAracislemleriMarka = new System.Windows.Forms.ComboBox();
            this.cbAracislemleriModel = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // btneklesil
            // 
            this.btneklesil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btneklesil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneklesil.Location = new System.Drawing.Point(501, 63);
            this.btneklesil.Name = "btneklesil";
            this.btneklesil.Size = new System.Drawing.Size(167, 61);
            this.btneklesil.TabIndex = 1;
            this.btneklesil.Text = "Araç Ekle - Araç Sil - Araç Güncelle";
            this.btneklesil.UseVisualStyleBackColor = true;
            this.btneklesil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTumArac
            // 
            this.btnTumArac.Location = new System.Drawing.Point(12, 199);
            this.btnTumArac.Name = "btnTumArac";
            this.btnTumArac.Size = new System.Drawing.Size(207, 45);
            this.btnTumArac.TabIndex = 4;
            this.btnTumArac.Text = "Tüm Araçları Göster";
            this.btnTumArac.UseVisualStyleBackColor = true;
            this.btnTumArac.Click += new System.EventHandler(this.btnTumArac_Click);
            // 
            // btnAnasayfaD
            // 
            this.btnAnasayfaD.Location = new System.Drawing.Point(501, 12);
            this.btnAnasayfaD.Name = "btnAnasayfaD";
            this.btnAnasayfaD.Size = new System.Drawing.Size(167, 45);
            this.btnAnasayfaD.TabIndex = 6;
            this.btnAnasayfaD.Text = "Anasayfaya Dön";
            this.btnAnasayfaD.UseVisualStyleBackColor = true;
            this.btnAnasayfaD.Click += new System.EventHandler(this.btnAnasayfaD_Click);
            // 
            // btnAracislemListele
            // 
            this.btnAracislemListele.Location = new System.Drawing.Point(202, 20);
            this.btnAracislemListele.Name = "btnAracislemListele";
            this.btnAracislemListele.Size = new System.Drawing.Size(121, 73);
            this.btnAracislemListele.TabIndex = 7;
            this.btnAracislemListele.Text = "Araç Listele";
            this.btnAracislemListele.UseVisualStyleBackColor = true;
            this.btnAracislemListele.Click += new System.EventHandler(this.btnAracislemListele_Click);
            // 
            // txtAracislemRuhsatNo
            // 
            this.txtAracislemRuhsatNo.Location = new System.Drawing.Point(103, 139);
            this.txtAracislemRuhsatNo.Name = "txtAracislemRuhsatNo";
            this.txtAracislemRuhsatNo.Size = new System.Drawing.Size(121, 20);
            this.txtAracislemRuhsatNo.TabIndex = 9;
            // 
            // cbVasitaTurleri
            // 
            this.cbVasitaTurleri.FormattingEnabled = true;
            this.cbVasitaTurleri.Location = new System.Drawing.Point(75, 20);
            this.cbVasitaTurleri.Name = "cbVasitaTurleri";
            this.cbVasitaTurleri.Size = new System.Drawing.Size(121, 21);
            this.cbVasitaTurleri.TabIndex = 11;
            // 
            // lblAracislemTipi
            // 
            this.lblAracislemTipi.AutoSize = true;
            this.lblAracislemTipi.Location = new System.Drawing.Point(9, 28);
            this.lblAracislemTipi.Name = "lblAracislemTipi";
            this.lblAracislemTipi.Size = new System.Drawing.Size(52, 13);
            this.lblAracislemTipi.TabIndex = 12;
            this.lblAracislemTipi.Text = "Araç Tipi:";
            // 
            // lblAracislemMarka
            // 
            this.lblAracislemMarka.AutoSize = true;
            this.lblAracislemMarka.Location = new System.Drawing.Point(21, 54);
            this.lblAracislemMarka.Name = "lblAracislemMarka";
            this.lblAracislemMarka.Size = new System.Drawing.Size(40, 13);
            this.lblAracislemMarka.TabIndex = 13;
            this.lblAracislemMarka.Text = "Marka:";
            // 
            // lblAracislemModel
            // 
            this.lblAracislemModel.AutoSize = true;
            this.lblAracislemModel.Location = new System.Drawing.Point(22, 76);
            this.lblAracislemModel.Name = "lblAracislemModel";
            this.lblAracislemModel.Size = new System.Drawing.Size(39, 13);
            this.lblAracislemModel.TabIndex = 14;
            this.lblAracislemModel.Text = "Model:";
            // 
            // lblAracislemRuhsatNo
            // 
            this.lblAracislemRuhsatNo.AutoSize = true;
            this.lblAracislemRuhsatNo.Location = new System.Drawing.Point(28, 146);
            this.lblAracislemRuhsatNo.Name = "lblAracislemRuhsatNo";
            this.lblAracislemRuhsatNo.Size = new System.Drawing.Size(61, 13);
            this.lblAracislemRuhsatNo.TabIndex = 15;
            this.lblAracislemRuhsatNo.Text = "Ruhsat No:";
            // 
            // txtAracislemPlaka
            // 
            this.txtAracislemPlaka.Location = new System.Drawing.Point(103, 165);
            this.txtAracislemPlaka.Name = "txtAracislemPlaka";
            this.txtAracislemPlaka.Size = new System.Drawing.Size(121, 20);
            this.txtAracislemPlaka.TabIndex = 16;
            // 
            // lblAracislemPlaka
            // 
            this.lblAracislemPlaka.AutoSize = true;
            this.lblAracislemPlaka.Location = new System.Drawing.Point(52, 172);
            this.lblAracislemPlaka.Name = "lblAracislemPlaka";
            this.lblAracislemPlaka.Size = new System.Drawing.Size(37, 13);
            this.lblAracislemPlaka.TabIndex = 18;
            this.lblAracislemPlaka.Text = "Plaka:";
            // 
            // cbAracislemleriMarka
            // 
            this.cbAracislemleriMarka.FormattingEnabled = true;
            this.cbAracislemleriMarka.Location = new System.Drawing.Point(75, 46);
            this.cbAracislemleriMarka.Name = "cbAracislemleriMarka";
            this.cbAracislemleriMarka.Size = new System.Drawing.Size(121, 21);
            this.cbAracislemleriMarka.TabIndex = 19;
            this.cbAracislemleriMarka.SelectedIndexChanged += new System.EventHandler(this.cbAracislemleriMarka_SelectedIndexChanged);
            // 
            // cbAracislemleriModel
            // 
            this.cbAracislemleriModel.FormattingEnabled = true;
            this.cbAracislemleriModel.Location = new System.Drawing.Point(75, 72);
            this.cbAracislemleriModel.Name = "cbAracislemleriModel";
            this.cbAracislemleriModel.Size = new System.Drawing.Size(121, 21);
            this.cbAracislemleriModel.TabIndex = 20;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(230, 139);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 46);
            this.btnAra.TabIndex = 21;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // aracislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(680, 432);
            this.ControlBox = false;
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cbAracislemleriModel);
            this.Controls.Add(this.cbAracislemleriMarka);
            this.Controls.Add(this.lblAracislemPlaka);
            this.Controls.Add(this.txtAracislemPlaka);
            this.Controls.Add(this.lblAracislemRuhsatNo);
            this.Controls.Add(this.lblAracislemModel);
            this.Controls.Add(this.lblAracislemMarka);
            this.Controls.Add(this.lblAracislemTipi);
            this.Controls.Add(this.cbVasitaTurleri);
            this.Controls.Add(this.txtAracislemRuhsatNo);
            this.Controls.Add(this.btnAracislemListele);
            this.Controls.Add(this.btnAnasayfaD);
            this.Controls.Add(this.btnTumArac);
            this.Controls.Add(this.btneklesil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "aracislemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AKDERE OTOMOTİV | ARAÇ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.aracislemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btneklesil;
        private System.Windows.Forms.Button btnTumArac;
        private System.Windows.Forms.Button btnAnasayfaD;
        private System.Windows.Forms.Button btnAracislemListele;
        private System.Windows.Forms.TextBox txtAracislemRuhsatNo;
        private System.Windows.Forms.ComboBox cbVasitaTurleri;
        private System.Windows.Forms.Label lblAracislemTipi;
        private System.Windows.Forms.Label lblAracislemMarka;
        private System.Windows.Forms.Label lblAracislemModel;
        private System.Windows.Forms.Label lblAracislemRuhsatNo;
        private System.Windows.Forms.TextBox txtAracislemPlaka;
        private System.Windows.Forms.Label lblAracislemPlaka;
        private System.Windows.Forms.ComboBox cbAracislemleriMarka;
        private System.Windows.Forms.ComboBox cbAracislemleriModel;
        private System.Windows.Forms.Button btnAra;
    }
}