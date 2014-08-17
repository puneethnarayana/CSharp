using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;

namespace Day2
{
    class Program
    {
        public List<Book> PopulateCatalog() {

            Book book = new Book();

           /* book.StrBookName = "Count of Monte Cristo";
            book.StrAuthor = "Victor Hugo";
            book.StrBookType = typeBook.General;*/

            book.StrBookName = "City of Djinns";
            book.StrAuthor = "William Darlymple";
            book.StrBookType = typeBook.General;
            book.IntYear = 2007;
            book.IntBookID = 1;
            //book.isAvailable = true;

            Book book1 = new Book();
            book1.StrBookName = "Last Mughal";
            book1.StrAuthor = "William Darlymple";
            book1.StrBookType = typeBook.General;
            book1.IntYear = 2004;
            book1.IntBookID = 2;
            //book1.isAvailable = true;

            Book book2 = new Book();
            book2.StrBookName = "Wise and Otherwise";
            book2.StrAuthor = "Sudha Murthy";
            book2.StrBookType = typeBook.Reference;
            book2.IntYear = 2001;
            book2.IntBookID = 3;
            //book2.isAvailable = true;

            Book book3 = new Book();
            book3.StrBookName = "A Brief History of Time";
            book3.StrAuthor = "Stephen Hawking";
            book3.StrBookType = typeBook.Reference;
            book3.IntYear = 1990;
            book3.IntBookID = 4;
            //book3.isAvailable = true;

            Book book4 = new Book();
            book4.StrBookName = "White Tiger";
            book4.StrAuthor = "Arvind Adiga";
            book4.StrBookType = typeBook.General;
            book4.IntYear = 2008;
            book4.IntBookID = 5;
            //book4.isAvailable = true;

            
            List<Book> catalog;
            catalog = new List<Book>();

            catalog.Add(book);
                        
            catalog.Add(book1);
            catalog.Add(book2);
            catalog.Add(book3);
            catalog.Add(book4);
            return catalog;
        }

        public int display(List<Book> catalog,LibraryMember user) {

            
            String strInput;
            int Count = 0;

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Welcome to Thoroghly Awesome Library Management System");
            Console.WriteLine("Books in our system are");

            for (int i = 0; i < catalog.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + catalog[i].StrBookName + " by " + catalog[i].StrAuthor + " type:" + catalog[i].StrBookType);
            }

             Console.WriteLine();
            Console.WriteLine("What Operation do you want to Perform? ");
            Console.WriteLine("1. Issue ");
            Console.WriteLine("2. Return ");
            Console.WriteLine("3. Check Status");

            int intOpsOption = 0;

            try
            {
                strInput = Console.ReadLine();
                intOpsOption = Convert.ToInt32(strInput);
             }
            catch (FormatException e){
                
                Console.WriteLine(e.Message);
            }
                     
            Library lib = new Library();

            //ISSUE LOGIC
            if (intOpsOption == 1)
            {
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Select the Books which you want to perform this operation on");
                Console.WriteLine("1. Search by Book Name, 2. Search by Author 3. Search by Book No.");
                strInput = Console.ReadLine();
                int intBooksSearchOption = Convert.ToInt32(strInput);

                switch (intBooksSearchOption)
                {

                    case 1: Console.WriteLine("Enter the Book Name");
                        strInput = Console.ReadLine();

                        for (int i = 0; i < catalog.Count; i++)
                        {
                            if (catalog[i].StrBookName.Equals(strInput))
                            {
                                if (intOpsOption == 1)
                                {
                                    catalog[i].Issue(user.StrMemberType, user.IntNoOfBooksIssued);
                                    user.IntNoOfBooksIssued++;
                                    Count++;

                                }
                             }
                            // Console.WriteLine("There is no book by that Name");
                        }
                        break;

                    case 2: Console.WriteLine("Enter the Author");
                        strInput = Console.ReadLine();

                        for (int i = 0; i < catalog.Count; i++)
                        {
                            if (catalog[i].StrAuthor.Equals(strInput))
                            {
                                if (intOpsOption == 1)
                                {
                                    catalog[i].Issue(user.StrMemberType, user.IntNoOfBooksIssued);
                                    user.IntNoOfBooksIssued++;
                                    Count++;
                                }
                            }
                        }

                        break;

                    case 3: Console.WriteLine("Enter the Book ID");
                        strInput = Console.ReadLine();
                        int intBooksID = Convert.ToInt32(strInput);

                        if (intOpsOption == 1)
                        {
                            catalog[intBooksID - 1].Issue(user.StrMemberType, user.IntNoOfBooksIssued);
                            user.IntNoOfBooksIssued++;
                            Book newentry = catalog[intBooksID - 1];
                            newentry.StrBorrower = user.StrMemberName;
                            user.issuedBook.Add(newentry);
                            lib.issuedBooks.Add(newentry);
                            Count++;
                  }
                       
                        break;

                    default: Console.WriteLine("Invalid Option");
                        break;
                }
            }

                //RETURN LOGIC
            else if (intOpsOption == 2)
            {

                Console.WriteLine();
                Console.WriteLine("------Books Issued by: " + user.StrMemberName + " are :-------------------");

                for (int i = 0; i < user.issuedBook.Count; i++)
                {
                    Console.WriteLine("Book no." + (i + 1) + " is " + user.issuedBook[i].StrBookName +
                        " Author: " + user.issuedBook[i].StrAuthor + "Borrwer: " + user.issuedBook[i].StrBorrower);
                }

                Console.WriteLine("Enter the Book which you have to return");
                strInput = Console.ReadLine();
                int intReturn = Convert.ToInt32(strInput);

                int intBID = user.issuedBook[intReturn - 1].IntBookID;
                int intIndex = intReturn - 1;
                //user.issuedBook.Remove(intReturn-1);

                user.issuedBook.RemoveAt(intIndex);
                foreach (Book b in catalog)
                {
                    if (b.IntBookID == intBID)
                    {
                        b.returnBook();
                    }
                }

                user.IntNoOfBooksIssued--;

                Console.WriteLine();
                Console.WriteLine("Books Remaining in the catalog are:");
                for (int i = 0; i < user.issuedBook.Count; i++)
                {
                    Console.WriteLine("Book no." + (i + 1) + " is " + user.issuedBook[i].StrBookName + " Author: " 
                        + user.issuedBook[i].StrAuthor + 
                        "Borrwer: " + user.issuedBook[i].StrBorrower);
                }
            }

                //DISPLAY ALERTS 
            else if (intOpsOption == 3)
            {
                
                lib.displayAlerts(user.issuedBook);
            }

            else {
                Console.WriteLine("Invalid Option");
            }
            
            return Count;
            //Console.ReadLine();

        }
        }
        
  /*
            foreach (Book b in catalog) {
                Console.WriteLine(b.strAuthor + "--" + b.strBookName);
            }
            */


           
    }

