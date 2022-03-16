using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOop
{
    public class Mahasiswa
    {
        private static List<DataMahasiswa> DataMhs { get; set; } = new List<DataMahasiswa>();
        public List<DataMahasiswa> Lihat()
        {
            return DataMhs;
        }
        public List<DataMahasiswa> Lihat(int nim)
        {
            return DataMhs.Where(x => x.Nim == nim).ToList();
        }
        public void Tambah(int nim, string nama, string kelas)
        {
            DataMahasiswa temp = new DataMahasiswa();
            temp.Nim = nim;
            temp.Nama = nama;
            temp.Kelas = kelas;
            DataMhs.Add(temp);
        }
        public void Hapus(int nim)
        {
            DataMhs.RemoveAt(DataMhs.FindIndex(x => x.Nim == nim));
        }
    }
}
