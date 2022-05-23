using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodanalyzerProgram
{
    public class MoodAnalyze
    {
        public string CheckingMood(string word)
        {
            if (word.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }

        }

    }
}
