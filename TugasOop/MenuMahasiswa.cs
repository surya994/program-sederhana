using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOop
{
    public class MenuMahasiswa : Mahasiswa
    {
        public void Main()
        {
            Console.Clear();
            List<DataMahasiswa> mhs = Lihat();
            Console.WriteLine("----Data Mahasiswa----");
            if (mhs.Count == 0)
            {
                Console.WriteLine("(Mahasiswa Tidak Ada)");
            }
            else
            {
                Console.WriteLine($"--------------------------------------------------");
                Console.WriteLine($"|{" NIM.",-6}|{" Nama",-30}|{" Kelas",-10}|");
                Console.WriteLine($"--------------------------------------------------");
                foreach (var data in mhs)
                {
                    Console.WriteLine($"| {data.Nim,-5}| {data.Nama,-29}| {data.Kelas,-9}|");
                }
                Console.WriteLine($"--------------------------------------------------");
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
                    Console.Write("\nNim Mahasiswa : ");
                    int nim = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nama Mahasiswa : ");
                    string nama = Console.ReadLine();
                    Console.Write("Kelas Mahasiswa : ");
                    string kelas = Console.ReadLine();
                    Tambah(nim,nama,kelas);
                    Main();
                    break;
                case '2':
                    Console.Write("\nPilih Nim Mahasiswa : ");
                    int id = Convert.ToInt32(Console.ReadLine());
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
