using System;
using System.IO;
namespace UsingNaredba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            string prezime = Console.ReadLine();
            // Podatke upisujemo u datoteku
            Console.WriteLine("\n-- Zapisujemo u datoteku...");
            using (StreamWriter sw = new StreamWriter(@"C:\Users\ucenik\Documents\LukaRadetic\datoteka.txt"))
            {
                sw.WriteLine("Ime: {0}", ime);
                sw.WriteLine("Prezime: {0}", prezime);
            }
            // Podatke čitamo iz datoteke
            Console.WriteLine("\n-- Pročitano iz datoteke:");
            using (StreamReader sr = new StreamReader(@"C:\Users\ucenik\Documents\LukaRadetic\datoteka.txt"))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            Console.ReadKey();
        }
    }
}