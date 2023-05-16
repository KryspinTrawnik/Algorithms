using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.String
{
    public class High_Low
    {
        public string HighAndLow(string numbers)
        {
            string[] arr = numbers.Split(" ");
            int length = arr.Length, min = int.MaxValue, max = int.MinValue;

            for (int i = 0; i < arr.Length; i++) 
            {
                int current = int.Parse(arr[i]);
                if (current > max)
                {
                    max = current;
                }
                if (current < min)
                { 
                    min = current; 
                }
            }

            return $"{max} {min}";
        }
    }
}
