/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataTypesAndConstructs
{
    class EnumExampleOne
    {
        public enum Directions
        {
            East,
            West,
            North,
            South
        }

        static void Main(string[] args)
        {
            int x = (int)Directions.East;
            int y = (int)Directions.West;
            Console.WriteLine("East : " + x);
            Console.WriteLine("West : " + y);

            Console.WriteLine("------------------------------");

            foreach (string s in Enum.GetNames(typeof(Directions)))
            {
                Console.WriteLine(s);
            }
               
            Console.ReadKey();
        }
    }
}
*/