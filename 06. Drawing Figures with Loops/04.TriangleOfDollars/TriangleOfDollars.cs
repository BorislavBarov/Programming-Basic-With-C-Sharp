﻿namespace TriangleOfDollars
{
    using System;

    public class TriangleOfDollars
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write('$');

                for (int col = 1; col < row; col++)
                {
                    Console.Write(" $");
                }

                Console.WriteLine();
            }
        }
    }
}
