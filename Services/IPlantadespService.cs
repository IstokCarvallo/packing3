using Packing3.Models;

namespace Packing3.Services
{
    public interface IPlantadespService : IPbServiceBase<Plantadesp>
    {
		Task<Plantadesp> RetrieveOneAsync(decimal plde_codigo, CancellationToken cancellationToken);
    }
}