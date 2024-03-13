using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class DateTimeFunctions
    {
        public static TimeSpan DifferenceBetweenDates(DateTime date1, DateTime date2)
        {
            return date2 - date1;
        }

        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0);
        }

        public static string TimeOfDay(int hour, int minute)
        {
            if(hour > 23|| minute < 0 || minute > 59)
            {
                return "Некорректное время";
            }
            else if (hour < 5)
            {
                return "Ночь";
            }
            else if (hour < 12)
            {
                return "Утро";
            }
            else if (hour < 18)
            {
                return "День";
            }
            else
            {
                return "Вечер";
            }
        }

        public static string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}
