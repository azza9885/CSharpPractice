using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AdvancedCSharp_Topics
{
    public class RegularExpressionsExample2
    {
        public static void Main()
        {
            string input = "This This is a a a farm that that raises raises dairy cattle.";
            string pattern = @"\b(\w+)\W+(\1)\b";
            Match match = Regex.Match(input, pattern);
            while (match.Success)
            {
                Console.WriteLine("Duplicate '{0}' found at position {1}.",
                                  match.Groups[1].Value, match.Groups[2].Index);
                match = match.NextMatch();
            }
        }
    }
}

//Pattern Description
//\b Begin the match on a word boundary.
//(\w+)   Match one or more word characters.This is the first capturing group.
//\W+	Match one or more non-word characters.
//(\1)    Match the first captured string. This is the second capturing group.
//\b End the match on a word boundary.