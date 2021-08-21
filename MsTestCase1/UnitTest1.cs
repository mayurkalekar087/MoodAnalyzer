using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MsTestCase1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            //Act
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}