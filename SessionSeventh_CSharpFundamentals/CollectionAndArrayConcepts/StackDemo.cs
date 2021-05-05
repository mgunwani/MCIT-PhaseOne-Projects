using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndArrayConcepts
{
    class StackDemo
    {
        static void Main(string[] args) 
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            stack.Push(400);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Element Popped out is : " + stack.Pop());
            Console.WriteLine("Element will be popped out is : " + stack.Peek());
            Console.WriteLine("------------------------------");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
