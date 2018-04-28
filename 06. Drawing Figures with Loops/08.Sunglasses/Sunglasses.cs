namespace Sunglasses
{
    using System;

    public class Sunglasses
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/', n * 2 - 2));
                Console.Write("*");

                if (i == (n - 1) / 2 - 1)
                { 
                    Console.Write(new string('|', n));
                }
                else
                { 
                    Console.Write(new string(' ', n));
                }

                Console.Write("*");
                Console.Write(new string('/', n * 2 - 2));
                Console.WriteLine("*");
            }

            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
        }
    }
}
