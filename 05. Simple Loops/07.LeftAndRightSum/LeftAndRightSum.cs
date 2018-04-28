namespace LeftAndRightSum
{
    using System;

    public class LeftAndRightSum
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                leftSum += num;
            }

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                rightSum += num;
            }

            if (leftSum == rightSum)
            { 
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            { 
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}
