using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleriOtomasyonu.WindowsFormUI.Views.Kullanici
{
    public partial class bakimislemleri : Form
    {
        public bakimislemleri()
        {
            InitializeComponent();
        }

        private void btnAnasayfaD_Click(object sender, EventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
            this.Hide();
        }
    }
}
