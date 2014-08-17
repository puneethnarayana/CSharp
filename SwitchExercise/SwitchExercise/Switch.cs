using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchExercise
{
    class Switch
    {
        static void Switch(string[] args)
        {
            String strInput;

            Console.WriteLine("Enter the first no");
            strInput = Console.ReadLine();
            double dblNo1 = Convert.ToDouble(strInput);

            Console.WriteLine("Enter the Second No.");
            strInput = Console.ReadLine();
            double dblNo2 = Convert.ToDouble(strInput);

            Console.WriteLine("Enter the operator");
            strInput = Console.ReadLine();
            String  strOpr = strInput;

            switch (strOpr) { 
                case "+" : 
                    Console.WriteLine("Sum is "+(dblNo1+dblNo2));
                        break;
                case "-" :
                    Console.WriteLine("Difference is "+(dblNo1-dblNo2));
                    break;

                case "*" :
                     Console.WriteLine("Difference is "+(dblNo1*dblNo2));
                    break;

                case "/":
                     Console.WriteLine("Quotient is "+(dblNo1/dblNo2));
                    break;
           
                default: 
                    Console.WriteLine("Not a Valid Operator");
                    break;
              }
            Console.ReadLine();
        }
    }
}
