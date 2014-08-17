using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Ain(string[] args)
        {
            string strVal;

            //Integer Processing
            Console.WriteLine("Integer Input");
            Console.Write("Enter first number:");
            strVal = Console.ReadLine();
            int intNum1 = Convert.ToInt32(strVal);

            Console.Write("Enter second number:");
            strVal = Console.ReadLine();
            int intNum2= Convert.ToInt32(strVal);

            Console.WriteLine("Sum is "+(intNum1+intNum2));
            Console.WriteLine("Difference is " + (intNum1 - intNum2));
            Console.WriteLine("Product is " + (intNum1 * intNum2));
            Console.WriteLine("Quotient is " + (intNum1 / intNum2));
            Console.WriteLine("Remainder is " + (intNum1 %intNum2));
            Console.ReadLine();

            //Accepts Decimal Input

            Console.WriteLine("Decimal Input");
            Console.Write("Enter first number:");
            strVal = Console.ReadLine();
            decimal decNum1 = Convert.ToDecimal(strVal);

            Console.Write("Enter second number:");
            strVal = Console.ReadLine();
            decimal decNum2 = Convert.ToDecimal(strVal);

            Console.WriteLine("Sum is " + (decNum1 + decNum2));
            Console.WriteLine("Difference is " + (decNum1 - decNum2));
            Console.WriteLine("Product is " + (decNum1 * decNum2));
            Console.WriteLine("Quotient is " + (decNum1 / decNum2));
            Console.WriteLine("Remainder is " + (decNum1 % decNum2));
            Console.ReadLine();

            //Accepts Double Input

            Console.WriteLine("Double Input");
            Console.Write("Enter first number:");
            strVal = Console.ReadLine();
            double dblNum1 = Convert.ToDouble(strVal);

            Console.Write("Enter second number:");
            strVal = Console.ReadLine();
            double dblNum2 = Convert.ToDouble(strVal);

            Console.WriteLine("Sum is " + (dblNum1 + dblNum2));
            Console.WriteLine("Difference is " + (dblNum1 - dblNum2));
            Console.WriteLine("Product is " + (dblNum1 * dblNum2));
            Console.WriteLine("Quotient is " + (dblNum1 / dblNum2));
            Console.WriteLine("Remainder is " + (dblNum1 % dblNum2));
            Console.ReadLine();

            //Accepts Float Input

            Console.WriteLine("Float Input");
            Console.Write("Enter first number:");
            strVal = Console.ReadLine();
            float fltNum1 = float.Parse(strVal, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);

            Console.Write("Enter second number:");
            strVal = Console.ReadLine();
            float fltNum2 = float.Parse(strVal, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Sum is " + (fltNum1 + fltNum2));
            Console.WriteLine("Difference is " + (fltNum1 - fltNum2));
            Console.WriteLine("Product is " + (fltNum1 * fltNum2));
            Console.WriteLine("Quotient is " + (fltNum1 / fltNum2));
            Console.WriteLine("Remainder is " + (fltNum1 % fltNum2));
            Console.ReadLine();        
        
        }
    }

   
}
