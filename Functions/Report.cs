using System;
using System.Collections;

namespace Calc
{
    class Report : IFunctions
    {
        static string classname = nameof(Report);
        private static ArrayList MR = new ArrayList();

        public static void RecordAdd(string rec)
        {
            MR.Add(rec);            
        }

        public void Function(Parse data)
        {
            foreach (string value in MR)
            {
                Console.WriteLine(value);
            }
            Logger.Logging(data.indata, 0, classname);
        }
    }
}
