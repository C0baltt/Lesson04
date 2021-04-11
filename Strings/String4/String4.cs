using System;

namespace String4
{/*
  41. Write a C# Sharp program to indicate whether each string in an array ends with a period (".").
  */
    class String4
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nInput string or type \"q\" for quit");
                string str = Console.ReadLine();
                
                if (str == "q")
                {
                    return;
                }
                
                Console.Write($"Does string ends in a \".\"? {str.EndsWith(".")}\n");
            }
        }
    }
}