using System;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {

            string FirstName1, FirstName2;
            string LastName1, LastName2;
            DateTime BirthDate1, BirthDate2;
            int StudentId1, StudentId2;
            int ClassCount1, ClassCount2;
            int Graduation1, Graduation2;
            string StudentId_String;
            string BirthDate_String;
            string ClassCount_String;
            string Graduation_String;

            Console.WriteLine("Enter information for student 1:");

            Console.WriteLine("Enter your first name: ");
            FirstName1 = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            LastName1 = Console.ReadLine();
            Console.WriteLine("Enter Your Date of Birth (yyyy-mm-dd):");
            BirthDate_String = Console.ReadLine();
            BirthDate1 = Convert.ToDateTime(BirthDate_String);
            Console.WriteLine("Enter your Student ID");
            StudentId_String = Console.ReadLine();
            StudentId1 = Convert.ToInt32(StudentId_String);
            Console.WriteLine("Enter how many students are in your class:");
            ClassCount_String = Console.ReadLine();
            ClassCount1 = Convert.ToInt32(ClassCount_String);
            Console.WriteLine("Enter your graduation year:");
            Graduation_String = Console.ReadLine();
            Graduation1 = Convert.ToInt32(Graduation_String);

            Console.Write("------------------");

            Console.WriteLine("Enter information for student 2:");

            Console.WriteLine("Enter your first name: ");
            FirstName2 = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            LastName2 = Console.ReadLine();
            Console.WriteLine("Enter Your Date of Birth (yyyy-mm-dd):");
            BirthDate_String = Console.ReadLine();
            BirthDate2 = Convert.ToDateTime(BirthDate_String);
            Console.WriteLine("Enter your Student ID");
            StudentId_String = Console.ReadLine();
            StudentId2 = Convert.ToInt32(StudentId_String);
            Console.WriteLine("Enter how many students are in your class:");
            ClassCount_String = Console.ReadLine();
            ClassCount2 = Convert.ToInt32(ClassCount_String);
            Console.WriteLine("Enter your graduation year:");
            Graduation_String = Console.ReadLine();
            Graduation2 = Convert.ToInt32(Graduation_String);

            Console.WriteLine("{0,-30}{1,-30}{2,-30}{3,-30}{4,-3-}{5,-30}{6,-30}", "FirstName", "LastName", "DOB", "StudentId", "ClassCount", "Year");
            

            Console.WriteLine("------------------");
            Console.WriteLine("{0,-30}{1,-30}{2,-30}{3,-30}{4,-3-}{5,-30}{6,-30}", FirstName1, LastName1, BirthDate1, StudentId1, ClassCount1, Graduation1);
           


            Console.WriteLine("------------------");
            Console.WriteLine("{0,-30}{1,-30}{2,-30}{3,-30}{4,-3-}{5,-30}{6,-30}", FirstName2, LastName2, BirthDate2, StudentId2, ClassCount2, Graduation2);
            Console.ReadLine();


        }
    }
}