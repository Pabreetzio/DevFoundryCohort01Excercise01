using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBook;
using System.Collections.Generic;

namespace GradeBookTests
{
    [TestClass]
    public class AssessmentMasterTests
    {
        private List<AssessmentMaster> teachersDesk = new List<AssessmentMaster>();
        public AssessmentMasterTests()
        {
            teachersDesk.Add(new AssessmentMaster(AssessmentType.Test));
            teachersDesk.Add(new AssessmentMaster(AssessmentType.PopQuiz));
        }
        [TestMethod]
        public void CreateAssessmentMasterTest()
        {
            AssessmentMaster Test1 = teachersDesk[0];
            Assert.AreEqual(AssessmentType.Test, Test1.Type);
        }

        [TestMethod]
        public void UnnammedPopQuizName()
        {
            AssessmentMaster PopQuiz1 = teachersDesk[1];
            Assert.AreEqual("Unnamed PopQuiz", PopQuiz1.Name);
        }

        [TestMethod]
        public void CreateAssessmentTestWithName()
        {
            string nameOfQuiz = "Biology of Coleoptera";
            AssessmentMaster Quiz1 = new AssessmentMaster(AssessmentType.Quiz, nameOfQuiz);
            Assert.AreEqual(nameOfQuiz, Quiz1.Name);
        }

    }
}
