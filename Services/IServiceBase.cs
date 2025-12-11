namespace Packing3.Services
{
    public interface IServiceBase<TModel>
    {
        Task<int> CreateAsync(TModel model, CancellationToken cancellationToken);
    }
} 