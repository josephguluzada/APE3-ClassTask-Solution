using System;
using System.Collections.Generic;
using System.Text;

namespace HotelTask.CustomExtensions
{
    static class StringExtension
    {
        public static string Capitalize(this string word)
        {
            if (word == null) return null;

            return char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}
