namespace HalfSumElement
{
    using System;

    public class HalfSumElement
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var max = -1000000000;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                { 
                    max = num;
                }
            }

            sum -= max;

            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sum - max));
            }
        }
    }
}
