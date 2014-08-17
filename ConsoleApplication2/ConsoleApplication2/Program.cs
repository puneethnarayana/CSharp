using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            String strFirstName;
            String strLastName;

            Console.WriteLine("Enter your First Name");
            strFirstName = Console.ReadLine();
            int intLengthFName = strFirstName.Length;
            Console.WriteLine("Enter your Last Name");
            strLastName = Console.ReadLine();
            int intLengthLName = strFirstName.Length;

            String strPhrase = "Welcome," + strFirstName + "," + strLastName + "!";
            Console.WriteLine("Welcome,"+strFirstName+","+strLastName+"!");

            String strQuery = "come";

            //Checks if substring exists
            Console.WriteLine(strPhrase.Contains(strQuery));
            bool contains = strPhrase.Contains(strQuery);
            //Gets the Index 
            if (contains)
            {
                int intIndex = strPhrase.IndexOf(strQuery);
                
                Console.WriteLine(intIndex);
                int intSize = strQuery.Length;
                Console.WriteLine("Last letter at index: " + (intSize + intIndex));
              
            }

            //USING SUBSTRINGS
            int intCommaIndex = strPhrase.IndexOf(",");
            Console.WriteLine(strPhrase.Substring(intCommaIndex + 1));
            Console.WriteLine(strPhrase.Substring(intCommaIndex+1,strPhrase.Length-intCommaIndex-2));
            
            //REPLACEMENT LOGIC
            String strTemp1 = strPhrase.Substring(0, (strPhrase.IndexOf(strQuery)));
           // Console.WriteLine(strTemp1);
            String strTemp2 = strPhrase.Substring(strPhrase.IndexOf(strQuery), strQuery.Length);
           // Console.WriteLine(strTemp2);
            String strTemp3 = strPhrase.Substring(strPhrase.IndexOf(strQuery) + strQuery.Length);
           // Console.WriteLine(strTemp3);
            String strReplace = "go";

            String strFinal = strTemp1 + strReplace + strTemp3;
            Console.WriteLine(strFinal);
            
            //REPLACEMENT FUNCTION
           Console.WriteLine(strPhrase.Replace("come","go"));
           

           Console.ReadLine();
        }
    }
}
