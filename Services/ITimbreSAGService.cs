using Packing3.Models;

namespace Packing3.Services
{
    public interface ITimbreSAGService : IPbServiceBase<TimbreSAG>
    {
		Task<IList<TimbreSAG>> RetrieveAsync(CancellationToken cancellationToken);
    }
}