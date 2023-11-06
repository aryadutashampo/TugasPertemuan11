using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan11.Model;


namespace TugasPertemuan11.Controller
{
    internal class SertifikatController : Model.Connection
    {
        Connection Koneksi = new Connection();
        public DataTable tampilSertifikat()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM sertifikat";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public DataTable searchSertifikat(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                    ("SELECT * FROM Sertifikat WHERE CONCAT(id,nama_sertifikat,deskripsi,pelatihan_id)LIKE '%" + search + "%'", Koneksi.GetConn());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }


        public void tambahSertifikat(string idsertifikat, string namasertifikat,string deskripsi,  string idpelatihan2)
        {
            string tambah = "INSERT INTO sertifikat VALUES(" + "@id,@nama_sertifikat,@deskripsi,@pelatihan_id)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idsertifikat;
                cmd.Parameters.Add("@nama_sertifikat", MySqlConnector.MySqlDbType.VarChar).Value = namasertifikat;
                cmd.Parameters.Add("@deskripsi", MySqlConnector.MySqlDbType.VarChar).Value = deskripsi;
                cmd.Parameters.Add("@pelatihan_id", MySqlConnector.MySqlDbType.VarChar).Value = idpelatihan2;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data Sertifikat gagal" + ex.Message);
            }
        }
    }
}
