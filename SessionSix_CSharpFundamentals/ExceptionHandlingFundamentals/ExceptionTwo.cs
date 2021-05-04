/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingFundamentals
{
    class ExceptionTwo
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40 };

            try
            {
                Console.WriteLine(numbers[0]);
                Console.WriteLine(numbers[1]);
                Console.WriteLine(numbers[2]);
                Console.WriteLine(numbers[3]);
                Console.WriteLine(numbers[4]);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Exception Occurred 1..!!");
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientExecutionStackException ex)
            {
                Console.WriteLine("Exception Occurred 2..!!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred 3..!!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block gets always executed.");
                Console.WriteLine("All Elements of an array are printed successfully");
            }
            Console.WriteLine("Rest of the Code Here!!");
            Console.ReadKey();
        }
    }
}
*/