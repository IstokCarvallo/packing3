using Packing3.Models;

namespace Packing3.Services
{
    public interface ISpro_ProdcuartelesService : IPbServiceBase<Spro_Prodcuarteles>
    {
		Task<Spro_Prodcuarteles> RetrieveOneAsync(decimal prod_codigo, CancellationToken cancellationToken);

		Task<IList<Spro_Prodcuarteles>> RetrieveAsync(CancellationToken cancellationToken);
    }
}