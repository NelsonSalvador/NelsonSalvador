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
            CountToN(3, 7);
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

        /// <summary>
        /// Outputs numbers from n to n depending on the input
        /// </summary>
        /// <param name="n1">Min number</param>
        /// <param name="n2">Max number</param>
        static void CountToN(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
