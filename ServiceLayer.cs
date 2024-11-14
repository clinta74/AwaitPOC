namespace AwaitPOC;

public class ServiceLayer : IServiceLayer
{
    public async Task<int> GetData(int delay, CancellationToken cancellationToken = default)
    {
        Console.WriteLine($"Starting a service with a delay of {delay} seconds.");
        await Task.Delay(delay * 1000, cancellationToken);
        Console.WriteLine($"Stopping a service with a delay of {delay} seconds.");

        return delay;
    }
}

public interface IServiceLayer
{
    Task<int> GetData(int delay, CancellationToken cancellationToken);
}