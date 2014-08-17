using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2
{
    class Professori: LibraryMember
    {
        public Professori() {
            StrMemberType = typeMember.Faculty;
        }
        
        public Professori(int intUserID,String strProfName,int intNoIssued) { 
            IntMemberID = intUserID;
            StrMemberName = strProfName;
            IntNoOfBooksIssued = intNoIssued;
            StrMemberType = typeMember.Faculty;
           
        }

        public override bool canIssueBook()
        {
            Console.WriteLine("Fac");
            return true;
        }
    
        public static void Mai(String[] args) {

            LibraryMember lib = new Student();
            lib.canIssueBook();

            LibraryMember lib2 = new Professori();
            lib2.canIssueBook();

            Console.ReadLine();
        }
    }
}