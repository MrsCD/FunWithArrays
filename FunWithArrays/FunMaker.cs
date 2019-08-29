using System;

namespace FunWithArrays
{
    /// <summary>
    /// FunMaker.
    /// </summary>
    internal class FunMaker
    {
        /// <summary>
        /// Gets the even numbers of an existing array.
        /// </summary>
        /// <returns>Even Numbers</returns>
        internal int[] GetEvenNumbers()
        {
            int[] numbers =  { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] even = new int[4];
            int counter = 0;
            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        System.Console.WriteLine(numbers[i]);
                        even[i] = numbers[i];
                    }

                }
            }
            catch
            {
               throw new IndexOutOfRangeException($"'{even}' array has a to high index");
            }
        
            // Objective: Return array which contains only even numbers

            return even;
           
        }
       
    }
}
