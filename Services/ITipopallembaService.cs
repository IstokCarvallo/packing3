using DWNet.Data;
using Packing3.Models;

namespace Packing3.Services
{
    public interface ITipopallembaService : IPbServiceBase<Tipopallemba>
    {
        Task<IDataStore<Tipopallemba>> RetrieveAsync(double? cliente,string embalaje, CancellationToken cancellationToken);
    }
}