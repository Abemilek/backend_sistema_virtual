using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface IEvaluacionService
    {
        Task<IEnumerable<Evaluacion>> GetAllAsync();
        Task<Evaluacion> GetByIdAsync(int id);
        Task<IEnumerable<Evaluacion>> GetByGrupoAsignaturaIdAsync(int grupoAsignaturaId);
        Task<Evaluacion> CreateAsync(Evaluacion entity);
        Task<bool> UpdateAsync(Evaluacion entity);
        Task<bool> DeleteAsync(int id);
    }
}