namespace TimePlus15Minutes
{
    using System;

    public class TimePlus15Minutes
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var zero = string.Empty;
            minutes += 15;

            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }

            if (minutes < 10)
            {
                zero = "0";
            }

            hours %= 24;
            minutes %= 60;

            Console.WriteLine("{0}:{1}{2}", hours, zero, minutes);
        }
    }
}
