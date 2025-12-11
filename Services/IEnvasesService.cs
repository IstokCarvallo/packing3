namespace Packing3.Services
{
    public interface IEnvasesService : IServiceBase<Envases>
    {
		Task<Envases> RetrieveOneAsync(decimal enva_tipoen,decimal enva_codigo, CancellationToken cancellationToken);
        
    }
}