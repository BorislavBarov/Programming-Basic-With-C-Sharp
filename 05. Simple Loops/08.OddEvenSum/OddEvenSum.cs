namespace OddEvenSum
{
    using System;

    public class OddEvenSum
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                var element = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += element;
                }
                else
                {
                    oddSum += element;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(evenSum - oddSum));
            }
        }
    }
}
