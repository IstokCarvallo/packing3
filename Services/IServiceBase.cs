using System;
using System.Threading;
using System.Threading.Tasks;

namespace Packing3.Services
{
    public interface IServiceBase<TModel>
    {
        Task<int> CreateAsync(TModel model, CancellationToken cancellationToken);
    }
} 