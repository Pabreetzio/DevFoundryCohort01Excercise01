using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBook;
namespace GradeBookTests
{
    [TestClass]
    public class EnumerationTests
    {
        [TestMethod]
        public void TestAssessmentTypes()
        {
            Assert.AreEqual(0, AssessmentType.PopQuiz.GetHashCode());
            Assert.AreEqual(1, AssessmentType.Quiz.GetHashCode());
            Assert.AreEqual(2, AssessmentType.Test.GetHashCode());
            Assert.AreEqual(3, AssessmentType.Final.GetHashCode());
        }
        [TestMethod]
        public void TestAssessmentToString()
        {
            Assert.AreEqual("Quiz", AssessmentType.Quiz.ToString());
        }
    }
}
