using System;

namespace Array5
{/*
  16. Write a program in C# Sharp to find the second largest element in an array.
  */
    class Array5
    {
        static void Main(string[] args)
        {
            var numberOfArrayElements = ReadNumberOfArrayElements();
            int ReadNumberOfArrayElements()
            {
                while (true)
                {
                    int minNumberOfArrayElements = 5, maxNumberOfArrayElements = 10;
                    Console.WriteLine($"Input number of elements from {minNumberOfArrayElements} to {maxNumberOfArrayElements}:");
                    var input = Console.ReadLine();
                    if ((Int32.TryParse(input, out int numberOfArrayElements)) && (numberOfArrayElements >= minNumberOfArrayElements && numberOfArrayElements <= maxNumberOfArrayElements))
                    {
                        return numberOfArrayElements;
                    }
                    else
                    {
                        Console.WriteLine($"Input only numbers from {minNumberOfArrayElements} to {maxNumberOfArrayElements}!\n");
                    }
                }
            }

            int[] arrayElements = new int[numberOfArrayElements];

            ReadArrayElements();
            void ReadArrayElements()
            {
                for (int i = 0; i < numberOfArrayElements;)
                {
                    Console.WriteLine($"Input an element № {i}");
                    var input = Console.ReadLine();
                    if (Int32.TryParse(input, out int elementOfArray))
                    {
                        arrayElements[i] = elementOfArray;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Input only numbers!\n");
                    }
                }
            }

            Console.WriteLine("\nArray of elements:");
            WriteArrayOfElements(arrayElements);
            void WriteArrayOfElements(int[] array)
            {
                foreach (var item in array)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine("\n");
            }

            FindSecondLargestElement();
            void FindSecondLargestElement()
            {
                int max = arrayElements[0];
                for (int i = 0;i < arrayElements.Length; i++)
                {
                    if (max < arrayElements[i])
                    {
                        max = arrayElements[i];
                    }
                }
                int secondMax = (max == arrayElements[0] ? arrayElements[1] : arrayElements[0]);
                int different = (max - arrayElements[0]) == 0 ? max - arrayElements[1] : max - arrayElements[0];
                for (int i = 1; i < arrayElements.Length; i++)
                {
                    if ((different > (max - arrayElements[i])) && (max != arrayElements[i]))
                    {
                        different = max - arrayElements[i];
                        secondMax = arrayElements[i];
                    }
                }
                Console.Write($"max = {max}, secondMax = {secondMax}\n");
            }   
        }
    }
}
