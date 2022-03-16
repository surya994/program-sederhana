using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOop
{
    public class Matkul
    {
        private static List<DataMatkul> DataMtk { get; set; } = new List<DataMatkul>();
        public List<DataMatkul> Lihat()
        {
            return DataMtk;
        }
        public void Tambah(string kode, string nama)
        {
            DataMatkul temp = new DataMatkul();
            temp.Kode = kode;
            temp.Nama = nama;
            DataMtk.Add(temp);
        }
        public void Hapus(string kode)
        {
            DataMtk.RemoveAt(DataMtk.FindIndex(x => x.Kode == kode));
        }
    }
}
