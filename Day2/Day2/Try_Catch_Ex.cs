using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2
{
    class Try_Catch_Ex
    {
        int result;
        Try_Catch_Ex()
        {
            result = 0;
        }

        public void Division(int num1, int num2) {

            try
            {
                result = num1 / num2;

                if (num2 == 0) {
                    throw new Exception();
                }
            }
                
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e) {

                Console.WriteLine(e);
            }
        
        }

        public static void Mai(String[] args) {

            Try_Catch_Ex t = new Try_Catch_Ex();
            t.Division(4,0);
            Console.ReadLine();

        }
    }
}
