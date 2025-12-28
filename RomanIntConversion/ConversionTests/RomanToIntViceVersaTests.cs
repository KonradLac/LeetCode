using static RomanIntConversion.Solution;

namespace ConversionTests
{
    public class RomanToIntViceVersaTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int input = 1994;
            string expectedRoman = "MCMXCIV";
            // Act
            string actualRoman = IntToRoman(input);
            int actualInt = RomanToInt(actualRoman);
            // Assert
            Assert.Equal(expectedRoman, actualRoman);
            Assert.Equal(input, actualInt);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            int input = 58;
            string expectedRoman = "LVIII";
            // Act
            string actualRoman = IntToRoman(input);
            int actualInt = RomanToInt(actualRoman);
            // Assert
            Assert.Equal(expectedRoman, actualRoman);
            Assert.Equal(input, actualInt);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            int input = 4;
            string expectedRoman = "IV";
            // Act
            string actualRoman = IntToRoman(input);
            int actualInt = RomanToInt(actualRoman);
            // Assert
            Assert.Equal(expectedRoman, actualRoman);
            Assert.Equal(input, actualInt);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            int input = 3999;
            string expectedRoman = "MMMCMXCIX";
            // Act
            string actualRoman = IntToRoman(input);
            int actualInt = RomanToInt(actualRoman);
            // Assert
            Assert.Equal(expectedRoman, actualRoman);
            Assert.Equal(input, actualInt);
        }

        [Fact]
        public void Test5()
        {
            // Arrange
            int input = 1;
            string expectedRoman = "I";
            // Act
            string actualRoman = IntToRoman(input);
            int actualInt = RomanToInt(actualRoman);
            // Assert
            Assert.Equal(expectedRoman, actualRoman);
            Assert.Equal(input, actualInt);
        }

        [Fact]
        public void Test6()
        {
            // Arrange
            int input = 2763;
            string expectedRoman = "MMDCCLXIII";
            // Act
            string actualRoman = IntToRoman(input);
            int actualInt = RomanToInt(actualRoman);
            // Assert
            Assert.Equal(expectedRoman, actualRoman);
            Assert.Equal(input, actualInt);
        }

        [Fact]
        public void Test7()
        {
            // Arrange
            int input = 944;
            string expectedRoman = "CMXLIV";
            // Act
            string actualRoman = IntToRoman(input);
            int actualInt = RomanToInt(actualRoman);
            // Assert
            Assert.Equal(expectedRoman, actualRoman);
            Assert.Equal(input, actualInt);
        }

        [Fact]
        public void Test8()
        {
            // Arrange
            int input = 123;
            string expectedRoman = "CXXIII";
            // Act
            string actualRoman = IntToRoman(input);
            int actualInt = RomanToInt(actualRoman);
            // Assert
            Assert.Equal(expectedRoman, actualRoman);
            Assert.Equal(input, actualInt);
        }
    }
}
