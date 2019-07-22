using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Functions
{
    class OtherActions : IFunctions
    {
        public void Function(Parse data)
        {
            switch (data.command)
            {
                case "backtostart":
                    InformHelp.IncorrectInput(data.indata);
                    break;
                case "help":
                    InformHelp.Help(data.indata);
                    break;
                case "exit":
                    Logger.Logging(data.indata, 0, "Exit");
                    break;
            }
        }
    }
}
