class KnowledgeSourceA : IKnowledgeSource
{
    public void UpdateBlackboard(Blackboard blackboard)
    {
        blackboard.Data = "Knowledge Source A updated the data.";
        blackboard.AddMessage("Knowledge Source A added a message.");
    }
}
