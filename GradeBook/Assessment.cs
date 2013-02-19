using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Assessment
    {
        private static int _idEnumerator = 0;
        public Assessment(AssessmentType type, string name):this(type)
        {
            Name = name;
        }
        public Assessment(AssessmentType type)
        {
            Type = type;
            Id = _idEnumerator;
            _idEnumerator++;
            Name = "Unnamed " + type.ToString() + " " + (_idEnumerator + 1).ToString();
        }
        public AssessmentType Type { get; private set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
