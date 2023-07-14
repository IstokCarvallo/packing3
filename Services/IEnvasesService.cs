using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Packing3;

namespace Packing3.Services
{
    public interface IEnvasesService : IServiceBase<Envases>
    {
		Task<Envases> RetrieveOneAsync(decimal enva_tipoen,decimal enva_codigo, CancellationToken cancellationToken);
        
    }
}