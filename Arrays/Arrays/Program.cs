using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String strInput;
            bool Ingestion = true;
            String[] Names = new String[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Your Names");
                strInput = Console.ReadLine();
                Names[i] = strInput;
            }

            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Names[i]);
            }

            Console.ReadLine();
        }
    }
}
