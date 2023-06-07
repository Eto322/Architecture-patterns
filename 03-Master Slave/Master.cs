namespace MasterSlavePattern
{



public class Master
    {
        private readonly List<ISlave> _slave;

        public Master(List<ISlave> slave)
        {
            _slave = slave;
        }

        public async Task<List<int>> ExecuteTaskAsync(List<int> DataList)
        {
            var taskResults = new List<int>();

           
            int slaveCount = _slave.Count;
            int taskCount = DataList.Count;

            for (int i = 0; i < taskCount; i++)
            {
                ISlave slave = _slave[i % slaveCount];
                int taskData = DataList[i];

                // Send task to the slave node for processing
                Task<int> task = slave.ProcessTaskAsync(taskData);
                taskResults.Add(await task);
            }

            return taskResults;
        }
    }

}