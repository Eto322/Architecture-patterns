using System;

namespace Broker
{
    public interface IBroker
{
    void Register(Client client);
    void Unregister(Client client);
    void Notify(string message);
}

public class ConcreteBroker : IBroker
{
    private List<Client> clients = new List<Client>();

    public void Register(Client client)
    {
        clients.Add(client);
    }

    public void Unregister(Client client)
    {
        clients.Remove(client);
    }

    public void Notify(string message)
    {
        foreach (var client in clients)
        {
            client.Receive(message);
        }
    }
}
}