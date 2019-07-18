using System;
using System.Collections;

namespace Calc
{
    class Report
    {
        static string classname = nameof(Report);
        private static ArrayList MR = new ArrayList();

        public static void RecordAdd(string rec)
        {
            MR.Add(rec);            
        }

        public static void Function(Parse data, string InpData)
        {
            foreach (string value in MR)
            {
                Console.WriteLine(value);
            }
            Logger.Logging(InpData, 0, classname);
        }
    }
}
