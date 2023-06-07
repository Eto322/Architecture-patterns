using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Xunit;

namespace ClientServerPattern.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Connect_SendMessage_MessageReceivedByServer()
        {
            // Arrange
            var server = new Server();
            var serverThread = new Thread(server.Start);
            serverThread.Start();

            var client = new Client();
            client.Connect("127.0.0.1", 8888);
            var expectedMessage = "Test message";

            // Act
            string receivedMessage = null;
            var waitHandle = new ManualResetEvent(false);

            server.MessageReceived += (sender, message) =>
            {
                receivedMessage = message;
                waitHandle.Set();
            };

            client.SendMessage(expectedMessage);
            waitHandle.WaitOne(TimeSpan.FromSeconds(1));

            // Assert
            Assert.Equal(expectedMessage, receivedMessage);

            server.Stop();
            serverThread.Join();
        }
    }

    public class Server
{
    private TcpListener listener;
    private bool running;
    private Thread serverThread;

    public event EventHandler<string> MessageReceived;

    public void Start()
    {
        listener = new TcpListener(IPAddress.Any, 8888);
        listener.Start();
        running = true;
        Console.WriteLine("Server started. Waiting for connections...");

        serverThread = new Thread(ListenForClients);
        serverThread.Start();
    }

    private void ListenForClients()
    {
        while (running)
        {
            var client = listener.AcceptTcpClient();
            var clientHandler = new ClientHandler(client);
            clientHandler.MessageReceived += OnMessageReceived;
            clientHandler.Start();
        }
    }

    private void OnMessageReceived(object sender, string message)
    {
        MessageReceived?.Invoke(this, message);
    }

    public void Stop()
    {
        running = false;
        listener.Stop();
        Console.WriteLine("Server stopped.");
    }
}


    public class ClientHandler
    {
        private TcpClient client;

        public event EventHandler<string> MessageReceived;

        public ClientHandler(TcpClient client)
        {
            this.client = client;
        }

        public void Start()
        {
            var clientAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address;
            Console.WriteLine($"Client connected: {clientAddress}");

            var stream = client.GetStream();
            var buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                var message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"Received from client: {message}");
                MessageReceived?.Invoke(this, message);
            }

            Console.WriteLine($"Client disconnected: {clientAddress}");
            client.Close();
        }
    }

    public class Client
    {
        private TcpClient client;

        public void Connect(string serverIp, int port)
        {
            client = new TcpClient();
            client.Connect(serverIp, port);
            Console.WriteLine("Connected to server.");
        }

        public void SendMessage(string message)
        {
            var stream = client.GetStream();
            var data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
            Console.WriteLine($"Sent to server: {message}");
        }
    }
}
