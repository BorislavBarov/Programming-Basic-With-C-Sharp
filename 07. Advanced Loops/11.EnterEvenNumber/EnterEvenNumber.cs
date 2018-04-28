namespace EnterEvenNumber
{
    using System;

    public class EnterEvenNumber
    {
        public static void Main()
        {
            var n = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    { 
                        break;
                    }

                    Console.WriteLine("The number is not even.");
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
