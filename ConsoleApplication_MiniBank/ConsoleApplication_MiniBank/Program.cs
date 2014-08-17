using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_MiniBank
{
    class Program
    {
        public static List<Account> accounts = new List<Account>();
        public static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            
            Utility util = new Utility();
            //util.MainMenu();
            

            //Console.WriteLine("yeah it returns "+intChoice);
            
            

           /* 
            CustomerUtility csutil = new CustomerUtility();
            csutil.getCustomerName();
            csutil.getHouseNumber();
            csutil.getStreetName();
            csutil.getCityName();
            csutil.getAge();
            csutil.getContactNumber();
            */

            
            AccountUtility acu = new AccountUtility();
            /*
            acu.getAccounttNumber();
            acu.getBalanceAmount();
            acu.getInterestRate();
            */
            
            
            Customer cs1 = new Customer("Puneeth",12,"Malgudi Street","Bengaluru",24,9884459932);
            customers.Add(cs1);

            Account ac1 = new Account();
            ac1.Custom = cs1;
            ac1.DblBalanceAmount = 10000;
            ac1.IntAccountNumber = 12345;
            accounts.Add(ac1);

            Account ac2 = new Account();
            ac2.Custom = cs1;
            ac2.DblBalanceAmount = 100000;
            ac2.IntAccountNumber = 23456;
            accounts.Add(ac2);

            

            /*
            ac1.Deposit(12345,15000);
            ac1.WithDraw(12345, 78000);

            Console.WriteLine(ac1.getBankTotalAmount());
            Console.WriteLine(ac2.getBankTotalAmount());

           // ac1.calculateInterestAllAccounts();

            ac1.calculateInterest(ac2.IntAccountNumber);
             */

            
            Customer cs2 = new Customer("Supreeth", 832, "Rangappa Beedi", "Mysooru", 19, 8867909775);
            customers.Add(cs2);
            util.MainMenu();
            
           // cs1.DisplayCustomerDetails();
            //Console.WriteLine("But where");
           // cs1.DisplayONECustomerDetails("Puneeth");
            //Console.WriteLine(acu.isAccountNoAvailable(12315));
            //Console.WriteLine(acu.generateFullAcNo(12345));
       
            Console.ReadLine();
        }
    }
}
