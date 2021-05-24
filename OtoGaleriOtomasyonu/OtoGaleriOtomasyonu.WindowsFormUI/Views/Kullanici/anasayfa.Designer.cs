
namespace OtoGaleriOtomasyonu.WindowsFormUI.Views.Kullanici
{
    partial class anasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.btnAracislem = new System.Windows.Forms.Button();
            this.btnMusteris = new System.Windows.Forms.Button();
            this.btnSatisis = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblAnasayfaTarih = new System.Windows.Forms.Label();
            this.lblAnasayfaSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnAracislem
            // 
            this.btnAracislem.Location = new System.Drawing.Point(12, 46);
            this.btnAracislem.Name = "btnAracislem";
            this.btnAracislem.Size = new System.Drawing.Size(277, 46);
            this.btnAracislem.TabIndex = 0;
            this.btnAracislem.Text = "Araç İşlemleri";
            this.btnAracislem.UseVisualStyleBackColor = true;
            this.btnAracislem.Click += new System.EventHandler(this.btnAracislem_Click);
            // 
            // btnMusteris
            // 
            this.btnMusteris.Location = new System.Drawing.Point(12, 98);
            this.btnMusteris.Name = "btnMusteris";
            this.btnMusteris.Size = new System.Drawing.Size(277, 46);
            this.btnMusteris.TabIndex = 1;
            this.btnMusteris.Text = "Müşteri İşlemleri";
            this.btnMusteris.UseVisualStyleBackColor = true;
            this.btnMusteris.Click += new System.EventHandler(this.btnMusteris_Click);
            // 
            // btnSatisis
            // 
            this.btnSatisis.Location = new System.Drawing.Point(12, 150);
            this.btnSatisis.Name = "btnSatisis";
            this.btnSatisis.Size = new System.Drawing.Size(277, 46);
            this.btnSatisis.TabIndex = 2;
            this.btnSatisis.Text = "Satış İşlemleri";
            this.btnSatisis.UseVisualStyleBackColor = true;
            this.btnSatisis.Click += new System.EventHandler(this.btnSatisis_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Location = new System.Drawing.Point(88, 235);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(122, 74);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblAnasayfaTarih
            // 
            this.lblAnasayfaTarih.AutoSize = true;
            this.lblAnasayfaTarih.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAnasayfaTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnasayfaTarih.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAnasayfaTarih.Location = new System.Drawing.Point(325, 27);
            this.lblAnasayfaTarih.Name = "lblAnasayfaTarih";
            this.lblAnasayfaTarih.Size = new System.Drawing.Size(90, 31);
            this.lblAnasayfaTarih.TabIndex = 9;
            this.lblAnasayfaTarih.Text = "Tarih:";
            this.lblAnasayfaTarih.Click += new System.EventHandler(this.lblAnasayfaTarih_Click);
            // 
            // lblAnasayfaSaat
            // 
            this.lblAnasayfaSaat.AutoSize = true;
            this.lblAnasayfaSaat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAnasayfaSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnasayfaSaat.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAnasayfaSaat.Location = new System.Drawing.Point(442, 79);
            this.lblAnasayfaSaat.Name = "lblAnasayfaSaat";
            this.lblAnasayfaSaat.Size = new System.Drawing.Size(83, 31);
            this.lblAnasayfaSaat.TabIndex = 10;
            this.lblAnasayfaSaat.Text = "Saat:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(679, 332);
            this.ControlBox = false;
            this.Controls.Add(this.lblAnasayfaSaat);
            this.Controls.Add(this.lblAnasayfaTarih);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSatisis);
            this.Controls.Add(this.btnMusteris);
            this.Controls.Add(this.btnAracislem);
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AKDERE OTOMOTİV | HOŞGELDİNİZ";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAracislem;
        private System.Windows.Forms.Button btnMusteris;
        private System.Windows.Forms.Button btnSatisis;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblAnasayfaTarih;
        private System.Windows.Forms.Label lblAnasayfaSaat;
        private System.Windows.Forms.Timer timer1;
    }
}