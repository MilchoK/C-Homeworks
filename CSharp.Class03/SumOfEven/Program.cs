using System;

namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter integer no.{i + 1}:");
                string input = Console.ReadLine();
                int.TryParse(input, out int num);
                numbers[i] = num;
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine("The result is: " + sum);

        }
    }
}
