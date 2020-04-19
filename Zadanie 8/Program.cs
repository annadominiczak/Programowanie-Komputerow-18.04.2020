using System;

namespace Zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Podaj pierwszy bok trójkąta:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugi bok trójkąta:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj trzeci bok trójkąta:");
            c = Convert.ToDouble(Console.ReadLine());

            if ((a + b > c) && (b + c > a) && (c + a > b))
                Console.WriteLine("Z podanych wartości można stworzyć trójkąt");

            else
                Console.WriteLine("Z podanych wartości nie można stworzyć trójkąta");


            Console.ReadLine();



        }
    }
}
