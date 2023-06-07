using System;

namespace PipeFilter
{

    public class ReverseFilter
    {
        public string Process(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}