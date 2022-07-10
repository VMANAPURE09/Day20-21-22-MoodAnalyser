using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyse
    {
        public string message;
        public MoodAnalyse()
        {

        } 

        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        //Creating method for Analysing the mood
        public string AnalyseMood()
        {
            try
            {
                if (this.message == null)
                {
                    throw new MoodNullException("Mood can not be null");
                }
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(MoodNullException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return message;
        }
    }
}
