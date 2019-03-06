using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BrowserDemo
{
    public static class PersianDateTools
    {
        public static string ToPersianDate(DateTime _date)
        {
            PersianCalendar pc = new PersianCalendar();
            var year = pc.GetYear(_date);
            var month = pc.GetMonth(_date);
            var day = pc.GetDayOfMonth(_date);

            return $"{year}/{month:00}/{day:00}";
        }
    }
}
