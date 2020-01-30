using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    public static class stringutilities
    {
        public static int ToWords(string input)
        {
            string[] words = input.Split(' ');
            return words.Length;

        }
    }
}
