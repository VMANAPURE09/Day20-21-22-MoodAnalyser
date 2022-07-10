using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodNullException: Exception
    {
        public MoodNullException(string message) : base(message)
        {

        }
    }
}
