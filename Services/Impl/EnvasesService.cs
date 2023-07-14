using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SnapObjects.Data;
using System;
using Packing3;

namespace Packing3.Services.Impl
{
	/// <summary>
	/// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
	/// services.AddScoped<I<EnvasesService>, EnvasesService>();
	/// </summary>
    public class EnvasesService : ServiceBase<Envases>, IEnvasesService
    {
        public EnvasesService(Produccion_2022DataContext dataContext) : base(dataContext)
        {
        }

        public async Task<Envases> RetrieveOneAsync(decimal enva_tipoen,decimal enva_codigo, CancellationToken cancellationToken)
        {
            var result = await _dataContext.SqlModelMapper.LoadByKeyAsync<Envases>(new object[] { enva_tipoen, enva_codigo }, cancellationToken);

            return result.FirstOrDefault();
        }
    }
}