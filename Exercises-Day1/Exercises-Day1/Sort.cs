using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises_Day1
{
    class Sort
    {

        public static class Utility{

        public static int[] getInputArray()
        {
            String strInput;

            Console.WriteLine("How Many Nos do you want to Sort?");
            strInput = Console.ReadLine();
            int intNoInput = Convert.ToInt32(strInput);
            int[] Arr = new int[intNoInput];
            for (int i = 0; i < intNoInput; i++)
            {
                Console.WriteLine("Enter a Number");
                strInput = Console.ReadLine();
                int intNo = Convert.ToInt32(strInput);
                Arr[i] = intNo;
            }
            return Arr;
        }
                        
        public static void printArray(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }

        }



        static void Main(String[] args)
        {

            Console.WriteLine("----------------------");

            int[] intUnsorted = Utility.getInputArray();

            Console.WriteLine("----Unsorted Array----");

            int[] intSorted = Sortings.Sort(intUnsorted);

            Console.WriteLine();
            Console.WriteLine("----Sorted Array----");
            Utility.printArray(intSorted);

            Console.ReadLine();
        }

        }

        public static class Sortings{
          
            public static int[] Sort(int[] Arr)
            {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < (Arr.Length-1); j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        int intTemp = Arr[j + 1];
                        Arr[j + 1] = Arr[j];
                        Arr[j] = intTemp;
                    }
                }
            }

                return Arr;
            }

      
        }

        
       
    }
}
