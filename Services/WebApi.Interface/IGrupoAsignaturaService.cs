using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface IGrupoAsignaturaService
    {
        Task<IEnumerable<GrupoAsignatura>> GetAllAsync();
        Task<GrupoAsignatura> GetByIdAsync(int id);
        Task<IEnumerable<GrupoAsignatura>> GetByGrupoIdAsync(int grupoId);
        Task<GrupoAsignatura> CreateAsync(GrupoAsignatura entity);
        Task<bool> UpdateAsync(GrupoAsignatura entity);
        Task<bool> DeleteAsync(int id);
    }
}