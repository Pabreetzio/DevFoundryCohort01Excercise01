using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBook;


namespace GradeBookTests
{
     [TestClass]
    public class StudentTests
    {
         [TestMethod]
         public void CreatingStudentSucceeds()
         {
             Student willOwens = new Student("Will", "Owens");
         }
    }
}
