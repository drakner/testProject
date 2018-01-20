using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej");
            GradeBook book1 = new GradeBook();
            book1.AddGrade(22f);
            List<float> allGrades = book1.getAllGrades();
            Console.WriteLine(allGrades.First());

            GradeStatistics stats = book1.ComputeGradeStatistics();

            WriteResult("Average", stats.AverageGrade);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }
    }

 
}
