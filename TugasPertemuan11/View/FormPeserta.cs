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
using System.Drawing.Printing;

namespace TugasPertemuan11.View
{
    public partial class Form_Peserta : Form
    {
        Validation val = new Validation();
        private PesertaController psCtrl;   
        public Form_Peserta()
        {
            psCtrl = new PesertaController();
            InitializeComponent();
        }

        private void Form_Peserta_Load(object sender, EventArgs e)
        {
            txtIDPSPS.MaxLength = 11;
            txtNAMAPS.MaxLength = 255;
            txtEMAILPS.MaxLength = 255;
            txtNTPS.MaxLength = 15;
            ShowTable();
        }

        private void btnADDPS_Click(object sender, EventArgs e)
        {
            if(val.valName(txtNAMAPS.Text) && val.valEmail(txtEMAILPS.Text))
            {
                try
                {
                    psCtrl = new PesertaController();
                    psCtrl.tambahPeserta(txtIDPSPS.Text, txtNAMAPS.Text, txtEMAILPS.Text, txtNTPS.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txtIDPSPS.Focus();
                    MessageBox.Show("Data Registrasi disimpan");

                    Form_Peserta fps = new Form_Peserta();
                    fps.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnREADPS_Click(object sender, EventArgs e)
        {
            dataGridViewPS.DataSource = psCtrl.tampilPeserta();
            dataGridViewPS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void ShowTable()
        {
            dataGridViewPS.DataSource = psCtrl.SelectPeserta(new MySqlConnector.MySqlCommand("SELECT * FROM peserta"));
        }

        private void btnUPDPS_Click(object sender, EventArgs e)
        {
            if (val.valName(txtNAMAPS.Text) && val.valEmail(txtEMAILPS.Text))
            {
                try
                {
                    psCtrl = new PesertaController();
                    psCtrl.updatePeserta(txtIDPSPS.Text, txtNAMAPS.Text, txtEMAILPS.Text, txtNTPS.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txtNAMAPS.Focus();
                    MessageBox.Show("Data Peserta diupdate");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void btnDELPS_Click(object sender, EventArgs e)
        {
            if(verifyDel())
            {
                
                try
                {
                    psCtrl.hapusPeserta(txtIDPSPS.Text);
                    MessageBox.Show("Data Peserta Berhasil Dihapus", "Hapus Data Peserta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDPSPS.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Data Peserta gagal dihapus", "Hapus Data Peserta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form_Peserta fps = new Form_Peserta();
            fps.Show();
            this.Hide();
        }

        private void btnCLEARPS_Click(object sender, EventArgs e)
        {
            txtIDPSPS.Clear();
            txtNAMAPS.Clear();
            txtEMAILPS.Clear();
            txtNTPS.Clear();
        }

        private void btnCCPS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kembali ke Halaman Utama");
            FormUtama FU = new FormUtama();
            FU.Show();
            this.Hide();
        }

        bool verify()
        {
            if (txtIDPSPS.Text == "" || txtNAMAPS.Text == "" || txtEMAILPS.Text == "" || txtNTPS.Text == "")
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
            if (txtIDPSPS.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtIDPSPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtNAMAPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtEMAILPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtNTPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void btnSearchPS_Click(object sender, EventArgs e)
        {
            dataGridViewPS.DataSource = psCtrl.searchPeserta(txtCPS.Text);
            dataGridViewPS.RowTemplate.Height = 80;
        }

        private void printDocumentPS_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.dataGridViewPS.Width, this.dataGridViewPS.Height);
            dataGridViewPS.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridViewPS.Width, this.dataGridViewPS.Height));
            e.Graphics.DrawImage(btm, 100, 100);
            e.Graphics.DrawString(labelPPS.Text, new Font("Consolas", 23, FontStyle.Bold), Brushes.Black, new Point(310, 50));
        }

        private void btnPrintPS_Click(object sender, EventArgs e)
        {
            printPreviewDialogPS.Document = printDocumentPS;
            printPreviewDialogPS.ShowDialog();
        }
    }
}
