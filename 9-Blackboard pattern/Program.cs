class Program
{
    static void Main(string[] args)
    {
        Blackboard blackboard = new Blackboard();
        KnowledgeSourceA knowledgeSourceA = new KnowledgeSourceA();
        KnowledgeSourceB knowledgeSourceB = new KnowledgeSourceB();
        Client client = new Client(blackboard);

        knowledgeSourceA.UpdateBlackboard(blackboard);
        knowledgeSourceB.UpdateBlackboard(blackboard);

        client.DisplayData();
        client.DisplayMessages();

        Console.WriteLine("Blackboard pattern example");
    }
}