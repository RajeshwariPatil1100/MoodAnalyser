using MoodAnalyser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer");
            MoodAnalyser mo = new MoodAnalyser("i am in natural mood");
            mo.AnalyseMood();
        }
    }
}