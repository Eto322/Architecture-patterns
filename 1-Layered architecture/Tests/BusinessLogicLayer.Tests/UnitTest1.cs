using Xunit;
using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.IO;

namespace BusinessLogicLayer.Tests
{
    public class BusinessLogicTests
    {
        [Fact]
        public void ProcessData_RetrievesDataFromDataAccessAndSavesProcessedData()
        {
            // Arrange
            var businessLogic = new BusinessLogic();
            string expectedOutput = "Data saved successfully";

            // Redirect console output to a StringWriter
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            businessLogic.ProcessData();

            // Assert
            string actualOutput = stringWriter.ToString().Trim();
            Assert.Contains("Data retrived successfully", actualOutput);
            Assert.Contains("data changed successfully", actualOutput);
            Assert.Contains(expectedOutput, actualOutput);
        }

    }
}
