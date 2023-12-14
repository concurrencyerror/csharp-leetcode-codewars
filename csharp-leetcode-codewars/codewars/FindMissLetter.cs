using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.codewar
{
    public static class FindMissLetter
    {
        public static char FindMissingLetter(char[] array)
        {
            var tmp = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                tmp++;
                char letter = array[i];
                if (tmp != letter)
                {
                    return tmp;
                }
            }
            return '_';
        }
    }
}