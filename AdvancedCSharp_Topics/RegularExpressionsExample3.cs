using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//extracting all matches 
namespace AdvancedCSharp_Topics
{
    class RegularExpressionsExample3
    {
        public static void Main()
        {
            string input = "This This is a a a farm that that a raises dairy cattle.";
            string pattern = @"\b(\w+)\W+(\1)\b";
            foreach (Match match in Regex.Matches(input, pattern))
                Console.WriteLine("Duplicate {0} is found at position {1}", match.Groups[1].Value, match.Groups[2].Index);
        }
    }
}
