
using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoodAnalyzer
{
    public class MoodAnalyserrr 
    {

        public string message;


        public MoodAnalyserrr(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new MoodAnalysisException("Mood cannot be null or empty", MoodAnalysisError.NULL_OR_EMPTY_MOOD);
                }

                if (this.message.Contains("SAD"))
                {
                    Console.WriteLine("SAD");
                    return "SAD";

                }
                else if (this.message.Contains("HAPPY"))
                {
                    Console.WriteLine("HAPPY");
                    return "HAPPY";

                }
                else
                {
                    throw new MoodAnalysisException("Invalid mood provided", MoodAnalysisError.INVALID_MOOD);
                }
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
                return "Unknown Mood";
            }

        }
    }
}
