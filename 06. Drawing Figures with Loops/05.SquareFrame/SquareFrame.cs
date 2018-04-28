namespace SquareFrame
{
    using System;

    public class SquareFrame
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write('+');

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }

            Console.WriteLine(" +");

            for (int row = 1; row <= n - 2; row++)
            {
                Console.Write('|');

                for (int col = 0; col < n - 2; col++)
                {
                    Console.Write(" -");
                }

                Console.WriteLine(" |");
            }

            Console.Write('+');

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }

            Console.WriteLine(" +");
        }
    }
}
