namespace _1000DaysAfterBirth
{
    using System;
    using System.Globalization;

    public class _1000DaysAfterBirth
    {
        public static void Main()
        {
            var birthDay = Console.ReadLine();

            var birthDayDateTime = DateTime.ParseExact(birthDay, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            for (int i = 0; i < 999; i++)
            {
                birthDayDateTime = birthDayDateTime.AddDays(1);
            }

            Console.WriteLine(birthDayDateTime.ToString("dd-MM-yyyy"));
        }
    }
}
