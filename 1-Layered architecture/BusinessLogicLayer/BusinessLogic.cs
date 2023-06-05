// Business Logic Layer
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogic
    {
        private readonly DataAccess _dataAccess = new DataAccess();

        public void ProcessData()
        {
            // Retrieve data from data access layer
            var data = _dataAccess.GetData();

            // Perform business logic operations on the data
            // ...
            System.Console.WriteLine("data changed successfully");
            // Call data access layer to save the processed data
            _dataAccess.SaveData(data);
        }
    }
}
