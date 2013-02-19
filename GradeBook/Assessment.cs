using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public interface Assessment
    {
        AssessmentType Type();
        int Id();        
    }
}
