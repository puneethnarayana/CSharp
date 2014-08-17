using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ArithmeticOps
    {

        public static int Addition(int intNum1, int intNum2)
        {
            return (intNum1 + intNum2);
        }

        public static int Substraction(int intNum1, int intNum2)
        {
            return (intNum1 - intNum2);
        }

        public static int Multiplication(int intNum1, int intNum2)
        {
            return (intNum1 * intNum2);
        }

        public static double Division(int intNum1, int intNum2)
        {
            return (intNum1 / intNum2);
        }


        static void Main(String[] args){
        
        string strVal;

            

            //Integer Processing
            Console.WriteLine("Integer Input");
            Console.Write("Enter first number:");
            strVal = Console.ReadLine();
            int intNum1 = Convert.ToInt32(strVal);

            Console.Write("Enter second number:");
            strVal = Console.ReadLine();
            int intNum2= Convert.ToInt32(strVal);

            Console.WriteLine("what operation do you wish to perform?");
            Console.WriteLine("1. Addition, 2. Subtraction 3. Multiplication, 4. Division");
            Console.WriteLine("Choose a Number between 1 to 4");
            strVal = Console.ReadLine();
            int intOption = Convert.ToInt32(strVal);

                switch (intOption)
                {
                    case 1: Console.WriteLine("Sum is " + Addition(intNum1, intNum2));
                        break;
                    case 2: Console.WriteLine("Difference is " + Substraction(intNum1, intNum2));
                        break;
                    case 3: Console.WriteLine("Product is " + Multiplication(intNum1, intNum2));
                        break;
                    case 4: Console.WriteLine("Quotient is " + Division(intNum1, intNum2));
                        break;
                    default: Console.WriteLine("Invalid Operator Choice Try Again");
                        break;

                }
                
            

            Console.ReadLine();
        }
    }
}
