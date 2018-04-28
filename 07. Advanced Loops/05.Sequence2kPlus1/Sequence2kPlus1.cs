namespace Sequence2kPlus1
{
    using System;

    public class Sequence2kPlus1
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 0; num <= n; i++)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
