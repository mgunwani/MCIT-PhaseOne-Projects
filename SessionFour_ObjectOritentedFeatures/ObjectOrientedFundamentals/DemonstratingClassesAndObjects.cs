/*using System;

namespace ObjectOrientedFundamentals
{
    class Student
    {
        // Data Members
        int id;
        string name;
        int age;

        public void AcceptDetails()
        {
            Console.WriteLine("-----------------------------");
            Console.Write("Enter Student Id : ");
            this.id = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name : ");
            this.name = Console.ReadLine();
            Console.Write("Enter Student Age : ");
            this.age = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");
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
            Student student = new Student();
            student.AcceptDetails();
            student.DisplayDetails();

            Student student1 = new Student();
            student1.AcceptDetails();
            student1.DisplayDetails();

            Console.ReadKey();

        }
    }
}
*/