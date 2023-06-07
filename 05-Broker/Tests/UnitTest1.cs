using NUnit.Framework;
using Broker; // Replace with the correct namespace for your main project

namespace BrokerTests
{
    [TestFixture]
    public class BrokerTests
    {
        [Test]
        public void TestBroker()
        {
            // Arrange
            var broker = new ConcreteBroker();
            var client1 = new Client("Client 1");
            var client2 = new Client("Client 2");
            var client3 = new Client("Client 3");

            // Act
            broker.Register(client1);
            broker.Register(client2);
            broker.Notify("Test message");

            // Assert
            Assert.AreEqual("Test message", client1.LastReceivedMessage);
            Assert.AreEqual("Test message", client2.LastReceivedMessage);
            Assert.IsNull(client3.LastReceivedMessage);
        }

        [Test]
        public void TestBroker_UnregisterClient()
        {
            // Arrange
            var broker = new ConcreteBroker();
            var client1 = new Client("Client 1");
            var client2 = new Client("Client 2");

            // Act
            broker.Register(client1);
            broker.Register(client2);
            broker.Unregister(client1);
            broker.Notify("Test message");

            // Assert
            Assert.IsNull(client1.LastReceivedMessage);
            Assert.AreEqual("Test message", client2.LastReceivedMessage);
        }
    }
}
