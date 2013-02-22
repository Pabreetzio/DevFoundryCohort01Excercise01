using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class AssessmentMaster
    {
        public AssessmentMaster(AssessmentType type, string name):this(type)
        {
            Name = name;
        }
        public AssessmentMaster(AssessmentType type)
        {
            Type = type;
            Name = "Unnamed " + type.ToString();
        }
        public AssessmentType Type { get; private set; }
        public string Name { get; set; }

    }
}
