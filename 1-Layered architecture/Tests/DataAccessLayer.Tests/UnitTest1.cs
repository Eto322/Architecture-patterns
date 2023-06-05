using DataAccessLayer;
using Xunit;
using System;
using System.IO;

namespace DataAccessLayer.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void GetData_ReturnsData()
        {
            // Arrange
            var dataAccess = new DataAccess();

            // Act
            string data = dataAccess.GetData();

            // Assert
            Assert.Equal("Some data", data);
        }

        [Fact]
        public void SaveData_WritesMessageToConsole()
        {
            // Arrange
            var dataAccess = new DataAccess();

            // Redirect console output to a StringWriter
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            dataAccess.SaveData("Some data");

            // Assert
            string output = stringWriter.ToString().Trim();
            Assert.Equal("Data saved successfully", output);
        }
    }
}
