using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBook;

namespace GradeBookTests
{
    [TestClass]
    public class AssessmentTests
    {
        [TestMethod]
        public void CreateAssessmentTest()
        {
            Assessment Test1 = new Assessment(AssessmentType.Test);
            Assert.AreEqual(AssessmentType.Test, Test1.Type);
        }

        [TestMethod]
        public void UnnammedPopQuizName()
        {
            Assessment PopQuiz1 = new Assessment(AssessmentType.PopQuiz);
            Assert.AreEqual("Unnamed PopQuiz 2", PopQuiz1.Name);
        }

        //TODO: Add test for ID

        [TestMethod]
        public void CreateAssessmentTestWithName()
        {
            string nameOfQuiz = "Biology of Coleoptera";
            Assessment Quiz1 = new Assessment(AssessmentType.Test, nameOfQuiz);
            Assert.AreEqual(nameOfQuiz, Quiz1.Name);
        }

    }
}
