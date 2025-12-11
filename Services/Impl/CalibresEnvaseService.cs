using SnapObjects.Data;
using DWNet.Data;
using Packing3.Models;

namespace Packing3.Services.Impl
{
    /// <summary>
    /// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
    /// services.AddScoped<I<CalibresEnvaseService>, CalibresEnvaseService>();
    /// </summary>  
    public class CalibresEnvaseService : ICalibresEnvaseService
    {
        private readonly DataContext _dataContext;
        public CalibresEnvaseService(Produccion_2022DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IDataStore<CalibresEnvase>> RetrieveAsync(double? especie,double? tipo,double? codigo, CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<CalibresEnvase>(_dataContext);

            await dataStore.RetrieveAsync(new object[] {especie, tipo, codigo }, cancellationToken);

            return dataStore;
        }
    }  
}