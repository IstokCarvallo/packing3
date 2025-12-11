using Packing3.Models;

namespace Packing3.Services
{
    public interface ICodigoOperacionalService : IPbServiceBase<CodigoOperacional>
    {
        Task<IList<CodigoOperacional>> RetrieveAsync(CancellationToken cancellationToken);
    }
}