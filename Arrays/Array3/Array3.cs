using System;

namespace Array3
{
    /*
     3. Write a program in C# Sharp to find the sum of all elements of the array.
     */
    class Array3
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
                foreach (var i in array)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("\n");
            }

            int sum = 0;
            foreach (var i in arrayElements)
            {
                sum += i;
            }
            Console.WriteLine($"sum = {sum}\n");
        }
    }
}
