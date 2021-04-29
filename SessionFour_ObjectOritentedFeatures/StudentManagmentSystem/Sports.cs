using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    public class Sports : Marks
    {
        protected float score;
        public new void AcceptDetails()
        {
            base.AcceptDetails();
            Console.WriteLine("-----------------------------");
            Console.Write("Enter Sports Score : ");
            this.score = float.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");
        }

        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sports Score : " + this.score);
            Console.WriteLine("-----------------------------");
        }
    }
}
