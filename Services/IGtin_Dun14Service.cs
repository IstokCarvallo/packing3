using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Packing3;
using Packing3.Models;

namespace Packing3.Services
{
    public interface IGtin_Dun14Service : IPbServiceBase<Gtin_Dun14>
    {
        Task<IDataStore<Gtin_Dun14>> RetrieveAsync(double? cliente,string embalaje, CancellationToken cancellationToken);
    }
}