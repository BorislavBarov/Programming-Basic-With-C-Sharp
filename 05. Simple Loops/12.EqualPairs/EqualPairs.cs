namespace EqualPairs
{
    using System;

    public class EqualPairs
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            double previousPairSum = 0;
            double currentPairSum = 0;
            double difference = 0;
            double biggestDifference = 0;

            for (int i = 0; i < n; i++)
            {
                var firstNumber = double.Parse(Console.ReadLine());
                var secondNumber = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    previousPairSum = firstNumber + secondNumber;
                }
                else
                {
                    currentPairSum = firstNumber + secondNumber;
                    difference = Math.Abs(currentPairSum - previousPairSum);

                    if (difference > biggestDifference)
                    {
                        biggestDifference = difference;
                    }

                    previousPairSum = currentPairSum;
                }
            }

            if (biggestDifference == 0)
            {
                Console.WriteLine("Yes, value ={0}", previousPairSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff ={0}", biggestDifference);
            }
        }
    }
}
