namespace ThreeEqualNumbers
{
    using System;

    public class ThreeEqualNumbers
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber && secondNumber == thirdNumber && thirdNumber == firstNumber)
            { 
                Console.WriteLine("yes");
            }
            else
            { 
                Console.WriteLine("no");
            }
        }
    }
}
