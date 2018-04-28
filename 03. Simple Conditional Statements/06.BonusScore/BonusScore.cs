namespace BonusScore
{
    using System;

    public class BonusScore
    {
        public static void Main()
        {
            var score = double.Parse(Console.ReadLine());
            var bonus = 0d;

            if (score <= 100)
            {
                bonus += 5;
            }
            else if (score > 100 && score <= 1000)
            {
                bonus = (score * 20) / 100;
            }
            else if (score > 1000)
            {
                bonus = (score * 10) / 100;
            }

            if (score % 2 == 0)
            {
                bonus += 1;
            }

            if (score % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(score + bonus);
        }
    }
}
