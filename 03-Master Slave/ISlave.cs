namespace MasterSlavePattern
{
    public interface ISlave
    {
        Task<int> ProcessTaskAsync(int data);
    }
}