
using MoodAnalyzerAppWithCore;
namespace MoodAnayzerMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            string expected = "SAD";
            string message = "I am In Sad Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

            string mood = moodAnalyzer.AnalyseMood();
          Assert.AreEqual(expected, mood);
        }
        
        
    }
}