using System;

namespace Project_Euler.Libraries
{
    public class String
    {
        public static bool IsPallindrome(string s)
        {
            var charArray = new char[s.Length];
            for (int i = s.Length-1; i>=0;i--)
            {
                int index = s.Length - 1 - i;
                charArray[index] = s[i];
            }

            string v = new string(charArray);

            return v.Equals(s, StringComparison.Ordinal);
        }
    }
}