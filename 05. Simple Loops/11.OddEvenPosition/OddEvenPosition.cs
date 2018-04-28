namespace OddEvenPosition
{
    using System;

    public class OddEvenPosition
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var oddSum = 0.0;
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var evenSum = 0.0;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;

                    if (evenMax < num)
                    { 
                        evenMax = num;
                    }

                    if (evenMin > num)
                    { 
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;

                    if (oddMax < num)
                    { 
                        oddMax = num;
                    }

                    if (oddMin > num)
                    { 
                        oddMin = num;
                    }
                }
            }

            if (n == 0)
            { 
                Console.WriteLine("OddSum=0, OddMin=No, OddMax=No, EvenSum=0, EvenMin=No, EvenMax=No");
            }
            else if (n == 1)
            { 
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=0, EvenMin=No, EvenMax=No", oddSum, oddMin, oddMax);
            }
            else
            { 
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
            }
        }
    }
}
