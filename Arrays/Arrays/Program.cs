using System;

namespace Arrays
{
    /*
     2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            int ReadNumberOfArrayElements()
            {
                while (true)
                {
                    Console.WriteLine("Input number of elements from 3 to 10:");
                    var input = Console.ReadLine();
                    if ((Int32.TryParse(input, out int numberOfArrayElements)) && (numberOfArrayElements >= 3 && numberOfArrayElements <= 10))
                    {
                        return numberOfArrayElements;
                    }
                    else
                    {
                        Console.WriteLine("Input only numbers from 3 to 10:");
                        continue;
                    }
                }
            }

            var numberOfArrayElements = ReadNumberOfArrayElements();

            void ReadArrayElements()
            {

            }

        }
    }
}
