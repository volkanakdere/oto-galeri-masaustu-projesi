
namespace OtoGaleriOtomasyonu.WindowsFormUI.Views.Kullanici
{
    partial class Login
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
            this.lblEposta = new System.Windows.Forms.Label();
            this.tbxEposta = new System.Windows.Forms.TextBox();
            this.tbxParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(118, 96);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(50, 13);
            this.lblEposta.TabIndex = 0;
            this.lblEposta.Text = "E-Posta :";
            // 
            // tbxEposta
            // 
            this.tbxEposta.Location = new System.Drawing.Point(174, 93);
            this.tbxEposta.Name = "tbxEposta";
            this.tbxEposta.Size = new System.Drawing.Size(232, 20);
            this.tbxEposta.TabIndex = 1;
            // 
            // tbxParola
            // 
            this.tbxParola.Location = new System.Drawing.Point(174, 130);
            this.tbxParola.Name = "tbxParola";
            this.tbxParola.Size = new System.Drawing.Size(232, 20);
            this.tbxParola.TabIndex = 3;
            this.tbxParola.UseSystemPasswordChar = true;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(118, 133);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(43, 13);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parola :";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(331, 156);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(75, 23);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 233);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.tbxParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.tbxEposta);
            this.Controls.Add(this.lblEposta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.TextBox tbxEposta;
        private System.Windows.Forms.TextBox tbxParola;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Button btnGirisYap;
    }
}