using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class AdvancedStudent : Student
    {
        public override double GetScore(IEnumerable<Assessment> grades)
        {
            grades = grades.Where(a => a.Master.Type == AssessmentType.Final);
            return base.GetScore(grades);
        }
    }
}
