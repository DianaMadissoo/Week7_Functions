using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta esimene arv:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teine arv:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vali tehe: (sisesta '+', '-', '*' voi '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch(userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultiplyTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    MinusTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Kena paeva!");
                    break;
            }
        }

        public static void AddTwoNumbers(double x, double y)
        {
            double result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }
        public static void MultiplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }
        public static void MinusTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine(result);
        }

    }
}
