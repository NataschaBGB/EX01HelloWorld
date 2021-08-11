using System;

namespace EX06ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            //opgave 6

            int a = 2;
            int b = 4;

            // Udsagn: (mine gæt)
            // a == b  (false)
            // a > b   (false)
            // a <= b  (true)
            // a-b > 0 (false)
            // a+b > 0 (true)
            // a > 1-b (true)

            //løsninger
            Console.WriteLine(a ==b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <=b);
            Console.WriteLine(a-b > 0);
            Console.WriteLine(a+b > 0);
            Console.WriteLine(a > 1-b);



        }
    }
}
