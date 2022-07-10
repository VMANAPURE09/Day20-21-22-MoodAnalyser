using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class CustomMoodAnalyserException: Exception
    {
        //Creating types of Exception may arise
        public enum ExceptionType
        {
            Empty_Message, Null_Message, NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        private readonly ExceptionType type;

        public CustomMoodAnalyserException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
