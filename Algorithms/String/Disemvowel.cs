using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.String
{
    public class Disemvowel
    {
        public string RemoveVowelFromText(string str) 
        {
                if (string.IsNullOrEmpty(str))
                    return "";
                List<string> vowels = new() { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
                vowels.ForEach(x => { str = str.Replace(x, ""); });

                return str;
        }
    }
}
