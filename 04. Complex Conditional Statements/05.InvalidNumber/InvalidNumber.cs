namespace InvalidNumber
{
    using System;

    public class InvalidNumber
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());

            var isValid = (number >= 100 && number <= 200) || number == 0;

            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
