using Packing3.Models;

namespace Packing3.Services.Impl
{
	/// <summary>
	/// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
	/// services.AddScoped<I<PlantadespService>, PlantadespService>();
	/// </summary>
    public class PlantadespService : PbServiceBase<Plantadesp>, IPlantadespService
    {
        public PlantadespService(Produccion_2022DataContext dataContext) : base(dataContext)
        {
        }
        public async Task<Plantadesp> RetrieveOneAsync(decimal plde_codigo, CancellationToken cancellationToken)
        {
            var result = await _dataContext.SqlModelMapper.LoadByKeyAsync<Plantadesp>(new object[] { plde_codigo }, cancellationToken);

            return result.FirstOrDefault();
        }
    }
}