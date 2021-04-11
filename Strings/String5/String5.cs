using System;
using System.Text;

namespace String5
{/*
  15. Write a program in C# Sharp to read a sentence and replace lowercase characters by uppercase and vice-versa. 
  */
    class String5
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

                foreach (var item in str)
                {
                    var ch = item;
                    if (Char.IsLower(ch))
                    {
                        ch = Char.ToUpper(ch);
                        Console.Write(ch);
                    }
                    else
                    {
                        ch = Char.ToLower(ch);
                        Console.Write(ch);
                    }
                }
            }
        }
    }
}
