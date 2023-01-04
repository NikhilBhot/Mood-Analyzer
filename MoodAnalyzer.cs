using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerAppWithCore
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message ) 
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
