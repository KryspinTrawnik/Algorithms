using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.String
{
    public class ValidParentheses
    {
        //mine initial version
        public static bool ValidateParentheses(string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;
            if (str[0] == ')' || str[str.Length - 1] == '(' || str.Length == 1)
                return false;

            int openIndex = str.IndexOf('(');

            if (openIndex >= 0 && str.Length > 0)
            {
                str = str.Remove(openIndex, 1);
            }
            
            int closeIndex = str.IndexOf(')');
            if (closeIndex >= 0)
            {
                str = str.Remove(closeIndex, 1);

            }

                return ValidateParentheses(str);

        }

        // cleaner version
        public static bool ValidParentheses2(string str)
        {
            if (str.Length == 0)
                return true;

            if (str.Contains("()"))
                return ValidParentheses2(str.Replace("()", ""));
            else
                return false;
        }
    }
}
