using System;

namespace ModulusCalculation
{
    class Program
    {
        static int CalculateModulus(int dividend, int divisor)
        {
            // Laske jakojäännös
            int remainder = dividend % divisor;
            return remainder;
        }

        static void Main(string[] args)
        {
            Console.Write("Syötä jaettava luku: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Syötä jakaja: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            // Laske jakojäännös
            int remainder = CalculateModulus(dividend, divisor);

            // Tulosta tulos
            Console.WriteLine($"Jakojäännös: {remainder}");
        }
    }
}

