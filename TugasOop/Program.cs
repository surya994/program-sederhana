using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOop
{
    class Program
    {
        public static void Main()
        {
            Program menu = new Program();
            menu.Menu();
        }
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("---Program Hitung Nilai---");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Mahasiswa");
            Console.WriteLine("2. Mata Kuliah");
            Console.WriteLine("3. Hitung Nilai");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilih : ");
            var pilih = Console.ReadKey();
            switch (pilih.KeyChar)
            {
                case '1' :
                    MenuMahasiswa mhs = new MenuMahasiswa();
                    mhs.Main();
                    break;
                case '2' :
                    MenuMatkul mtk = new MenuMatkul();
                    mtk.Main();
                    break;
                case '3':
                    Nilai nli = new Nilai();
                    nli.Main();
                    break;
                case '4':
                    Environment.Exit(0);
                    break;
                default:
                    Main();
                    break;
            }
        }
    }
}