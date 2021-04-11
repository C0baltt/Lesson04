using System;

namespace String2
{
    /*
     9. Write a program in C# Sharp to count a total number of vowel or consonant in a string.
     */
    class String2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            string str1 = Console.ReadLine();
            str1 = str1.Trim().ToLower();
            int vovels = 0, consonants = 0, otherSimbols = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                switch (str1[i])
                {
                    case 'a' or 'o' or 'e' or 'u' or 'i':
                        vovels++;
                        break;
                    case 'b' or 'c' or 'd' or 'f' or 'g' or 'j' or 'k' or 'l' or 'm' or 'n' or 'p' or 'q' or 's' or 't' or 'v' or 'x' or 'z' or 'h' or 'r' or 'w' or 'y':
                        consonants++;
                        break;
                    default:
                        otherSimbols++;
                        break;
                }
            }
            Console.WriteLine($"vovels = {vovels}, consonants = {consonants}, other simbols = {otherSimbols}");
        }
    }
}
