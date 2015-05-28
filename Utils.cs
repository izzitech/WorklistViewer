using System;

namespace WorklistViewer
{
    class Utils
    {
        public static int AgeCalc(DateTime birthdate)
        {
            int year = (DateTime.Today.Year - birthdate.Year);
            if (DateTime.Today.Month < birthdate.Month)
            {
                year--;
            }
            return year;
        }
    }
}
