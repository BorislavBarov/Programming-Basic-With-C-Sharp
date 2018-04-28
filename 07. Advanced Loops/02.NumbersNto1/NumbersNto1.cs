namespace NumbersNto1
{
    using System;

    public class NumbersNto1
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
