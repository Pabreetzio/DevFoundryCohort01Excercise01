using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradingRubric
    {

        public static Dictionary<AssessmentType, int> Rubric
        {
            get
            {
                return new Dictionary<AssessmentType, int>()
                {
                    {AssessmentType.PopQuiz, 4},
                    {AssessmentType.Quiz, 5},
                    {AssessmentType.Test, 10},
                    {AssessmentType.Final, 50}
                };
            }
        }
    }
}
