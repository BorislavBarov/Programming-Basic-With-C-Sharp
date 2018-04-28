namespace CurrencyConverter
{
    using System;

    public class CurrencyConverter
    {
        public static void Main()
        {
            var sum = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();
            var result = 0d;

            if (input == "BGN")
            {
                if (output == "USD")
                {
                    result = sum / 1.79549;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (output == "EUR")
                {
                    result = sum / 1.95583;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (output == "GBP")
                {
                    result = sum / 2.53405;
                    Console.WriteLine(Math.Round(result, 2));
                }
            }
            else if (input == "USD")
            {
                if (output == "BGN")
                {
                    result = sum * 1.79549;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (output == "EUR")
                {
                    result = (sum * 1.79549) / 1.95583;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (output == "GBP")
                {
                    result = (sum * 1.79549) / 2.53405;
                    Console.WriteLine(Math.Round(result, 2));
                }
            }
            else if (input == "EUR")
            {
                if (output == "USD")
                {
                    result = (sum * 1.95583) / 1.79549;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (output == "BGN")
                {
                    result = sum * 1.95583;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (output == "GBP")
                {
                    result = (sum * 1.95583) / 2.53405;
                    Console.WriteLine(Math.Round(result, 2));
                }
            }
            else if (input == "GBP")
            {
                if (output == "USD")
                {
                    result = (sum * 2.53405) / 1.79549;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (output == "EUR")
                {
                    result = (sum * 2.53405) / 1.95583;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (output == "BGN")
                {
                    result = sum * 2.53405;
                    Console.WriteLine(Math.Round(result, 2));
                }
            }
        }
    }
}
