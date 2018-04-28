namespace ChristmasTree
{
    using System;

    public class ChristmasTree
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write(new string('*', i));
                Console.Write(" | ");
                Console.Write(new string('*', i));
                Console.WriteLine(new string(' ', n - i));
            }
        }
    }
}
