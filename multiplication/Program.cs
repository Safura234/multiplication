using System;

namespace multiplication
{
    internal class Program
    {
        private static bool result;

        static int Main(string[] args)
        {
            Console.WriteLine("multiplication table");
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Enter the num1");
            Console.WriteLine("Enter the num2");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            int multiplicationTable = num1 * num2;
        
            {
                int result = num1 * num2;
                return result;
                Console.WriteLine(result);
            }
        }
    }
}
