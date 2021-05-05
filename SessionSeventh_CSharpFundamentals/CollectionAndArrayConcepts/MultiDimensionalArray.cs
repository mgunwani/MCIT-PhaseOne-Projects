/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndArrayConcepts
{
    class MultiDimensionalArray
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[2, 3];
            numbers[0, 0] = 10;
            numbers[0, 1] = 20;
            numbers[0, 2] = 30;
            numbers[1, 0] = 40;
            numbers[1, 1] = 50;
            numbers[1, 2] = 60;

            // Outer Loop works for rows
            for (int i = 0; i <= 1; i++)
            {
                // Inner Loop works for columns
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(numbers[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
*/