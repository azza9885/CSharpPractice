using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class ExceptionHandling_introClass
    {
        public static void DivisionTest()
        {
            try 
            {
                int total_Scores = 10;
                int countOfScores = 0;

                double average = total_Scores / countOfScores;
                
            }
            
            catch(Exception ex)    //when try catch is used atleast one catch block is required
            {
                Console.WriteLine(ex.Message);
                
            }

            finally // finally is an optional block for try catch and it executes no matter what if the try catch 
                    // block hits the exception or not
            {
                Console.WriteLine("Division Operation");
                
            }

        }

        public static string state;

        public static void CheckStateOk(string st)
        {
            switch (st.ToUpper())
            {
                case "FL":
                case "PA":
                case "NJ":
                case "MO":
                case "CA":
                    state = st.ToUpper();
                    Console.WriteLine("I have visited the entered State : {0} ", state);
                    break;
                default:
                    
                    Exception ex = new Exception("Not any of the states" + "That I have visited");
                    throw ex;
            }

           
        }


    }
}
