using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface ISesionService
    {
        Task<IEnumerable<Sesion>> GetAllAsync();
        Task<Sesion> GetByIdAsync(int id);
        Task<IEnumerable<Sesion>> GetByGrupoAsignaturaIdAsync(int grupoAsignaturaId);
        Task<Sesion> CreateAsync(Sesion entity);
        Task<bool> UpdateAsync(Sesion entity);
        Task<bool> DeleteAsync(int id);
    }
}