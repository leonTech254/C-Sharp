﻿// See https://aka.ms/new-console-template for more information

namespace HelloC
    {
    public class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Hello leon");
//changing console color
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            //Getting userInput
            UserInteraction.UserInput.AskUserName();

            //Variaables
            Variables.variables();


            //Casting 
            /*
            Casting.casting();
             * */


            //String Functions

            StringFuncs.Strigfunc();

            //CArrarys
            CArrays.cArray();
        }
    }

}



