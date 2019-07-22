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
            Boolean s = true;
            command = Symbols(command, ref s);
            if (s == false)             
                command = CommandInputed(command);            
            return command;
        }

        static private string Symbols(string command, ref Boolean s)
        {
            switch (command)
            {
                case "+":
                    return command = "plus";
                case "-":
                    return command = "minus";
                case "*":
                    return command = "multiply";
                case "/":
                    return command = "divide";             
            }
            s = false;
            return command;
        }
     
        static private string CommandInputed(string command)
        {
            opt i;

            for (i = opt.sum; i <= opt.exit; i++)
            {
                if (command.ToLower() == i.ToString())
                    break;
            }

            if (i > opt.exit)
                return command = "backtostart";

            switch (i)
            {
                case opt.h: case opt.help:
                    command = "help";                    
                    break;
                case opt.exit: case opt.quit:
                    command = "exit";
                    break;
                case opt.sum: case opt.plus:
                    command = "plus";                    
                    break;
                case opt.diff: case opt.difference:
                case opt.minus:
                    command = "minus";
                    break;
                case opt.multiplication: case opt.multiply:
                    command = "multiply";
                    break;                    
                case opt.div: case opt.division: case opt.divide:
                    command = "divide";
                    break;
                case opt.square:
                    command = "square";
                    break;
                case opt.report:
                    command = "report";
                    break;
            }
            return command;
        }
    }
}
