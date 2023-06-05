// Data Access Layer
using System;

namespace DataAccessLayer
{
    public class DataAccess
    {
        public string GetData()
        {
            // Retrieve data from a data source (e.g., database, API, file)
            // ...
            Console.WriteLine("Data retrived successfully");
            return "Some data";
        }

        public void SaveData(string data)
        {
            // Save the processed data to the data source
            // ...
            Console.WriteLine("Data saved successfully");
        }
    }
}
