using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace lr6
{
    public static class Data
    {
        public static string ChangeDate(this string s, int mm)
        {
            s = Regex.Replace(s, @"([01][0-9]:[0-5][0-9])|(2[0-3]:[0-5][0-9])", m => DateTime.Parse(m.Value).AddMinutes(mm).ToShortTimeString());
            return s;
        }
    }
}
