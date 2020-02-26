using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repitition
{
    [TestClass]
    public class BreakandContinue
    {
        [TestMethod]
        public void Break_Test()
        {
            int t = 0;
            for(int n = 0; n <= 10; n++)
            {
                if (n == 5)
                {
                    break; // break is used for unconditional control movement inside the program, as soon as break is hit , the control moves out of the loop
                }
                t += n;

                Console.WriteLine($"the value of n is {n} and the value of t is {t}");
            }

            Assert.AreEqual(10, t);
        }

        [TestMethod]
        public void Continue_Test()
        {
            int t = 0;
            for (int n = 0; n <= 10; n++)
            {
                if (n == 5)
                {
                    continue; // continue is used for unconditional control movement inside the program, where an exception can be made i.e in this context the loop skips 
                              // when n==5, so as soon as n hits 5, without continuing it just increments the value to 6 and restarts printing again , so only the 
                             //loop is skipped 
                              
                }
                t += n;

                Console.WriteLine($"the value of n is {n} and the value of t is {t}");
            }

            Assert.AreEqual(50, t);
        }
    }
}
