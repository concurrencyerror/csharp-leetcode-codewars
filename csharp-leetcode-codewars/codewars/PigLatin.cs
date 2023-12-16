using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_leetcode_codewars.codewars
{
    public class PigLatin
    {
        public static string PigIt(string str)
        {
            string[] strings = str.Split(' ');
            for (int i = 0; i < strings.Length; i++)
            {
                string s = strings[i];
                if (s.Equals("!")) continue;
                s = string.Concat(s.AsSpan(1, s.Length - 1), s.AsSpan(0, 1), "ay");
                strings[i] = s;
            }
            return string.Join(" ", strings);
        }
    }
}
