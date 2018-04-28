namespace RectangleOfNxNStars
{
    using System;

    public class RectangleOfNxNStars
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', n));
            }
        }
    }
}
