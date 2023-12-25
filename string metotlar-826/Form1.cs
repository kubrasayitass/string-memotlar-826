using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_metotlar_826
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToUpper();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToLower();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("toplam karakter" + lblMesaj.Text.Length + "karakter vardır.");
            string mesaj = $"toplam{lblMesaj.Text.Length} karakter vardır.";

            MessageBox.Show(mesaj);
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
           lblMesaj.Text = $"Merhaba Dünya, Ben {txtMesaj.Text}!";
        }
    }
}
