using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsolePracticeApp
{
    public class Problems
    {
        public static int[] minMax(int[] lst)
        {
            return new int[] { lst.Min(), lst.Max() };
        }

        public static int NumberOfOccurrences(int x, int[] xs)
        {
            return xs.Where(y => y == x).Count(); 
        }

        public static bool IsSquare(int n)
        {
            double sqrRoot = Math.Sqrt(n);
            return sqrRoot % 1 == 0; 
        }

        public static string SongDecoder(string input)
        {
            string cleanString = Regex.Replace(input, "WUB", " ").Trim();
    
            return cleanString;
        }
    }

}
