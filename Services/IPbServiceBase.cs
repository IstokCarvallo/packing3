using DWNet.Data;

namespace Packing3.Services
{
    public interface IPbServiceBase<TModel>
    {
        Task<int> UpdateAsync(IDataStore<TModel> dataStore, CancellationToken cancellationToken);
    }
} 