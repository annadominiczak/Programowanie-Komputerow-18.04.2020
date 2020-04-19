using System;

namespace Zadania_Programowanie_Komputerów
{
    class Program
    {
        static void Main(string[] args)
        {
            double V, r, H, Pb, Pp, Pc;

            Console.WriteLine("Podaj promień podstawy walca:");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wysokość podstawy walca:");
            H = Convert.ToDouble(Console.ReadLine());
            V = Math.PI * r * r * H;
            Pp = Math.PI * Math.Pow(r, 2);
            Pb = 2 * Math.PI * r * H;
            Pc = 2 * Pp + Pb;
            Console.WriteLine("Pole całkowite walca = {0}", Pc);
            Console.WriteLine("Objetość walca = {0}", V);
            Console.ReadLine();


        }
    }
}
