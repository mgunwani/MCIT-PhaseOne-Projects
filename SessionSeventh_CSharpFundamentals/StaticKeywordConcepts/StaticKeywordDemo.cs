/*using System;

namespace StaticKeywordConcepts
{
    class Employee 
    {
        // Instance Data Members
        int Code;
        string Name;
        float Salary;
        // Static Data Member
        public static string OrganizationName;
        public static string ApplicationName;
        public static string ApplicationVersion;
        static Employee()
        {
            // Console.WriteLine("Static Constructor Invoked.");
            Employee.OrganizationName = "Simplilearn";
            Employee.ApplicationName = "Employee Management System";
            Employee.ApplicationVersion = "EMPv001";
        }
        public Employee()
        {
            // Console.WriteLine("Default Constructor Invoked.");
        }
        public Employee(int code, string name, float salary) 
        {
            this.Code = code;
            this.Name = name;
            this.Salary = salary;
        }
        public static void AppllicationDetails()
        {
            Console.WriteLine("Application Version : {0}", Employee.ApplicationVersion);
            Console.WriteLine("Application Name : {0}", Employee.ApplicationName);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Employee Code : {0}", this.Code);
            Console.WriteLine("Employee Name : {0}", this.Name);
            Console.WriteLine("Employee Salary : {0}", this.Salary);
            Console.WriteLine("Organization Name : {0}", Employee.OrganizationName);
            Console.WriteLine("-----------------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Employee.OrganizationName = "Simplilearn Pvt. Ltd.";
            Employee.AppllicationDetails();

            Employee emp = new Employee();

            Employee emp1 = new Employee(101, "King", 12000);
            emp1.DisplayDetails();

            Employee emp2 = new Employee(102, "Sarah", 23000);
            emp2.DisplayDetails();

            Console.ReadKey();
        }
    }
}
*/