using DWNet.Data;
using Packing3.Models;

namespace Packing3.Services
{
    public interface ICorrelfolioService : IPbServiceBase<Correlfolio>
    {
        Task<IDataStore<Correlfolio>> RetrieveAsync(double? Cliente, CancellationToken cancellationToken);
    }
}