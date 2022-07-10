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
        public void CheckHappyMood()
        {
            //Arrange
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Happy Mood");

            //Act
            string checkhappymood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual("HAPPY", checkhappymood);
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