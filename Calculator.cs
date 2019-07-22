using System;
using System.Collections.Generic;
using Calc.Functions;

namespace Calc
{
    class Calculator
    {
        private readonly Dictionary<string, IFunctions> _dict;
        private Calculator()
        {
            _dict = new Dictionary<string, IFunctions>
            {
                { "plus", new PlusMinus() },
                { "minus", new PlusMinus() },
                { "multiply", new MultDiv() },
                { "divide", new MultDiv() },
                { "square", new Square() },
                { "report", new Report() },
                { "help", new OtherActions() },
                { "backtostart", new OtherActions() },
                { "exit", new OtherActions() }
            };
        }
        public static Calculator InitializeCalculator()
        {
            return new Calculator();
        }        


        public void Calculation()
        {
            InformHelp.TextIntro();
            for (; ; ) {
                Console.WriteLine("Please enter your data:");
                string InpData = Console.ReadLine();
                Parse pd = new Parse(InpData);
                pd.command = ActionTypes.ActionType(pd.command);
                _dict[pd.command].Function(pd);

                if (pd.command == "exit")
                    break;
            }
        }
    }
}