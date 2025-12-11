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
	/// services.AddScoped<I<ProdcuartelesService>, ProdcuartelesService>();
	/// </summary>
    public class ProdcuartelesService : PbServiceBase<Spro_Prodcuarteles>, IProdcuartelesService
    {
        public ProdcuartelesService(Produccion_2024DataContext dataContext) : base(dataContext)
        {
        }

        public async Task<Spro_Prodcuarteles> RetrieveOneAsync(decimal prod_codigo,decimal prpr_codigo,decimal prcc_codigo,decimal? siri_codigo,decimal? sico_codigo, CancellationToken cancellationToken)
        {
            var result = await _dataContext.SqlModelMapper.LoadByKeyAsync<Spro_Prodcuarteles>(new object[] { prod_codigo, prpr_codigo, prcc_codigo, siri_codigo, sico_codigo }, cancellationToken);

            return result.FirstOrDefault();
        }

		public async Task<IList<Spro_Prodcuarteles>> RetrieveAsync( CancellationToken cancellationToken)
		{
			var result = await _dataContext.SqlModelMapper
						.LoadAsync<Spro_Prodcuarteles>(new object[] { },  cancellationToken);

			return result.ToList();
		}

        public async Task<int> UpdateAsync(Spro_Prodcuarteles Spro_Prodcuarteles, CancellationToken cancellationToken)
        {
            var oldSpro_Prodcuarteles = await this.RetrieveOneAsync(Spro_Prodcuarteles.Prod_Codigo, Spro_Prodcuarteles.Prpr_Codigo, Spro_Prodcuarteles.Prcc_Codigo, Spro_Prodcuarteles.Siri_Codigo, Spro_Prodcuarteles.Sico_Codigo, cancellationToken);

            _dataContext.SqlModelMapper.TrackUpdate(oldSpro_Prodcuarteles,Spro_Prodcuarteles);

            var result = await _dataContext.SqlModelMapper.SaveChangesAsync(cancellationToken);

            return result.ModifiedCount;
        }

        public async Task<int> DeleteAsync(decimal prod_codigo,decimal prpr_codigo,decimal prcc_codigo,decimal? siri_codigo,decimal? sico_codigo, CancellationToken cancellationToken)
        {
            var result = await _dataContext.SqlModelMapper
						.TrackDeleteByKey<Spro_Prodcuarteles>(prod_codigo, prpr_codigo, prcc_codigo, siri_codigo, sico_codigo)
						.SaveChangesAsync(cancellationToken);

            return result.DeletedCount;
        }
    }
}