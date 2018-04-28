namespace CheckPrime
{
    using System;

    public class CheckPrime
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var prime = true;

            if (n <= 1)
            {
                Console.WriteLine("Not prime");
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
