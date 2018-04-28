namespace MaxNumber
{
    using System;

    public class MaxNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > max)
                { 
                    max = num;
                }
            }

            Console.WriteLine(max);
        }
    }
}
