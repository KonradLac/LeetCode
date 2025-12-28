using static ThreeSumBody.Solution;

namespace ThreeSumTests
{
    public class ThreeSumTesting
    {
        [Fact]
        public void Test1()
        {
            int[] input = [-1, 0, 1, 2, -1, -4];
            List<List<int>> expected =
            [
                [-1, -1, 2],
                [-1, 0, 1]
            ];
            var result = ThreeSum(input);
            Assert.Equal(expected.Count, result.Count);
            foreach (var triplet in expected)
            {
                Assert.Contains(triplet, result);
            }
        }

        [Fact]
        public void Test2()
        {
            int[] input = [];
            List<List<int>> expected = [];
            var result = ThreeSum(input);
            Assert.Equal(expected.Count, result.Count);
        }

        [Fact]
        public void Test3()
        {
            int[] input = [0];
            List<List<int>> expected = [];
            var result = ThreeSum(input);
            Assert.Equal(expected.Count, result.Count);
        }

        [Fact]
        public void Test4()
        {
            int[] input = [0, 0, 0, 0];
            List<List<int>> expected = [[0, 0, 0]];
            var result = ThreeSum(input);
            Assert.Equal(expected.Count, result.Count);
            foreach (var triplet in expected)
            {
                Assert.Contains(triplet, result);
            }
        }

        [Fact]
        public void Test5()
        {
            int[] input = [-2, 0, 1, 1, 2];
            List<List<int>> expected =
            [
                [-2, 0, 2],
                [-2, 1, 1]
            ];
            var result = ThreeSum(input);
            Assert.Equal(expected.Count, result.Count);
            foreach (var triplet in expected)
            {
                Assert.Contains(triplet, result);
            }
        }

        [Fact]
        public void Test6()
        {
            int[] input = [-4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 4];
            List<List<int>> expected =
            [
                [-4, 0, 4],
                [-4, 1, 3],
                [-4, 2, 2],
                [-2, -2, 4],
                [-2, 0, 2]
            ];
            var result = ThreeSum(input);
            Assert.Equal(expected.Count, result.Count);
            foreach (var triplet in expected)
            {
                Assert.Contains(triplet, result);
            }
        }
    }
}
