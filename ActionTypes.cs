using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public enum opt
    {
        sum = 1, // "sum" should be first value
        plus,
        difference,
        diff,
        minus,
        mult,
        multiply,
        multiplication,
        division,
        divide,
        div,
        square,
        h,
        help,
        report,
        backtostart,
        quit,
        exit  // should be last value
    }

    static class ActionTypes
    {       
        static public string ActionType(string command)
        {
            opt i;
            Boolean s = false;
            command = Symbols(command, ref s);
            if (s == false)
            {
                for (i = opt.sum; i <= opt.exit; i++)
                {
                    if (command.ToLower() == i.ToString())
                        break;
                }
                command = CommandInputed(command, i);
            }
            return command;
        }
        static private string Symbols(string command, ref Boolean s)
        {
            s = false;
            switch (command)
            {
                case "+":
                    command = "plus";
                    s = true;
                    break;

                case "-":
                    command = "minus";
                    s = true;
                    break;

                case "*":
                    command = "multiply";
                    s = true;
                    break;

                case "/":
                    command = "divide";
                    s = true;
                    break;                    
            }
            return command;
        }
     
        static private string CommandInputed(string command, opt i)
        {
            if (i > opt.exit)
                command = "backtostart";

            switch (i)
            {
                case opt.h: case opt.help:
                    InformHelp.TextIntro();
                    command = "help";                    
                    break;

                case opt.exit: case opt.quit:
                    Console.WriteLine("Good bye!");
                    command = "exit";
                    break;

                case opt.sum: case opt.plus:
                    Console.WriteLine("Your choice is \'sum\' function."); 
                    command = "plus";                    
                    break;

                case opt.diff: case opt.difference:
                case opt.minus:
                    Console.WriteLine("Your choice is \'difference\' function.");
                    command = "minus";
                    break;

                case opt.multiplication: case opt.multiply:
                    Console.WriteLine("Your choice is multiplication function");
                    command = "multiply";
                    break;
                    
                case opt.div: case opt.division: case opt.divide:
                    Console.WriteLine("Your choice is division function");
                    command = "divide";
                    break;

                case opt.square:
                    Console.WriteLine("Your choice is square function"); 
                    command = "square";
                    break;

                case opt.report:
                    Console.WriteLine("Your choice is report"); 
                    command = "report";
                    break;
            }
            return command;
        }
    }
}
