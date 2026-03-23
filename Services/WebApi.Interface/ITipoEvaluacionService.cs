using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface ITipoEvaluacionService
    {
        Task<IEnumerable<TipoEvaluacion>> GetAllAsync();
        Task<TipoEvaluacion> GetByIdAsync(int id);
        Task<TipoEvaluacion> CreateAsync(TipoEvaluacion entity);
        Task<bool> UpdateAsync(TipoEvaluacion entity);
        Task<bool> DeleteAsync(int id);
    }
}