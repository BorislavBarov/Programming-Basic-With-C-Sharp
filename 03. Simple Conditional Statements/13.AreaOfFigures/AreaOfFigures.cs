namespace AreaOfFigures
{
    using System;

    public class AreaOfFigures
    {
        public static void Main()
        {
            var figure = Console.ReadLine();

            if (figure == "square")
            {
                var x = double.Parse(Console.ReadLine());
                var area = x * x;
                Console.WriteLine(Math.Round(area, 3));
            }
            if (figure == "rectangle")
            {
                var x = double.Parse(Console.ReadLine());
                var y = double.Parse(Console.ReadLine());
                var area = x * y;
                Console.WriteLine(Math.Round(area, 3));
            }
            if (figure == "circle")
            {
                var x = double.Parse(Console.ReadLine());
                var area = Math.PI * x * x;
                Console.WriteLine(Math.Round(area, 3));
            }
            if (figure == "triangle")
            {
                var x = double.Parse(Console.ReadLine());
                var y = double.Parse(Console.ReadLine());
                var area = (x * y) / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
