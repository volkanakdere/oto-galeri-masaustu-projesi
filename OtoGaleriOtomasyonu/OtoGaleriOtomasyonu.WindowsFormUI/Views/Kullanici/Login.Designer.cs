
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblEposta = new System.Windows.Forms.Label();
            this.tbxEposta = new System.Windows.Forms.TextBox();
            this.tbxParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEposta
            // 
            resources.ApplyResources(this.lblEposta, "lblEposta");
            this.lblEposta.Name = "lblEposta";
            // 
            // tbxEposta
            // 
            this.tbxEposta.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.tbxEposta, "tbxEposta");
            this.tbxEposta.Name = "tbxEposta";
            // 
            // tbxParola
            // 
            this.tbxParola.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.tbxParola, "tbxParola");
            this.tbxParola.Name = "tbxParola";
            this.tbxParola.UseSystemPasswordChar = true;
            // 
            // lblParola
            // 
            resources.ApplyResources(this.lblParola, "lblParola");
            this.lblParola.Name = "lblParola";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.btnGirisYap, "btnGirisYap");
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnGirisYap;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.tbxParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.tbxEposta);
            this.Controls.Add(this.lblEposta);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.TopMost = true;
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