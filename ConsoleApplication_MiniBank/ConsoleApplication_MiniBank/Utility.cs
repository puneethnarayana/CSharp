using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication_MiniBank
{
    class Utility
    {

        public void MainMenu()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Welcome to Iron Banks: ");
            Console.WriteLine(" 1. Add customer");
            Console.WriteLine(" 2. Get customer Details ");
            Console.WriteLine(" 3. Update Customer Address");
            Console.WriteLine(" 4. Display all customers ");
            Console.WriteLine(" 5. Add Account ");
            Console.WriteLine(" 6. Get account details ");
            Console.WriteLine(" 7. Get total number of Customers and accounts ");
            Console.WriteLine(" 8. Calculate interest ");
            Console.WriteLine(" 9. Calculate interest on all accounts");
            Console.WriteLine(" 10. Deposit Amount");
            Console.WriteLine(" 11. Withdraw Amount");
            Console.WriteLine(" 12. Transfer Amount");
            Console.WriteLine(" 13. Get Total Money in the Bank");
            Console.WriteLine(" 14. Quit application. ");
            int intChoice = getUserInput();
            Router(intChoice); 

        }

        public static Boolean isNumeric(string strToCheck)
        {
            Regex rg = new Regex(@"^[0-9]*$");
            return rg.IsMatch(strToCheck);
        }

        public int getUserInput()
        {
            bool boolInputReceived = false;
            
                while(!boolInputReceived){
                String strInput;
                Console.WriteLine("Select an Option between 1-14 ");
                strInput = Console.ReadLine();
                int intOption;

                if (Utility.isNumeric(strInput) && strInput.Length>0)
                {
                    intOption = Int32.Parse(strInput);
                    if (intOption < 15 && intOption > 0)
                    {
                        boolInputReceived = true;

                        return intOption;
                    }
                    else{
                        Console.WriteLine("ONLY input values between 1 to 14. ");
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

        public void Router(int intMainMenuOption) { 
        
            switch(intMainMenuOption){

                case 1: Customer c1 = new Customer();
                    Program.customers.Add(c1.addCustomer());
                    MainMenu();
                    break;

                case 2: Customer c2 = new Customer();
                    CustomerUtility csu = new CustomerUtility();
                    String strInput = csu.getCustomerName();
                    c2.DisplayONECustomerDetails(strInput);
                    MainMenu();
                    break;

                case 3: Customer c3 = new Customer();
                    CustomerUtility csu3 = new CustomerUtility();
                    String strCName = csu3.getCustomerName();
                    Customer editing = c3.DisplayONECustomerDetails(strCName);
                    Console.WriteLine("Enter the new address parameters: ");
                    String strCity = csu3.getCityName();
                    String strStreet = csu3.getStreetName();
                    int intHN = csu3.getHouseNumber();
                    int intIndex = c3.getIndexCustomerInList(strCName);
                    c3.UpdateCustomerAddress(intHN, strStreet, strCity, editing);
                    Program.customers.RemoveAt(intIndex);
                   
                    MainMenu();
                    break;

                case 4: Customer c4 = new Customer();
                    c4.DisplayCustomerDetails();
                    MainMenu(); 
                    break;

                case 5: Customer c5 = new Customer();
                    Account a5 = new Account();
                    Console.WriteLine("Do you create an account for an existing user or a new user");
                    Console.WriteLine("1. Existing 2. New User");
                    strInput = Console.ReadLine();
                    int intopt = Convert.ToInt32(strInput);
                    if(intopt == 1){
                        c5.DisplayCustomerDetails();
                        Console.WriteLine("Choose the customer name to create account on: ");
                        strInput = Console.ReadLine();
                        Customer cOps = c5.DisplayONECustomerDet(strInput);
                        Program.accounts.Add(a5.addAccount(cOps));
                        Console.WriteLine("Account Successfully Added");
                    }

                    if (intopt == 2)
                    {
                        Console.WriteLine(" Creating a new customers : ");
                        Program.customers.Add(c5.addCustomer());
                        c5.DisplayCustomerDetails();
                        Console.WriteLine("Choose the customer name to create account on: ");
                        strInput = Console.ReadLine();
                        Customer cOps = c5.DisplayONECustomerDetails(strInput);
                        Program.accounts.Add(a5.addAccount(cOps));
                        Console.WriteLine("Account Successfully Added");
                    }
                   
                    MainMenu();
                    break;
                case 6:
                    Console.WriteLine("How to want to search the account");
                    Console.WriteLine("1. Customer Name 2. Full Account No.");
                    strInput = Console.ReadLine();
                    int intops = Convert.ToInt32(strInput);
                    if(intops == 1 ) {
                        Customer cs6 = new Customer();
                        Console.WriteLine("Enter Customer Name: ");
                        strInput = Console.ReadLine();
                        cs6.DisplayONECustomerDetails(strInput);
                    }
                    if (intops == 2)
                    {
                        Account a6 = new Account();
                        Console.WriteLine("Enter Account No: ");
                        strInput = Console.ReadLine();
                        int intAAC = Convert.ToInt32(strInput);
                        a6.DisplayONEAccount(intAAC);
                    }
                    MainMenu();
                    break;
                case 7: Console.WriteLine(" The Number of Customers are: "+Program.customers.Count);
                    Console.WriteLine(" The Number of Accounts are: " +Program.accounts.Count);

                    MainMenu();
                    break;
                case 8:
                    Account a8 = new Account();
                    Console.WriteLine("Enter Account No: ");
                        strInput = Console.ReadLine();
                        int intToUpdate = Convert.ToInt32(strInput);
                        a8.calculateInterest(intToUpdate);

                    MainMenu();
                    break;

                case 9: Account a9 = new Account();
                    a9.calculateInterestAllAccounts();
                        Console.WriteLine("All Account Balances Updated");

                    MainMenu();
                    break;

                case 10: Account a10 = new Account();
                   Console.WriteLine("Enter Account No where money is to be Deposited: ");
                        strInput = Console.ReadLine();
                        int intACToUpdate = Convert.ToInt32(strInput);
                   Console.WriteLine("Enter Amount to deposit: ");
                        strInput = Console.ReadLine();
                        double dblAmountToUpdate = Convert.ToInt32(strInput);
                    a10.Deposit(intACToUpdate, dblAmountToUpdate);

                    MainMenu();
                    break;

                case 11: Account a11 = new Account();
                    Console.WriteLine("Enter Account No where money is to be Withdrawn: ");
                    strInput = Console.ReadLine();
                    int intACFrom= Convert.ToInt32(strInput);
                    Console.WriteLine("Enter Amount to remove ");
                    strInput = Console.ReadLine();
                    double dblAmountToRemove = Convert.ToInt32(strInput);
                    a11.WithDraw(intACFrom, dblAmountToRemove);

                    MainMenu();
                    break;

                case 12: Account a12 = new Account();
                    Console.WriteLine("Enter Account No where money is to be removed: ");
                    strInput = Console.ReadLine();
                    int intACSource = Convert.ToInt32(strInput);
                    Console.WriteLine("Enter Account No where money is to be deposited: ");
                    strInput = Console.ReadLine();
                    int intACDestination = Convert.ToInt32(strInput);
                    Console.WriteLine("Enter Amount to Transfer: ");
                    strInput = Console.ReadLine();
                    double dblAmountToTransfer = Convert.ToInt32(strInput);
                    a12.Transfer(intACSource,intACDestination, dblAmountToTransfer);

                    MainMenu();
                    break;

                case 13: Account a13 = new Account();
                        Console.WriteLine(" Total Money in the Bank is: "+a13.getBankTotalAmount());
                        MainMenu();
                    break;

                case 14: Console.WriteLine(" Hope to see you again! Good Bye");
                    break;

                default: MainMenu(); 
                    break;
            
            }

        
        }


    }
}
