using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.String
{
    public class Millipede
    {
        public static bool CanItBeMillipede(string[] arr)
        {
            bool result = false;

            List<string> Wörter = arr.ToList();

            foreach (var VARIABLE in Wörter)
            {
                Console.WriteLine(VARIABLE);
            }

            for (int i = 0; i < 10000; i++)
            {

                Random rand = new Random();
                List<string> shuffledWörter = Wörter.OrderBy(_ => rand.Next()).ToList();

            End:
                for (int t = 1; t < shuffledWörter.Count; t++)
                {
                    if (shuffledWörter[0][shuffledWörter[0].Length - 1] == shuffledWörter[t][0])
                    {
                        shuffledWörter[0] = shuffledWörter[t];
                        shuffledWörter.RemoveAt(t);
                        goto End;
                    }
                }

                if (shuffledWörter.Count == 1)
                    return true;

            }

            return result;

        }
    }
}
