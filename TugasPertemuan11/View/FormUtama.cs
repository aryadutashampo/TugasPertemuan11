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

namespace TugasPertemuan11
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }
        //Perpindahan Form
        private void btnMPL_Click(object sender, EventArgs e)
        {
            Form_Pelatihan fpl = new Form_Pelatihan();
            fpl.Show();
            this.Hide();
        }

        private void btnMPS_Click(object sender, EventArgs e)
        {
            Form_Peserta fps = new Form_Peserta();
            fps.Show();
            this.Hide();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            Form_Sertifikat fs = new Form_Sertifikat();
            fs.Show();
            this.Hide();
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            Form_Registrasi freg = new Form_Registrasi();
            freg.Show();
            this.Hide();
        }

    }
}
