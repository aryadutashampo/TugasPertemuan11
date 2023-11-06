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
    internal class PelatihanController : Model.Connection
    {
        Connection Koneksi = new Connection();

        public DataTable tampilPelatihan()
        {

            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM Pelatihan";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public DataTable searchPelatihan(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                    ("SELECT * FROM Pelatihan WHERE CONCAT(id,nama_pelatihan,deskripsi,tanggal_mulai," +
                    "instruktur,lokasi,harga)LIKE '%" + search + "%'", Koneksi.GetConn());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }

        public DataTable SelectPelatihan(MySqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM Pelatihan";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }


        public void tambahPelatihan(string idpelatihan, string namapelatihan, string deskripsi, DateTime tanggalmulai, string instruktur, string lokasi, string harga)
        {
            string tambah = "INSERT INTO Pelatihan VALUES(" + "@id,@nama_pelatihan,@deskripsi,@tanggal_mulai,@instruktur,@lokasi,@harga)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpelatihan;
                cmd.Parameters.Add("@nama_pelatihan", MySqlConnector.MySqlDbType.VarChar).Value = namapelatihan;
                cmd.Parameters.Add("@deskripsi", MySqlConnector.MySqlDbType.VarChar).Value = deskripsi;
                cmd.Parameters.Add("@tanggal_mulai", MySqlConnector.MySqlDbType.VarChar).Value = tanggalmulai;
                cmd.Parameters.Add("@instruktur", MySqlConnector.MySqlDbType.VarChar).Value = instruktur;
                cmd.Parameters.Add("@lokasi", MySqlConnector.MySqlDbType.VarChar).Value = lokasi;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.VarChar).Value = harga;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Pelatihan Gagal" + ex.Message);
            }
        }

        public void updatePelatihan(string idpelatihan, string nama_pelatihan, string deskripsi, DateTime tanggal_mulai, string instruktur, string lokasi, string harga)
        {
            string update = "UPDATE Pelatihan set " + "nama_pelatihan=@nama_pelatihan,deskripsi=@deskripsi,tanggal_mulai=@tanggal_mulai,instruktur=@instruktur,lokasi=@lokasi,harga=@harga " + "WHERE id=" + idpelatihan;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpelatihan;
                cmd.Parameters.Add("@nama_pelatihan", MySqlConnector.MySqlDbType.VarChar).Value = nama_pelatihan;
                cmd.Parameters.Add("@deskripsi", MySqlConnector.MySqlDbType.VarChar).Value = deskripsi;
                cmd.Parameters.Add("@tanggal_mulai", MySqlConnector.MySqlDbType.VarChar).Value = tanggal_mulai;
                cmd.Parameters.Add("@instruktur", MySqlConnector.MySqlDbType.VarChar).Value = instruktur;
                cmd.Parameters.Add("@lokasi", MySqlConnector.MySqlDbType.VarChar).Value = lokasi;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.VarChar).Value = harga;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Data Pelatihan Gagal" + ex.Message);
            }
        }

        public void hapusPelatihan(string idpelatihan)
        {
            string hapus = "DELETE FROM Pelatihan WHERE id=" + idpelatihan;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpelatihan;
                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Delete Data Pelatihan Gagal" + ex.Message);
            }
        }

    }
}
