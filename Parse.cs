﻿using System;

namespace Calc
{
    class Parse
    {
        public string command;
        public string indata;
        public dynamic num1;
        public dynamic num2;

        public Parse(string InpData)
        {
            indata = InpData;
            string[] a = InpData.Split(' ');

            if (a.Length == 1)
                ParseOneValue(a, ref command);

            if (a.Length == 3)
                ParseThreeValues(a, ref command, ref num1, ref num2);             

            if (a.Length == 2 | a.Length > 3)
                command = "backtostart";

            if (command == null)
                command = "backtostart";            
        }

        private static void ParseOneValue(string[] objectList, ref string command)
        {
            opt i;
            command = objectList[0];
            Boolean s = false;
            
            for (i = opt.h; i <= opt.exit; i++)
            {
                if (command.ToLower() == i.ToString())
                    s = true;
            }
            if (s == false)
                command = "backtostart";
        }

        private static void ParseThreeValues(string[] objectList, ref string command, ref dynamic num1, ref dynamic num2)
        {
            foreach (var value in objectList)
            {
                double number;

                bool success = Double.TryParse(value, out number);
                if (success)
                {
                    if (num1 == null)
                    {
                        num1 = System.Convert.ToDouble(value);
                        continue;
                    }
                    else
                    {
                        num2 = System.Convert.ToDouble(value);
                        continue;
                    }
                }

                if (command == null)
                {
                    command = value;
                    continue;
                }
                else
                {
                    command = "backtostart";
                    break;
                }
            }
        }
    }
}