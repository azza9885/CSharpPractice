using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace AdvancedCSharp_Topics
{
    [TestClass]
    public class RegularExpressions_UdemyExample
    {
        [TestMethod]
        public void MatchEmail()
        {
            //string[] addresses = { "9AAAAAA@gmail.com", "AAAAAAaaaa!@gmail.com" };
            string[] addresses = { "9AAAAAA@9gmail.com", "9BBBBB9@9gmail.com" };
            string pattern = @"^[0-9A-Z]([-.\w]*[0-9A-Z])*$";
            bool response = false;
            foreach(var address in addresses)
            {
                response = IsEmail(address, pattern);
            }
            Assert.IsTrue(response);
        }

        public static bool IsEmail(string email,string pattern)
        {
            if (email != null)
            {
                return Regex.IsMatch(email, pattern);
            }

            else
                return false;
        }

        [TestMethod]
        public void MatchPhone()
        {
            string number = "(555)-555-5555";
            string pattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            bool response = Regex.IsMatch(number, pattern);
            Assert.IsTrue(response);
        }
    }
}
