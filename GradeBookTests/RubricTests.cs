using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBook;

namespace GradeBookTests
{
    [TestClass]
    public class RubricTests
    {
        [TestMethod]
        public void PopQuizWeightingTest()
        {
            Assert.AreEqual(4, GradingRubric.Rubric[AssessmentType.PopQuiz]);
        }
        [TestMethod]
        public void QuizWeightingTest()
        {
            Assert.AreEqual(5, GradingRubric.Rubric[AssessmentType.Quiz]);
        }
        [TestMethod]
        public void TestWeightingTest()
        {
            Assert.AreEqual(10, GradingRubric.Rubric[AssessmentType.Test]);
        }
        [TestMethod]
        public void FinalWeightingTest()
        {
            Assert.AreEqual(50, GradingRubric.Rubric[AssessmentType.Final]);
        }
    }
}
