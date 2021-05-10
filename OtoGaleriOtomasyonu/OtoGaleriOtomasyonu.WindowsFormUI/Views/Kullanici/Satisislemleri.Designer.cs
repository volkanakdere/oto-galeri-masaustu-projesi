
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
            this.lblTarih = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSatisaHazir = new System.Windows.Forms.Button();
            this.btnSat = new System.Windows.Forms.Button();
            this.btnAnasayfaD = new System.Windows.Forms.Button();
            this.dgvSatis = new System.Windows.Forms.DataGridView();
            this.dateTimeSatis = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAracNo
            // 
            this.lblAracNo.AutoSize = true;
            this.lblAracNo.Location = new System.Drawing.Point(45, 24);
            this.lblAracNo.Name = "lblAracNo";
            this.lblAracNo.Size = new System.Drawing.Size(49, 13);
            this.lblAracNo.TabIndex = 0;
            this.lblAracNo.Text = "Araç No:";
            // 
            // lblMNo
            // 
            this.lblMNo.AutoSize = true;
            this.lblMNo.Location = new System.Drawing.Point(33, 55);
            this.lblMNo.Name = "lblMNo";
            this.lblMNo.Size = new System.Drawing.Size(61, 13);
            this.lblMNo.TabIndex = 1;
            this.lblMNo.Text = "Müşteri No:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(34, 84);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(60, 13);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "Satış Fiyatı:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(34, 117);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(62, 13);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "Satış Tarihi:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btnSatisaHazir
            // 
            this.btnSatisaHazir.Location = new System.Drawing.Point(446, 100);
            this.btnSatisaHazir.Name = "btnSatisaHazir";
            this.btnSatisaHazir.Size = new System.Drawing.Size(132, 47);
            this.btnSatisaHazir.TabIndex = 8;
            this.btnSatisaHazir.Text = "Satışa Hazır Araçlar";
            this.btnSatisaHazir.UseVisualStyleBackColor = true;
            // 
            // btnSat
            // 
            this.btnSat.Location = new System.Drawing.Point(446, 14);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(132, 80);
            this.btnSat.TabIndex = 9;
            this.btnSat.Text = "Araç Sat";
            this.btnSat.UseVisualStyleBackColor = true;
            // 
            // btnAnasayfaD
            // 
            this.btnAnasayfaD.Location = new System.Drawing.Point(446, 153);
            this.btnAnasayfaD.Name = "btnAnasayfaD";
            this.btnAnasayfaD.Size = new System.Drawing.Size(132, 75);
            this.btnAnasayfaD.TabIndex = 10;
            this.btnAnasayfaD.Text = "Anasayfaya Dön";
            this.btnAnasayfaD.UseVisualStyleBackColor = true;
            this.btnAnasayfaD.Click += new System.EventHandler(this.btnAnasayfaD_Click);
            // 
            // dgvSatis
            // 
            this.dgvSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatis.Location = new System.Drawing.Point(-5, 243);
            this.dgvSatis.Name = "dgvSatis";
            this.dgvSatis.Size = new System.Drawing.Size(626, 150);
            this.dgvSatis.TabIndex = 11;
            // 
            // dateTimeSatis
            // 
            this.dateTimeSatis.Location = new System.Drawing.Point(109, 107);
            this.dateTimeSatis.Name = "dateTimeSatis";
            this.dateTimeSatis.Size = new System.Drawing.Size(169, 20);
            this.dateTimeSatis.TabIndex = 12;
            // 
            // satisislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 397);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimeSatis);
            this.Controls.Add(this.dgvSatis);
            this.Controls.Add(this.btnAnasayfaD);
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.btnSatisaHazir);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblMNo);
            this.Controls.Add(this.lblAracNo);
            this.Name = "satisislemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AKDERE OTOMOTİV | Satış İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAracNo;
        private System.Windows.Forms.Label lblMNo;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSatisaHazir;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.Button btnAnasayfaD;
        private System.Windows.Forms.DataGridView dgvSatis;
        private System.Windows.Forms.DateTimePicker dateTimeSatis;
    }
}