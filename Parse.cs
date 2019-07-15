using System;

namespace Calc
{
    class Parse
    {
        public string command;
        public dynamic num1;
        public dynamic num2;

        public Parse(string[] objectList)
        {
            if (objectList.Length == 1)
            {
                command = objectList[0];
                ActionTypes.opt i;
                for (i = ActionTypes.opt.h; i <= ActionTypes.opt.exit; i++)
                {
                    if (command.ToLower() == i.ToString())
                        num1 = 1;                                       
                }
                if (num1 == null)
                    command = "backtostart";
            }

            if (objectList.Length == 2 | objectList.Length > 3)
                command = "backtostart";
                    
            if (objectList.Length == 3)
                foreach (var value in objectList)
                {
                    // int number;
                    double number2;

                    /*
                     * To work with different number types
                    bool success = Int32.TryParse(value, out number);
                    if (success)
                    {
                        if (num1 == null)
                        {
                            num1 = System.Convert.ToInt32(value);
                            continue;
                        }
                        num2 = System.Convert.ToInt32(value);
                        continue;
                    }
                    */

                    bool success2 = Double.TryParse(value, out number2);
                    if (success2)
                    {
                        if (num1 == null)
                        {
                            num1 = System.Convert.ToDouble(value);
                            continue;
                        }
                        num2 = System.Convert.ToDouble(value);
                        continue;
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
            if (command == null)
            {
                command = "backtostart";
            }

/* Might be improve for works with different types
            if (num1.GetType() != num2.GetType())
            {
                num1 = (double)num1;
                num2 = (double)num2;
            }
*/
        }
    }
}