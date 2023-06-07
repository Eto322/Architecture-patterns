
using System;

namespace PipeFilter
{
    class Program
    {
        static void Main()
        {
            string input = "Hello, World!";

            var upperCaseFilter = new UpperCaseFilter();
            string result = upperCaseFilter.Process(input);

            var reverseFilter = new ReverseFilter();
            result = reverseFilter.Process(result);

            Console.WriteLine(result);
        }
    }

}
