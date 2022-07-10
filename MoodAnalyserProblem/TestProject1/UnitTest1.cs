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
        public void GivenNullShouldReturnNullException()
        {
            string expected = "Mood should not be null";
            MoodAnalyse moodAnalyser = new MoodAnalyse(null);
            try
            {
                //ACT
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (CustomMoodAnalyserException e)
            {
                //Assert
                Assert.AreEqual("Exception:", e.Message);
            }
           
        }
        //[Test]
        //public void GivenEmptyShouldReturnEmptyException()
        //{
        //    string expected = "Message should not be empty";
        //    MoodAnalyse moodAnalyser = new MoodAnalyse(null);
        //    try
        //    {
        //        //ACT
        //        string actual = moodAnalyser.AnalyseMood();
        //    }
        //    catch (CustomMoodAnalyserException ex)
        //    {
        //        //ASSERT
        //        Assert.AreEqual(expected, ex.Message);
        //    }
        //}
    }
}