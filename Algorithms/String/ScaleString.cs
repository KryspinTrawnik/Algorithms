namespace Algorithms.String
{
    public class ScaleString
    {
        public static string Scale(string strng, int k, int n)
        {
            string result = "";
            if (string.IsNullOrEmpty(strng))
            {
                return result;
            }
            string[] temp = strng.Split('\n');
            string tempor = "";
            List<string> list = new List<string>();
            for (int i = 0; i < temp.Length; i++)
            {
                foreach (char chr in temp[i])
                {
                    tempor = tempor + getCharTimed(chr, k);
                }
                tempor = tempor + "\n";
                temp[i] = tempor;
                for (int j = 0; j < n; j++)
                {
                    list.Add(tempor);
                }
                tempor = "";
            }

            result = string.Concat(list.ToArray()).ToString().TrimEnd('\n');

            return result;
        }

        private static string getCharTimed(char ch, int n)
        {
            string result = ch.ToString();
            for (int i = 1; i < n; i++)
            {
                result = result + ch.ToString();
            }

            return result.ToString();
        }
    }
}
