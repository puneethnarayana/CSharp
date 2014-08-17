using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication_MiniBank
{
    class CustomerUtility
    {
        public static Boolean isAlphabetic(string strToCheck)
        {
            Regex rg = new Regex(@"^[a-zA-Z]*$");
            return rg.IsMatch(strToCheck);
        }

        public static Boolean isAlphNumeric(string strToCheck)
        {
            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            return rg.IsMatch(strToCheck);
        }

        public String getCustomerName()
        {
            bool boolInputReceived = false;
            try
            {
                while (!boolInputReceived)
                {
                    String strInput;
                    Console.WriteLine("Please Enter the Customer Name:");
                    strInput = Console.ReadLine();

                    if (isAlphabetic(strInput) && strInput.Length < 40 && Customer.canCreateCustomer(strInput))
                    {
                        boolInputReceived = true;
                        return strInput;
                    }
                    if(strInput.Length>=40)
                    {
                        Console.WriteLine("Please Input Names less than 40 characters");
                        Console.WriteLine();
                    }
                    if (!Customer.canCreateCustomer(strInput))
                    {
                        Console.WriteLine("The Customer Already Exists");
                    }
                    if (!isAlphabetic(strInput))
                    {
                        Console.WriteLine("Please Input Only String Inputs! "
                         + "Do Not Use numeric or Special characters");
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            return null;
        }

        public int getHouseNumber()
        {
            bool boolInputReceived = false;

            while (!boolInputReceived)
            {
                String strInput;
                Console.WriteLine("Enter the House Number (1-10000)");
                strInput = Console.ReadLine();
                int intOption;

                if (Utility.isNumeric(strInput))
                {
                    intOption = Int32.Parse(strInput);
                    if (intOption < 10000)
                    {
                        boolInputReceived = true;

                        return intOption;
                    }
                    else
                    {
                        Console.WriteLine("House No can only be FOUR digits or below");
                        Console.WriteLine();
                    }
                }
               
                if (!Utility.isNumeric(strInput))
                {
                    Console.WriteLine("Please Input ONLY integer values.");
                    Console.WriteLine();
                }
            }
         return 0;
        }


        public String getStreetName()
        {
            bool boolInputReceived = false;
            try
            {
                while (!boolInputReceived)
                {
                    String strInput;
                    Console.WriteLine("Please Enter the Street Name:");
                    strInput = Console.ReadLine();

                    if (isAlphNumeric(strInput) && strInput.Length < 50)
                    {
                        boolInputReceived = true;
                        return strInput;
                    }
                    if (strInput.Length >= 40)
                    {
                        Console.WriteLine("Please Input Names less than 50 characters");
                        Console.WriteLine();
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            return null;
        }

        public String getCityName()
        {
            bool boolInputReceived = false;
            try
            {
                while (!boolInputReceived)
                {
                    String strInput;
                    Console.WriteLine("Please Enter the City Name:");
                    strInput = Console.ReadLine();

                    if (isAlphabetic(strInput) && strInput.Length < 20)
                    {
                        boolInputReceived = true;
                        return strInput;
                    }
                    if (strInput.Length >= 40)
                    {
                        Console.WriteLine("Please Input Names less than 20 characters");
                        Console.WriteLine();
                    }
                    if (!isAlphabetic(strInput))
                    {
                        Console.WriteLine("Please Input Only String Inputs! "
                         + "Do Not Use numeric or Special characters");
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            return null;
        }
        
        public int getAge()
        {
            bool boolInputReceived = false;

            while (!boolInputReceived)
            {
                String strInput;
                Console.WriteLine("Please Enter your Age: ");
                strInput = Console.ReadLine();
                int intOption;

                if (Utility.isNumeric(strInput))
                {
                    intOption = Int32.Parse(strInput);
                    if (intOption > 15 && intOption < 101)
                    {
                        boolInputReceived = true;

                        return intOption;
                    }
                    else
                    {
                        Console.WriteLine("Customers can Open Account ONLY between the ages of 16 to 100. ");
                        Console.WriteLine();
                    }
                }
                if (!Utility.isNumeric(strInput))
                {
                    Console.WriteLine("Please Input ONLY integer values!!");
                    Console.WriteLine();
                }
            }
            return 0;
        }

        public double getContactNumber()
        {
            bool boolInputReceived = false;

            while (!boolInputReceived)
            {
                String strInput;
                Console.WriteLine("Please Enter a Valid Ten Digit Phone No.");
                strInput = Console.ReadLine();
                double dblOption;

                if (Utility.isNumeric(strInput) && strInput.StartsWith("9") && strInput.Length==10)
                {
                    //char[] Nos = strInput.ToCharArray();
                    

                    dblOption = Convert.ToDouble(strInput);
                    //Console.WriteLine(" The Tel No. is "+dblOption);

                    
                        boolInputReceived = true;
                        return dblOption;
                    }

                if (Utility.isNumeric(strInput) && strInput.Length!=10)
                {
                    Console.WriteLine("Valid Telephone No. starts with 9 and is TEN digits long");
                    Console.WriteLine();
                }

                if (Utility.isNumeric(strInput) && !strInput.StartsWith("9"))
                    {
                        Console.WriteLine("Valid Telephone No. starts with 9 ");
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
    }
}
