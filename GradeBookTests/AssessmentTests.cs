using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBook;

namespace GradeBookTests
{
    [TestClass]
    public class AssessmentTests
    {
        [TestMethod]
        public void CanCreateAnAssessment()
        {
            Assessment keithsClarificationQuestionaire = new Assessment() {Master = new AssessmentMaster(AssessmentType.PopQuiz), Result = 80 };
            Assert.AreEqual(80, keithsClarificationQuestionaire.Result);
        }
    }
}
