﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Linq
{
    internal class CaseInsensitive : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return x.ToLower().CompareTo(y.ToLower());
        }
    }

    internal class SameLetters : IEqualityComparer<string>
    {


        public bool Equals(string? x, string? y)
        {
            if (x == null && y == null) return true;
            if (x == null || y == null) return false;
            return x.ToLower().OrderBy(c => c).SequenceEqual(y.ToLower().OrderBy(c => c));
        }
        public int GetHashCode(string obj)
        {
            return string.Concat(obj.ToLower().OrderBy(c => c)).GetHashCode();
        }
    }
}
