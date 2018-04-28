namespace TradeComissions
{
    using System;

    public class TradeComissions
    {
        public static void Main()
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (0 <= sales && sales <= 500)
                {
                    Console.WriteLine(Math.Round(sales * 0.05, 2));
                }
                else if (500 < sales && sales <= 1000)
                {
                    Console.WriteLine(Math.Round(sales * 0.07, 2));
                }
                else if (1000 < sales && sales <= 10000)
                {
                    Console.WriteLine(Math.Round(sales * 0.08, 2));
                }
                else if (sales > 10000)
                {
                    Console.WriteLine(Math.Round(sales * 0.12, 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    Console.WriteLine(Math.Round(sales * 0.045, 2));
                }
                else if (500 < sales && sales <= 1000)
                {
                    Console.WriteLine(Math.Round(sales * 0.075, 2));
                }
                else if (1000 < sales && sales <= 10000)
                {
                    Console.WriteLine(Math.Round(sales * 0.1, 2));
                }
                else if (sales > 10000)
                {
                    Console.WriteLine(Math.Round(sales * 0.13, 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    Console.WriteLine(Math.Round(sales * 0.055, 2));
                }
                else if (500 < sales && sales <= 1000)
                {
                    Console.WriteLine(Math.Round(sales * 0.08, 2));
                }
                else if (1000 < sales && sales <= 10000)
                {
                    Console.WriteLine(Math.Round(sales * 0.12, 2));
                }
                else if (sales > 10000)
                {
                    Console.WriteLine(Math.Round(sales * 0.145, 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
