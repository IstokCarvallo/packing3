using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SnapObjects.Data;
using System;
using Packing3;
using Packing3.Models;

namespace Packing3.Services.Impl
{
	/// <summary>
	/// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
	/// services.AddScoped<I<Spro_TimbresdespachoService>, Spro_TimbresdespachoService>();
	/// </summary>
    public class Spro_TimbresdespachoService : PbServiceBase<Spro_Timbresdespacho>, ISpro_TimbresdespachoService
    {
        public Spro_TimbresdespachoService(Produccion_2022DataContext dataContext) : base(dataContext)
        {
        }
		public async Task<IList<Spro_Timbresdespacho>> RetrieveAsync( CancellationToken cancellationToken)
		{
			var result = await _dataContext.SqlModelMapper
						.LoadAsync<Spro_Timbresdespacho>(new object[] { },  cancellationToken);

			return result.ToList();
		}       
    }
}