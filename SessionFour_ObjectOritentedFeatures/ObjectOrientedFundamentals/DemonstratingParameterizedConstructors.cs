using System;

namespace ObjectOrientedFundamentals
{
    class Student
    {
        // Data Members
        int id;
        string name;
        int age;

        // Default Constructor
        public Student()
        {
            this.id = 101;
            this.name = "Annonymous";
            this.age = 18;
        }

        // Parameterized Constructor
        public Student(int sid, string sname, int sage)
        {
            this.id = sid;
            this.name = sname;
            this.age = sage;
        }

        // Member Functions
        public void DisplayDetails()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Student Id : " + this.id);
            Console.WriteLine("Student Name : " + this.name);
            Console.WriteLine("Student Age : " + this.age);
            Console.WriteLine("-----------------------------");
        }
    }

    class DemonstratingClassesAndObjects
    {
        static void Main(string[] args)
        {
            Student student = new Student(101, "James", 34);
            student.DisplayDetails();

            Student student1 = new Student(102, "Shreya", 40);
            student1.DisplayDetails();

            Student student3 = new Student();
            student3.DisplayDetails();

            Console.ReadKey();

        }
    }
}
