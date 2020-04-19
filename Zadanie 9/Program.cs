using System;

namespace Zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x0, x1, x2, delta;

            Console.WriteLine("Podaj współczynnik a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik c:");
            c = Convert.ToDouble(Console.ReadLine());

            delta = Math.Pow(b, 2) - (4 * a * c);
            Console.WriteLine(delta);


            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);

                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Funkcja posiada dwa miejsca zerowe x1={0}, x2={1}", x1, x2);
            }
            else if (delta == 0)
            {
                x0 = -b / (2 * a);
                Console.WriteLine("Funkcja posiada jedno miejsce zerowe x0={0}", x0);
            }
            else
            {
                Console.WriteLine("Funkcja nie posiada miejsc zerowych");
            }


            Console.ReadLine();
        }
    }
}