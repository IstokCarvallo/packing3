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
    /// services.AddScoped<I<Gtin_Dun14Service>, Gtin_Dun14Service>();
    /// </summary>  
    public class Gtin_Dun14Service : PbServiceBase<Gtin_Dun14>, IGtin_Dun14Service
    {
        public Gtin_Dun14Service(Produccion_2022DataContext dataContext) : base(dataContext)
        {
        }

        public async Task<IDataStore<Gtin_Dun14>> RetrieveAsync(double? cliente,string embalaje, CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Gtin_Dun14>(_dataContext);

            await dataStore.RetrieveAsync(new object[] {cliente, embalaje }, cancellationToken);

            return dataStore;
        }
    }  
}