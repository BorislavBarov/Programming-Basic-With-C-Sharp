namespace FruitShop
{
    using System;

    public class FruitShop
    {
        public static void Main()
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine(Math.Round(quantity * 2.50, 2));
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine(Math.Round(quantity * 1.20, 2));
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine(Math.Round(quantity * 0.85, 2));
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(Math.Round(quantity * 1.45, 2));
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(Math.Round(quantity * 2.70, 2));
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine(Math.Round(quantity * 5.50, 2));
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine(Math.Round(quantity * 3.85, 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine(Math.Round(quantity * 2.70, 2));
                }
                if (fruit == "apple")
                {
                    Console.WriteLine(Math.Round(quantity * 1.25, 2));
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine(Math.Round(quantity * 0.90, 2));
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(Math.Round(quantity * 1.60, 2));
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(Math.Round(quantity * 3.00, 2));
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine(Math.Round(quantity * 5.60, 2));
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine(Math.Round(quantity * 4.20, 2));
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
