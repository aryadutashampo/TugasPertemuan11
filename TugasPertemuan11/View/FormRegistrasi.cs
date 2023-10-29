﻿using TugasPertemuan11.Controller;
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
    public partial class Form_Registrasi : Form
    {
        private RegistrasiController regCtrl;
        public Form_Registrasi()
        {
            regCtrl = new RegistrasiController();
            InitializeComponent();
        }

        private void Form_Registrasi_Load(object sender, EventArgs e)
        {
            //Validasi Batas Inputan
            txtIDREG.MaxLength = 11;
            txtIDPSREG.MaxLength = 11;
            txtIDPLREG.MaxLength = 11;
            tampilRegistrasi();
        }

        public void tampilRegistrasi()
        {
            dataGridViewREG.DataSource = regCtrl.tampilRegistrasi();
            dataGridViewREG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        //Button Add
        private void btnADDREG_Click(object sender, EventArgs e)
        {
            regCtrl = new RegistrasiController();
            regCtrl.tambahRegistrasi(txtIDREG.Text,txtIDPSREG.Text,txtIDPLREG.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIDREG.Focus();
            MessageBox.Show("Data Registrasi disimpan");

            Form_Registrasi fr = new Form_Registrasi();
            fr.Show();
            this.Hide();
        }
        //Button Clear
        private void btnCLEARREG_Click(object sender, EventArgs e)
        {
            txtIDREG.Clear();
            txtIDPSREG.Clear();
            txtIDPLREG.Clear();
        }
        //Button Cancel
        private void btnCCREG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kembali ke Halaman Utama");
            FormUtama FU = new FormUtama();
            FU.Show();
            this.Hide();
        }
        //Validasi Inputan
        private void txtIDREG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtIDPSREG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtIDPLREG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        bool verify()
        {
            if (txtIDREG.Text == "" || txtIDPSREG.Text == "" || txtIDPLREG.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
