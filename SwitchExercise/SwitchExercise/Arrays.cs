using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchExercise
{
    class Arrays
    {
        static void arrays(string[] args)
        {
            String strInput;
           // bool Ingestion = true;
            String[] Names = new String[5];

            for(int i=0;i<5;i++){
            Console.WriteLine("Enter Your Names");
            strInput = Console.ReadLine();
            Names[i] = strInput;
        }

            Console.WriteLine("----Names in the Order entered--");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Names[i]);
            }

            Console.WriteLine("----Names in the Reverse of the order entered--");

            for (int i = 4; i >=0 ; i--)
            {
                Console.WriteLine(Names[i]);
            }
            Console.ReadLine();
        }
    }
}
