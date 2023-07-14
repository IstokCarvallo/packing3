using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Packing3;
using Packing3.Models;

namespace Packing3.Services
{
    public interface ICorrelfolioService : IPbServiceBase<Correlfolio>
    {
        Task<IDataStore<Correlfolio>> RetrieveAsync(double? Cliente, CancellationToken cancellationToken);
    }
}