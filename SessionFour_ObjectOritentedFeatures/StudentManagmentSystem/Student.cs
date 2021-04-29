using System;

namespace StudentManagmentSystem
{
    public class Student
    {
        // Data Members
        int id;
        string name;
        int age;

        // Member Functions
        protected void AcceptDetails()
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
        protected void DisplayDetails()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Student Id : " + this.id);
            Console.WriteLine("Student Name : " + this.name);
            Console.WriteLine("Student Age : " + this.age);
            Console.WriteLine("-----------------------------");
        }
    }
}
