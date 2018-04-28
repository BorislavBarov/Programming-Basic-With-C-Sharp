namespace RhombusOfStars
{
    using System;

    public class RhombusOfStars
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int k = 0; k < n - row; k++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int i = 0; i < row - 1; i++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }

            for (int row = n - 1; row > 0; row--)
            {
                for (int k = 0; k < n - row; k++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int i = 0; i < row - 1; i++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}
