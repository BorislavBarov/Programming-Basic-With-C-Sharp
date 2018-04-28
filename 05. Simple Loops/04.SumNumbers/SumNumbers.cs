namespace SumNumbers
{
    using System;

    public class SumNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
