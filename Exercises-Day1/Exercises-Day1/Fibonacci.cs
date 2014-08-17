using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises_Day1
{
    class Fibonacci
    {
        static void M(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Fibo(0, 1, 1, number);
        }

        public static void Fibo(int a, int b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number) Fibo(b, a + b, counter + 1, number);
        }
    }
}
