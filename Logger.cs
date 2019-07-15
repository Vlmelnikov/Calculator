using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Logger
    {
        public static void Logging(string InpData, double answer, string classname)
        {
            DateTime utcDate = DateTime.UtcNow;
            string logString = "|" + utcDate + " |" + InpData + " |result: " + answer + " |" + classname + " |";
            Logger.Log(logString);
        }
        public static void Log(string message)
        {
            File.AppendAllText("log.txt", message + Environment.NewLine);
            Report.RecordAdd(message);
        }
    }
}
