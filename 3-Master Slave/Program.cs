using System;


namespace MasterSlavePattern
{ 
 
 class Program
    {
        static async Task Main(string[] args)
        {
            
            var slaves = new List<ISlave>
            {
                new Slave(),
                new Slave(),
                new Slave()
            };

            
            var master= new Master(slaves);

           
            var taskDataList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

           
            List<int> taskResults = await master.ExecuteTaskAsync(taskDataList);

           
            Console.WriteLine("Task Results:");
            foreach (int result in taskResults)
            {
                Console.WriteLine(result);
            }
        }
    }
}
