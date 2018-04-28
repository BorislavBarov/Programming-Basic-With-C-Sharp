namespace MinNumber
{
    using System;

    public class MinNumber
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num < min)
                { 
                    min = num;
                }
            }

            Console.WriteLine(min);
        }
    }
}
