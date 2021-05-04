using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingFundamentals
{

    class InvalidAgeException : Exception
    {
        public InvalidAgeException(): base("Invalid Age Exception!!")
        { }
        public InvalidAgeException(string message): base(message)
        { }
    }

    class ExceptionThree
    {

        public static void checkAge(int age)
        {
            if(age >= 18)
            {
                Console.WriteLine("You are valid to give vote.");
            }
            else
            {
                throw new InvalidAgeException();
                // throw new InvalidAgeException("Age is not Valid");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Age : ");
            int age = int.Parse(Console.ReadLine());
            try
            {
                ExceptionThree.checkAge(age);
            }
            catch(InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
