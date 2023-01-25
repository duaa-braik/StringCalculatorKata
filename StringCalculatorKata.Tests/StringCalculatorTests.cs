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

        [Fact]
        public void ShouldReturnZeroIfEmpty()
        {
            Output = StringCalculator.Add("");

            Assert.Equal(0, Output);
        }

        [Fact]
        public void ShouldReturnTheSameNumber()
        {
            Output = StringCalculator.Add("1");

            Assert.Equal(1, Output);
        }
    }
}