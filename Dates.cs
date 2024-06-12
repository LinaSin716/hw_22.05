using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_22._05
{
    public class Dates
    {
        public int Year;
        public int Month;
        public int Day;
        public Dates(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public static bool operator<=(Dates start, Dates end)
        {
            return (start.Year == end.Year) && (start.Month == end.Month) && (start.Day <= end.Day) 
                || (start.Year == end.Year) && (start.Month < end.Month) 
                || (start.Year < end.Year);
        }
        public static bool operator >=(Dates start, Dates end)
        {
            return (start.Year == end.Year) && (start.Month == end.Month) && (start.Day >= end.Day)
                || (start.Year == end.Year) && (start.Month > end.Month)
                || (start.Year > end.Year);
        }
    }
}
