using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentServiceLib;

namespace StudentTest
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void WhenScoreIs8_ShouldReturnTrue()
        {
            Student std = new Student();
            std.Score = 8;

            Assert.AreEqual(std.getLetterScore(),'A');
        }

        [TestMethod]
        public void WhenScoreIs7AndHalf_ShouldReturnTrue()
        {
            Student std = new Student();
            std.Score = 7.5;

            Assert.AreEqual(std.getLetterScore(), 'B');
        }

        [TestMethod]
        public void WhenScoreIs7_ShouldReturnTrue()
        {
            Student std = new Student();
            std.Score = 7;

            Assert.AreEqual(std.getLetterScore(), 'B');
        }

        [TestMethod]
        public void WhenScoreIs6_ShouldReturnTrue()
        {
            Student std = new Student();
            std.Score = 6;

            Assert.AreEqual(std.getLetterScore(), 'C');
        }

        [TestMethod]
        public void WhenScoreIs3AndHafl_ShouldReturnTrue()
        {
            Student std = new Student();
            std.Score = 3.5;

            Assert.AreEqual(std.getLetterScore(), 'D');
        }

        [TestMethod]
        public void WhenScoreIs2_ShouldReturnTrue()
        {
            Student std = new Student();
            std.Score = 2;

            Assert.AreEqual(std.getLetterScore(), 'E');
        }
    }
}
