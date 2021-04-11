using System;

namespace String3
{
    class String3
    {
        static void Main(string[] args)
        {
            string ReadString(int stringNumber)
            {
                Console.WriteLine($"Input string № {stringNumber}:");
                string str = Console.ReadLine();
                return str;
            }
            string str1 = ReadString(1);
            string str2 = ReadString(2);
            string str3 = ReadString(3);

            Console.WriteLine("\nPrint concotenate strings:"); 
            Console.WriteLine($"{String.Concat(str1, str2, str3)}\n");
        }
    }
}
