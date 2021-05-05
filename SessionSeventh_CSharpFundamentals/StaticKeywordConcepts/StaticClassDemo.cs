using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordConcepts
{
    static class Calculator
    {
        static int result;
        static Calculator()
        {
            result = 0;
        }
        public static void calculate(int num1, int num2)
        {
            result = num1 + num2;
            Console.WriteLine("Result : {0}", Calculator.result);
        }
    }
    class StaticClassDemo
    {
        static void Main(string[] args)
        {
            Calculator.calculate(100, 200);
        }
    }
}
