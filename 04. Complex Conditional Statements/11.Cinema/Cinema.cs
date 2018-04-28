namespace Cinema
{
    using System;

    public class Cinema
    {
        public static void Main()
        {
            var typeOfTicket = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            if (typeOfTicket == "Premiere")
            { 
                Console.WriteLine("{0:f2} leva", (rows * cols) * 12.00);
            }
            else if (typeOfTicket == "Normal")
            { 
                Console.WriteLine("{0:f2} leva", (rows * cols) * 7.50);
            }
            else if (typeOfTicket == "Discount")
            { 
                Console.WriteLine("{0:f2} leva", (rows * cols) * 5.00);
            }
        }
    }
}
