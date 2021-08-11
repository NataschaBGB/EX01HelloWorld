using System;

namespace EX07ExtraSelectionIfElse
{
    class Program
    {
        static void Main(string[] args)
        {

            //ekstra 7.1
            Console.WriteLine("Velkommen til mit store program!");
            Console.WriteLine();
            Console.WriteLine("Tast et bogstav for det du ønsker, og afslut med enter.");
            Console.WriteLine("a) Velkomstbesked");
            Console.WriteLine("b) Udregning af BMI");
            Console.WriteLine("c) Størst af to tal");
            string choice = Console.ReadLine();
            

            if (choice != "a" & choice != "b" & choice != "c")
            {
                Console.WriteLine("Fejl! Det indtastede bogstav er ikke på listen.");
            }
            else if (choice == "a")
            {
                Console.WriteLine("Indtast dit fornavn, efterfulgt af enter.");
                string firstName = Console.ReadLine();
                Console.WriteLine("Indtast dit efternavn, efterfulgt af enter.");
                string lastName = Console.ReadLine();
                Console.WriteLine($"Velkommen {firstName} {lastName}. Jeg håber, du har en god dag!");
            }
            else if (choice == "b")
            {
                Console.WriteLine("Indtast din højde i meter, efterfulgt af enter.");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("Indtast din vægt i kg, efterfulgt af enter.");
                int weight = int.Parse(Console.ReadLine());
                double bmi = (double)(weight / (height * height));
                Console.WriteLine($"Din BMI er: {bmi}");
                
                if (bmi < 18.5)
                {
                    Console.WriteLine("Du vejer for lidt.");
                }
                else if (bmi >= 18.5 & bmi < 25)
                {
                    Console.WriteLine("Din vægt er passende.");
                }
                else if (bmi >= 25 & bmi < 30)
                {
                    Console.WriteLine("Du er moderat overvægtig.");
                }
                else
                {
                    Console.WriteLine("Du er svært overvægtig.");
                }
            
            }
            else
            {
                Console.WriteLine("Indtast to tal, og jeg skal fortælle hvilket der er størst.");
                Console.WriteLine("Indtast det første tal, efterfulgt af enter");
                int numb1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Indtast det andet tal, efterfulgt af enter");
                int numb2 = int.Parse(Console.ReadLine());
                if (numb1 < numb2)
                {
                    Console.WriteLine($"Det største tal er {numb2}");
                }
                else if (numb2 < numb1)
                {
                    Console.WriteLine($"Det største tal er {numb1}");
                }
                else
                {
                    Console.WriteLine("Tallene er lige store.");
                }
            }







        }
    }
}
