﻿namespace SquareOfStars
{
    using System;

    public class SquareOfStars
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write('*');

                for (int j = 1; j < n; j++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}
