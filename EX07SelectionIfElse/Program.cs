using System;

namespace EX07SelectionIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave 7.1
            Console.WriteLine("Indtast det beløb, du vil købe for:");
            double userInput = double.Parse(Console.ReadLine());
            
            


            if (userInput > 1000)
                {
                    Console.WriteLine($"Du får {userInput * 0.05} kr. i rabat.");
                }
            else
                {
                    Console.WriteLine("Køb for mindst 1000 kr., for at få rabat.");
                }
            Console.WriteLine();
            
            //opgave 7.2
            Console.WriteLine("Indtast et heltal:");
            int numb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast et heltal mere:");
            int numb2 = int.Parse(Console.ReadLine());

            if (numb1 == numb2)
            {
                Console.WriteLine("De to tal er ens.");
            }
            else
            {
                Console.WriteLine("De to tal er ikke ens.");
            }
            Console.WriteLine();
            
            //opgave 7.3
            Console.WriteLine("Skriv et heltal:");
            int inputOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv et heltal mere:");
            int inputTwo = int.Parse(Console.ReadLine());

            if (inputTwo == 0)
            {
                Console.WriteLine("Fejl. - Kan ikke udskrive de indtastede tal.");
            }
            else
            {
                Console.WriteLine($"{inputOne}/{inputTwo}");
            }
            Console.WriteLine();

            //opgave 7.4
            Console.WriteLine("Indtast et heltal:");
            int numb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast et helt tal mere:");
            int numb2 = int.Parse(Console.ReadLine());

            if (numb1 == numb2)
            {
                Console.WriteLine("De to tal er ens.");
            }
            else if (numb1 > numb2)
            {
                Console.WriteLine($"Det højeste tal er {numb1}.");
            }
            else
            {
                Console.WriteLine($"Det højeste tal er {numb2}.");
            }
            Console.WriteLine();

            //opgave 7.5
            Console.WriteLine("Skriv et heltal:");
            int numb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv et heltal mere:");
            int numb2 = int.Parse(Console.ReadLine());

            if (numb1 > numb2)
            {
                Console.WriteLine($"{numb2} {numb1}");
            }
            else if (numb2 > numb1)
            {
                Console.WriteLine($"{numb1} {numb2}");
            }
            Console.WriteLine();

            //opgave 7.6
            Console.WriteLine("Skriv et heltal;");
            int numb = int.Parse(Console.ReadLine());

            if (numb > 0)
            {
                Console.WriteLine("Tallet er positivt.");
            }
            else if (numb < 0)
            {
                Console.WriteLine("Tallet er negativt.");
            }
            else
            {
                Console.WriteLine("Tallet er 0 - Hverken positivt eller negativt.");
            }
            Console.WriteLine();

            //opgave 7.7 og 7.8
            Console.WriteLine("Hvor meget vejer dit brev i gram?");
            int weight = int.Parse(Console.ReadLine());
            int price = 0;

            if (weight < 20)
            {
                price = 5;
                Console.WriteLine($"Portoen koster {price} kroner.");
            }
            else if (weight >= 20 & weight < 50)
            {
                price = 7;
                Console.WriteLine($"Portoen koster {price} kroner.");
            }
            else if (weight >= 50 & weight < 100)
            {
                price = 10;
                Console.WriteLine($"Portoen koster {price} kroner.");
            }
            else if (weight >= 100 & weight < 150)
            {
                price = 15;
                Console.WriteLine($"Portoen koster {price} kroner.");
            }
            else if (weight >= 150 & weight < 200)
            {
                price = 20;
                Console.WriteLine($"Portoen koster {price} kroner.");
            }
            else
            {
                price = 30;
                Console.WriteLine($"Portoen koster {price} kroner.");
            }
            Console.WriteLine();
            Console.WriteLine("Ønsker du at sende med ekspres?");
            string user = Console.ReadLine();
            
            if (user == "Ja")
            {
                Console.WriteLine($"Portoen koster {price + (0.5 * price)}");
            }
            else
            {
                Console.WriteLine("Hav en god dag!");
            }
            





        }
    }
}
