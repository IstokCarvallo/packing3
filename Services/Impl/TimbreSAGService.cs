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
	/// services.AddScoped<I<TimbreSAGService>, TimbreSAGService>();
	/// </summary>
    public class TimbreSAGService : PbServiceBase<TimbreSAG>, ITimbreSAGService
    {
        public TimbreSAGService(Produccion_2022DataContext dataContext) : base(dataContext)
        {
        }

		public async Task<IList<TimbreSAG>> RetrieveAsync( CancellationToken cancellationToken)
		{
			var result = await _dataContext.SqlModelMapper
						.LoadAsync<TimbreSAG>(new object[] { },  cancellationToken);

			return result.ToList();
		}
    }
}