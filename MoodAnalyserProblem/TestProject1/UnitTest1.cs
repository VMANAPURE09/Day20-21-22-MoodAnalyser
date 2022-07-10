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
        public void CheckMood_returnSad()
        {

            //Arrange
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Sad Mood");

            //Act
            string checkmood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual("SAD", checkmood);
        }
    }
}