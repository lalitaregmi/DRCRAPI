using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Dapper
{
    public class NepDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        private string _weekDayName;
        public string WeekDayName
        {
            get { return _weekDayName; }
            set { _weekDayName = value; }
        }

        public string MonthName { get; set; }
        public int WeekDay { get; set; }


        public override string ToString()
        {
            string month, day;
            if (Month < 10)
            {
                month = "0" + Month;
            }
            else month = "" + Month;
            if (Day < 10)
            {
                day = "0" + Day;
            }
            else day = "" + Day;
            return string.Format("{0}/{1}/{2}", Year, month, day);
        }
        public string ToLongDateString()
        {
            return string.Format("{0}, {1} {2}, {3}", WeekDayName, MonthName, Day, Year);
        }

    }
}

