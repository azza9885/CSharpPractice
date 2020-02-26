using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exception_Handling
{
    [TestClass]
    public class ExceptionHandling_Intro_test
    {
        [TestMethod]
        public void TestMethod1()
        {
            ExceptionHandling_introClass.DivisionTest();
        }

        [TestMethod]
        public void VisitedStateList_CheckTest()
        {
            try
            {
                ExceptionHandling_introClass.CheckStateOk("TX");
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
