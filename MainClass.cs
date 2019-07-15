using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class MainClass
    {
        public static void Main()
        {
            InformHelp.TextIntro();
            Parse ArrayData;
            IFunctions f;

            do
            {
                Console.WriteLine("Please enter your data:");
                string InpData = Console.ReadLine();
                string[] objectList = InpData.Split(' ');
                ArrayData = new Parse(objectList);
                ArrayData.command = ActionTypes.ActionType(ArrayData.command);
                
                switch (ArrayData.command)
                {
                    case "backtostart":                        
                        InformHelp.IncorrectInput();
                        Logger.Logging(InpData, 0, "Wrong input data");
                        break;

                    case "help":
                        InformHelp.Help();
                        Logger.Logging(InpData, 0, "Help");
                        break;

                    case "plus":
                    case "minus":
                        f = new PlusMinus();
                        f.Function(ArrayData, InpData);
                        break;

                    case "multiply":
                    case "divide":
                        f = new MultDiv();
                        f.Function(ArrayData, InpData);
                        break;

                    case "square":
                        f = new Square();
                        f.Function(ArrayData, InpData);
                        break;

                    case "report":
                        Report.Function(ArrayData, InpData);
                        break;

                    case "exit":
                        Logger.Logging(InpData, 0, "Exit");
                        break;
                }
                
            } while (ArrayData.command != "exit");            
        }
    }
}
