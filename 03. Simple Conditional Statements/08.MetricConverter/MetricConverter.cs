namespace MetricConverter
{
    using System;

    public class MetricConverter
    {
        public static void Main()
        {
            var metricNumber = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();

            if (input == "m")
                metricNumber /= 1;
            else if (input == "mm")
                metricNumber /= 1000;
            else if (input == "cm")
                metricNumber /= 100;
            else if (input == "mi")
                metricNumber /= 0.000621371192;
            else if (input == "in")
                metricNumber /= 39.3700787;
            else if (input == "km")
                metricNumber /= 0.001;
            else if (input == "ft")
                metricNumber /= 3.2808399;
            else if (input == "yd")
                metricNumber /= 1.0936133;

            if (output == "m")
                metricNumber *= 1;
            else if (output == "mm")
                metricNumber *= 1000;
            else if (output == "cm")
                metricNumber *= 100;
            else if (output == "mi")
                metricNumber *= 0.000621371192;
            else if (output == "in")
                metricNumber *= 39.3700787;
            else if (output == "km")
                metricNumber *= 0.001;
            else if (output == "ft")
                metricNumber *= 3.2808399;
            else if (output == "yd")
                metricNumber *= 1.0936133;

            Console.WriteLine(metricNumber + " " + output);
        }
    }
}
