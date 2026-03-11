using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Shift(this string s, int shift)
        {
            if (s == null)
                return string.Empty;

            int len = s.Length;
            if (len == 0)
                return s;

      
            shift = shift % len;
            if (shift < 0)
                shift += len;  

            if (shift == 0)
                return s;

            return s.Substring(len - shift) + s.Substring(0, len - shift);
        }
    }
}
