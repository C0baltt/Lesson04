using System;

namespace Strings
{
    class String1
    {
        /*
         6. Write a program in C# Sharp to compare two string without using string library functions.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st string :");
            var str1 = Console.ReadLine();
            Console.WriteLine("Input the 2nd string :");
            var str2 = Console.ReadLine();

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] == str2[i])
                    {
                        if ((i + 1) == str1.Length)
                        {
                            Console.WriteLine("The length of both strings are equal and also, both strings are equal.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The length of both strings are equal, but strings are NOT EUQUAL");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("The length of both strings are NOT EUQUAL.");
            }
            
        }
    }
}
