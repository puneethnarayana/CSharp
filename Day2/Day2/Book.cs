using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2
{
    public enum typeBook { Reference, General };
   // public enum typeMember { Student, Faculty };

    class Book
    {
        public static int intNoOfBooksinLibrary;

        public Book() {
            intNoOfBooksinLibrary++;
           // Console.WriteLine(" No of Books in Library :" + intNoOfBooksinLibrary);
        }


        //PROPERTIES
        private String strBookName;
        public string StrBookName {

            get { return strBookName;  }
            set { strBookName = value;}
        }

        private String strBorrower = null;
        public string StrBorrower
        {

            get { return strBorrower; }
            set { strBorrower = value; }
        }
        
        private String strAuthor;
        public string StrAuthor
        {
            get { return strAuthor; }
            set { strAuthor = value; }
        }

        private int intYear;
        public int IntYear
        {
            get { return intYear; }
            set { intYear = value; }
        }

        //private String strISBNo;
       // public const int intBookID = 1;

        private int intBookID;
        public int IntBookID
        {
            get { return intBookID; }
            set { intBookID = value; }
        }
        
        private typeBook strBookType;
        public typeBook StrBookType
        {
            get { return strBookType; }
            set { strBookType = value; }
        }
                
        public DateTime issueDate;
        public bool isAvailable = true;
        
        public bool OverDue() {
            int Days = Convert.ToInt32(DateTime.Now - issueDate);

            if (Days > 7) {
                return true;
            }
            return false;
        }

        public bool canBeIssued(typeMember strUserType, int intBooksIssued)
        {

            if (strUserType ==typeMember.Faculty) {
                return true;
            }
            else if ( strUserType==typeMember.Student)
            {
                if (intBooksIssued < 5 && StrBookType==typeBook.General)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else 
            {
                Console.WriteLine("Invalid User Type");
                return false;
            }
        
        }

        public int Issue(typeMember strUserType, int intBooksIssued)
        {

            if(isAvailable==true && canBeIssued(strUserType,intBooksIssued)){
                isAvailable = false;
                issueDate = DateTime.Now;
                Console.WriteLine("Issue Successful");
                return 1;
            }

            Console.WriteLine("Issue Unsuccessful");
            return 0;
        }

        public int returnBook() {

            if (isAvailable == false)
            {
                isAvailable = true;
                issueDate = Convert.ToDateTime(0);
                StrBorrower=null;
                return 1;
            }
            return 0;
        }     
    }
}