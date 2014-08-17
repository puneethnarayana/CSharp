using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchExercise
{
    class Loops
    {
        static void Loo(String[] args){
        String strInput;
           // bool Ingestion = true;
            int[] intNos = new int[10];

            for(int i=0;i<10;i++){
            Console.WriteLine("Enter The Numbers");
            strInput = Console.ReadLine();
            intNos[i] = Convert.ToInt32(strInput);
        }

            Console.WriteLine("-----------------------------------");

            double dblAvg = 0;

            for (int i = 0; i < 10; i++)
            {
                dblAvg += intNos[i];
            }

            Console.WriteLine("The Average of the ten entered nos. is "+dblAvg/10);
            Console.ReadLine();
        }
        }
    }
