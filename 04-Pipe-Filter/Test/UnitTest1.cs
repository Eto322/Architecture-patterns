using Xunit;
using PipeFilter;

namespace PipeFilter.Tests
{
    public class PipeFilterTests
    {
        [Fact]
        public void TestPipeFilter()
        {
            // Arrange
            string input = "Hello, World!";
            string expectedOutput = "!DLROW ,OLLEH";

            var upperCaseFilter = new UpperCaseFilter();
            var reverseFilter = new ReverseFilter();

            // Act
            string result = upperCaseFilter.Process(input);
            result = reverseFilter.Process(result);

            // Assert
            Assert.Equal(expectedOutput, result);
        }
    }
}
