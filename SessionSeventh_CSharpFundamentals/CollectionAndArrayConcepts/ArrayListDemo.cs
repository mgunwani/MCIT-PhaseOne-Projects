/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionAndArrayConcepts
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            
            list.Add("King");
            list.Add("Kochhar");
            list.Add("Sarah");
            list.Add("Bowling");

            string value1 = (string)list[0];
            Console.WriteLine("First Element : " + value1);
            var value2 = list[0];
            Console.WriteLine("Second Element : " + value2);
            Console.WriteLine("-------------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("-------------------------------");
            Console.ReadKey();
        }
    }
}
*/