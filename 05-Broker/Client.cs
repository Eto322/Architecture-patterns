using System;

namespace Broker
{
    public class Client
{
    private string name;
    public string LastReceivedMessage { get; private set; }//for test purposes only
    public Client(string name)
    {
        this.name = name;
    }

    public void Receive(string message)
    {
        LastReceivedMessage = message;
        Console.WriteLine($"{name} received message: {message}");
    }
}
}