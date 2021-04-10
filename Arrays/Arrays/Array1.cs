using System;

namespace Arrays
{
    /*
     2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order. 
     */
    class Array1
    {
        static void Main(string[] args)
        {
            int ReadNumberOfArrayElements()
            {
                while (true)
                {
                    int minNumberOfArrayElements = 3, maxNumberOfArrayElements = 10;
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

            var numberOfArrayElements = ReadNumberOfArrayElements();
            int[] ArrayElements = new int[numberOfArrayElements];

            void ReadArrayElements()
            {
                for(int i = 0; i < numberOfArrayElements;)
                {
                    Console.WriteLine($"Input an element № {i}");
                    var input = Console.ReadLine();
                    if (Int32.TryParse(input, out int elementOfArray))
                    {
                        ArrayElements[i] = elementOfArray;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Input only numbers!\n");
                    }
                }
            }

            ReadArrayElements();

            void WriteArrayOfElements()
            {
                foreach (var i in ArrayElements)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Array of elements:");
            WriteArrayOfElements();

            void WriteReverseArray()
            {
                for (int i = ArrayElements.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{ArrayElements[i]} ");
                }
            }
            Console.WriteLine("Reverse array of elements:");
            WriteReverseArray(); 
        }
    }
}
