using System;

namespace SwapNumbers
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

            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"Posle zamenata:\nPrviot broj e: {num1}\nVtoriot broj e: {num2}");
        }
    }
}
