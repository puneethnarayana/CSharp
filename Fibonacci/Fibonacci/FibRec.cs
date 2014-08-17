using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class FibRec
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Fibonacci(0, 1, 1, number);
            Console.ReadLine();
        }

        public static void Fibonacci(int a, int b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number) Fibonacci(b, a + b, counter + 1, number);
        }
    }
}
