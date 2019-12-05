using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    public static class Utilities
    {
        public static string ConvertInchestoFeetAndInchString(int inches)
        {
            //may need to account for negatives later, but not listed as a requirement
            var returnValue = "";
            var inchRemainder = 0;
            var feet = Math.DivRem(inches, 12, out inchRemainder);

            if (feet > 0)
            {
                returnValue += feet.ToString() + "'";
            }

            if (inchRemainder > 0)
            {
                returnValue += inchRemainder.ToString();
            }

            return returnValue;
        }

        public static int ConvertFeetAndInchestoInt(string FeetAndInches)
        {
            int returnValue = 0;

            var breakUp = FeetAndInches.Split("'");
            returnValue = int.Parse(breakUp[0]) * 12;
            if (breakUp[1].Length > 0)
            {
                returnValue += int.Parse(breakUp[1]);
            }
            return returnValue;
        }

    }

}

