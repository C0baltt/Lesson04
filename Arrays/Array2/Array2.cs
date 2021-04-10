using System;

namespace Array2
{
    class Array2
    {
        /*
         10. Write a program in C# Sharp to separate odd and even integers in separate arrays.
         */
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
                foreach (var i in array)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("\n");
            }

            int[] arrayOfEven = new int[numberOfArrayElements], arrayOfOdd = new int[numberOfArrayElements];
            
            SortEvenOdd();
            void SortEvenOdd()
            {
                int indexArrayOfEven = 0, indexArrayOfOdd = 0;
                for (int i = 0; i < arrayElements.Length; i++)
                {
                    if ((arrayElements[i] % 2) == 0)
                    {
                        arrayOfEven[indexArrayOfEven] = arrayElements[i];
                        indexArrayOfEven++;
                    }
                    else
                    {
                        arrayOfOdd[indexArrayOfOdd] = arrayElements[i];
                        indexArrayOfOdd++;
                    }
                }
            }

            Console.WriteLine("The Even elements are:");
            WriteArrayOfElements(arrayOfEven);

            Console.WriteLine("The Odd elements are:");
            WriteArrayOfElements(arrayOfOdd);
        }
    }
}
