using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    public class Result : Sports
    {
        float totalMarks;
        float averageMarks;

        public void CalculateMarks()
        {
            this.totalMarks = this.ObjectiveMarks + this.SubjectiveMarks + this.score;
            this.averageMarks = this.totalMarks / 3;
            Console.WriteLine("Total Marks: " + this.totalMarks);
            Console.WriteLine("Average Marks: " + this.averageMarks);
            if(this.ObjectiveMarks > 70 && this.SubjectiveMarks > 70 && this.score > 70 && this.averageMarks >= 75)
            {
                Console.WriteLine("You are Selected.");
            }
            else
            {
                Console.WriteLine("You are Rejected.");
            }
        }
    }
}
