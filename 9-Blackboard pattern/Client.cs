class Client
{
    private Blackboard _blackboard;

    public Client(Blackboard blackboard)
    {
        _blackboard = blackboard;
    }

    public void DisplayData()
    {
        Console.WriteLine($"Data on the blackboard: {_blackboard.Data}");
    }

    public void DisplayMessages()
    {
        Console.WriteLine("Messages on the blackboard:");
        foreach (var message in _blackboard.Messages)
        {
            Console.WriteLine(message);
        }
    }
}