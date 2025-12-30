using static PhoneLetterCombinations.Solution;

namespace PhoneLetterCombinationsTests
{
    public class PhoneTests
    {
        [Fact]
        public void Test1()
        {
            var result = LetterCombinations("23");
            List<string> expected =
            [
                "ad", "ae", "af",
                "bd", "be", "bf",
                "cd", "ce", "cf"
            ];
            Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
        }

        [Fact]
        public void Test2()
        {
            var result = LetterCombinations("");
            List<string> expected = [];
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            var result = LetterCombinations("2");
            List<string> expected = ["a", "b", "c"];
            Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
        }

        [Fact]
        public void Test4()
        {
            var result = LetterCombinations("9");
            List<string> expected = ["w", "x", "y", "z"];
            Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
        }

        [Fact]
        public void Test5()
        {
            var result = LetterCombinations("79");
            List<string> expected =
            [
                "pw", "px", "py", "pz",
                "qw", "qx", "qy", "qz",
                "rw", "rx", "ry", "rz",
                "sw", "sx", "sy", "sz"
            ];
            Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
        }

        [Fact]
        public void Test6()
        {
            var result = LetterCombinations("234");
            List<string> expected =
            [
                "adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi",
                "bdg", "bdh", "bdi", "beg", "beh", "bei", "bfg", "bfh", "bfi",
                "cdg", "cdh", "cdi", "ceg", "ceh", "cei", "cfg", "cfh", "cfi"
            ];
            Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
        }

        [Fact]
        public void Test7()
        {
            var result = LetterCombinations("1");
            List<string> expected = [];
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test8()
        {
            var result = LetterCombinations("203");
            List<string> expected = [];
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test9()
        {
            var result = LetterCombinations("5678");
            List<string> expected =
            [
                "jmpt", "jmpu", "jmpv", "jmqt", "jmqu", "jmqv", "jmrt", "jmru", "jmrv", "jmst", "jmsu", "jmsv",
                "jnpt", "jnpu", "jnpv", "jnqt", "jnqu", "jnqv", "jnrt", "jnru", "jnrv", "jnst", "jnsu", "jnsv",
                "jopt", "jopu", "jopv", "joqt", "joqu", "joqv", "jort", "joru", "jorv", "jost", "josu", "josv",
                "kmpt", "kmpu", "kmpv", "kmqt", "kmqu", "kmqv", "kmrt", "kmru", "kmrv", "kmst", "kmsu", "kmsv",
                "knpt", "knpu", "knpv", "knqt", "knqu", "knqv", "knrt", "knru", "knrv", "knst", "knsu", "knsv",
                "kopt", "kopu", "kopv", "koqt", "koqu", "koqv", "kort", "koru", "korv", "kost", "kosu", "kosv",
                "lmpt", "lmpu", "lmpv", "lmqt", "lmqu", "lmqv", "lmrt", "lmru", "lmrv", "lmst", "lmsu", "lmsv",
                "lnpt", "lnpu", "lnpv", "lnqt", "lnqu", "lnqv", "lnrt", "lnru", "lnrv", "lnst", "lnsu", "lnsv",
                "lopt", "lopu", "lopv", "loqt", "loqu", "loqv", "lort", "loru", "lorv", "lost", "losu", "losv"
            ];
            Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
        }
    }
}
