namespace EqualWords
{
    using System;

    public class EqualWords
    {
        public static void Main()
        {
            var firstWord = Console.ReadLine().ToLower();
            var secondWord = Console.ReadLine().ToLower();

            if (firstWord == secondWord)
            { 
                Console.WriteLine("yes");
            }
            else
            { 
                Console.WriteLine("no");
            }
        }
    }
}
