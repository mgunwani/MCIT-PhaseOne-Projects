/*using System;

namespace CSharp_DataTypesAndConstructs
{

    struct Address
    {
        public int houseno;
        public string streetname;
        public string city;
        public string country;

        public Address(int hno, string street, string city, string country)
        {
            this.houseno = hno;
            this.streetname = street;
            this.city = city;
            this.country = country;
        }
    }

    struct Employee
    {
        public int id;
        public string name;
        public int age;
        public float salary;
        public Address address;
       
        // Initializing the struct members
        public Employee(int eid, string ename, int eage, float esalary, Address eaddress)
        {
            this.id = eid;
            this.name = ename;
            this.age = eage;
            this.salary = esalary;
            this.address = eaddress;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Employee Id : " + this.id);
            Console.WriteLine("Employee Name : " + this.name);
            Console.WriteLine("Employee Age : " + this.age);
            Console.WriteLine("Employee Salary : " + this.salary);
            Console.WriteLine("Employee Address: ");
            Console.WriteLine("House Number : " + this.address.houseno);
            Console.WriteLine("Street Name : " + this.address.streetname);
            Console.WriteLine("Current City : " + this.address.city);
            Console.WriteLine("Country : " + this.address.country);
            Console.WriteLine("---------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address add1 = new Address(123, "Civil Lines", "New Delhi", "India");
            Employee employee1 = new Employee(101, "King Kochhar", 18, 10000, add1);
            employee1.DisplayDetails();

            Address add2 = new Address(140, "Hudsaan Lanes", "New Delhi", "India");
            Employee employee2 = new Employee(102, "John Smith", 20, 20000, add2);
            employee2.DisplayDetails();

            Console.ReadKey();
        }
    }
}
*/