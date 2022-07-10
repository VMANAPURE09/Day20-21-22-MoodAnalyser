using System;

namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyse moodanalyse = new MoodAnalyse("I am in any Mood");
            string checkmood = moodanalyse.AnalyseMood();
            Console.WriteLine(checkmood);
        }
    }
}
