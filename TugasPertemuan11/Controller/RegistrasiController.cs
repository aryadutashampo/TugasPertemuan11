using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPertemuan11.Controller
{
    internal class RegistrasiController : Model.Connection
    {
        public DataTable tampilRegistrasi()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM registrasi";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void tambahRegistrasi(string idregistrasi, string idpeserta, string idpelatihan)
        {
            string tambah = "INSERT INTO registrasi VALUES(" + "@id,@peserta_id,@pelatihan_id)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idregistrasi;
                cmd.Parameters.Add("@peserta_id", MySqlConnector.MySqlDbType.VarChar).Value = idpeserta;
                cmd.Parameters.Add("@pelatihan_id", MySqlConnector.MySqlDbType.VarChar).Value = idpelatihan;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data registrasi gagal" + ex.Message);
            }
        }
    }
}
