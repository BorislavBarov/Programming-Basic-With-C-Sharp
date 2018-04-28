namespace CelsiusToFahrenheit
{
    using System;

    public class CelsiusToFahrenheit
    {
        public static void Main()
        {
            var celsius = double.Parse(Console.ReadLine());

            var fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(fahrenheit);
        }
    }
}
