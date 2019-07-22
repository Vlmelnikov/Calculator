using System;

namespace Calc
{
    static class InformHelp
    {
        static public void TextIntro()
        {
            Console.WriteLine("Welcome to \"Calculator\"\n" +
                "In this application you can perform operations on two numbers.\n" +
                "Enter two numbers and operation on them, separating by spaces.\n");
        }

        static public void Help(string indata)
        {
            Console.WriteLine("On this place need to add full instruction to use this APP.\n" +
                "Number format is 123,45\n" +
                "Input data should be separated by space symbols.\n" +
                "This App supported next commands:\n" +
                "- sum, plus or \"+\"\n" +
                "- difference, diff or \"-\"\n" +
                "- multiply or \"*\"\n" +
                "- divide or \"/\"\n" +
                "- square\n" +
                "- report\n");
            Logger.Logging(indata, 0, "Help");
        }

        static public void IncorrectInput(string indata)
        {
            Console.WriteLine("Input is not correct. " +
                "For help use \"H\" command.");
            Logger.Logging(indata, 0, "Wrong input data");
        }
    }
}
