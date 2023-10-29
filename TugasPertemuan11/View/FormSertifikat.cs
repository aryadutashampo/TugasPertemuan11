using TugasPertemuan11.Controller;
using TugasPertemuan11.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TugasPertemuan11.View
{
    public partial class Form_Sertifikat : Form
    {
        private SertifikatController srtCtrl;
        public Form_Sertifikat()
        {
            srtCtrl = new SertifikatController();
            InitializeComponent();
        }



        public void tampilSertifikat()
        {
            dataGridViewS.DataSource = srtCtrl.tampilSertifikat();
            dataGridViewS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

       
        bool verify()
        {
            if (txtIDS.Text == "" || txtNS.Text == "" || txtDS.Text == "" || txtIDPS.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnADDS_Click(object sender, EventArgs e)
        {
            srtCtrl = new SertifikatController();
            srtCtrl.tambahSertifikat(txtIDS.Text, txtNS.Text, txtDS.Text, txtIDPS.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIDS.Focus();
            MessageBox.Show("Data Sertifikat disimpan");

            Form_Sertifikat fs = new Form_Sertifikat();
            fs.Show();
            this.Hide();
        }

        private void btnCLEARS_Click(object sender, EventArgs e)
        {
            txtIDS.Clear();
            txtNS.Clear();
            txtDS.Clear();
            txtIDPS.Clear();
        }

        private void btnCCS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kembali ke Halaman Utama");
            FormUtama FU = new FormUtama();
            FU.Show();
            this.Hide();
        }

        private void txtIDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtIDPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void Form_Sertifikat_Load(object sender, EventArgs e)
        {
            txtIDS.MaxLength = 11;
            txtNS.MaxLength = 255;
            txtDS.MaxLength = 255;
            txtIDPS.MaxLength = 11;
            tampilSertifikat();
        }
    }
}
