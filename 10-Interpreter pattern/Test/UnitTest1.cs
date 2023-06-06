using Xunit;
using InterpreterPatternExample;

namespace InterpreterPatternTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestInterpreterPattern()
        {
            // Arrange
            Expression expression = new AdditionExpression(
                new NumberExpression(5),
                new SubtractionExpression(
                    new NumberExpression(2),
                    new NumberExpression(3)
                )
            );

            // Act
            int result = expression.Interpret();

            // Assert
            Assert.Equal(4, result);
        }
    }
}
