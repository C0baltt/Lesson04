using System;

namespace Array4
{
    class Array4
    {
        /*
         19. Write a program in C# Sharp for addition of two Matrices of same size. Go to the editor
         */
        static void Main(string[] args)
        {
            var numberOfArrayRows = ReadNumberOfArrayElements();//Rows -- строки
            var numberOfArrayColumns = ReadNumberOfArrayElements();//Columns -- ряды
            
            int ReadNumberOfArrayElements()
            {
                while (true)
                {
                    int minNumberOfArrayElements = 2, maxNumberOfArrayElements = 4;
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

            int[,] array1Elements = new int[numberOfArrayRows,numberOfArrayColumns], array2Elements = new int[numberOfArrayRows, numberOfArrayColumns];
            Console.WriteLine($"Input array1:");
            ReadArrayElements(array1Elements);

            Console.WriteLine($"Input array2:");
            ReadArrayElements(array2Elements);

            void ReadArrayElements(int[,] array)
            {
                for (int i = 0; i < numberOfArrayRows; i++)
                {
                    for (int j = 0; j < numberOfArrayColumns;)
                    {
                        Console.WriteLine($"Input an element № [{i},{j}]");
                        var input = Console.ReadLine();
                        if (Int32.TryParse(input, out int elementOfArray))
                        {
                            array[i,j] = elementOfArray;
                            j++;
                        }
                        else
                        {
                            Console.WriteLine("Input only numbers!\n");
                        } 
                    }
                }
            }

            Console.WriteLine("\n\nArray 1:");
            WriteArrayOfElements(array1Elements);
            Console.WriteLine("\n\nArray 2:");
            WriteArrayOfElements(array2Elements);

            void WriteArrayOfElements(int[,] array)
            {
                for (int i = 0; i < numberOfArrayRows; i++)
                {
                    for (int j = 0; j < numberOfArrayColumns; j++)
                    {
                        Console.Write($"{array[i,j]} ");
                    }
                    Console.WriteLine("\n");
                }
            }

            Console.WriteLine($"Arrays sum:");
            SumArrayElements();

            void SumArrayElements()
            {
                for (int i = 0; i < numberOfArrayRows; i++)
                {
                    for (int j = 0; j < numberOfArrayColumns; j++)
                    {
                        Console.Write($"{array1Elements[i,j] + array2Elements[i,j]} ");
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
