using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.String
{
    public class ConsecutiveVowels
    {
        public static int GetTheVowels(string word)
        {
            if (string.IsNullOrEmpty(word)) 
                return 0;
            int count = 0;
            char[] vowel = ['a', 'e', 'i', 'o', 'u'];
            Queue<char> queue = new Queue<char>();

            return count;
        }
    }
}
