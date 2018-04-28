namespace GreaterNumber
{
    using System;

    public class GreaterNumber
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(firstNumber, secondNumber));
        }
    }
}
