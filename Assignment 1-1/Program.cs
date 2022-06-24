using System;

namespace Assignment_1_1
{
    class Program
    {
        public class Calculator
        {
            public int Addition(int x, int y)
            {
                int result = x + y;
                return result;
            }

            public int Substracton(int x, int y)
            {
                int result = x - y;
                return result;
            }
            public int Division(int x, int y)
            {
                int result = x / y;
                return result;
            }
            public int Multiplication(int x, int y)
            {
                int result = x * y;
                return result;
            }
        }


            static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result = 0;

            Console.WriteLine("Enter the Method Number : \n" +
                "1. Addition \n2.Substraction \n3.Multiplication \n4.Division");

            int action = int.Parse(Console.ReadLine());
            
                Console.WriteLine("Enter First Number : ");
                string ans1 = Console.ReadLine();
                int x = int.Parse(ans1);

                Console.WriteLine(" Enter Second Number : ");
                string ans2 = Console.ReadLine();
                int y = int.Parse(ans2);
           
                switch (action)
                {
                    case 1:
                        result = calculator.Addition(x, y);
                        break;
                    case 2:
                        result = calculator.Substracton(x, y);
                        break;
                    case 3:
                        result = calculator.Multiplication(x, y);
                        break;
                    case 4:
                        result = calculator.Division(x, y);
                        break;
                    

                    default:
                        Console.WriteLine("Wrong input! Please try again!");
                        break;

                }
           

            Console.Write("Result =  ");
            Console.WriteLine(result);



            //Console.WriteLine("Hello World!");


        }
    }
}
