using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtension
    {
        public static string getShortString(this string str,int maxLength)
        {
            if(str.Length <= maxLength) return str;
            return str.Substring(0,maxLength-3) + "...";
        }
    }
}
