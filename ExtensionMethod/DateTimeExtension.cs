using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class DateTimeExtension
    {
        public static string dateTimeToString(this DateTime date)
        {
            return date.ToString("dd-MM-yy");
        }
    }
}
