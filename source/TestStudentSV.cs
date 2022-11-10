using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentServiceLib;
using System;

namespace TestStudentService
{
    [TestClass]
    public class TestStudentSV
    {
        [TestMethod]
        public void WhenAddStudentCheckID_ShoudReturnTrue()
        {
            Student s = new Student();
            s.Id = 1;

            StudentService s1 = new StudentService();

            Assert.IsTrue(s1.addStudent(s));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void WhenAddNull_ShoudThrow()
        {
            StudentService s1 = new StudentService();
            Assert.IsTrue(s1.addStudent(null));
        }

        [TestMethod]
        public void WhenAddStudentSucessed_ShoudReturnTrue()
        {
            Student s = new Student();
            s.Id = 1;

            StudentService s1 = new StudentService();
            Assert.IsTrue(s1.addStudent(s));
            Assert.AreEqual(s1.size(),1);
        }

        [TestMethod]
        public void WhenAddStudentFailed_ShoudReturnFalse()
        {
            Student s = new Student();
            s.Id = 1;
            Student st = new Student();
            st.Id = 1;

            StudentService s1 = new StudentService();
            Assert.IsTrue(s1.addStudent(s));
            Assert.IsFalse(s1.addStudent(st));
        }
    }
}
