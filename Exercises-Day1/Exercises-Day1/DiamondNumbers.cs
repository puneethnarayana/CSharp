using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises_Day1
{
    class DiamondNumbers
    {
        static void Mai(String[] args) {

            int number;
            Console.Write("Enter number of rows\n");
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++) {

                for (int j = number; j > i; j--) {
                    Console.Write(" ");
                }
                int k;
                for (k=1;k<(i+1);k++){
                    Console.Write(k);
                }
                for(int l=k-1;l>1;l--){
                    Console.Write(l-1);
                }
              Console.WriteLine();
            }

            for (int i = number; i >=1; i--)
            {
                for (int j = i; j < number; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i+1; k++)
                {
                    Console.Write(k);
                }
                for (int l = i ; l > 1; l--)
                {
                    Console.Write(l-1);
                }
                Console.WriteLine();
            }
        Console.ReadLine();
        }           
    }       
 }
    
