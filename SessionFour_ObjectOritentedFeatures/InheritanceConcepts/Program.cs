using System;
using StudentManagmentSystem;

namespace InheritanceConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Result obj = new Result();
            obj.AcceptDetails();
            obj.DisplayDetails();
            obj.CalculateMarks();


            Console.ReadKey();
        }
    }
}
