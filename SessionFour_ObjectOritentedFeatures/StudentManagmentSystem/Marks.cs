using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    public class Marks : Student
    {
        protected float ObjectiveMarks;
        protected float SubjectiveMarks;

        protected new void AcceptDetails()
        {
            base.AcceptDetails();
            Console.WriteLine("-----------------------------");
            Console.Write("Enter Objective Marks : ");
            this.ObjectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Subjective Marks : ");
            this.SubjectiveMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");
        }

        protected new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Objective Marks : " + this.ObjectiveMarks);
            Console.WriteLine("Subjective Marks : " + this.SubjectiveMarks);
            Console.WriteLine("-----------------------------");
        }

    }
}
