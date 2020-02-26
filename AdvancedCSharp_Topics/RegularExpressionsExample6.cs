using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AdvancedCSharp_Topics
{
    class RegularExpressionsExample6
    {
        public static void Main()
        {
            MatchCollection matches;
            List<String> results = new List<string>();
            List<int> matchposition = new List<int>();

            //create a regex object and define the regular expression
            Regex r = new Regex("This");
            // use the Matches method to find all the matches in the input string
            matches = r.Matches("This is a This a farm that that raises dairy cattle.");
            // Enumerate the collection to retreive all the matches and strings
            foreach(Match match in matches)
            {
                //Add the matched string to the string array
                results.Add(match.Value);

                //Record the charecter position where the match was found
                matchposition.Add(match.Index);
            }
            for(int ctr=0; ctr < results.Count; ctr++)
            {
                Console.WriteLine("{0} was found at {1}.", results[ctr], matchposition[ctr]);
            }
        }
    }
}
