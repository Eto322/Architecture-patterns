using Xunit;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MasterSlavePattern.Test
{
    public class MasterNodeTests
    {
        [Fact]
        public async Task ExecuteTaskAsync_DistributesTaskDataAmongSlaveNodes()
        {
            // Arrange
            var slaves = new List<ISlave>
            {
                MockSlaveNode(),
                MockSlaveNode(),
                MockSlaveNode()
            };

            var masterNode = new Master(slaves);

            var DataList = new List<int> { 1, 2, 3, 4, 5 };

            // Act
            List<int> taskResults = await masterNode.ExecuteTaskAsync(DataList);

            // Assert
            Assert.Equal(DataList.Count, taskResults.Count);
            for (int i = 0; i < DataList.Count; i++)
            {
                int expectedTaskResult = DataList[i] * 2;
                Assert.Equal(expectedTaskResult, taskResults[i]);
            }
        }

        private ISlave MockSlaveNode()
        {
            var slaveMock = new Mock<ISlave>();
            slaveMock.Setup(s => s.ProcessTaskAsync(It.IsAny<int>()))
                .Returns<int>(taskData => Task.FromResult(taskData * 2));
            return slaveMock.Object;
        }
    }
}