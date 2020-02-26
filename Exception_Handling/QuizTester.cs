using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exception_Handling
{
    [TestClass]
    public class QuizTester
    {
        //modify test to catch three different exceptions:
        //ArithmeticException 
        //FormatException 
        //Exception 
        //Use one try block to accomplish this task

        [TestMethod]
        public void Calculate_BMI()
        {
            //setup variables to calculate BMI
            string weight = "0";
            string heightInFeet = "6";
            string heightInInches = "72";
            BodyMassIndexCalculator bmi = null;

            try
            {
                //create instance of the BodyMassIndexCalculator, pass over all variables
                bmi = new BodyMassIndexCalculator
                    (int.Parse(weight), int.Parse(heightInFeet), int.Parse(heightInInches));

            }
            catch (DivideByZeroException exc)
            {
                Console.WriteLine("Divide by zero exception Problem - " + exc.Message);
            }
            catch (FormatException exc)
            {
                Console.WriteLine("Number Format Problem - " + exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            //get result
            string result = bmi.ToString();
            Console.WriteLine(result);

            //create Assertion
            StringAssert.Equals("BMI: 5.09", result);
        }
    }
}
