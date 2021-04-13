using System;

namespace DifficultExercise2
{/*
  Given an array numbers of integers, return how many of item contain an even number of digits
  */
    class DifficultExercise2
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 12, 345, 2, 6, 7896 };
            
            printArray();
            void printArray()
            {
                foreach (var item in nums)
                {
                    Console.Write($"{item} ");
                }
                Console.Write("\n");
            }

            int evenNumbers = 0;

            foreach (var item in nums)
            {
                var temp = item;
                var numberOfDigits = 0;

                while ((temp % 10) != 0)
                {
                    temp /= 10;
                    numberOfDigits++;
                }

                if ((numberOfDigits % 2) == 0)
                {
                    evenNumbers++;
                }
            }

            Console.WriteLine($"Even numbers = {evenNumbers}");
        }
    }
}
