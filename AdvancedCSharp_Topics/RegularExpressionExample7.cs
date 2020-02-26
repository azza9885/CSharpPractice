using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AdvancedCSharp_Topics
{
    class RegularExpressionExample7
    {
        public static void Main()
        {
            string pattern = "abc";
            string input = "abc123abc456abc789";
            Match match = Regex.Match(input, pattern);
            while (match.Success)
            {
                Console.WriteLine("{0} found at position {1}.", match.Value, match.Index);
                match = match.NextMatch();
            }
        }
    }
}
