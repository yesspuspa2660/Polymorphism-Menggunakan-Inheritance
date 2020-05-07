using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama \t: Rahayu Puspa Indah Lestari Ningrum");
            Console.WriteLine("NIM \t: 19.11.2660");
            Console.WriteLine("Kelas \t: Informatika 02\n");

            PrinterWindows printer;

            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson");
            Console.WriteLine("1. Canon");
            Console.WriteLine("1. LaserJet\n");

            Console.Write("Nomor Printer [1-3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else 
                printer = new LaserJet();

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
