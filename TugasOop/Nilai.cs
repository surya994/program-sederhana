using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOop
{
    public class Nilai
    {
        public void Main()
        {
            Console.Clear();
            Console.WriteLine("----Hitung Nilai----");
            Mahasiswa mahasiswa = new Mahasiswa();
            Matkul matkul = new Matkul();
            List<DataMahasiswa> mhs = mahasiswa.Lihat();
            List<DataMatkul> mtk = matkul.Lihat();
            if (mhs.Count == 0)
            {
                Console.WriteLine("(Harap Tambahkan Mahasiswa Terlebih Dahulu)");
                var pilihan = Console.ReadKey();
                switch (pilihan.KeyChar)
                {
                    default:
                        Program awal = new Program();
                        awal.Menu();
                        break;
                }
            }
            if (mtk.Count == 0)
            {
                Console.WriteLine("(Harap Tambahkan Mata Kuliah Terlebih Dahulu)");
                var pilihan = Console.ReadKey();
                switch (pilihan.KeyChar)
                {
                    default:
                        Program awal = new Program();
                        awal.Menu();
                        break;
                }
            }
            Console.Write("Pilih Nim Mahasiswa : ");
            int id = Convert.ToInt32(Console.ReadLine());

            List<DataMahasiswa> mhsCari = mahasiswa.Lihat(id);
            if (mhsCari.Count == 0)
            {
                Console.WriteLine("(Mahasiswa Tidak Ditemukan)");
                var pilihan = Console.ReadKey();
                switch (pilihan.KeyChar)
                {
                    default:
                        Program awal = new Program();
                        awal.Menu();
                        break;
                }
            }
           
            List<int> nilaiList = new List<int>();
            foreach (var data in mtk)
            {
                Console.Write($"{data.Nama}\t : ");
                nilaiList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine($"\n---------------------------------------");
            foreach (var data in mhsCari)
            {
                Console.WriteLine($"NIM\t : {data.Nim}");
                Console.WriteLine($"Nama\t : {data.Nama}");
                Console.WriteLine($"Kelas\t : {data.Kelas}");
            }
            int nilaiTotal = NilaiTotal(nilaiList);
            double nilaiRata = NilaiRata(nilaiList);
            Console.WriteLine($"\nNilai Total\t : {nilaiTotal}");
            Console.WriteLine($"Nilai Rata-Rata\t : {nilaiRata}");
            Console.WriteLine($"---------------------------------------");

            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Hitung Lagi");
            Console.WriteLine("2. Kembali");
            Console.Write("Pilih : ");
            var pilih = Console.ReadKey();
            switch (pilih.KeyChar)
            {
                case '1':
                    Main();
                    break;
                case '2':
                    Program awal = new Program();
                    awal.Menu();
                    break;
                default:
                    Main();
                    break;
            }
        }
        double NilaiRata(List<int> nilaiList)
        {
            double total = nilaiList.Sum();
            double jumlah = nilaiList.Count();
            double nilai = total / jumlah;
            return nilai;
        }
        int NilaiTotal(List<int> nilaiList)
        {
            int nilai = nilaiList.Sum();
            return nilai;
        }
    }
}
