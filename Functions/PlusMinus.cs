using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class PlusMinus : IFunctions
    {
        double answer;
        public void Function(Parse data, string InpData)
        {
            if (data.command == "plus")           
                answer = data.num1 + data.num2;            
            else            
                answer = data.num1 - data.num2;

            Logger.Logging(InpData, answer, nameof(PlusMinus));            
            Console.WriteLine("Result = {0}", answer);
        }
    }
}
