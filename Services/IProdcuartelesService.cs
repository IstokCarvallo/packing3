using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Packing3;
using Packing3.Models;

namespace Packing3.Services
{
    public interface IProdcuartelesService : IPbServiceBase<Spro_Prodcuarteles>
    {
		Task<Spro_Prodcuarteles> RetrieveOneAsync(decimal prod_codigo,decimal prpr_codigo,decimal prcc_codigo,decimal? siri_codigo,decimal? sico_codigo, CancellationToken cancellationToken);

		Task<IList<Spro_Prodcuarteles>> RetrieveAsync(CancellationToken cancellationToken);

        Task<int> UpdateAsync(Spro_Prodcuarteles Spro_Prodcuarteles, CancellationToken cancellationToken);

		Task<int> DeleteAsync(decimal prod_codigo,decimal prpr_codigo,decimal prcc_codigo,decimal? siri_codigo,decimal? sico_codigo, CancellationToken cancellationToken);
    }
}