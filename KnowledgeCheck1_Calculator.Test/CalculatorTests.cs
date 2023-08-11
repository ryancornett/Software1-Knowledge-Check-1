namespace KnowledgeCheck1_Calculator.Test
{
    public class CalculatorTests
    {
        Calculator calc = new Calculator();

        [Fact]
        public void AdditionTest()
        {
            // Act
            int expected = 5;

            // Arrange
            int actual = calc.Operate(1, 2, 3);

            // Act
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractionTest()
        {
            // Act
            int expected = 7;

            // Arrange
            int actual = calc.Operate(2, 13, 6);

            // Act
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultiplicationTest()
        {
            // Act
            int expected = 51;

            // Arrange
            int actual = calc.Operate(3, 17, 3);

            // Act
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DivisionTest()
        {
            // Act
            int expected = 10;

            // Arrange
            int actual = calc.Operate(4, 30, 3);

            // Act
            Assert.Equal(expected, actual);
        }
    }
}