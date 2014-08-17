using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_MiniBank
{
    class Account
    {
        public Account()
        {

        }

        public Account(double dblNewInterestRate, double dblOpeningBalance, Customer cust)
        {

            Custom = cust;
            DblBalanceAmount = dblOpeningBalance;
            DblInterestRate = dblNewInterestRate;

        }

        private Customer customer;
        public Customer Custom
        {
            get { return customer; }
            set { customer = value; }
        }

        private const int intBranchNumber = 77777;
       
        private int intAccountNumber;
        public int IntAccountNumber
        {
            get { return intAccountNumber; }
            set { intAccountNumber = value; }
        }


        //Concatanate Branch no with the account no.
        private double dblFullAccountNumber;
        public double DblFullAccountNumber
        {
            get { return dblFullAccountNumber; }
            set { dblFullAccountNumber = value; }
        }


        //CHECK: Should be greater than 0
        private double dblBalanceAmount;
        public double DblBalanceAmount
        {
            get { return dblBalanceAmount; }
            set { dblBalanceAmount = value; }
        }

        private double dblInterestRate = 10;
        public double DblInterestRate
        {
            get { return dblInterestRate; }
            set { dblInterestRate = value; }
        }

        public Account addAccount(Customer customer) {
            Account newac = new Account();
            AccountUtility acu = new AccountUtility();
            newac.Custom = customer;
            newac.IntAccountNumber = acu.getAccounttNumber();
            newac.DblInterestRate = acu.getInterestRate();
            newac.DblBalanceAmount = acu.getBalanceAmount();


            return newac;
        }

        public bool Deposit(int intACno, double dblCreditAmount)
        {
            bool boolACFound;
            if (Program.accounts.Count > 0 && Program.customers.Count > 0)
            {
                boolACFound = false;
                for (int i = 0; i < Program.accounts.Count;i++ )
                {
                    if(Program.accounts[i].IntAccountNumber == intACno)
                    {
                        boolACFound = true;
                        Program.accounts[i].DblBalanceAmount += dblCreditAmount;
                        Console.WriteLine(" Account no. " + Program.accounts[i].IntAccountNumber + 
                            " Current Balance: " + Program.accounts[i].DblBalanceAmount+
                            " Previous Balance: " + (Program.accounts[i].DblBalanceAmount-dblCreditAmount));
                       
                        return true;
                    }
                }

                if(!boolACFound){
                    Console.WriteLine("The Account Does Not Exist.");
                }

            }
            if (Program.customers.Count == 0)
            {
                Console.WriteLine("There are no Customers in our banking System. ");
            
            }
            if (Program.accounts.Count == 0)
            {
                Console.WriteLine("There are no Accounts in our banking System. ");

            }

            return false;
        }

        public bool WithDraw(int intACno, double dblDebitAmount)
        {
            bool boolValidAmount;
            bool boolACFound;

            if (Program.accounts.Count > 0 && Program.customers.Count > 0)
            {
                boolACFound = false;
                boolValidAmount = false;

                    for (int i = 0; i < Program.accounts.Count; i++)
                    {
                        if (Program.accounts[i].IntAccountNumber == intACno)
                        {
                            boolACFound = true;
                            while (!boolValidAmount)
                            {
                                if (Program.accounts[i].DblBalanceAmount > dblDebitAmount + 1000)
                                {
                                    Program.accounts[i].DblBalanceAmount -= dblDebitAmount;
                                    Console.WriteLine(" Account no. " + Program.accounts[i].IntAccountNumber +
                                        " Current Balance: " + Program.accounts[i].DblBalanceAmount +
                                        " Previous Balance: " + (Program.accounts[i].DblBalanceAmount + dblDebitAmount));

                                    boolValidAmount = true;

                                    return true;
                                }
                                if ((Program.accounts[i].DblBalanceAmount - dblDebitAmount) < 1000)
                                {

                                    Console.WriteLine("Not Enough Funds to perform the operation.");
                                    Console.WriteLine("You Current Balance is: " + Program.accounts[i].DblBalanceAmount);
                                    Console.WriteLine("You can withdraw: " + (Program.accounts[i].DblBalanceAmount - 1000));
                                    
                                }
                            }
                        }

                    if (!boolACFound)
                    {
                        Console.WriteLine("The Account Does Not Exist.");
                    }


                }
            }
            else if (Program.customers.Count == 0)
            {
                Console.WriteLine("There are no Customers in our banking System. ");

            }
            else if (Program.accounts.Count == 0)
            {
                Console.WriteLine("There are no Accounts in our banking System. ");

            }

            return false;
        }

        public bool Transfer(int intSourceAccount, int intDestinationAccount, double dblTransferAmount)
        {
            WithDraw(intSourceAccount,dblTransferAmount);
            Deposit(intDestinationAccount, dblTransferAmount);

            return false;
        }

        public double getBankTotalAmount()
        {
            double dblTotalAmountInBank = 0;

            if (Program.accounts.Count > 0 && Program.customers.Count > 0)
            {
                for (int i = 0; i < Program.accounts.Count; i++)
                {
                    dblTotalAmountInBank += Program.accounts[i].DblBalanceAmount;
                }
                return dblTotalAmountInBank;
            }
            else if (Program.customers.Count == 0)
            {
                Console.WriteLine("There are no Customers in our banking System. ");

            }
            else if (Program.accounts.Count == 0)
            {
                Console.WriteLine("There are no Accounts in our banking System. ");

            }

            return 0;
        }

        public bool calculateInterest(int intActNoToUpdate)
        {

            if (Program.accounts.Count > 0 && Program.customers.Count > 0)
            {
                for (int i = 0; i < Program.accounts.Count; i++)
                {

                    if (Program.accounts[i].IntAccountNumber == intActNoToUpdate)
                    {
                    double dblTemp = Program.accounts[i].DblBalanceAmount;
                    Program.accounts[i].DblBalanceAmount = dblTemp + (dblTemp) * (dblInterestRate / 100);
                    Console.WriteLine(" Account no. " + Program.accounts[i].IntAccountNumber +
                        " Current Balance: " + Program.accounts[i].DblBalanceAmount +
                        " Previous Balance: " + dblTemp);
                    }
                }
                return true;


            }
            else if (Program.customers.Count == 0)
            {
                Console.WriteLine("There are no Customers in our banking System. ");

            }
            else if (Program.accounts.Count == 0)
            {
                Console.WriteLine("There are no Accounts in our banking System. ");

            }

            return false;
        }

        public bool calculateInterestAllAccounts()
        {

            if (Program.accounts.Count > 0 && Program.customers.Count > 0)
            {
                for (int i = 0; i < Program.accounts.Count;i++)
                {
                        double dblTemp = Program.accounts[i].DblBalanceAmount;
                        Program.accounts[i].DblBalanceAmount = dblTemp+ (dblTemp)*(dblInterestRate/100);
                        Console.WriteLine(" Account no. " + Program.accounts[i].IntAccountNumber +
                            " Current Balance: " + Program.accounts[i].DblBalanceAmount +
                            " Previous Balance: " + dblTemp);
                      
                 }
                return true;
      

            }
            else if (Program.customers.Count == 0)
            {
                Console.WriteLine("There are no Customers in our banking System. ");

            }
            else if (Program.accounts.Count == 0)
            {
                Console.WriteLine("There are no Accounts in our banking System. ");

            }

            return false;
        }


        public Account DisplayONEAccount(int AcNO )
        {
            bool boolAccExists;
            bool boolCustomerExists;
            Account acc = new Account() ;

            if (Program.customers.Count > 0)
            {
                boolCustomerExists = false;
                boolAccExists = false;

               
                       for (int j = 0; j < Program.accounts.Count; j++)
                        {
                            if (Program.accounts[j].IntAccountNumber == AcNO)
                            {

                                boolCustomerExists = true;
                                boolAccExists = true;
                                Console.WriteLine("--------------------------------------------------------");
                                Console.WriteLine("Customer Details: ");
                                Console.WriteLine(" Customer Name: " + Program.accounts[j].Custom.StrCustomerName);
                                Console.WriteLine(" Customer Address: " + Program.accounts[j].Custom.FullAddress);
                                Console.WriteLine();

                                boolAccExists = true;
                                Console.WriteLine("========== Account Details: ");
                                Console.WriteLine(" Account No: " + Program.accounts[j].IntAccountNumber);
                                Console.WriteLine(" Branch No: " + Program.accounts[j].DblFullAccountNumber);
                                Console.WriteLine(" Balance Amount: " + Program.accounts[j].DblBalanceAmount);
                                Console.WriteLine(" Interest Rate: " + Program.accounts[j].DblInterestRate);
                                Console.WriteLine();

                                acc = Program.accounts[j];
                            }


                        

                        // Console.WriteLine("asas"+intAccExists);
                        if (boolAccExists == false)
                        {
                            Console.WriteLine("This Customer has not yet opened an account");
                        }
                    }
                if (!boolCustomerExists)
                {
                    Console.WriteLine(" No Customer by this name in our system");
                }

                return acc;
                
                
            }
            else if (Program.customers.Count == 0)
            {
                Console.WriteLine("There are no Customers in our banking System. ");

            }
            return null;
        }



    }
}
