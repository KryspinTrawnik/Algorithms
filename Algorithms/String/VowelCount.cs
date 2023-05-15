namespace Algorithms.String
{
    public class VowelCount
    {
        public int GetVowelCount(string str)
        {
            int vowelCount = 0;
            HashSet<char> chars = new() { 'a', 'e', 'i', 'o', 'u' };

            foreach (char c in str)
            {
                if (chars.Contains(c)) { vowelCount++; }
            }

            return vowelCount;
        }
    }
}
