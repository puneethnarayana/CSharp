using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2
{
    class Library
    {

       public List<Book> issuedBooks;
        
       // bool overdue;
       int intDifference;

        public Library() {

            issuedBooks = new List<Book>();

                   
        }

        public bool OverDue(DateTime issueDate)
        {

            DateTime localTime = DateTime.Now;
             intDifference = (localTime - issueDate).Days;



            if (intDifference > 7)
            {
                return true;
            }
            return false;
        }

        public void displayAlerts(List<Book> issuedBooks) {

          //  Console.WriteLine("Comes here" +issuedBooks.Count);
            if(issuedBooks.Count>0){
            foreach(Book bk1 in issuedBooks){

                if (OverDue(bk1.issueDate))
                {

                    Console.WriteLine("The Book" + bk1.StrBookName + " Borrowed by:" + bk1.StrBorrower
                        + " is Over Due by: " + (intDifference - 7));
                }
                else {
                    Console.WriteLine("The Books checked out are: ");
                    

                    Console.WriteLine("The Book" + bk1.StrBookName + " Borrowed by:" + bk1.StrBorrower+
                    " Due in: "+(7-intDifference)+" Days");
                }
            }
            }
                else{
                
                Console.WriteLine("No one is interested in borrowing your books!");
                Console.WriteLine();
                }
            }
        
        }
        
    }

