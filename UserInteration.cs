using System;

namespace UserInteraction
{
    public class UserInput
    {
        public static void AskUserName()
        {
            Console.Write("What is your name? ");
            String name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
    }
}