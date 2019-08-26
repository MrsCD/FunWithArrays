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

            for(int i = 0; i< numbers.Length; i++)
            {
                if(numbers[i] % 2 != 0)
                {
                    // This option is not available
                    // numbers[i].Remove();
                }
            }

            // Objective: Return an which contains only even numbers

            return numbers;
        }
    }
}
