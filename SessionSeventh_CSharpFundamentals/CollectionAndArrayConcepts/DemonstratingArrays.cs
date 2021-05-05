/*using System;

namespace CollectionAndArrayConcepts
{
    class DemonstratingArrays
    {
        static void Main(string[] args)
        {
            *//*
            // Declare the Array
            int[] numbers = new int[5];
            // Assigning Values to Array
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);*/

            /*
            // Initialize the Array
            int[] numbers = { 10, 20, 30, 40, 50};
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }*/

            /*int[] numbers = new int[5];
            Console.WriteLine("Enter 5 elements of an array : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elements of an array are: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }*//*

            int[] numbers = new int[5]{ 101, 120, 30, 45, 15 };
            Array.Sort(numbers);
            Array.Reverse(numbers);
            Array.ForEach(numbers, a => Console.WriteLine(a));
            Console.ReadKey();
        }
    }
}
*/