using MoodAnalyserProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyserFactory
    {
        public object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"^" + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType("MoodAnalyzerProblem." + className);
                    Console.WriteLine("Mood Analyser Type is : " + moodAnalyseType);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class Not Found" + className);

                }
            }
            else
            {
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Constructor is Not Found" + constructorName);
            }

        }
        public object CreateMoodAnalyserUsingParametrisedConstructor(string className, string ConstructorName, string message)
        {
            Type type = typeof(MoodAnalyse);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(ConstructorName))
                {
                    ConstructorInfo construct = type.GetConstructor(new[] { typeof(string) });
                    object instance = construct.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
                }
            }
            else
            {
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class is not found");
            }

        }
    }
}