using System;

namespace PipeFilter
{

    public class UpperCaseFilter
    {
        public string Process(string input)
        {
            return input.ToUpper();
        }
    }

}