namespace MasterSlavePattern
{
     public class Slave : ISlave
    {
        public async Task<int> ProcessTaskAsync(int Data)
        {
            // Simulate processing time
            await Task.Delay(TimeSpan.FromSeconds(1));

            // Perform the task and return the result
            int result = Data * 2;
            return result;
        }
    }
}