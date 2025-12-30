using static FourSumLC.Solution;

namespace FourSumLCTests
{
    public class FourSumTests
    {
        [Fact]
        public void Test1()
        {
            int[] nums = { 1, 0, -1, 0, -2, 2 };
            int target = 0;
            var expected = new List<IList<int>>
            {
                new List<int> { -2, -1, 1, 2 },
                new List<int> { -2, 0, 0, 2 },
                new List<int> { -1, 0, 0, 1 }
            };
            var result = FourSum(nums, target);
            Assert.Equal(expected.Count, result.Count);
            foreach (var list in expected)
            {
                Assert.Contains(list, result);
            }
        }

        [Fact]
        public void Test2()
        {
            int[] nums = { 1, -1, 0, 0 };
            int target = 0;
            var expected = new List<IList<int>>
            {
                new List<int> { -1, 0, 0, 1 }
            };
            var result = FourSum(nums, target);
            Assert.Equal(expected.Count, result.Count);
            foreach (var list in expected)
            {
                Assert.Contains(list, result);
            }
        }

        [Fact]
        public void Test3()
        {
            int[] nums = { 0, 0, 0, 0 };
            int target = 0;
            var expected = new List<IList<int>>
            {
                new List<int> { 0, 0, 0, 0 }
            };
            var result = FourSum(nums, target);
            Assert.Equal(expected.Count, result.Count);
            foreach (var list in expected)
            {
                Assert.Contains(list, result);
            }
        }

        [Fact]
        public void Test4()
        {
            int[] nums = { -3, -1, 0, 2, 4, 5 };
            int target = 2;
            var expected = new List<IList<int>>
            {
                new List<int> { -3, -1, 2, 4 }
            };
            var result = FourSum(nums, target);
            Assert.Equal(expected.Count, result.Count);
            foreach (var list in expected)
            {
                Assert.Contains(list, result);
            }
        }

        [Fact]
        public void Test5()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int target = 50;
            var expected = new List<IList<int>> { };
            var result = FourSum(nums, target);
            Assert.Equal(expected.Count, result.Count);
        }

        [Fact]
        public void Test6()
        {
            int[] nums = { -5, -4, -3, -2, -1 };
            int target = -10;
            var expected = new List<IList<int>>
            {
                new List<int> { -4, -3, -2, -1 }
            };
            var result = FourSum(nums, target);
            Assert.Equal(expected.Count, result.Count);
            foreach (var list in expected)
            {
                Assert.Contains(list, result);
            }
        }

        [Fact]
        public void Test7()
        {
            int[] nums = { 1000000000, 1000000000, 1000000000, 1000000000 };
            int target = -294967296;
            var expected = new List<IList<int>> { };
            var result = FourSum(nums, target);
            Assert.Equal(expected.Count, result.Count);
        }
    }
}
