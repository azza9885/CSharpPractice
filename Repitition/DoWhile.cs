using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repitition
{
    [TestClass]
    public class DoWhile
    {
        [TestMethod]
        public void DoWhile_Test()
        {

            int sum = 0;
            int number = 1;

            do
            {
                Console.WriteLine("\n value of number before running this while loop is : {0} ", number);
                sum += number;
                number++;

                Console.WriteLine($" Value of Sum is : \t {sum} ");
                Console.WriteLine($" Value of number after incrementing is {number} ");

            } while (number <= 10);

            Assert.AreEqual(55, sum);
        }
    }
}
