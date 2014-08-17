using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2
{
    class Student : LibraryMember
    {
        int intLimit = 5;
        
        public Student() {
            StrMemberType = typeMember.Student;
            IntLimit = intLimit;
        }

        public Student(int intUserID,String strStudentName,int intNoIssued) { 
            IntMemberID = intUserID;
            StrMemberName = strStudentName;
            IntNoOfBooksIssued = intNoIssued;
            StrMemberType = typeMember.Student;
            IntLimit = intLimit;
        }

        public override bool canIssueBook()
        {
            Console.WriteLine("Student");
            if (IntNoOfBooksIssued < intLimit)
                return true;
            return false;
        }

        static void Mai(string[] args)
        {
            List<Student> studs = new List<Student>();
            Student stu = new Student(1, "Puneeth", 3);
            studs.Add(stu);
            Student stu1 = new Student(2, "Bhargav", 0);
            studs.Add(stu1);
            Student stu2 = new Student(3, "Sankeerth", 5);
            studs.Add(stu2);
            Student stu3 = new Student(4, "Supreeth", 1);
            studs.Add(stu3);
            Student stu4 = new Student(5, "Agger", 10);
            
            /*
            stu4.StrMemberName = "Guru";
            stu4.IntMemberID = 12;
            stu4.IntNoOfBooksIssued = 20;
            */

            studs.Add(stu4);

        foreach(Student s in studs){
            Console.WriteLine("Member Type: "+s.StrMemberType+", ID: "+s.IntMemberID+", Limit :"+s.intLimit+", Books Issued: "+s.IntNoOfBooksIssued+", Name: "+s.StrMemberName);
          }

        Console.ReadLine();
        }
    }
}
