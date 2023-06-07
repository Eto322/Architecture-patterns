// Presentation Layer
using BusinessLogicLayer;

namespace PresentationLayer
{
    public class Program
    {
        private static readonly BusinessLogic _businessLogic = new BusinessLogic();

        public static void Main(string[] args)
        {   System.Console.WriteLine("Presentation layer start");
            // Call business logic methods
            _businessLogic.ProcessData();
            System.Console.WriteLine("Presentation layer end");
        }
    }
}
