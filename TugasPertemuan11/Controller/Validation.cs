using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TugasPertemuan11.Controller
{
    internal class Validation
    {
        //Validasi Nama
        public bool valName(string name)
        {
            for (int a = 0; a < name.Length; a++)
            {
                if ((name[a] >= '0' && name[a] <= '9') || name[0] == ' ' || name[name.Length - 1] == ' ' ||
                    name[a] == ',' || name[0] == '-' || name[name.Length - 1] == '-' ||
                    name[a] == '/' || name[a] == '\\' || name[a] == '?')
                {
                    MessageBox.Show("Input Name failed", "add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        //Validasi Alamat
        public bool valAlamat(string alamat)
        {
            for (int a = 0; a < alamat.Length; a++)
            {
                if ((alamat[0] == '1' || alamat[0] == '2' || alamat[0] == '3' || alamat[0] == '4' ||
                    alamat[0] == '5' || alamat[0] == '6' || alamat[0] == '7' || alamat[0] == '8' ||
                    alamat[0] == '9' || alamat[0] == '0' || alamat[0] == ' ' || alamat[alamat.Length - 1] == ' ' ||
                    alamat[alamat.Length - 1] == '-' || alamat[a] == '/' || alamat[a] == '\\' || alamat[a] == '?'))
                {
                    MessageBox.Show("Input Alamat failed", "add adress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        //Validasi harga
        public bool ValHarga(string harga)
        {
            for (int a = 0; a < harga.Length; a++)
            {
                if ((harga[a] >= 'A' && harga[a] <= 'Z' || harga[0] == ' ' || harga[0] == '0' || harga[harga.Length - 1] == ' ' ||
                    harga[a] == ',' || harga[0] == '-' || harga[harga.Length - 1] == '-' || harga[a] == '/' || harga[a] == '\\' || harga[a] == '?' || harga[a] == '`' || harga[a] == '~' || harga[a] == '!' ||
                    harga[a] == '@' || harga[a] == '#' || harga[a] == '$' || harga[a] == '%' || harga[a] == '^' || harga[a] == '&' || harga[a] == '*'))
                {
                    MessageBox.Show("Input Harga failed", "add Harga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            }
        }
    }
}

