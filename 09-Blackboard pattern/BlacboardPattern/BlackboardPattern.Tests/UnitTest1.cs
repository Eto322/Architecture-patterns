using Xunit;

namespace BlackboardPattern.Tests
{
    public class BlackboardTests
    {
        [Fact]
        public void GetData_ReturnsCorrectData()
        {
            // Arrange
            var blackboard = new BlackboardPattern.Blackboard();
            blackboard.SetData("Test data");

            // Act
            var data = blackboard.GetData();

            // Assert
            Assert.Equal("Test data", data);
        }
    }
}
