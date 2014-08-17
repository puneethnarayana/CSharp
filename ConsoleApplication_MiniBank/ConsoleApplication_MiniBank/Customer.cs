using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_MiniBank
{
    class Customer
    {
        public Customer()
        {

        }

        //Name,House No,Street,City,Age ,Contact number
        public Customer(String strName, int intHNo, String strStreet, String strCity, int intAge, double dblContact)
        {
            StrCustomerName = strName;
            IntHouseNumber = intHNo;
            StrStreetName = strStreet;
            StrCity = strCity;
            IntAge = intAge;
            DblPhoneNo = dblContact;
        }

        //ContactNumber and Age will be set to 9999999999 and 21 respectively
        public Customer(String strName, int intHNo, String strStreet, String strCity)
        {
            StrCustomerName = strName;
            IntHouseNumber = intHNo;
            StrStreetName = strStreet;
            StrCity = strCity;
            IntAge = 21;
            DblPhoneNo = 9999999999;
        }

        public Customer addCustomer() { 
        
            CustomerUtility csu=new CustomerUtility();
            Customer c = new Customer(csu.getCustomerName(),csu.getHouseNumber(),csu.getStreetName(),csu.getCityName(),csu.getAge(),csu.getContactNumber());
            Console.WriteLine("Customer added to database");

            return c;
        }

        private string strCustomerName;
        public string StrCustomerName
        {
            get { return strCustomerName; }
            set { strCustomerName = value; }
        }

        private int intHouseNumber;
        public int IntHouseNumber
        {
            get { return intHouseNumber; }
            set { intHouseNumber = value; }
        }

        private String strStreetName;
        public String StrStreetName
        {
            get { return strStreetName; }
            set { strStreetName = value; }
        }

        private String strCity;
        public String StrCity
        {
            get { return strCity; }
            set { strCity = value; }
        }

        private int intAge;
        public int IntAge
        {
            get { return intAge; }
            set { intAge = value; }
        }

        private double dblPhoneNo;
        public double DblPhoneNo
        {
            get { return dblPhoneNo; }
            set { dblPhoneNo = value; }
        }

        //private String FullDetails;
        public String FullDetails
        {
            get { return (StrCustomerName +","+ IntAge + ","+FullAddress); }
        }

        public String FullAddress
        {
            get { return (IntHouseNumber + ","+StrStreetName+","+StrCity); }
        }

        public void DisplayCustomerDetails()
        {
            bool boolAccExists;
             
            if (Program.customers.Count > 0)
            {
                

                for (int i = 0; i < Program.customers.Count; i++)
                {
                    boolAccExists = false;
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Customer Details: ");
                    Console.WriteLine(" Customer Name: "+Program.customers[i].StrCustomerName);
                    Console.WriteLine(" Customer Address: "+Program.customers[i].FullAddress);
                    Console.WriteLine();

                    for (int j = 0; j < Program.accounts.Count; j++ )
                    {
                        if (Program.accounts[j].Custom.StrCustomerName.Equals(Program.customers[i].StrCustomerName))
                        {

                            boolAccExists = true;
                            Console.WriteLine("========== Account Details: ");
                            Console.WriteLine(" Account No: " + Program.accounts[j].IntAccountNumber);
                            Console.WriteLine(" Branch No: " + Program.accounts[j].DblFullAccountNumber);
                            Console.WriteLine(" Balance Amount: " + Program.accounts[j].DblBalanceAmount);
                            Console.WriteLine(" Interest Rate: " + Program.accounts[j].DblInterestRate);
                            Console.WriteLine();
                        }
                       

                    }

                   // Console.WriteLine("asas"+intAccExists);
                    if(boolAccExists==false){
                        Console.WriteLine("This Customer has not yet opened an account");
                    }
                }

            }
            else if (Program.customers.Count == 0)
            {
                Console.WriteLine("There are no Customers in our banking System. ");

            }
            
        }

        public int getIndexCustomerInList(String strCN) {

           
            bool boolCustomerExists;

            if (Program.customers.Count > 0)
            {
                boolCustomerExists = false;
                for (int i = 0; i < Program.customers.Count; i++)
                {


                    if (Program.customers[i].StrCustomerName.Equals(strCN))
                    {
                        boolCustomerExists = true;
                       

                        return i;
                    }


                }
                if (!boolCustomerExists)
                {
                    Console.WriteLine(" No Customer by this name in our system");
                }
            }
            else if (Program.customers.Count == 0)
            {
                Console.WriteLine("There are no Customers in our banking System. ");

            }
            return 0;
        
        }

        public Customer DisplayONECustomerDetails(String StrCustomerName)
        {
            bool boolAccExists;
            bool boolCustomerExists;

            if (Program.customers.Count > 0)
            {
                boolCustomerExists = false;
                for (int i = 0; i < Program.customers.Count; i++)
                {
                    

                    if (Program.customers[i].StrCustomerName.Equals(StrCustomerName))
                    {
                        boolCustomerExists = true;
                        boolAccExists = false;
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Customer Details: ");
                        Console.WriteLine(" Customer Name: " + Program.customers[i].StrCustomerName);
                        Console.WriteLine(" Customer Address: " + Program.customers[i].FullAddress);
                        Console.WriteLine();

                        for (int j = 0; j < Program.accounts.Count; j++)
                        {
                            if (Program.accounts[j].Custom.StrCustomerName.Equals(Program.customers[i].StrCustomerName))
                            {

                                boolAccExists = true;
                                Console.WriteLine("========== Account Details: ");
                                Console.WriteLine(" Account No: " + Program.accounts[j].IntAccountNumber);
                                Console.WriteLine(" Branch No: " + Program.accounts[j].DblFullAccountNumber);
                                Console.WriteLine(" Balance Amount: " + Program.accounts[j].DblBalanceAmount);
                                Console.WriteLine(" Interest Rate: " + Program.accounts[j].DblInterestRate);
                                Console.WriteLine();
                            }


                        }

                        // Console.WriteLine("asas"+intAccExists);
                        if (boolAccExists == false)
                        {
                            Console.WriteLine("This Customer has not yet opened an account");
                        }

                        return Program.customers[i];
                    }

                   
                }
                if (!boolCustomerExists)
                {
                    Console.WriteLine(" No Customer by this name in our system");
                }
            }
            else if (Program.customers.Count == 0)
            {
                Console.WriteLine("There are no Customers in our banking System. ");

            }
            return null;
        }
        

        public Customer DisplayONECustomerDet(String StrCustomerName)
        {
            bool boolAccExists;
            bool boolCustomerExists;

            if (Program.customers.Count > 0)
            {
                boolCustomerExists = false;
                for (int i = 0; i < Program.customers.Count; i++)
                {


                    if (Program.customers[i].StrCustomerName.Equals(StrCustomerName))
                    {
                        boolCustomerExists = true;
                        boolAccExists = false;
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Customer Details: ");
                        Console.WriteLine(" Customer Name: " + Program.customers[i].StrCustomerName);
                        Console.WriteLine(" Customer Address: " + Program.customers[i].FullAddress);
                        Console.WriteLine();

                        // Console.WriteLine("asas"+intAccExists);
                        if (boolAccExists == false)
                        {
                            Console.WriteLine("This Customer has not yet opened an account");
                        }

                        return Program.customers[i];
                    }


                }
                if (!boolCustomerExists)
                {
                    Console.WriteLine(" No Customer by this name in our system");
                }
            }
            else if (Program.customers.Count == 0)
            {
                Console.WriteLine("There are no Customers in our banking System. ");

            }
            return null;
        }

        public static bool canCreateCustomer(String strNAME)
        {

            if (Program.customers.Count == 0)
                return true;

            foreach (Customer c in Program.customers)
            {
                if (c.StrCustomerName.Equals(strNAME))
                {
                    return false;
                }
            }
            return true;
        }

        public bool UpdateCustomerAddress(int inthouseNo, string strStreet, string strCity,Customer cs)
        {
            if (cs.StrCity.Equals(strCity)) {

                Console.WriteLine("Address within the same city, Cant update");
                return false;
            }

            cs.StrStreetName = strStreet;
            cs.IntHouseNumber = inthouseNo;
            cs.StrCity = strCity;
            Program.customers.Add(cs);
            return true;

        }
    }
}
