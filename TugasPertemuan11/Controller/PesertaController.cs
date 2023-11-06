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
    internal class PesertaController : Model.Connection
    {
        Connection Koneksi = new Connection();
        public DataTable tampilPeserta()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM Peserta";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public DataTable searchPeserta(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                    ("SELECT * FROM Peserta WHERE CONCAT(id,nama_peserta,email,no_telepon)LIKE '%" + search + "%'", Koneksi.GetConn());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }


        public DataTable SelectPeserta(MySqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM Peserta";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }


        public void tambahPeserta(string idpeserta, string namapeserta, string email, string notelp)
        {
            string tambah = "INSERT INTO Peserta VALUES(" + "@id,@nama_peserta,@email,@no_telepon)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpeserta;
                cmd.Parameters.Add("@nama_peserta", MySqlConnector.MySqlDbType.VarChar).Value = namapeserta;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@no_telepon", MySqlConnector.MySqlDbType.VarChar).Value = notelp;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Peserta Gagal" + ex.Message);
            }
        }

        public void updatePeserta(string idpeserta, string nama_peserta, string email, string no_telepon)
        {
            string update = "UPDATE Peserta set " + "nama_peserta=@nama_peserta,email=@email,no_telepon=@no_telepon " + "WHERE id=" + idpeserta;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpeserta;
                cmd.Parameters.Add("@nama_peserta", MySqlConnector.MySqlDbType.VarChar).Value = nama_peserta;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@no_telepon", MySqlConnector.MySqlDbType.VarChar).Value = no_telepon;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Data Peserta Gagal" + ex.Message);
            }
        }

        public void hapusPeserta(string idpeserta)
        {
            string hapus = "DELETE FROM Peserta WHERE id=" + idpeserta;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpeserta;
                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Delete Data Peserta Gagal" + ex.Message);
            }
        }


    }
}
