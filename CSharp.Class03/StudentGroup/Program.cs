using System;

namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] { "Reuben", "Garland", "Luna","Kylee","Chase"};
            string[] studentsG2 = new string[] { "Jon", "Rob", "Sansa", "Arya", "Michael" };

            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            string input = Console.ReadLine();
            if (input == "1")
            {
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else if (input == "2")
            {
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
