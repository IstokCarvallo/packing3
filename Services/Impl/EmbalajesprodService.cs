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
	/// services.AddScoped<I<EmbalajesprodService>, EmbalajesprodService>();
	/// </summary>
    public class EmbalajesprodService : ServiceBase<Embalajesprod>, IEmbalajesprodService
    {
        public EmbalajesprodService(Produccion_2022DataContext dataContext) : base(dataContext)
        {
        }

        public async Task<Embalajesprod> RetrieveOneAsync(string emba_codigo,decimal clie_codigo, CancellationToken cancellationToken)
        {
            var result = await _dataContext.SqlModelMapper.LoadByKeyAsync<Embalajesprod>(new object[] { emba_codigo, clie_codigo }, cancellationToken);

            return result.FirstOrDefault();
        }
    }
}