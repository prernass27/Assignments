using System;

namespace Assignment_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Marks of Students : ");
            for(int n=0; n<5; n++)
            {
                int marks = int.Parse(Console.ReadLine());
                Console.WriteLine(marks);
            }
        }
    }
}