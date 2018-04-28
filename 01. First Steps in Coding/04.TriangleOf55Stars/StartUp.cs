namespace TriangleOf55Stars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                var stars = new string('*', i);
                Console.WriteLine(stars);
            }
        }
    }
}
