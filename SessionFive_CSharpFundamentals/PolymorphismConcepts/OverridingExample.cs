/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConcepts
{
    class Person
    {
        int id;
        string name;
        public Person()
        {
            this.id = 101;
            this.name = "Kartik";
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Id : {0}, Name: {1}", this.id, this.name);
        }
    }

    class Employee : Person
    {
        string OrganizationName;
        float salary;
        public Employee()
        {
            this.OrganizationName = "Simplilearn";
            this.salary = 12345.67F;
        }
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Organization Name : {0}, Salary: {1}", this.OrganizationName, this.salary);
        }
    }
    class OverridingExample
    {
        static void Main(string[] args)
        {
            // Person person = new Person();
            // person.DisplayDetails();

            Employee employee = new Employee();
            employee.DisplayDetails();

            *//*Person person = new Employee();
            person.DisplayDetails();*//*

            Console.ReadLine();
        }
    }
}
*/