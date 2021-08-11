using System;

namespace EX04ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {

            //opgave 4.1 + 4.2
            Console.WriteLine("Hvad er dit fornavn?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Hvad er dit efternavn?");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Velkommen {firstName} {lastName}!");

            Console.WriteLine();
            //opgave 4.3
            Console.WriteLine("Hvor gammel er du?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hvor høj er du?");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine();
            //ekstra opgave 4.4
            Console.WriteLine("Udregning af areal på en firkant!");
            Console.WriteLine("Hvad er længden i cm på den ene side af firkanten?: ");
            int sideOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Hvad er længden i cm på den anden side af firkanten?: ");
            int sideTwo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Arealet er firkanten er: {sideOne * sideTwo}");

            Console.WriteLine();
            //ekstra opgave 5.5
            Console.WriteLine("     AA         BBBBBBBB           CCCCCC");
            Console.WriteLine();
            Console.WriteLine("    A  A        B        B      C           C");
            Console.WriteLine();
            Console.WriteLine("   A    A       BBBBBB         C");
            Console.WriteLine();
            Console.WriteLine("  AAAAAAAA      B       B      C");
            Console.WriteLine();
            Console.WriteLine(" A        A     B         B     C           C");
            Console.WriteLine();
            Console.WriteLine("A          A    BBBBBBBB           CCCCCC");
        



        }
    }
}
