/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndArrayConcepts
{
    class Employee
    {
        int Code;
        string Name;
        float Salary;
        public Employee(int code, string name, float salary)
        {
            this.Code = code;
            this.Name = name;
            this.Salary = salary;
        }
        public override string ToString()
        {
            return "Code : " + this.Code + ", Name : " + this.Name + ", Salary : " + this.Salary;
        }
    }
    class ArrayListWithEmployee
    {
        static void Main(string[] args)
        {
            ArrayList employeesList = new ArrayList();
            
            employeesList.Add(new Employee(101, "Shreya", 12000));
            employeesList.Add(new Employee(102, "Alin", 45000));
            employeesList.Add(new Employee(103, "Rogeer", 34000));
            employeesList.Add(new Employee(104, "Nick", 12000));
            employeesList.Add(new Employee(105, "Lee", 22000));

            foreach (Employee emp in employeesList)
            {
                Console.WriteLine(emp);
            }
            Console.ReadKey();
        }
    }
}
*/