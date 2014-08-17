using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchExercise
{
    class StringSplit
    {
        static void Ssplit(String[] args) {
            //String strNames = "Puneeth,Bhargav,Sankeerth,Divya,Abhipsa,Saili,Aanchal,Maatrika,Guruneet";

            String strInput;
            Console.WriteLine("Enter the Comma separated names in a single string: ");
            strInput = Console.ReadLine();

            String[] tokens = strInput.Split(',');

            int intSize = tokens.Length;

            Console.WriteLine("Untrimmed Data");
            foreach(string token in tokens){
                //String tok = token.Trim();
                Console.WriteLine(token);
            }

            //Trims all the whitespaces
            for (int i = 0; i < intSize; i++) {
                tokens[i] = tokens[i].Trim();
            }


            Console.WriteLine("Trimmed Data");
            foreach (string token in tokens)
            {
                Console.WriteLine(token);
            }

            Console.WriteLine("Middle Element(s)");
            if (intSize % 2 == 0)
            {
                Console.WriteLine(tokens[(intSize / 2)-1]);
                Console.WriteLine(tokens[intSize / 2]);
            }

            else {
                Console.WriteLine(tokens[intSize/2]);
            }
            
            Console.ReadLine();
        }
    }
}
