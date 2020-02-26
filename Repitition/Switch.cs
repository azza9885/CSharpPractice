using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repitition
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void Switch_Test_Weekday()
        {
            int testDay = 4;
            string corresponding_Weekday = "";

            switch (testDay)
            {
                case 1:
                    corresponding_Weekday = "Monday";
                    break;
                case 2:
                    corresponding_Weekday = "Tuesday";
                    break;
                case 3:
                    corresponding_Weekday = "Wednesday";
                    break;
                case 4:
                    corresponding_Weekday = "Thursday";
                    break;
                case 5:
                    corresponding_Weekday = "Friday";
                    break;
                default:
                    corresponding_Weekday = "Not monday through friday";
                    break;
            }

            Console.WriteLine($"The testday value is : {testDay} and the corresponding weekday value is : {corresponding_Weekday}");
            Assert.AreEqual("Thursday", corresponding_Weekday);
        }

        [TestMethod]
        public void Switch_Test_StateAbbrevationcheck()
        {
            string state_Abbrevation = "PA";
            string _stateName = "";

            switch (state_Abbrevation)
            {
                case "PA":
                    _stateName = "Pennsylvania";
                    break;
                case "NJ":
                    _stateName = "NewJersey";
                    break;
                case "MD":
                    _stateName = "Maryland";
                    break;
                case "DE":
                    _stateName = "Delaware";
                    break;
                case "NY":
                    _stateName = "Newyork";
                    break;
                default:
                    _stateName = "Not a state in and around Philadelphia";
                    break;

            }

            Console.WriteLine($"The state abbrevation passed is {state_Abbrevation} and the corresponding state is : {_stateName}");
            Assert.AreEqual("Pennsylvania", _stateName);
        }
    }
}
