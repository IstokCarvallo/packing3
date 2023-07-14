using System.Threading;
using System.Threading.Tasks;
using SnapObjects.Data;
using DWNet.Data;
using System;
using Packing3;
using Packing3.Models;

namespace Packing3.Services.Impl
{
    /// <summary>
    /// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
    /// services.AddScoped<I<TipopallembaService>, TipopallembaService>();
    /// </summary>  
    public class TipopallembaService : PbServiceBase<Tipopallemba>, ITipopallembaService
    {
        public TipopallembaService(Produccion_2022DataContext dataContext) : base(dataContext)
        {
        }

        public async Task<IDataStore<Tipopallemba>> RetrieveAsync(double? cliente,string embalaje, CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Tipopallemba>(_dataContext);

            await dataStore.RetrieveAsync(new object[] {cliente, embalaje }, cancellationToken);

            return dataStore;
        }
    }  
}