using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises_Day1
{
    class Factorial
    {
        static int fac(int n) {
            int intFac = n;

            for (int i = n - 1; i >= 1; i--)
            {
                 intFac = intFac * i;
            }
            return intFac;
        }

        static void M(String[] args) {

            int number;
            Console.Write("Enter number\n");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine(fac(number));
            Console.ReadLine();
        }
    }
}
