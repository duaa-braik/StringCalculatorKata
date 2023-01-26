namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTests
    {
        private StringCalculator StringCalculator { get; }
        private int Output { get; set; }

        public StringCalculatorTests()
        {
            StringCalculator = new StringCalculator();
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("1,2,3,4", 10)]
        [InlineData("1\n2,3", 6)]
        [InlineData("//;\n1;2", 3)]
        public void ShouldReturnSumOfTheSumOfNumbers(String input, int Expected)
        {
            Output = StringCalculator.Add(input);
            if (string.IsNullOrEmpty(input))
            {
                Assert.Equal(Expected, Output);
            }
            else if (input.Length == 1)
            {
                Assert.Equal(Expected, Output);
            }
            else if (input.Length > 1)
            {
                Assert.Equal(Expected, Output);
            }
        }
    }
}