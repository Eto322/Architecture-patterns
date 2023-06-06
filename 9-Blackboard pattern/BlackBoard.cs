using System;
using System.Collections.Generic;

class Blackboard
{
    public string Data { get; set; }
    public List<string> Messages { get; set; } = new List<string>();

    public void AddMessage(string message)
    {
        Messages.Add(message);
    }
}