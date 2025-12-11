using Packing3.Models;

namespace Packing3.Services.Impl
{
	/// <summary>
	/// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
	/// services.AddScoped<I<Spro_ProdcuartelesService>, Spro_ProdcuartelesService>();
	/// </summary>
    public class Spro_ProdcuartelesService : PbServiceBase<Spro_Prodcuarteles>, ISpro_ProdcuartelesService
    {
        public Spro_ProdcuartelesService(Produccion_2022DataContext dataContext) : base(dataContext)
        {
        }

        public async Task<Spro_Prodcuarteles> RetrieveOneAsync(decimal prod_codigo, decimal predio, decimal cuartel, CancellationToken cancellationToken)
        {
            var result = await _dataContext.SqlModelMapper.LoadByKeyAsync<Spro_Prodcuarteles>(new object[] { prod_codigo, predio, cuartel }, cancellationToken);

            return result.FirstOrDefault();
        }
    }
}