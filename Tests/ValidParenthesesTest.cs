using Algorithms.String;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestValidParentheses()
        {
            DoTest(true, "()");
            DoTest(true, "((()))");
            DoTest(true, "()()()");
            DoTest(true, "(()())()");
            DoTest(true, "()(())((()))(())()");
        }

        [Test]
        public void TestInvalidParentheses()
        {
            DoTest(false, ")(");
            DoTest(false, "()()(");
            DoTest(false, "((())");
            DoTest(false, "())(()");
            DoTest(false, ")()");
            DoTest(false, ")");
        }

        [Test]
        public void TestEmptyString()
        {
            DoTest(true, "");
        }

        private void DoTest(bool expected, string str)
        {
            Assert.AreEqual(expected, ValidParentheses.ValidateParentheses(str), $"Incorrect answer for str = \"{str}\"");
        }
    }
}