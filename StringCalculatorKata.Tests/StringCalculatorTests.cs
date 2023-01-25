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
        [InlineData("")]
        [InlineData("1")]
        [InlineData("1,2")]
        public void ShouldReturnSumOfTheNtwoNumbers(String input)
        {
            Output = StringCalculator.Add(input);
            if (string.IsNullOrEmpty(input))
            {
                Assert.Equal(0, Output);
            }
            else if (input.Length == 1)
            {
                Assert.Equal(1, Output);
            }
            else if (input.Length > 1)
            {
                Assert.Equal(3, Output);
            }

        }


    }
}