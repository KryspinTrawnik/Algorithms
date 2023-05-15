namespace Algorithms.String
{
    public class CountCharsInString
    {
        public Dictionary<char, int> GetCountOfChars(string input)
        {
            Dictionary<char, int> result = new();
            if (input == string.Empty)
                return new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (result.ContainsKey(c))
                {
                    result[c]++;
                }
                else
                {
                    result.Add(c, 1);
                }
            }
            return result;
        }
    }
}
