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
    public partial class Form_Pelatihan : Form
    {
        private PelatihanController pltCtrl;
        public Form_Pelatihan()
        {
            pltCtrl = new PelatihanController();
            InitializeComponent();
        }

        private void Form_Pelatihan_Load(object sender, EventArgs e)
        {
            txtIDPL.MaxLength = 11;
            txtNAMAPL.MaxLength = 255;
            txtDESKRIPSIPL.MaxLength = 255;
            txtINSPL.MaxLength = 100;
            txtLOKASIPL.MaxLength = 255;
            txtHargaPL.MaxLength = 10;
            ShowTable();
        }

        public void ShowTable()
        {
            dataGridViewPL.DataSource = pltCtrl.SelectPelatihan(new MySqlConnector.MySqlCommand("SELECT * FROM Pelatihan"));
        }

        bool verify()
        {
            if (txtIDPL.Text == "" || txtNAMAPL.Text == "" || txtDESKRIPSIPL.Text == "" || dateTimePickerPL.Text == "" || txtINSPL.Text == "" || txtLOKASIPL.Text == "" || txtHargaPL.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool verifyDel()
        {
            if (txtIDPL.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCLEARPL_Click_1(object sender, EventArgs e)
        {
            txtIDPL.Clear();
            txtNAMAPL.Clear();
            txtDESKRIPSIPL.Clear();
            dateTimePickerPL.Value = DateTime.Now;
            txtINSPL.Clear();
            txtLOKASIPL.Clear();
            txtHargaPL.Clear();
        }

        private void btnCCPL_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Kembali ke Halaman Utama");
            FormUtama FU = new FormUtama();
            FU.Show();
            this.Hide();
        }

        private void btnADDPL_Click_1(object sender, EventArgs e)
        {
            pltCtrl = new PelatihanController();
            pltCtrl.tambahPelatihan(txtIDPL.Text, txtNAMAPL.Text, txtDESKRIPSIPL.Text, dateTimePickerPL.Value, txtINSPL.Text, txtLOKASIPL.Text, txtHargaPL.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIDPL.Focus();
            MessageBox.Show("Data Pelatihan disimpan");

            Form_Pelatihan fpl = new Form_Pelatihan();
            fpl.Show();
            this.Hide();
        }

        private void btnREADPL_Click_1(object sender, EventArgs e)
        {
            dataGridViewPL.DataSource = pltCtrl.tampilPelatihan();
            dataGridViewPL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUPDPL_Click_1(object sender, EventArgs e)
        {
            pltCtrl = new PelatihanController();
            pltCtrl.updatePelatihan(txtIDPL.Text, txtNAMAPL.Text, txtDESKRIPSIPL.Text, dateTimePickerPL.Value, txtINSPL.Text, txtLOKASIPL.Text, txtHargaPL.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIDPL.Focus();
            MessageBox.Show("Data Pelatihan diupdate");
            Form_Pelatihan fpl = new Form_Pelatihan();
            fpl.Show();
            this.Hide();
        }

        private void btnDELPL_Click_1(object sender, EventArgs e)
        {
            if (verifyDel())
            {

                try
                {
                    pltCtrl.hapusPelatihan(txtIDPL.Text);
                    MessageBox.Show("Data Pelatihan Berhasil Dihapus", "Hapus Data Pelatihan",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDPL.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Data Pelatihan gagal dihapus", "Hapus Data Pelatihan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form_Pelatihan fpl = new Form_Pelatihan();
            fpl.Show();
            this.Hide();
        }

        private void txtIDPL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtNAMAPL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtDESKRIPSIPL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtINSPL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
        //Untuk lokasi hanya divalidasi batas input
        private void txtHargaPL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
