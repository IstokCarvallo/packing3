namespace Packing3.Services
{
    public interface IEmbalajesprodService : IServiceBase<Embalajesprod>
    {
		Task<Embalajesprod> RetrieveOneAsync(string emba_codigo,decimal clie_codigo, CancellationToken cancellationToken);
    }
}