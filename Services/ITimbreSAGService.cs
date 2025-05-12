using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Packing3;
using Packing3.Models;

namespace Packing3.Services
{
    public interface ITimbreSAGService : IPbServiceBase<TimbreSAG>
    {
		Task<IList<TimbreSAG>> RetrieveAsync(CancellationToken cancellationToken);
    }
}