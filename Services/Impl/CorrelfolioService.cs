using DWNet.Data;
using Packing3.Models;

namespace Packing3.Services.Impl
{
    /// <summary>
    /// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
    /// services.AddScoped<I<Dw_Mues_CorrelfolioService>, Dw_Mues_CorrelfolioService>();
    /// </summary>  
    public class CorrelfolioService : PbServiceBase<Correlfolio>, ICorrelfolioService
    {
        public CorrelfolioService(Produccion_2022DataContext dataContext) : base(dataContext)
        {
        }

        public async Task<IDataStore<Correlfolio>> RetrieveAsync(double? Cliente, CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Correlfolio>(_dataContext);

            await dataStore.RetrieveAsync(new object[] {Cliente }, cancellationToken);

            return dataStore;
        }
    }  
}