﻿namespace PasswordGuess
{
    using System;

    public class PasswordGuess
    {
        public static void Main()
        {
            var password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            { 
                Console.WriteLine("Welcome");
            }
            else
            { 
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
