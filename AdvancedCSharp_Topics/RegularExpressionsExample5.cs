using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AdvancedCSharp_Topics
{
    class RegularExpressionsExample5
    {
        public static void Main()
        {
            string input = "1. Eggs 2. Milk 3. Chicken 4. Peas 5. Spinach 6. Soda 7. Jam 8. Butter 9. Greek Yogurt 10. Goat Meat 11. Cilantro";
            string pattern = @"\b\d+\.\s";
            foreach (string item in Regex.Split(input, pattern))
            {
                if (!String.IsNullOrEmpty(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
       

    }
}
//The Regex.Split method splits the input string at the positions defined by a regular expression match. 
//   For example, the following code places the items in a numbered list into a string array.
//The regular expression pattern \b\d{1,2}\.\s is interpreted as shown in the following table.

//Pattern Description
//\b Begin the match at a word boundary.
//\d{ 1,2}
//Match one or two decimal digits.
//\.	Match a period.
//\s Match a white-space character.
// so it looks for input to see if there is a match in the words and if a match is found it will split strings where the matching pattern ends