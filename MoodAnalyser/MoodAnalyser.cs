using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    internal class MoodAnalyser
    {
        public string message;


        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {

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
                    throw new InvalidMoodException("Invalid mood provided");
                }
            }
            catch (InvalidMoodException ex)
            {
                Console.WriteLine(ex.Message);
                return "Unknown Mood";
            }

        }
    }
}
