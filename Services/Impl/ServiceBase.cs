using System;
using System.Threading;
using System.Threading.Tasks;
using SnapObjects.Data;

namespace Packing3.Services.Impl
{
    public abstract class ServiceBase<TModel> : IServiceBase<TModel>
    {
        protected readonly DataContext _dataContext;

        public ServiceBase(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        
        public async Task<int> CreateAsync(TModel model, CancellationToken cancellationToken)
        {
            var result = await _dataContext.SqlModelMapper
                   .TrackCreate<TModel>(model).SaveChangesAsync(cancellationToken);

            return result.InsertedCount;
        }      
    }
}