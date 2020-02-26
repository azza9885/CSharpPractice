using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//Replacing a Matched Substring
namespace AdvancedCSharp_Topics
{
    class RegularExpressionsExample4
    {
        public static void Main()
        {
            string pattern = @"\b\d+\.\d{2}\b";
            string replacement = "$$$&";
            string input = "Total Cost : 103.64";
            Console.WriteLine(Regex.Replace(input, pattern, replacement));
        }
    }
}

//The regular expression pattern \b\d+\.\d{2}\b is interpreted as shown in the following table.

//Pattern Description
//\b Begin the match at a word boundary.
//\d+	Match one or more decimal digits.
//\.	Match a period.
//\d{ 2}
//Match two decimal digits.
//\b End the match at a word boundary.
//The replacement pattern $$$& is interpreted as shown in the following table.

//Pattern Replacement string
//$$	The dollar sign ($) character.
//$&	The entire matched substring.