class KnowledgeSourceB : IKnowledgeSource
{
    public void UpdateBlackboard(Blackboard blackboard)
    {
        blackboard.Data = "Knowledge Source B updated the data.";
        blackboard.AddMessage("Knowledge Source B added a message.");
    }
}