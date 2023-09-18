using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTiga3
{
    public partial class frmLatihanTiga3 : Form
    {
        public frmLatihanTiga3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = textNama.Text;
            var pendidikan =comboPendidikan.Text;
            var pekerjaan = listPekerjaan.Text;

            Pesan1.Text = string.Format("Halo {0}", nama);
            Pesan2.Text = string.Format("Pendidikan Anda {0}", pendidikan);
            Pesan3.Text = string.Format("Anda seorang {0} Anda Keren !!!!", pekerjaan);
        }

        private void txtPesan1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLatihanTiga3_Load(object sender, EventArgs e)
        {

        }
    }
}
