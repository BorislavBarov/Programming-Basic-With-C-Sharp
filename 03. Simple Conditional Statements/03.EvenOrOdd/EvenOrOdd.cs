namespace EvenOrOdd
{
    using System;

    public class EvenOrOdd
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}