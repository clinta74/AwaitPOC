using Microsoft.VisualBasic;

namespace AwaitPOC;
public class BusinessLayer : IBusinessLayer
{
    private readonly IServiceLayer _serviceLayer;
    public BusinessLayer()
    {
        _serviceLayer = new ServiceLayer();
    }

    public async Task<int> DoIt1(CancellationToken cancellationToken = default)
    {
        return await _serviceLayer.GetData(5, cancellationToken);
    }

    public async Task<int> DoIt2(CancellationToken cancellationToken= default)
    {
        return await _serviceLayer.GetData(3, cancellationToken);
    }
}

public interface IBusinessLayer
{
    public Task<int> DoIt1(CancellationToken cancellationToken = default);
    public Task<int> DoIt2(CancellationToken cancellationToken= default);
}