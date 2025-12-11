using DWNet.Data;
using Packing3.Models;

namespace Packing3.Services
{
    public interface ICalibresEnvaseService
    {
        Task<IDataStore<CalibresEnvase>> RetrieveAsync(double? especie,double? tipo,double? codigo, CancellationToken cancellationToken);
    }
}