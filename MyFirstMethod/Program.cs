using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// This is the main Method, the program starts here.
        /// </summary>
        /// <param name="args">Not used in this program.</param>
        static void Main(string[] args)
        {
            CountTo10();
            CountTo10();
        }
        /// <summary>
        /// Outputs numbers from 1 to 10
        /// </summary>
        static void CountTo10 ()
        {
            for (int i = 1 ; i <= 10; i ++)
            {
                Console.WriteLine(i);
            }
        }   

    }
}
