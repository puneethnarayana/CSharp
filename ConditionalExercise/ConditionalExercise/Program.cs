    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace ConditionalExercise
    {
    class Program
    {
        static void Main(string[] args)
        {
            String strVal;
            Console.WriteLine("Enter the Production Costs of FY 14-15: ");
            strVal = Console.ReadLine();
            double dblPC = Convert.ToDouble(strVal);

            Console.WriteLine("Enter the Revenue of FY 14-15: ");
            strVal = Console.ReadLine();
            double dblRevenue = Convert.ToDouble(strVal);

            if(dblPC > dblRevenue){
                Console.WriteLine("Loss Incurred");
            }
            else if(dblRevenue > dblPC){
                Console.WriteLine("Made a Profit");
                }
            else{
                Console.WriteLine("Broke Even");
            }

            //Using Ternary Operator
            //Nested on the if side
            String result =  dblPC >= dblRevenue ? dblPC > dblRevenue ? "Loss Incurred" : "Broke Even" : "Profit Made";

            //Nested on the else side
            String result2 = dblPC > dblRevenue ? "Loss Incurred" : dblPC < dblRevenue? "Profit Made": "break even";

            Console.WriteLine(result);
            Console.WriteLine(result2);

            int intVar = 10;

            //SWITCH CASE
            switch (dblPC > dblRevenue)
            {
                case true: Console.WriteLine("Loss"); 
                    break;

                case false: Console.WriteLine("Profit");
                    break;

                default: Console.WriteLine("Some");
                    break;

            }


            Console.ReadLine();
        }
    }
    }
