﻿using System;
using System.Linq;

namespace KirovAir.Core.Extensions
{
    public static class StringExtensions
    {
        public static string Truncate(this string value, int maxChars, bool addDots = true)
        {
            if (addDots)
                maxChars -= 2;
            return value.Length <= maxChars ? value : string.Concat(value.AsSpan(0, maxChars), addDots ? ".." : "");
        }

        public static string UpperToSpace(this string value)
        {
            return string.Concat(value.Select(x => char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
        }
    }
}
