using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchExercise
{
    class Nested
    {
        static void Main(String[] args) {

            String strInput;
            int intNo;

            for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Enter the nos. ");
                    strInput = Console.ReadLine();
                    intNo = Convert.ToInt32(strInput);

                    if (intNo % 2 == 0)
                    {
                        int intTemp = intNo;
                        for (int i = 0; i < 5; i++)
                        {
                            intTemp += 2;
                            Console.WriteLine(intTemp);
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Exiting the Loop");
                        break;
                        
                    }
                }
            Console.ReadLine();
            }
    }  
}
