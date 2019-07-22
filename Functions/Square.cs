using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Square : IFunctions
    {
        dynamic answer;
        public void Function(Parse data)
        {
            answer = data.num1 * data.num2;
            Logger.Logging(data.indata, answer, nameof(Square));
            Console.WriteLine("Result = {0}", answer);
        }
    }
}
