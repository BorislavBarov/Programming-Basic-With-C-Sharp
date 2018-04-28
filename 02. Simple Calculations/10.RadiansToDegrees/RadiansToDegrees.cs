namespace RadiansToDegrees
{
    using System;

    public class RadiansToDegrees
    {
        public static void Main()
        {
            var radians = double.Parse(Console.ReadLine());

            var degrees = (radians * 180) / Math.PI;
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
