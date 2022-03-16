using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOop
{
    public class MenuMatkul : Matkul
    {
        public void Main()
        {
            Console.Clear();
            List<DataMatkul> mtk = Lihat();
            Console.WriteLine("----Daftar Matkul----");
            if (mtk.Count == 0)
            {
                Console.WriteLine("(Matkul Tidak Ada)");
            }
            else
            {
                Console.WriteLine($"---------------------------------------");
                Console.WriteLine($"|{" Kode",-6}|{" Nama Matkul",-30}|");
                Console.WriteLine($"---------------------------------------");
                foreach (var data in mtk)
                {
                    Console.WriteLine($"| {data.Kode,-5}| {data.Nama,-29}|");
                }
                Console.WriteLine($"---------------------------------------");
            }
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Tambah");
            Console.WriteLine("2. Hapus");
            Console.WriteLine("3. Kembali");
            Console.Write("Pilih : ");
            var pilih = Console.ReadKey();
            switch (pilih.KeyChar)
            {
                case '1':
                    Console.Write("\nKode Matkul : ");
                    string kode = Console.ReadLine();
                    Console.Write("Nama Matkul : ");
                    string nama = Console.ReadLine();
                    Tambah(kode,nama);
                    Main();
                    break;
                case '2':
                    Console.Write("\nPilih Kode Matkul : ");
                    string id = Console.ReadLine();
                    Hapus(id);
                    Main();
                    break;
                case '3':
                    Program awal = new Program();
                    awal.Menu();
                    break;
                default:
                    Main();
                    break;
            }
        }
    }
}
