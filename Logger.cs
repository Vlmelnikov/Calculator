using System;
using System.IO;


namespace Calc
{
    public class Logger
    {
        public static void Logging(string InpData, double answer, string classname)
        {
            string logString = $"|{DateTime.UtcNow} |{InpData} |result: {answer} |{classname} |";          
            File.AppendAllText("log.txt", logString + Environment.NewLine);
            Report.RecordAdd(logString);
        }
    }
}
