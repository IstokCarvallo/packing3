using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Packing3;

namespace Packing3.Services
{
    public interface IEmbalajesprodService : IServiceBase<Embalajesprod>
    {
		Task<Embalajesprod> RetrieveOneAsync(string emba_codigo,decimal clie_codigo, CancellationToken cancellationToken);
    }
}