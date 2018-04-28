namespace NumberInRange
{
    using System;

    public class NumberInRange
    {
        public static void Main()
        {
            Console.Write("Еnter a number in the range [1...100]:");
            var n = int.Parse(Console.ReadLine());

            while (1 > n || n > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Еnter a number in the range [1...100]:");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: " + n);
        }
    }
}
