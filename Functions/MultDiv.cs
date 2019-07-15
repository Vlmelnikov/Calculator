using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class MultDiv : IFunctions
    {
        dynamic answer;
        string classname = nameof(MultDiv);
        public void Function(Parse data, string InpData)
        {
            if (data.command == "multiply")
            {
                answer = data.num1 * data.num2;
                Logger.Logging(InpData, answer, classname);
            }
            else
            {
                answer = data.num1 / data.num2;
                Logger.Logging(InpData, answer, classname);
            }
            Console.WriteLine("Result = " + answer);
        }
    }
}
