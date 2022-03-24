using System;

namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesete Prv Broj:");
            string input = Console.ReadLine();
            int.TryParse(input, out int num1);

            Console.WriteLine("Vnesete Vtor Broj:");
            string input2 = Console.ReadLine();
            int.TryParse(input2, out int num2);

            Console.WriteLine("Vnesete Tret Broj:");
            string input3 = Console.ReadLine();
            int.TryParse(input3, out int num3);

            Console.WriteLine("Vnesete Cetvrt Broj:");
            string input4 = Console.ReadLine();
            int.TryParse(input4, out int num4);

            int average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"Prosekot nab broevite {num1}, {num2}, {num3}, {num4} e: {average}");
        
        }
    }
}
