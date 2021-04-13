using System;

namespace DifficultExercises
{
    /*
     Given an integer array numbers. Move all 0 to the end of while maintaining the relative order of the non-zero elements
    that you must do this in-place without making a copy of the array
     */
    class DifficultExercise1
    {
        static void Main(string[] args)
        {
            int[] nums  = new[] { 0, 1, 0, 3, 12 };

            int numberOfZero = 0;

            printArray();
            void printArray()
            {
                foreach (var item in nums)
                {
                    Console.Write($"{item} ");
                }
                Console.Write("\n");
            }

            foreach (var item in nums)
            {
                if (item == 0)
                {
                    numberOfZero++;
                }
            }

            while (numberOfZero != 0)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0)
                    {
                        if (i + 1 != nums.Length)
                        {
                            int temp = 0;
                            nums[i] = nums[i + 1];
                            nums[i + 1] = temp;
                        }
                    }
                }
                numberOfZero--;
            }

            printArray();
        }
    }
}
