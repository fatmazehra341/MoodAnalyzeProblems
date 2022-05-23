using MoodanalyzerProgram;
using NUnit.Framework;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        MoodAnalyze moodAnalyze = new MoodAnalyze();
        [Test]
        public void Test1()
        {
            string result = moodAnalyze.CheckingMood("sad");
            Assert.AreEqual(result,"sad");
        }
    }
}