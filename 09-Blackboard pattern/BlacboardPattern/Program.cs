using System;

namespace BlackboardPattern
{
    public class Blackboard
    {
        private string data;

        public string GetData()
        {
            return data;
        }

        public void SetData(string newData)
        {
            data = newData;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Blackboard
            var blackboard = new Blackboard();

            // Set and retrieve data from the Blackboard
            blackboard.SetData("Hello, Blackboard!");
            Console.WriteLine(blackboard.GetData());
        }
    }
}
