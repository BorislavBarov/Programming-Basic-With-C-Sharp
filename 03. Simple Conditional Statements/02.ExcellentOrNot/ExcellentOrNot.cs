namespace ExcellentOrNot
{
    using System;

    public class ExcellentOrNot
    {
        public static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
