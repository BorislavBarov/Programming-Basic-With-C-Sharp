namespace House
{
    using System;

    public class House
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int starsCount;

            if (n % 2 == 0)
            { 
                starsCount = 2;
            }
            else
            { 
                starsCount = 1;
            }

            int linesCount = (n - starsCount) / 2;

            Console.Write(new string('-', linesCount));
            Console.Write(new string('*', starsCount));
            Console.WriteLine(new string('-', linesCount));

            for (int i = 2; i <= (n + 1) / 2; i++)
            {
                starsCount += 2;
                linesCount -= 1;
                Console.Write(new string('-', linesCount));
                Console.Write(new string('*', starsCount));
                Console.WriteLine(new string('-', linesCount));
            }

            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');
            }
        }
    }
}
