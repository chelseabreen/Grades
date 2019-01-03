using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    // class that inherits from GradeBook
    public class ThrowAwayGradeBook : GradeBook
    {
        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("ThrowAwayGradeBook::ComputeStatistics");

            float lowest = float.MaxValue; // variable of type float, I will call it lowest, and initialize it to float.MaxValue
            foreach (float grade in grades) // loop through each grade that is in my grades collection
            {
                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest);
            return base.ComputeStatistics();  //referring to that ComputeStatistics method that is available from the GradeBook
        }
    }
}
