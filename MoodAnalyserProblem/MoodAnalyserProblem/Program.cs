using System;

namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyse moodanalyse = new MoodAnalyse("I am in Happy Mood");
            string checkmood = moodanalyse.AnalyseMood();
            Console.WriteLine(checkmood);
        }
    }
}
