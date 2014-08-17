using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2
{
    public enum typeMember {Student,Faculty};

    class LibraryMember
    {
        protected String strMemberName;
        public String StrMemberName {
            set { strMemberName = value; }
            get { return strMemberName; }        
        }

        protected int intLimitofBooks;
        public int IntLimit {
            set { intLimitofBooks = value; }
            get { return intLimitofBooks; }  
        }

        protected typeMember strMemberType;
        public typeMember StrMemberType
        {
            set { strMemberType = value; }
            get { return strMemberType; }
        }

        protected int intMemberID;
        public int IntMemberID
        {
            set { intMemberID = value; }
            get { return intMemberID; }
        }

        protected int intNoOfBooksIssued;
        public int IntNoOfBooksIssued
        {
            set { intNoOfBooksIssued = value; }
            get { return intNoOfBooksIssued; }
        }

        public virtual bool canIssueBook()
        {
            Console.WriteLine("Base Class");
            return false;
        }

        public List<Book> issuedBook = new List<Book>();

        public void DisplayUserInfo(LibraryMember stu) {

            Console.WriteLine("Member Type: " + stu.StrMemberType);
            Console.WriteLine("ID: " + stu.IntMemberID);
            Console.WriteLine("No of Books Issued: " + stu.IntNoOfBooksIssued);
            Console.WriteLine("Name: " + stu.StrMemberName);
        }
        

        static void Main(String[] args) {
            LibraryMember stu = new Professori(1, "Puneeth", 0);

            stu.DisplayUserInfo(stu);

            Console.WriteLine();

            Program bk = new Program();
            bk.display(bk.PopulateCatalog(), stu);

         //   Console.WriteLine(" The No of Books in Library "+Book.intNoOfBooksinLibrary);

            stu.DisplayUserInfo(stu);

            Program bk1 = new Program();
            bk1.display(bk.PopulateCatalog(), stu);
            stu.DisplayUserInfo(stu);

            Program bk2 = new Program();
            bk2.display(bk.PopulateCatalog(), stu);

            stu.DisplayUserInfo(stu);

            Console.ReadLine();
        }
        
        static void Main_Lib(string[] args)
        {
            List<LibraryMember> studs = new List<LibraryMember>();
            LibraryMember stu = new Student(1, "Puneeth", 3);
            studs.Add(stu);
            LibraryMember stu1 = new Student(2, "Bhargav", 0);
            studs.Add(stu1);
            LibraryMember stu2 = new Professori();
            studs.Add(stu2);
            LibraryMember stu3 = new Professori();
            studs.Add(stu3);
            LibraryMember stu4 = new Student(5, "Agger", 10);

            /*
            stu4.StrMemberName = "Guru";
            stu4.IntMemberID = 12;
            stu4.IntNoOfBooksIssued = 20;
            */

            studs.Add(stu4);

            foreach (LibraryMember s in studs)
            {
                Console.WriteLine("Member Type: " + s.StrMemberType + ", ID: " + s.IntMemberID + " " + s.IntNoOfBooksIssued + ", Name: " + s.StrMemberName);
            }

            Console.ReadLine();
        }
    }
}