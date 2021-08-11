using System;

namespace EX05Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {

            //opgave 5.1, 5.2, 5.3, 5.4
            Console.WriteLine("Velkommen til lommeregneren!");
            Console.WriteLine();
            Console.WriteLine("Indtast et tal, efterfulgt af enter: ");
            double numb1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast endnu et tal, efterfulgt af enter: ");
            double numb2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Resultatet af de to tal lagt sammen er: {numb1 + numb2}");
            Console.WriteLine($"Resultatet af de to tal trukket fra hinanden er: {numb1 - numb2}");
            Console.WriteLine($"Resultatet af de to tal ganget sammen er: {numb1 * numb2}");
            Console.WriteLine($"Resultatet af de to tal divideret med hinanden er: {numb1 / numb2}");
            Console.WriteLine($"Resultatet af de to tal modulo med hinanden er: {numb1 % numb2}");

        }
    }
}
