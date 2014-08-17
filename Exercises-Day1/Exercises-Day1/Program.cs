using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises_Day1
{
    class Program
    {
        static double getSalary() {
            String strInput;
            Console.WriteLine("Enter Your Salary");
            strInput = Console.ReadLine();
            double dblSalary = Convert.ToDouble(strInput);
            return dblSalary;
        }

        static int getSlab(double dblSal) {

            int intSlabType = dblSal <= 100000? dblSal < 10000? 1:2 :3;
            return intSlabType;
        }

        static void Ma(string[] args)
        {
            bool session = true;

            while (session)
            {
                double dblSal = getSalary();
                int intSlabType = getSlab(dblSal);
                Console.WriteLine(intSlabType);

                switch (intSlabType)
                {
                    case 1: Console.WriteLine("The Tax Payable by You is: Rs."+0.05 * dblSal);
                        break;
                    case 2: Console.WriteLine("The Tax Payable by You is: Rs." + 0.08 * dblSal);
                        break;
                    case 3: Console.WriteLine("The Tax Payable by You is: Rs." + 0.085 * dblSal);
                        break;
                    default:
                        Console.WriteLine("Please Check the input");
                        break;
                }

                Console.WriteLine("Do You Want to Continue?! Y/N");
                String strInput = Console.ReadLine();

                if (strInput.Equals("Y"))
                {
                    continue;
                }
                else {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
