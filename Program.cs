using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("aplikasi kalkulator");
            Console.WriteLine("--------------------");

            Console.WriteLine();

            Console.WriteLine("inputkan nilai a = ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("inputkan nilai b = ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("pilih menu kalkulator:");

            Console.WriteLine();

            Console.WriteLine("1. penambahan");
            Console.WriteLine("2. pengurangan");
            Console.WriteLine("3. perkalian");
            Console.WriteLine("4. pembagian");

            Console.WriteLine();
            Console.WriteLine("input nomor menu [1...4]");
            int pilih;
            pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (pilih)
            {
                case 1:
                    Console.WriteLine("hasil penjumlahan :");
                    Console.WriteLine(a + b);
                    Console.ReadKey(); break;
                case 2:
                    Console.WriteLine("hasil pengurangan :");
                    Console.WriteLine(a - b);
                    Console.ReadKey(); break;
                case 3:
                    Console.WriteLine("hasil perkalian :");
                    Console.WriteLine(a * b);
                    Console.ReadKey(); break;
                case 4:
                    Console.WriteLine("hasil pembagian");
                    Console.WriteLine(a / b);
                    Console.ReadKey(); break;
                default:
                    Console.WriteLine("mohon maaf menu tidak tersedia");
                    Console.ReadKey(); break;

            }

            Console.WriteLine(); ;

            Console.WriteLine("\n tekan sembarang key untuk keluar");
            Console.ReadKey();
        }



    }
}

