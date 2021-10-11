using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenNums = { 2, 4, 6, 8, 10 };

            for (int i = 0; i < evenNums.Length; i++)
                Console.WriteLine(evenNums[i]);

            for (int i = 0; i < evenNums.Length; i++)
                evenNums[i] = evenNums[i] + 10;

            Console.ReadKey();
        }
    }
}
