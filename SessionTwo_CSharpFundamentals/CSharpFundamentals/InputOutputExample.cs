using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    class InputOutputExample
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            float salary;
            double contact;
            char gender;
            bool isIndian;

            Console.Write("Enter User Name : ");
            name = Console.ReadLine();
            Console.Write("Enter User Age : ");
            /*age = Convert.ToInt32(Console.ReadLine());*/
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter User Salary : ");
            /*salary = Convert.ToSingle(Console.ReadLine());*/
            salary = float.Parse(Console.ReadLine());
            Console.Write("Enter User Contact Number : ");
            /*contact = Convert.ToDouble(Console.ReadLine());*/
            contact = double.Parse(Console.ReadLine());
            Console.Write("Enter User Gender : ");
            /*gender = Convert.ToChar(Console.ReadLine());*/
            gender = char.Parse(Console.ReadLine());
            Console.Write("Are you Indian?(True/False): ");
            /*isIndian = Convert.ToBoolean(Console.ReadLine());*/
            isIndian = bool.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------");
            Console.WriteLine("User Name : " + name);
            Console.WriteLine("User Age : " + age);
            Console.WriteLine("User Salary : " + salary);
            Console.WriteLine("User Contact Number : " + contact);
            Console.WriteLine("User Gender : " + gender);
            Console.WriteLine("User is Indian or not ? : " + isIndian);
            Console.WriteLine("---------------------------");
            Console.ReadKey();
        }
    }
}
