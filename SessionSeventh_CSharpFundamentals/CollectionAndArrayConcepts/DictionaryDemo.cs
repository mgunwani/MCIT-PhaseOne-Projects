/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndArrayConcepts
{
    class DictionaryDemo
    {
        static void Main(string[] args) 
        {
            IDictionary<int, string> list = new Dictionary<int, string>();
            list.Add(1, "King");
            list.Add(2, "Kochhar");
            list.Add(3, "Sarah");
            list.Add(4, "Shreya");

            foreach (KeyValuePair<int, string> item in list)
            {
                Console.WriteLine("Key : {0}, Value : {1}", item.Key, item.Value);
            }
            Console.WriteLine("----------------------------");
            list.Remove(2);
            foreach (var item in list)
            {
                Console.WriteLine("Key : {0}, Value : {1}", item.Key, item.Value);
            }
            Console.WriteLine("----------------------------");
            if (list.ContainsKey(20))
            {
                Console.WriteLine(list[2]);
            }
            string result = "";
            if(list.TryGetValue(2, out result))
            {
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
*/