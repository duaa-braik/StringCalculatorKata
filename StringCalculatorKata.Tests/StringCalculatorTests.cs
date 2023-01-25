namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTests
    {
        private StringCalculator StringCalculator { get; }

        public StringCalculatorTests()
        {
            StringCalculator = new StringCalculator();
        }

        [Fact]
        public void ShouldReturnZeroIfEmpty()
        {
            int Output = StringCalculator.Add("");

            Assert.Equal(0, Output);
        }
    }
}