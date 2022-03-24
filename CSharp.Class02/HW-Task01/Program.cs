using System;

namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesete Broj:");
            string input = Console.ReadLine();
            int.TryParse(input, out int num1);
            Console.WriteLine("Vnesete Vtor Broj:");
            string input2 = Console.ReadLine();
            int.TryParse(input2, out int num2);
            Console.WriteLine("Vnesete Operacija:\n1)+\n2)-\n3)*\n4)/");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                int res = num1 + num2;
                Console.WriteLine("Rezultatot e " + res);
            }
            else if (operation == "-")
            {
                int res = num1 - num2;
                Console.WriteLine("Rezultatot e " + res);
            }
            else if (operation == "*")
            {
                int res = num1 * num2;
                Console.WriteLine("Rezultatot e " + res);
            }
            else
            {
                int res = num1 / num2;
                Console.WriteLine("Rezultatot e " + res);
            }
        }
    }
}
