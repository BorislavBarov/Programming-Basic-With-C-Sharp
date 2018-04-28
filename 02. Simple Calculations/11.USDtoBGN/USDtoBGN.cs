namespace USDtoBGN
{
    using System;

    public class USDtoBGN
    {
        public static void Main()
        {
            var usd = double.Parse(Console.ReadLine());

            var bgn = usd * 1.79549;
            Console.WriteLine(Math.Round(bgn, 2));
        }
    }
}
