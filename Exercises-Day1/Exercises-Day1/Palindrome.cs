using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises_Day1
{
    class Palindrome
    {
        static void Mai(String[] args)
        {

            String strInput;
            Console.WriteLine("Enter A String");
            strInput = Console.ReadLine();

            char[] chrArray = strInput.ToCharArray();
            bool pal = true;

            for (int i = 0; i < chrArray.Length; i++)
            {
                for (int j = chrArray.Length - 1; j >= 0; j--)
                {
                    if (chrArray[i].Equals(chrArray[j]))
                    {
                        pal = true;
                    }
                    else
                    {
                        pal = false;
                        break;
                    }
                }
            }

            Console.WriteLine(pal);
            Console.ReadLine();
        }

    }
}
