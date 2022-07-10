using MoodAnalyserProblem;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckSadMood()
        {

            //Arrange
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Sad Mood");

            //Act
            string checksadmood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual("SAD", checksadmood);
        }
    }
}