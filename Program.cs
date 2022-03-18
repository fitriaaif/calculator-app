using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkuator";

            int a, b, menu, total;

            Console.WriteLine("Pilihan menu kalkulator:");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();
            Console.Write("Masukkan nomor menu (1-4) : ");
            menu = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (menu == 1)
            {
                Console.Write("Masukkan bilangan pertama : ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan bilangan kedua   : ");
                b = Convert.ToInt32(Console.ReadLine());

                total = a + b;
                Console.WriteLine("Hasil penambahan : " + total);
            }
            else if (menu == 2)
            {
                Console.Write("Masukkan bilangan pertama : ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan bilangan kedua   : ");
                b = Convert.ToInt32(Console.ReadLine());

                total = a - b;
                Console.WriteLine("Hasil pengurangan : " + total);
            }
            else if (menu == 3)
            {
                Console.Write("Masukkan bilangan pertama : ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan bilangan kedua   : ");
                b = Convert.ToInt32(Console.ReadLine());

                total = a * b;
                Console.WriteLine("Hasil perkalian : " + total);
            }
            else if (menu == 4)
            {
                Console.Write("Masukkan bilangan pertama : ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan bilangan kedua   : ");
                b = Convert.ToInt32(Console.ReadLine());

                total = a / b;
                Console.WriteLine("Hasil pembagian : " + total);
            }
            else
            {
                Console.WriteLine("Maaf, pilihan menu yang dimasukkan salah");
            }
            Console.WriteLine("\nTERIMAKASIH");
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }  
    }
}
