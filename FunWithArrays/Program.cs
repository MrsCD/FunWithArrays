using System;

namespace FunWithArrays
{
    /// <summary>
    /// Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <exception cref="Exception">Length is not correct</exception>
        static void Main(string[] args)
        {
            var funMaker = new FunMaker();
            var evenNumbers = funMaker.GetEvenNumbers();

            if(evenNumbers.Length == 4)
            {
                Console.WriteLine("Good");
                Console.ReadLine();
            }

            throw new Exception($"Length '{evenNumbers.Length}' is not correct");

        }
    }
}
