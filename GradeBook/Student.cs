using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public virtual double GetScore(IEnumerable<Assessment> grades)
        {
            double cumulativeScore = 0;
            foreach(Assessment assessment in grades)
            {
                cumulativeScore+= assessment.Result * GradingRubric.Rubric[assessment.Master.Type];
            }
            return cumulativeScore;
        }
    }
}
