/*using System;

namespace PolymorphismConcepts
{
    class Calculation
    {
        public int addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public float addition(float num1, float num2)
        {
            return num1 + num2;
        }
        public int addition(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public float addition(int num1, float num2)
        {
            return num1 + num2;
        }
        public float addition(float num1, int num2)
        {
            return num1 + num2;
        }
    }

    class OverloadingExample
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();            
            Console.WriteLine("Sum of two integers : " + calc.addition(100, 200));
            Console.WriteLine("Sum of two floating integers : " + calc.addition(120.50F, 340.45F));
            Console.WriteLine("Sum of three integers : " + calc.addition(100, 200, 300));
            Console.WriteLine("Sum of first integer and second float value : " + calc.addition(123.45F, 500));
            Console.WriteLine("Sum of first float and second integer value : " + calc.addition(120, 456.70F));
            Console.ReadLine();
        }
    }
}
*/