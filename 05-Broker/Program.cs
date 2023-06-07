using System;

namespace Broker
{
class Program
{
    static void Main(string[] args)
    {
        
        var broker = new ConcreteBroker();
        var client1 = new Client("Client 1");
        var client2 = new Client("Client 2");

        
        broker.Register(client1);
        broker.Register(client2);

        
        broker.Notify("Hello, world!");

        
        broker.Unregister(client2);
        broker.Notify("Goodbye!");

        Console.ReadLine();
    }
}

}

