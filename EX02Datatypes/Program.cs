using System;

namespace EX02Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave 2.1
            string forNavn = "Karsten";
            string efterNavn = "Hansen";
            int alder = 35;

            Console.WriteLine(forNavn);
            Console.WriteLine(efterNavn);
            Console.WriteLine(alder);

            Console.WriteLine($"{forNavn} {efterNavn} {alder}");

            Console.WriteLine();

            //opgave 2.2
            string bogtitel = "Lord of The Rings - The Two Towers";
            long isbn = 9780007117116;
            int sideantal = 400;
            double pris = 249.95;

            Console.WriteLine(bogtitel);
            Console.WriteLine(isbn);
            Console.WriteLine(sideantal);
            Console.WriteLine(pris);

            Console.WriteLine();

            //opgave 2.3
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            uint maxUint = uint.MaxValue;
            uint minUint = uint.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            byte maxByte = byte.MaxValue;
            byte minByte = byte.MinValue;
            short maxShort = short.MaxValue;
            short minShort = short.MinValue;

            Console.WriteLine($"Max value: {maxInt}. Min value: {minInt}");
            Console.WriteLine($"Max value: {maxUint}. Min value: {minUint}");
            Console.WriteLine($"Max value: {maxLong}. Min value: {minLong}");
            Console.WriteLine($"Max value: {maxByte}. Min value: {minByte}");
            Console.WriteLine($"Max value: {maxShort}. Min value: {minShort}");


            Console.WriteLine();
        }
    }
}
