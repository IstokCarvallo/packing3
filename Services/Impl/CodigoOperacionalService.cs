using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SnapObjects.Data;
using System;
using Packing3;
using Packing3.Models;
using DWNet.Data;

namespace Packing3.Services.Impl
{
	/// <summary>
	/// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
	/// services.AddScoped<I<CodigoOperacionalService>, CodigoOperacionalService>();
	/// </summary>
    public class CodigoOperacionalService : PbServiceBase<CodigoOperacional>, ICodigoOperacionalService
    {
        public CodigoOperacionalService(Produccion_2022DataContext dataContext) : base(dataContext)
        {
        }
        public async Task<IList<CodigoOperacional>> RetrieveAsync( CancellationToken cancellationToken)
		{
			var result = await _dataContext.SqlModelMapper
						.LoadAsync<CodigoOperacional>(new object[] { },  cancellationToken);

			return result.ToList();
		}
    }
}