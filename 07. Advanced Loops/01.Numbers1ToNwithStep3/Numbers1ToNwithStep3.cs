namespace Numbers1ToNwithStep3
{
    using System;

    public class Numbers1ToNwithStep3
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
