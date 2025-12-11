using Packing3.Models;

namespace Packing3.Services
{
    public interface ISpro_TimbresdespachoService : IPbServiceBase<Spro_Timbresdespacho>
    {
		Task<IList<Spro_Timbresdespacho>> RetrieveAsync(CancellationToken cancellationToken);
    }
}