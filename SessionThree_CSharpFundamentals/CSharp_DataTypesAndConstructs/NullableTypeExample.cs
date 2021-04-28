/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataTypesAndConstructs
{
    class NullableTypeExample
    {
        static void Main(string[] args) 
        {
            *//*
            Console.WriteLine("--------------------------------------");
            int num1 = 100;
            int num2 = 200;
            int num3 = num1 + num2;
            Console.WriteLine("Number One : " + num1);
            Console.WriteLine("Number Two : " + num2);
            Console.WriteLine("Sum of Two Numbers : " + num3);
            Console.WriteLine("Sum of " + num1 + " and " + num2 + " : " + num3);
            Console.WriteLine("Sum of {0} and {1} : {2}", num1, num2, num3);
            Console.WriteLine("--------------------------------------");
            *//*

            // ? - Null Operator

            int? num1 = null;
            int? num2 = 100;

            Console.WriteLine("Number One : " + num1);
            Console.WriteLine("Number Two : " + num2);

            // ?? - Null Coalescing Operator

            int result = num2 ?? 10;
            Console.WriteLine("Result : " + result);

            Console.ReadKey();
        }
    }
}
*/