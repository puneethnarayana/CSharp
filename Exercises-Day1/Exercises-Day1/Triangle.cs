using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises_Day1
{
    class Triangle
    {
        static void Min(String[] args) {

            int number, i, k, count = 1;
            Console.Write("Enter number of rows\n");
            number = int.Parse(Console.ReadLine());
            count = number - 1;

            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                
                    count--;
                
                for (i = 1; i <= 2 * k - 1; i++)
                    {
                     Console.Write("*");  
                    /*if (i <= number / 2 + 1)
                        {
                            Console.Write(i);
                        }
                        else
                        {
                            Console.Write(2*k-i);
                        }*/
                    }
                    Console.WriteLine();
                }
                      
            /*
            count = 1;
            for (k = 1; k <= number - 1; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - k) - 1; i++)
                    //Console.Write("*");
                    if (i < number / 2)
                        Console.Write(2 * (number - k) - 1);
                    else
                        Console.Write(i);
                Console.WriteLine();
            }*/

            Console.ReadLine();
        }


    }
}
