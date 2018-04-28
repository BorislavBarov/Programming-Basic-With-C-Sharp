namespace SumSeconds
{
    using System;

    public class SumSeconds
    {
        public static void Main()
        {
            var firstPlayer = double.Parse(Console.ReadLine());
            var secondPlayer = double.Parse(Console.ReadLine());
            var thirdPlayer = double.Parse(Console.ReadLine());

            var totalTime = firstPlayer + secondPlayer + thirdPlayer;

            if (totalTime <= 59)
            {
                if (totalTime < 10)
                {
                    Console.WriteLine("0:0{0}", totalTime);
                }
                else
                {
                    Console.WriteLine("0:{0}", totalTime);
                }
            }
            else if (totalTime >= 60 && totalTime < 120)
            {
                totalTime -= 60;

                if (totalTime < 10)
                {
                    Console.WriteLine("1:0{0}", totalTime);
                }
                else
                {
                    Console.WriteLine("1:{0}", totalTime);
                }
            }
            else if (totalTime >= 120 && totalTime < 180)
            {
                totalTime -= 120;

                if (totalTime < 10)
                {
                    Console.WriteLine("2:0{0}", totalTime);
                }
                else
                {
                    Console.WriteLine("2:{0}", totalTime);
                }
            }
        }
    }
}
