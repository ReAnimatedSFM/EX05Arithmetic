using System;

namespace EX05Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("velkommen til lommeregneren version 1");
            Console.WriteLine("Jeg er en simpel lommeregner, som udelukkende kan lægge to tal sammen");
            Console.WriteLine();
            Console.Write("Indtast et tal, efterfulgt af enter: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Indtast endnu et tal, efterfulgt af enter: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"Resultatet af de to tal lagt sammen er: {x + y}");
            Console.WriteLine($"Resultatet af de to tal trukket fra hindanen er: {x - y}");
            Console.WriteLine($"Resultatet af de to tal ganget sammen er: {x * y}");
            Console.WriteLine($"Resultatet af de to tal divideret med hindanden er: {x / y}");
            Console.WriteLine($"Resultatet af de to tal modulo med hindanden er: {x % y}");





            Console.ReadKey();
        }
    }
}
