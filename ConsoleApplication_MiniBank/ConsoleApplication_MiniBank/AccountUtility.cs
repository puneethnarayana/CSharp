using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_MiniBank
{
    class AccountUtility
    {
        public int getAccounttNumber()
        {
            bool boolInputReceived = false;

            while (!boolInputReceived)
            {
                String strInput;
                Console.WriteLine("Please Enter a Valid 5 Digit ACCOUNT No.");
                strInput = Console.ReadLine();
                int intOption;

                if (Utility.isNumeric(strInput) && strInput.Length == 5)
                {
                    //char[] Nos = strInput.ToCharArray();
                    
                    intOption = Convert.ToInt32(strInput);
                   // Console.WriteLine(" The Account No. is " + intOption);

                    if(intOption > 11110 && isAccountNoAvailable(intOption))
                    {
                    boolInputReceived = true;
                    return intOption;
                    }

                    if (!isAccountNoAvailable(intOption))
                    {
                        Console.WriteLine("Account no. Already Assigned.");
                    }

                    if(intOption < 11111)
                    {
                        Console.WriteLine(" The Account No. can only start from 11111");
                    }
                    }

                if (Utility.isNumeric(strInput) && strInput.Length != 5)
                {
                    Console.WriteLine("Valid Account no is FIVE digits long");
                    Console.WriteLine();
                }

                if (!Utility.isNumeric(strInput) || strInput.Equals(""))
                {
                    Console.WriteLine("Please Input ONLY integer values!!");
                    Console.WriteLine();
                }
            }
            return 0;
        }

        public bool isAccountNoAvailable(int intAC) {

            if (Program.accounts.Count == 0)
                return true;
            
            foreach (Account ac in Program.accounts) {
                if (ac.IntAccountNumber == intAC) {
                    return false;
                    }
            }
            return true;        
        }

        public double generateFullAcNo(int intAC) {

            String strtmp = Convert.ToString(intAC);
            String strBranch = "77777";
            String Total = strBranch + strtmp;
            Double dblFullNo = Convert.ToDouble(Total);

            return dblFullNo;
        }

        public double getInterestRate()
        {
            bool boolInputReceived = false;

            while (!boolInputReceived)
            {
                String strInput;
                Console.WriteLine("Please Enter the Interest Rate.");
                strInput = Console.ReadLine();
                double dblOption;

                if (Utility.isNumeric(strInput))
                {
                    //char[] Nos = strInput.ToCharArray();

                    dblOption = Convert.ToInt32(strInput);
                    //Console.WriteLine(" The Account No. is " + dblOption);

                    if (dblOption < 21 && dblOption >= 4)
                    {
                        boolInputReceived = true;
                        return dblOption;
                    }
                    if (dblOption < 4)
                    {
                        Console.WriteLine("Aah.. We wish we could give you less interest but Govt says give 4 atleast");
                    }
                    if (dblOption > 20)
                    {
                        Console.WriteLine("This is a BANK not a charity");
                    }
                }

             
                if (!Utility.isNumeric(strInput) || strInput.Equals(""))
                {
                    Console.WriteLine("Please Input ONLY integer values!!");
                    Console.WriteLine();
                }
            }
            return 10;
        }


        public double getBalanceAmount()
        {
            bool boolInputReceived = false;

            while (!boolInputReceived)
            {
                String strInput;
                Console.WriteLine("Please Enter the Opening Balance.");
                strInput = Console.ReadLine();
                double dblOption;

                if (Utility.isNumeric(strInput) && strInput.Length!=0)
                {
                     dblOption = Convert.ToInt32(strInput);
                    //Console.WriteLine(" The Balance No. is " + dblOption);

                    if (dblOption > 1000)
                    {
                        boolInputReceived = true;
                        return dblOption;
                    }
                    if (dblOption < 1000)
                    {
                        Console.WriteLine(" The Opening Balance has to more than 1000");
                    }
                }

                if (!Utility.isNumeric(strInput) || strInput.Equals(""))
                {
                    Console.WriteLine("Please Input ONLY Numeric values!!");
                    Console.WriteLine();
                }
            }
            return 0;
        }
    }
}
