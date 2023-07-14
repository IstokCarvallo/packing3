using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;

namespace Packing3.Services
{
    public interface IPbServiceBase<TModel>
    {
        Task<int> UpdateAsync(IDataStore<TModel> dataStore, CancellationToken cancellationToken);
    }
} 