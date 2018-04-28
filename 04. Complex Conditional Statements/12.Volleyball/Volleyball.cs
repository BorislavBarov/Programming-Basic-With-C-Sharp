namespace Volleyball
{
    using System;

    public class Volleyball
    {
        public static void Main()
        {
            var leapOrNormal = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var weekends = int.Parse(Console.ReadLine());

            var games = (((48 - weekends) * 3.0) / 4) + weekends + ((holidays * 2.0) / 3);

            if (leapOrNormal == "leap")
            { 
                Console.WriteLine(Math.Truncate((games * 0.15) + games));
            }
            else
            { 
                Console.WriteLine(Math.Truncate(games));
            }
        }
    }
}
