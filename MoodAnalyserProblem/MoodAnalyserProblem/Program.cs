using MoodAnalyzerProblem;
using System;

namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyserFactory moodanalysefactory = new MoodAnalyserFactory();

            moodanalysefactory.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyse", "MoodAnalyse", "Happy");

        }
    }
}
